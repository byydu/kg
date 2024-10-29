namespace KG.Map.Models;

using System.Diagnostics;
using System.Drawing;
using System.Text.Json.Serialization;
using static KG.Map.Properties.Resources;

public sealed class Map
{
  private readonly List<Object> objects = [];

  private const byte cell = 15;

  private readonly Pen pen = new(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

  private readonly Dictionary<byte, Image> images = new()
  {
    { 1, mine1 },
    { 2, mine2 },
    { 3, mine3 },
    { 4, mine4 },
    { 5, mine5 },

    { 11, dragon11 },
    { 12, dragon12 },
    { 13, dragon13 },
    { 14, dragon14 },
    { 15, dragon15 },
    { 21, dragon21 },
    { 22, dragon22 },
    { 23, dragon23 },
    { 24, dragon24 },
    { 25, dragon25 },
    { 31, dragon31 },
    { 32, dragon32 },
    { 33, dragon33 },
    { 34, dragon34 },
    { 35, dragon35 },
    { 41, dragon41 },
    { 42, dragon42 },
    { 43, dragon43 },
    { 44, dragon44 },
    { 45, dragon45 },
  };

  public IReadOnlyList<Object> Mines => objects.AsReadOnly();

  public bool AddObject(byte type, Int32 x, Int32 y)
  {
    if ((x == 0) || (x > 7200)) return false;
    if ((y == 0) || (y > 7200)) return false;
    if (objects.Exists(m => (m.X == x) && (m.Y == y))) return false;
    if (!images.TryGetValue(type, out var img)) return false;

    var o = new Object(type, x, y);
    AddObject(o);

    return true;
  } /* proc.AddObject */

  public void DrawTo(Control.ControlCollection collection, ToolTip tooltip, byte type, Int32 x, Int32 y)
  {
    if (!objects.Exists(m => (m.X == x) && (m.Y == y))) return;

    if (!images.TryGetValue(type, out var img)) return;
    var pic = new PictureBox
    {
      BackColor = Color.Transparent,
      Tag = (type, x, y),
    };
    tooltip.SetToolTip(pic, $"[{x}, {y}]");

    y = 7199 - y;

    if (type < 6)
    {
      pic.Image = img;
      pic.Size = img.Size;
      pic.Location = new Point(x - 7, y - 7);
    }
    else
    {
      pic.Image = new Bitmap((7 * cell) + 1, (7 * cell) + 1);
      pic.Size = pic.Image.Size;
      pic.Location = new Point(((x / cell) - 3) * cell, (((y / cell) - 3) * cell) - 1);

      using (var graphic = Graphics.FromImage(pic.Image))
      {
        graphic.DrawRectangle(pen, 0, 0, 7 * cell, 7 * cell);
        graphic.DrawImage(img, (x - 14) - pic.Location.X, (y - 14) - pic.Location.Y);
      }
    }

    using (var graphic = Graphics.FromImage(pic.Image))
    {
      graphic.FillRectangle(Brushes.Pink, x - pic.Location.X, y - pic.Location.Y, 1, 1);
    }

    collection.Add(pic);
  } /* proc.DrawTo */

  public Image? GetImage(byte type)
      => images.TryGetValue(type, out var img) ? img : null;

  public Object? GetObject(Int32 x, Int32 y)
      => objects.Find(m => (m.X == x) && (m.Y == y));

  public void Highlight(Image image)
  {
    using (var g = Graphics.FromImage(image))
    {
      foreach (var item in objects.FindAll(x => x.Neighbour.Count >= 1))
      {
        item.Neighbour.ForEach(i =>
        {
          var x1 = Math.Min(item.CellX, i.CellX);
          var x2 = Math.Max(item.CellX, i.CellX);
          var y1 = Math.Min(item.CellY, i.CellY);
          var y2 = Math.Max(item.CellY, i.CellY);

          Draw(g, Brushes.Yellow, x1, y1, x2, y2);
        });
      }

      var list3 = objects.FindAll(x => x.Neighbour.Count > 1);
      foreach (var item in list3)
      {
        List<Object> a = [item, .. item.Neighbour];

        List<Object> x = [.. a.OrderBy(x => x.CellX)];
        List<Object> y = [.. a.OrderBy(y => y.CellY)];

        var dx = (x[^1].CellX - x[0].CellX) + 1;
        var dy = (y[^1].CellY - y[0].CellY) + 1;

        while ((dx > 5) || (dy > 5))
        {
          if (dx > dy)
          {
            if (dx > 5)
            {
              var dx1 = (x[1].CellX - x[0].CellX);
              var dx2 = (x[^1].CellX - x[^2].CellX);

              a.Remove((x[1].CellX - x[0].CellX) > (x[^1].CellX - x[^2].CellX) ? x[0] : x[^1]);
            }
          }
          else if (dx < dy)
          {
            if (dy > 5)
            {
              var dy1 = (y[1].CellY - y[0].CellY);
              var dy2 = (y[^1].CellY - y[^2].CellY);

              a.Remove((y[1].CellY - y[0].CellY) > (y[^1].CellY - y[^2].CellY) ? y[0] : y[^1]);
            }
          }
          else if (dx > 5)
          {
            if (Math.Max((x[1].CellX - x[0].CellX), (x[^1].CellX - x[^2].CellX))
              > Math.Max((y[1].CellY - y[0].CellY), (y[^1].CellY - y[^2].CellY)))
            {
              a.Remove((x[1].CellX - x[0].CellX) > (x[^1].CellX - x[^2].CellX) ? x[0] : x[^1]);
            }
            else
            {
              a.Remove((y[1].CellY - y[0].CellY) > (y[^1].CellY - y[^2].CellY) ? y[0] : y[^1]);
            }
          }

          (x, y) = ([.. a.OrderBy(x => x.CellX)], [.. a.OrderBy(y => y.CellY)]);
          (dx, dy) = ((x[^1].CellX - x[0].CellX) + 1, (y[^1].CellY - y[0].CellY) + 1);
        }

        if (a.Count < 3)
          continue;

        Draw(g, Brushes.Pink, x[0].CellX, y[0].CellY, x[^1].CellX, y[^1].CellY);
      }
    }

    static void Draw(Graphics g, Brush brush, Int32 x1, Int32 y1, Int32 x2, Int32 y2)
    {
      for (var i = x1; i <= x2; i++)
      {
        for (var j = y1; j <= y2; j++)
        {
          g.FillRectangle(brush, i * 15, ((((7200 / cell) - 1) - j) * cell), cell, cell);
        }
      }
    }
  } /* proc.Highlight */

  public void Load(string file)
  {
    try
    {
      foreach (var m in System.Text.Json.JsonSerializer.Deserialize<List<Object>>(File.ReadAllText(file))!)
      {
        AddObject(m.Type, m.X, m.Y);
      }
    }
    catch { /* Do nothing */ }
  } /* proc.Load */

  public Image New()
  {
    objects.Clear();

    return Create();
  } /* proc.New */

  public void Save(string file, bool highlight)
  {
    Draw(highlight).Save(file, System.Drawing.Imaging.ImageFormat.Png);
    File.WriteAllText(Path.ChangeExtension(file, ".json"), System.Text.Json.JsonSerializer.Serialize(objects));
  } /* proc.Save */

  private void AddObject(Object obj)
  {
    const int length = 7200 / cell;
    var x1 = Math.Max(obj.CellX - 4, 0);
    var x2 = Math.Min(obj.CellX + 4, length - 1);
    var y1 = Math.Max(obj.CellY - 4, 0);
    var y2 = Math.Min(obj.CellY + 4, length - 1);

    var list = objects.FindAll(z => z.Type < 6
                                 && z.CellX >= x1 && z.CellX <= x2
                                 && z.CellY >= y1 && z.CellY <= y2);

    obj.Neighbour.AddRange(list);
    list.ForEach(z => z.Neighbour.Add(obj));
    objects.Add(obj);
  } /* proc.AddObject */

  private Bitmap Create()
  {
    var img = new Bitmap(7200, 7200);
    using (var g = Graphics.FromImage(img))
    {
      g.FillRectangle(new SolidBrush(Color.FromArgb(153, 153, 53)), 0, 0, img.Width, img.Height);

      var pen1 = new Pen(Color.FromArgb(181, 230, 29));
      for (var i = 0; i < img.Width; i += cell)
      {
        g.DrawLine(pen1, 0, 7199 - i, img.Width - 1, 7199 - i);
        g.DrawLine(pen1, i, 0, i, img.Height - 1);
      }

      var brush = new SolidBrush(Color.FromArgb(180, 230, 30));
      for (var i = 0; i < img.Width; i += cell)
      {
        for (var j = 0; j < img.Height; j += cell)
        {
          g.FillRectangle(brush, i, 7199 - j, 1, 1);
        }
      }

      g.DrawRectangle(pen, 3315, 7199 - 3720, 27 * cell, 27 * cell);
    }

    return img;
  } /* func.Create */

  private Image Draw(bool highlight)
  {
    var img = Create();
    if (highlight)
      Highlight(img);

    using (var g = Graphics.FromImage(img))
    {
      foreach (var item in objects)
      {
        if (!images.TryGetValue(item.Type, out var image))
          continue;

        var x = item.X;
        var y = 7199 - item.Y;

        if (item.Type < 6)
        {
          g.DrawImage(image, x - 7, y - 7);
        }
        else
        {
          g.DrawImage(image, x - 14, y - 14);
          g.DrawRectangle(pen, ((x / cell) - 3) * cell, (((y / cell) - 3) * cell) - 1, 7 * cell, 7 * cell);
        }

        g.FillRectangle(Brushes.Pink, x, y, 1, 1);
      }
    }

    return img;
  } /* func.Draw */

  #region Object

  [DebuggerDisplay("Type = {Type}, X = {X}, Y = {Y}, CellX = {CellX}, CellY = {CellY}, Neighbour = {Neighbour.Count}")]
  public record Object(byte Type, Int32 X, Int32 Y)
  {
    [JsonIgnore]
    public Int32 CellX { get; init; } = X / cell;
    [JsonIgnore]
    public Int32 CellY { get; init; } = Y / cell;
    [JsonIgnore]
    public List<Object> Neighbour { get; init; } = [];
  } /* Object */

  #endregion

} /* Map */