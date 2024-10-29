namespace KG.Map.Views
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      layout = new TableLayoutPanel();
      control = new TableLayoutPanel();
      coordinates = new TableLayoutPanel();
      txtX = new TextBox();
      txtY = new TextBox();
      lbl = new Label();
      label1 = new Label();
      imges = new TableLayoutPanel();
      radio1 = new RadioButton();
      radio2 = new RadioButton();
      radio3 = new RadioButton();
      radio4 = new RadioButton();
      radio5 = new RadioButton();
      radio6 = new RadioButton();
      element = new TableLayoutPanel();
      radio10 = new RadioButton();
      radio20 = new RadioButton();
      radio30 = new RadioButton();
      radio40 = new RadioButton();
      nbxDragon = new NumericUpDown();
      controls = new TableLayoutPanel();
      btnAdd = new Button();
      btnSave = new Button();
      btnLoad = new Button();
      btnNew = new Button();
      scroll = new Panel();
      picture = new PictureBox();
      tooltip = new ToolTip(components);
      contextmenu = new ContextMenuStrip(components);
      cmnEdit = new ToolStripMenuItem();
      cmdSeparator = new ToolStripSeparator();
      cmnDelete = new ToolStripMenuItem();
      layout.SuspendLayout();
      control.SuspendLayout();
      coordinates.SuspendLayout();
      imges.SuspendLayout();
      element.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)nbxDragon).BeginInit();
      controls.SuspendLayout();
      scroll.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
      contextmenu.SuspendLayout();
      SuspendLayout();
      // 
      // layout
      // 
      layout.ColumnCount = 2;
      layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
      layout.Controls.Add(control, 1, 0);
      layout.Controls.Add(scroll, 0, 0);
      layout.Dock = DockStyle.Fill;
      layout.Location = new Point(0, 0);
      layout.Margin = new Padding(8);
      layout.Name = "layout";
      layout.RowCount = 1;
      layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      layout.Size = new Size(784, 561);
      layout.TabIndex = 0;
      // 
      // control
      // 
      control.ColumnCount = 1;
      control.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      control.Controls.Add(coordinates, 0, 0);
      control.Controls.Add(imges, 0, 2);
      control.Controls.Add(controls, 0, 4);
      control.Dock = DockStyle.Fill;
      control.Location = new Point(592, 8);
      control.Margin = new Padding(8);
      control.Name = "control";
      control.RowCount = 5;
      control.RowStyles.Add(new RowStyle());
      control.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
      control.RowStyles.Add(new RowStyle());
      control.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
      control.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      control.Size = new Size(184, 545);
      control.TabIndex = 0;
      // 
      // coordinates
      // 
      coordinates.AutoSize = true;
      coordinates.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      coordinates.ColumnCount = 4;
      coordinates.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));
      coordinates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      coordinates.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      coordinates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      coordinates.Controls.Add(txtX, 1, 0);
      coordinates.Controls.Add(txtY, 3, 0);
      coordinates.Controls.Add(lbl, 2, 0);
      coordinates.Controls.Add(label1, 0, 0);
      coordinates.Dock = DockStyle.Fill;
      coordinates.Location = new Point(0, 0);
      coordinates.Margin = new Padding(0);
      coordinates.Name = "coordinates";
      coordinates.RowCount = 1;
      coordinates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      coordinates.Size = new Size(184, 31);
      coordinates.TabIndex = 1;
      // 
      // txtX
      // 
      txtX.Dock = DockStyle.Fill;
      txtX.Font = new Font("Segoe UI", 13F);
      txtX.Location = new Point(0, 0);
      txtX.Margin = new Padding(0);
      txtX.MaxLength = 4;
      txtX.Name = "txtX";
      txtX.Size = new Size(82, 31);
      txtX.TabIndex = 1;
      txtX.Enter += txt_Enter;
      // 
      // txtY
      // 
      txtY.Dock = DockStyle.Fill;
      txtY.Font = new Font("Segoe UI", 13F);
      txtY.HideSelection = false;
      txtY.Location = new Point(102, 0);
      txtY.Margin = new Padding(0);
      txtY.MaxLength = 4;
      txtY.Name = "txtY";
      txtY.Size = new Size(82, 31);
      txtY.TabIndex = 2;
      txtY.Enter += txt_Enter;
      // 
      // lbl
      // 
      lbl.AutoSize = true;
      lbl.Dock = DockStyle.Fill;
      lbl.Location = new Point(85, 0);
      lbl.Name = "lbl";
      lbl.Size = new Size(14, 31);
      lbl.TabIndex = 2;
      lbl.Text = "x";
      lbl.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Dock = DockStyle.Fill;
      label1.Location = new Point(3, 0);
      label1.Name = "label1";
      label1.Size = new Size(1, 31);
      label1.TabIndex = 0;
      label1.Text = "&0.";
      // 
      // imges
      // 
      imges.AutoSize = true;
      imges.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      imges.ColumnCount = 3;
      imges.ColumnStyles.Add(new ColumnStyle());
      imges.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      imges.ColumnStyles.Add(new ColumnStyle());
      imges.Controls.Add(radio1, 1, 0);
      imges.Controls.Add(radio2, 1, 1);
      imges.Controls.Add(radio3, 1, 2);
      imges.Controls.Add(radio4, 1, 3);
      imges.Controls.Add(radio5, 1, 4);
      imges.Controls.Add(radio6, 1, 5);
      imges.Controls.Add(element, 1, 6);
      imges.Controls.Add(nbxDragon, 2, 5);
      imges.Dock = DockStyle.Fill;
      imges.Location = new Point(0, 39);
      imges.Margin = new Padding(0);
      imges.Name = "imges";
      imges.RowCount = 7;
      imges.RowStyles.Add(new RowStyle());
      imges.RowStyles.Add(new RowStyle());
      imges.RowStyles.Add(new RowStyle());
      imges.RowStyles.Add(new RowStyle());
      imges.RowStyles.Add(new RowStyle());
      imges.RowStyles.Add(new RowStyle());
      imges.RowStyles.Add(new RowStyle());
      imges.Size = new Size(184, 201);
      imges.TabIndex = 2;
      // 
      // radio1
      // 
      radio1.AutoSize = true;
      radio1.Dock = DockStyle.Fill;
      radio1.Font = new Font("Segoe UI", 11F);
      radio1.Location = new Point(3, 3);
      radio1.Name = "radio1";
      radio1.Size = new Size(128, 24);
      radio1.TabIndex = 0;
      radio1.TabStop = true;
      radio1.Text = "&1. Монетка";
      radio1.UseVisualStyleBackColor = true;
      // 
      // radio2
      // 
      radio2.AutoSize = true;
      radio2.Dock = DockStyle.Fill;
      radio2.Font = new Font("Segoe UI", 11F);
      radio2.Location = new Point(3, 33);
      radio2.Name = "radio2";
      radio2.Size = new Size(128, 24);
      radio2.TabIndex = 0;
      radio2.TabStop = true;
      radio2.Text = "&2. Сердце";
      radio2.UseVisualStyleBackColor = true;
      // 
      // radio3
      // 
      radio3.AutoSize = true;
      radio3.Dock = DockStyle.Fill;
      radio3.Font = new Font("Segoe UI", 11F);
      radio3.Location = new Point(3, 63);
      radio3.Name = "radio3";
      radio3.Size = new Size(128, 24);
      radio3.TabIndex = 0;
      radio3.TabStop = true;
      radio3.Text = "&3. Тапок";
      radio3.UseVisualStyleBackColor = true;
      // 
      // radio4
      // 
      radio4.AutoSize = true;
      radio4.Dock = DockStyle.Fill;
      radio4.Font = new Font("Segoe UI", 11F);
      radio4.Location = new Point(3, 93);
      radio4.Name = "radio4";
      radio4.Size = new Size(128, 24);
      radio4.TabIndex = 0;
      radio4.TabStop = true;
      radio4.Text = "&4. Камень";
      radio4.UseVisualStyleBackColor = true;
      // 
      // radio5
      // 
      radio5.AutoSize = true;
      radio5.Dock = DockStyle.Fill;
      radio5.Font = new Font("Segoe UI", 11F);
      radio5.Location = new Point(3, 123);
      radio5.Name = "radio5";
      radio5.Size = new Size(128, 24);
      radio5.TabIndex = 0;
      radio5.TabStop = true;
      radio5.Text = "&5. Кирка";
      radio5.UseVisualStyleBackColor = true;
      // 
      // radio6
      // 
      radio6.AutoSize = true;
      radio6.Dock = DockStyle.Fill;
      radio6.Font = new Font("Segoe UI", 11F);
      radio6.Location = new Point(3, 153);
      radio6.Name = "radio6";
      radio6.Size = new Size(128, 24);
      radio6.TabIndex = 1;
      radio6.TabStop = true;
      radio6.Text = "&6. Гнездо";
      radio6.UseVisualStyleBackColor = true;
      // 
      // element
      // 
      element.AutoSize = true;
      element.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      element.ColumnCount = 4;
      imges.SetColumnSpan(element, 2);
      element.ColumnStyles.Add(new ColumnStyle());
      element.ColumnStyles.Add(new ColumnStyle());
      element.ColumnStyles.Add(new ColumnStyle());
      element.ColumnStyles.Add(new ColumnStyle());
      element.Controls.Add(radio10, 0, 0);
      element.Controls.Add(radio20, 1, 0);
      element.Controls.Add(radio30, 2, 0);
      element.Controls.Add(radio40, 3, 0);
      element.Dock = DockStyle.Fill;
      element.Location = new Point(0, 180);
      element.Margin = new Padding(0);
      element.Name = "element";
      element.RowCount = 1;
      element.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      element.Size = new Size(184, 21);
      element.TabIndex = 2;
      // 
      // radio10
      // 
      radio10.AutoSize = true;
      radio10.Dock = DockStyle.Fill;
      radio10.Location = new Point(1, 1);
      radio10.Margin = new Padding(1, 1, 0, 1);
      radio10.Name = "radio10";
      radio10.Size = new Size(57, 19);
      radio10.TabIndex = 0;
      radio10.TabStop = true;
      radio10.Text = "огонь";
      radio10.UseVisualStyleBackColor = true;
      // 
      // radio20
      // 
      radio20.AutoSize = true;
      radio20.Dock = DockStyle.Fill;
      radio20.Location = new Point(58, 1);
      radio20.Margin = new Padding(0, 1, 0, 1);
      radio20.Name = "radio20";
      radio20.Size = new Size(44, 19);
      radio20.TabIndex = 1;
      radio20.TabStop = true;
      radio20.Text = "лук";
      radio20.UseVisualStyleBackColor = true;
      // 
      // radio30
      // 
      radio30.AutoSize = true;
      radio30.Dock = DockStyle.Fill;
      radio30.Location = new Point(102, 1);
      radio30.Margin = new Padding(0, 1, 0, 1);
      radio30.Name = "radio30";
      radio30.Size = new Size(37, 19);
      radio30.TabIndex = 2;
      radio30.TabStop = true;
      radio30.Text = "яд";
      radio30.UseVisualStyleBackColor = true;
      // 
      // radio40
      // 
      radio40.AutoSize = true;
      radio40.Dock = DockStyle.Fill;
      radio40.Location = new Point(139, 1);
      radio40.Margin = new Padding(0, 1, 1, 1);
      radio40.Name = "radio40";
      radio40.Size = new Size(44, 19);
      radio40.TabIndex = 3;
      radio40.TabStop = true;
      radio40.Text = "лед";
      radio40.UseVisualStyleBackColor = true;
      // 
      // nbxDragon
      // 
      nbxDragon.Font = new Font("Segoe UI", 12F);
      nbxDragon.Location = new Point(134, 150);
      nbxDragon.Margin = new Padding(0);
      nbxDragon.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
      nbxDragon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
      nbxDragon.Name = "nbxDragon";
      nbxDragon.Size = new Size(50, 29);
      nbxDragon.TabIndex = 2;
      nbxDragon.Value = new decimal(new int[] { 1, 0, 0, 0 });
      // 
      // controls
      // 
      controls.ColumnCount = 1;
      controls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      controls.Controls.Add(btnAdd, 0, 0);
      controls.Controls.Add(btnSave, 0, 1);
      controls.Controls.Add(btnLoad, 0, 2);
      controls.Controls.Add(btnNew, 0, 3);
      controls.Dock = DockStyle.Fill;
      controls.Location = new Point(0, 248);
      controls.Margin = new Padding(0);
      controls.Name = "controls";
      controls.RowCount = 5;
      controls.RowStyles.Add(new RowStyle());
      controls.RowStyles.Add(new RowStyle());
      controls.RowStyles.Add(new RowStyle());
      controls.RowStyles.Add(new RowStyle());
      controls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      controls.Size = new Size(184, 297);
      controls.TabIndex = 3;
      // 
      // btnAdd
      // 
      btnAdd.AutoSize = true;
      btnAdd.Dock = DockStyle.Fill;
      btnAdd.Location = new Point(3, 3);
      btnAdd.Name = "btnAdd";
      btnAdd.Padding = new Padding(12, 4, 12, 4);
      btnAdd.Size = new Size(178, 33);
      btnAdd.TabIndex = 0;
      btnAdd.TabStop = false;
      btnAdd.Text = "Добавить";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += Command_Add;
      // 
      // btnSave
      // 
      btnSave.AutoSize = true;
      btnSave.Dock = DockStyle.Fill;
      btnSave.Location = new Point(3, 42);
      btnSave.Name = "btnSave";
      btnSave.Padding = new Padding(12, 4, 12, 4);
      btnSave.Size = new Size(178, 33);
      btnSave.TabIndex = 1;
      btnSave.TabStop = false;
      btnSave.Text = "Сохранить";
      btnSave.UseVisualStyleBackColor = true;
      btnSave.Click += Command_Save;
      // 
      // btnLoad
      // 
      btnLoad.AutoSize = true;
      btnLoad.Dock = DockStyle.Fill;
      btnLoad.Location = new Point(3, 81);
      btnLoad.Name = "btnLoad";
      btnLoad.Padding = new Padding(12, 4, 12, 4);
      btnLoad.Size = new Size(178, 33);
      btnLoad.TabIndex = 2;
      btnLoad.TabStop = false;
      btnLoad.Text = "Загрузить";
      btnLoad.UseVisualStyleBackColor = true;
      btnLoad.Click += Command_Load;
      // 
      // btnNew
      // 
      btnNew.AutoSize = true;
      btnNew.Dock = DockStyle.Fill;
      btnNew.Location = new Point(3, 120);
      btnNew.Name = "btnNew";
      btnNew.Padding = new Padding(12, 4, 12, 4);
      btnNew.Size = new Size(178, 33);
      btnNew.TabIndex = 3;
      btnNew.TabStop = false;
      btnNew.Text = "Очистить";
      btnNew.UseVisualStyleBackColor = true;
      btnNew.Click += Command_New;
      // 
      // scroll
      // 
      scroll.AutoScroll = true;
      scroll.Controls.Add(picture);
      scroll.Dock = DockStyle.Fill;
      scroll.Location = new Point(3, 3);
      scroll.Name = "scroll";
      scroll.Size = new Size(578, 555);
      scroll.TabIndex = 2;
      // 
      // picture
      // 
      picture.Location = new Point(0, 0);
      picture.Margin = new Padding(8);
      picture.Name = "picture";
      picture.Size = new Size(578, 555);
      picture.SizeMode = PictureBoxSizeMode.AutoSize;
      picture.TabIndex = 1;
      picture.TabStop = false;
      picture.MouseClick += Mouse_Click;
      // 
      // contextmenu
      // 
      contextmenu.Items.AddRange(new ToolStripItem[] { cmnEdit, cmdSeparator, cmnDelete });
      contextmenu.Name = "contextmenu";
      contextmenu.Size = new Size(121, 54);
      // 
      // cmnEdit
      // 
      cmnEdit.Name = "cmnEdit";
      cmnEdit.Size = new Size(120, 22);
      cmnEdit.Text = "Править";
      cmnEdit.Click += Command_Edit;
      // 
      // cmdSeparator
      // 
      cmdSeparator.Name = "cmdSeparator";
      cmdSeparator.Size = new Size(117, 6);
      // 
      // cmnDelete
      // 
      cmnDelete.Name = "cmnDelete";
      cmnDelete.Size = new Size(120, 22);
      cmnDelete.Text = "Удалить";
      cmnDelete.Click += Command_Delete;
      // 
      // MainForm
      // 
      AcceptButton = btnAdd;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(784, 561);
      Controls.Add(layout);
      KeyPreview = true;
      Name = "MainForm";
      Text = "Map";
      KeyDown += MainForm_KeyDown;
      layout.ResumeLayout(false);
      control.ResumeLayout(false);
      control.PerformLayout();
      coordinates.ResumeLayout(false);
      coordinates.PerformLayout();
      imges.ResumeLayout(false);
      imges.PerformLayout();
      element.ResumeLayout(false);
      element.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)nbxDragon).EndInit();
      controls.ResumeLayout(false);
      controls.PerformLayout();
      scroll.ResumeLayout(false);
      scroll.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)picture).EndInit();
      contextmenu.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel layout;
    private TableLayoutPanel control;
    private TextBox txtX;
    private TableLayoutPanel coordinates;
    private TextBox txtY;
    private Label lbl;
    private TableLayoutPanel imges;
    private RadioButton radio1;
    private RadioButton radio2;
    private RadioButton radio3;
    private RadioButton radio4;
    private RadioButton radio5;
    private PictureBox picture;
    private TableLayoutPanel controls;
    private Button btnAdd;
    private Button btnSave;
    private Panel scroll;
    private Button btnLoad;
    private RadioButton radio6;
    private TableLayoutPanel element;
    private RadioButton radio10;
    private RadioButton radio20;
    private RadioButton radio30;
    private RadioButton radio40;
    private NumericUpDown nbxDragon;
    private Button btnNew;
    private ToolTip tooltip;
    private ContextMenuStrip contextmenu;
    private ToolStripMenuItem cmnEdit;
    private ToolStripSeparator cmdSeparator;
    private ToolStripMenuItem cmnDelete;
    private Label label1;
  }
}