namespace KG.Map.Views;

using static System.Environment;

public partial class MainForm : Form
{
  private readonly Models.Map _map = new();

  private readonly OpenFileDialog open = new()
  {
    DefaultExt = "json",
    Filter = "json files (*.json)|*.json",
    InitialDirectory = GetFolderPath(SpecialFolder.MyPictures),
  };

  private readonly SaveFileDialog save = new()
  {
    DefaultExt = "png",
    Filter = "png+json files (*.png)|*.png",
    InitialDirectory = GetFolderPath(SpecialFolder.MyPictures),
    OverwritePrompt = true
  };

  public MainForm()
  {
    InitializeComponent();

    picture.Image = _map.New();
  } /* Constructor */

  private void AddObject(byte type, Int32 x, Int32 y)
  {
    if (!_map.AddObject(type, x, y)) return;

    _map.DrawTo(picture.Controls, tooltip, type, x, y);
  } /* proc.AddMine */

  private void Command_Add(object sender, EventArgs e)
  {
    if (!Int32.TryParse(txtX.Text, out var x) || (x == 0) || (x > 7200)) return;
    if (!Int32.TryParse(txtY.Text, out var y) || (y == 0) || (y > 7200)) return;

    if (radio1.Checked) AddObject(1, x, y);
    else if (radio2.Checked) AddObject(2, x, y);
    else if (radio3.Checked) AddObject(3, x, y);
    else if (radio4.Checked) AddObject(4, x, y);
    else if (radio5.Checked) AddObject(5, x, y);
    else if (radio6.Checked)
    {
      if (radio10.Checked) AddObject(Convert.ToByte(10 + nbxDragon.Value), x, y);
      else if (radio20.Checked) AddObject(Convert.ToByte(20 + nbxDragon.Value), x, y);
      else if (radio30.Checked) AddObject(Convert.ToByte(30 + nbxDragon.Value), x, y);
      else if (radio40.Checked) AddObject(Convert.ToByte(40 + nbxDragon.Value), x, y);
    }

    txtX.Focus();
  } /* event:btnAdd.Click */

  private void CommandLoad()
  {
    if (open.ShowDialog() != DialogResult.OK) return;

    _map.Load(open.FileName);
    foreach (var m in _map.Mines)
    {
      _map.DrawTo(picture.Controls, tooltip, m.Type, m.X, m.Y);
    }
  } /* proc.CommandLoad */

  private void CommandNew()
  {
    picture.Image?.Dispose();
    picture.Image = _map.New();
    picture.Controls.Clear();
  } /* proc.CommandNew */

  private void CommandSave()
  {
    if (save.ShowDialog() != DialogResult.OK) return;

    _map.Save(save.FileName, ModifierKeys == Keys.Alt);
  } /* proc.CommandSave */

  private void Command_Delete(object sender, EventArgs e)
  {

  } /* event:cmdDelete_Click */

  private void Command_Edit(object sender, EventArgs e)
  {

  } /* event:cmdEdit_Click */

  private void Command_Load(object sender, EventArgs e) => CommandLoad();

  private void Command_New(object sender, EventArgs e) => CommandNew();

  private void Command_Save(object sender, EventArgs e) => CommandSave();

  private void MainForm_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.Modifiers == Keys.Control)
    {
      switch (e.KeyCode)
      {
        case Keys.N: CommandNew(); break;
        case Keys.O: CommandLoad(); break;
        case Keys.S: CommandSave(); break;
      }
    }
    else if (e.Modifiers == Keys.Alt)
    {
      if (e.KeyCode == Keys.Enter)
      {
        _map.Highlight(picture.Image);
        picture.Refresh();
      }
    }
    else
    {
      return;
    }

    e.Handled = true;
  } /* event:MainForm_KeyDown */

  private void Mouse_Click(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left) return;
  } /* event:Picture.MouseClick */

  private void txt_Enter(object sender, EventArgs e)
  {
    if (sender is not TextBox text) return;

    text.SelectAll();
  } /* event:TextBox.Enter */

} /* MainForm */