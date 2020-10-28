namespace DUTools
{
  partial class frmLuaEmulator
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuaEmulator));
      this.StartButton = new System.Windows.Forms.Button();
      this.TextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.InsertMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ifThenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.suroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.commentSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.Lua_panel = new System.Windows.Forms.Panel();
      this.fctb = new DUTools.luatextbox();
      this.Splitter = new System.Windows.Forms.Splitter();
      this.DocMap = new FastColoredTextBoxNS.DocumentMap();
      this.panel3 = new System.Windows.Forms.Panel();
      this.slotType10 = new System.Windows.Forms.PictureBox();
      this.SlotMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuScreen = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
      this.coreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.radayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gyroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.slotType9 = new System.Windows.Forms.PictureBox();
      this.slotType8 = new System.Windows.Forms.PictureBox();
      this.slotType7 = new System.Windows.Forms.PictureBox();
      this.slotType6 = new System.Windows.Forms.PictureBox();
      this.slotType5 = new System.Windows.Forms.PictureBox();
      this.slotType4 = new System.Windows.Forms.PictureBox();
      this.slotType3 = new System.Windows.Forms.PictureBox();
      this.slotType2 = new System.Windows.Forms.PictureBox();
      this.slotType1 = new System.Windows.Forms.PictureBox();
      this.button2 = new System.Windows.Forms.Button();
      this.slot10 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.slot9 = new System.Windows.Forms.TextBox();
      this.slot8 = new System.Windows.Forms.TextBox();
      this.slot7 = new System.Windows.Forms.TextBox();
      this.slot6 = new System.Windows.Forms.TextBox();
      this.slot5 = new System.Windows.Forms.TextBox();
      this.slot4 = new System.Windows.Forms.TextBox();
      this.slot3 = new System.Windows.Forms.TextBox();
      this.slot2 = new System.Windows.Forms.TextBox();
      this.slot1 = new System.Windows.Forms.TextBox();
      this.unit = new System.Windows.Forms.Button();
      this.system = new System.Windows.Forms.Button();
      this.library = new System.Windows.Forms.Button();
      this.SlotHeadingPanel = new System.Windows.Forms.Panel();
      this.SlotsLable = new System.Windows.Forms.Label();
      this.Filters = new System.Windows.Forms.FlowLayoutPanel();
      this.AddFilter = new System.Windows.Forms.Button();
      this.ErrorText = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.SaveFile = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.LoadFile = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.fileSystemWatcher = new System.IO.FileSystemWatcher();
      this.FilterMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
      this.MnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
      this.TextMenu.SuspendLayout();
      this.LayoutPanel.SuspendLayout();
      this.Lua_panel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.slotType10)).BeginInit();
      this.SlotMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.slotType9)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType1)).BeginInit();
      this.SlotHeadingPanel.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
      this.FilterMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // StartButton
      // 
      this.StartButton.Location = new System.Drawing.Point(12, 484);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(79, 27);
      this.StartButton.TabIndex = 0;
      this.StartButton.Text = "Start";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.Start_Click);
      // 
      // TextMenu
      // 
      this.TextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertMenu,
            this.suroundToolStripMenuItem,
            this.commentSelectedToolStripMenuItem});
      this.TextMenu.Name = "FilterMenu";
      this.TextMenu.Size = new System.Drawing.Size(174, 70);
      // 
      // InsertMenu
      // 
      this.InsertMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.ifThenToolStripMenuItem,
            this.forToolStripMenuItem});
      this.InsertMenu.Name = "InsertMenu";
      this.InsertMenu.Size = new System.Drawing.Size(173, 22);
      this.InsertMenu.Text = "Insert";
      // 
      // functionToolStripMenuItem
      // 
      this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
      this.functionToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
      this.functionToolStripMenuItem.Text = "function";
      // 
      // ifThenToolStripMenuItem
      // 
      this.ifThenToolStripMenuItem.Name = "ifThenToolStripMenuItem";
      this.ifThenToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
      this.ifThenToolStripMenuItem.Text = "if then";
      // 
      // forToolStripMenuItem
      // 
      this.forToolStripMenuItem.Name = "forToolStripMenuItem";
      this.forToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
      this.forToolStripMenuItem.Text = "for  next";
      // 
      // suroundToolStripMenuItem
      // 
      this.suroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ifToolStripMenuItem});
      this.suroundToolStripMenuItem.Name = "suroundToolStripMenuItem";
      this.suroundToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.suroundToolStripMenuItem.Text = "suround with";
      // 
      // ifToolStripMenuItem
      // 
      this.ifToolStripMenuItem.Name = "ifToolStripMenuItem";
      this.ifToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
      this.ifToolStripMenuItem.Text = "if";
      // 
      // commentSelectedToolStripMenuItem
      // 
      this.commentSelectedToolStripMenuItem.Name = "commentSelectedToolStripMenuItem";
      this.commentSelectedToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.commentSelectedToolStripMenuItem.Text = "comment Selected";
      // 
      // LayoutPanel
      // 
      this.LayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
      this.LayoutPanel.ColumnCount = 3;
      this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
      this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
      this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.LayoutPanel.Controls.Add(this.Lua_panel, 2, 1);
      this.LayoutPanel.Controls.Add(this.panel3, 0, 1);
      this.LayoutPanel.Controls.Add(this.SlotHeadingPanel, 0, 0);
      this.LayoutPanel.Controls.Add(this.Filters, 1, 1);
      this.LayoutPanel.Controls.Add(this.AddFilter, 1, 2);
      this.LayoutPanel.Controls.Add(this.ErrorText, 2, 2);
      this.LayoutPanel.Controls.Add(this.panel1, 1, 0);
      this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.LayoutPanel.Margin = new System.Windows.Forms.Padding(0);
      this.LayoutPanel.Name = "LayoutPanel";
      this.LayoutPanel.Padding = new System.Windows.Forms.Padding(10);
      this.LayoutPanel.RowCount = 3;
      this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
      this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
      this.LayoutPanel.Size = new System.Drawing.Size(1094, 608);
      this.LayoutPanel.TabIndex = 4;
      // 
      // Lua_panel
      // 
      this.Lua_panel.AutoSize = true;
      this.Lua_panel.Controls.Add(this.fctb);
      this.Lua_panel.Controls.Add(this.Splitter);
      this.Lua_panel.Controls.Add(this.DocMap);
      this.Lua_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Lua_panel.Location = new System.Drawing.Point(460, 79);
      this.Lua_panel.Margin = new System.Windows.Forms.Padding(0);
      this.Lua_panel.Name = "Lua_panel";
      this.Lua_panel.Size = new System.Drawing.Size(624, 450);
      this.Lua_panel.TabIndex = 0;
      // 
      // fctb
      // 
      this.fctb.AutoCompleteBrackets = true;
      this.fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.fctb.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
      this.fctb.AutoScrollMinSize = new System.Drawing.Size(43, 14);
      this.fctb.BackBrush = null;
      this.fctb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.fctb.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
      this.fctb.CaretColor = System.Drawing.Color.White;
      this.fctb.CharHeight = 14;
      this.fctb.CharWidth = 8;
      this.fctb.CommentPrefix = "--";
      this.fctb.ContextMenuStrip = this.TextMenu;
      this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.fctb.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fctb.Enabled = false;
      this.fctb.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.fctb.ForeColor = System.Drawing.Color.White;
      this.fctb.hightlight = null;
      this.fctb.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.fctb.IsReplaceMode = false;
      this.fctb.Language = FastColoredTextBoxNS.Language.Lua;
      this.fctb.LeftBracket = '(';
      this.fctb.LeftBracket2 = '{';
      this.fctb.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.fctb.Location = new System.Drawing.Point(0, 0);
      this.fctb.Name = "fctb";
      this.fctb.Paddings = new System.Windows.Forms.Padding(0);
      this.fctb.ReservedCountOfLineNumberChars = 3;
      this.fctb.RightBracket = ')';
      this.fctb.RightBracket2 = '}';
      this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.fctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
      this.fctb.ShowFoldingLines = true;
      this.fctb.Size = new System.Drawing.Size(524, 450);
      this.fctb.TabIndex = 1;
      this.fctb.Zoom = 100;
      this.fctb.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Fctb_TextChanged);
      this.fctb.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Fctb_TextChangedDelayed);
      this.fctb.PaintLine += new System.EventHandler<FastColoredTextBoxNS.PaintLineEventArgs>(this.Fctb_PaintLine);
      this.fctb.Load += new System.EventHandler(this.Fctb_Load);
      this.fctb.Click += new System.EventHandler(this.Fctb_Click);
      // 
      // Splitter
      // 
      this.Splitter.Dock = System.Windows.Forms.DockStyle.Right;
      this.Splitter.Location = new System.Drawing.Point(524, 0);
      this.Splitter.Name = "Splitter";
      this.Splitter.Size = new System.Drawing.Size(3, 450);
      this.Splitter.TabIndex = 4;
      this.Splitter.TabStop = false;
      // 
      // DocMap
      // 
      this.DocMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.DocMap.Dock = System.Windows.Forms.DockStyle.Right;
      this.DocMap.ForeColor = System.Drawing.Color.Black;
      this.DocMap.Location = new System.Drawing.Point(527, 0);
      this.DocMap.Name = "DocMap";
      this.DocMap.Scale = 0.25F;
      this.DocMap.Size = new System.Drawing.Size(97, 450);
      this.DocMap.TabIndex = 5;
      this.DocMap.Target = this.fctb;
      this.DocMap.Text = "documentMap1";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.slotType10);
      this.panel3.Controls.Add(this.slotType9);
      this.panel3.Controls.Add(this.slotType8);
      this.panel3.Controls.Add(this.slotType7);
      this.panel3.Controls.Add(this.slotType6);
      this.panel3.Controls.Add(this.slotType5);
      this.panel3.Controls.Add(this.slotType4);
      this.panel3.Controls.Add(this.slotType3);
      this.panel3.Controls.Add(this.slotType2);
      this.panel3.Controls.Add(this.slotType1);
      this.panel3.Controls.Add(this.button2);
      this.panel3.Controls.Add(this.slot10);
      this.panel3.Controls.Add(this.button1);
      this.panel3.Controls.Add(this.StartButton);
      this.panel3.Controls.Add(this.slot9);
      this.panel3.Controls.Add(this.slot8);
      this.panel3.Controls.Add(this.slot7);
      this.panel3.Controls.Add(this.slot6);
      this.panel3.Controls.Add(this.slot5);
      this.panel3.Controls.Add(this.slot4);
      this.panel3.Controls.Add(this.slot3);
      this.panel3.Controls.Add(this.slot2);
      this.panel3.Controls.Add(this.slot1);
      this.panel3.Controls.Add(this.unit);
      this.panel3.Controls.Add(this.system);
      this.panel3.Controls.Add(this.library);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(10, 79);
      this.panel3.Margin = new System.Windows.Forms.Padding(0);
      this.panel3.Name = "panel3";
      this.LayoutPanel.SetRowSpan(this.panel3, 2);
      this.panel3.Size = new System.Drawing.Size(200, 519);
      this.panel3.TabIndex = 6;
      // 
      // slotType10
      // 
      this.slotType10.BackColor = System.Drawing.Color.Transparent;
      this.slotType10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType10.BackgroundImage")));
      this.slotType10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType10.ContextMenuStrip = this.SlotMenu;
      this.slotType10.ErrorImage = null;
      this.slotType10.InitialImage = null;
      this.slotType10.Location = new System.Drawing.Point(3, 359);
      this.slotType10.Name = "slotType10";
      this.slotType10.Size = new System.Drawing.Size(24, 26);
      this.slotType10.TabIndex = 22;
      this.slotType10.TabStop = false;
      this.slotType10.Tag = "9";
      // 
      // SlotMenu
      // 
      this.SlotMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScreen,
            this.mnuDatabase,
            this.coreToolStripMenuItem,
            this.switchToolStripMenuItem,
            this.radayToolStripMenuItem,
            this.gyroToolStripMenuItem});
      this.SlotMenu.Name = "FilterMenu";
      this.SlotMenu.Size = new System.Drawing.Size(181, 158);
      this.SlotMenu.Tag = "1";
      // 
      // mnuScreen
      // 
      this.mnuScreen.Name = "mnuScreen";
      this.mnuScreen.Size = new System.Drawing.Size(180, 22);
      this.mnuScreen.Text = "Screen";
      this.mnuScreen.Click += new System.EventHandler(this.SlotScreen_Click);
      // 
      // mnuDatabase
      // 
      this.mnuDatabase.Name = "mnuDatabase";
      this.mnuDatabase.Size = new System.Drawing.Size(180, 22);
      this.mnuDatabase.Text = "Database";
      this.mnuDatabase.Click += new System.EventHandler(this.SlotDatabase_Click);
      // 
      // coreToolStripMenuItem
      // 
      this.coreToolStripMenuItem.Name = "coreToolStripMenuItem";
      this.coreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.coreToolStripMenuItem.Text = "Core";
      // 
      // switchToolStripMenuItem
      // 
      this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
      this.switchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.switchToolStripMenuItem.Text = "Switch";
      // 
      // radayToolStripMenuItem
      // 
      this.radayToolStripMenuItem.Name = "radayToolStripMenuItem";
      this.radayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.radayToolStripMenuItem.Text = "Radar";
      // 
      // gyroToolStripMenuItem
      // 
      this.gyroToolStripMenuItem.Name = "gyroToolStripMenuItem";
      this.gyroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.gyroToolStripMenuItem.Text = "Gyro";
      // 
      // slotType9
      // 
      this.slotType9.BackColor = System.Drawing.Color.Transparent;
      this.slotType9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType9.BackgroundImage")));
      this.slotType9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType9.ContextMenuStrip = this.SlotMenu;
      this.slotType9.ErrorImage = null;
      this.slotType9.InitialImage = null;
      this.slotType9.Location = new System.Drawing.Point(2, 330);
      this.slotType9.Name = "slotType9";
      this.slotType9.Size = new System.Drawing.Size(24, 26);
      this.slotType9.TabIndex = 21;
      this.slotType9.TabStop = false;
      this.slotType9.Tag = "8";
      // 
      // slotType8
      // 
      this.slotType8.BackColor = System.Drawing.Color.Transparent;
      this.slotType8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType8.BackgroundImage")));
      this.slotType8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType8.ContextMenuStrip = this.SlotMenu;
      this.slotType8.ErrorImage = null;
      this.slotType8.InitialImage = null;
      this.slotType8.Location = new System.Drawing.Point(2, 301);
      this.slotType8.Name = "slotType8";
      this.slotType8.Size = new System.Drawing.Size(24, 26);
      this.slotType8.TabIndex = 20;
      this.slotType8.TabStop = false;
      this.slotType8.Tag = "7";
      // 
      // slotType7
      // 
      this.slotType7.BackColor = System.Drawing.Color.Transparent;
      this.slotType7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType7.BackgroundImage")));
      this.slotType7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType7.ContextMenuStrip = this.SlotMenu;
      this.slotType7.ErrorImage = null;
      this.slotType7.InitialImage = null;
      this.slotType7.Location = new System.Drawing.Point(3, 272);
      this.slotType7.Name = "slotType7";
      this.slotType7.Size = new System.Drawing.Size(24, 26);
      this.slotType7.TabIndex = 19;
      this.slotType7.TabStop = false;
      this.slotType7.Tag = "6";
      // 
      // slotType6
      // 
      this.slotType6.BackColor = System.Drawing.Color.Transparent;
      this.slotType6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType6.BackgroundImage")));
      this.slotType6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType6.ContextMenuStrip = this.SlotMenu;
      this.slotType6.ErrorImage = null;
      this.slotType6.InitialImage = null;
      this.slotType6.Location = new System.Drawing.Point(2, 243);
      this.slotType6.Name = "slotType6";
      this.slotType6.Size = new System.Drawing.Size(24, 26);
      this.slotType6.TabIndex = 18;
      this.slotType6.TabStop = false;
      this.slotType6.Tag = "5";
      // 
      // slotType5
      // 
      this.slotType5.BackColor = System.Drawing.Color.Transparent;
      this.slotType5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType5.BackgroundImage")));
      this.slotType5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType5.ContextMenuStrip = this.SlotMenu;
      this.slotType5.ErrorImage = null;
      this.slotType5.InitialImage = null;
      this.slotType5.Location = new System.Drawing.Point(2, 214);
      this.slotType5.Name = "slotType5";
      this.slotType5.Size = new System.Drawing.Size(24, 26);
      this.slotType5.TabIndex = 17;
      this.slotType5.TabStop = false;
      this.slotType5.Tag = "4";
      // 
      // slotType4
      // 
      this.slotType4.BackColor = System.Drawing.Color.Transparent;
      this.slotType4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType4.BackgroundImage")));
      this.slotType4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType4.ContextMenuStrip = this.SlotMenu;
      this.slotType4.ErrorImage = null;
      this.slotType4.InitialImage = null;
      this.slotType4.Location = new System.Drawing.Point(2, 185);
      this.slotType4.Name = "slotType4";
      this.slotType4.Size = new System.Drawing.Size(24, 26);
      this.slotType4.TabIndex = 16;
      this.slotType4.TabStop = false;
      this.slotType4.Tag = "3";
      // 
      // slotType3
      // 
      this.slotType3.BackColor = System.Drawing.Color.Transparent;
      this.slotType3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType3.BackgroundImage")));
      this.slotType3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType3.ContextMenuStrip = this.SlotMenu;
      this.slotType3.ErrorImage = null;
      this.slotType3.InitialImage = null;
      this.slotType3.Location = new System.Drawing.Point(2, 156);
      this.slotType3.Name = "slotType3";
      this.slotType3.Size = new System.Drawing.Size(24, 26);
      this.slotType3.TabIndex = 15;
      this.slotType3.TabStop = false;
      this.slotType3.Tag = "2";
      // 
      // slotType2
      // 
      this.slotType2.BackColor = System.Drawing.Color.Transparent;
      this.slotType2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType2.BackgroundImage")));
      this.slotType2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType2.ContextMenuStrip = this.SlotMenu;
      this.slotType2.ErrorImage = null;
      this.slotType2.InitialImage = null;
      this.slotType2.Location = new System.Drawing.Point(2, 127);
      this.slotType2.Name = "slotType2";
      this.slotType2.Size = new System.Drawing.Size(24, 26);
      this.slotType2.TabIndex = 14;
      this.slotType2.TabStop = false;
      this.slotType2.Tag = "1";
      // 
      // slotType1
      // 
      this.slotType1.BackColor = System.Drawing.Color.Transparent;
      this.slotType1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slotType1.BackgroundImage")));
      this.slotType1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.slotType1.ContextMenuStrip = this.SlotMenu;
      this.slotType1.ErrorImage = null;
      this.slotType1.InitialImage = null;
      this.slotType1.Location = new System.Drawing.Point(2, 98);
      this.slotType1.Name = "slotType1";
      this.slotType1.Size = new System.Drawing.Size(24, 26);
      this.slotType1.TabIndex = 13;
      this.slotType1.TabStop = false;
      this.slotType1.Tag = "0";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 424);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(79, 22);
      this.button2.TabIndex = 1;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // slot10
      // 
      this.slot10.BackColor = System.Drawing.Color.Black;
      this.slot10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot10.ForeColor = System.Drawing.Color.White;
      this.slot10.Location = new System.Drawing.Point(28, 359);
      this.slot10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot10.MaxLength = 20;
      this.slot10.Name = "slot10";
      this.slot10.Size = new System.Drawing.Size(169, 26);
      this.slot10.TabIndex = 12;
      this.slot10.Tag = "9";
      this.slot10.Text = "slot10";
      this.slot10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot10.WordWrap = false;
      this.slot10.Click += new System.EventHandler(this.Slot_Click);
      this.slot10.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot10.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 394);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(79, 24);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // slot9
      // 
      this.slot9.BackColor = System.Drawing.Color.Black;
      this.slot9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot9.ForeColor = System.Drawing.Color.White;
      this.slot9.Location = new System.Drawing.Point(28, 330);
      this.slot9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot9.MaxLength = 20;
      this.slot9.Name = "slot9";
      this.slot9.Size = new System.Drawing.Size(169, 26);
      this.slot9.TabIndex = 11;
      this.slot9.Tag = "8";
      this.slot9.Text = "slot9";
      this.slot9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot9.WordWrap = false;
      this.slot9.Click += new System.EventHandler(this.Slot_Click);
      this.slot9.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot9.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot8
      // 
      this.slot8.BackColor = System.Drawing.Color.Black;
      this.slot8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot8.ForeColor = System.Drawing.Color.White;
      this.slot8.Location = new System.Drawing.Point(28, 301);
      this.slot8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot8.MaxLength = 20;
      this.slot8.Name = "slot8";
      this.slot8.Size = new System.Drawing.Size(169, 26);
      this.slot8.TabIndex = 10;
      this.slot8.Tag = "7";
      this.slot8.Text = "slot8";
      this.slot8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot8.WordWrap = false;
      this.slot8.Click += new System.EventHandler(this.Slot_Click);
      this.slot8.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot8.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot7
      // 
      this.slot7.BackColor = System.Drawing.Color.Black;
      this.slot7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot7.ForeColor = System.Drawing.Color.White;
      this.slot7.Location = new System.Drawing.Point(28, 272);
      this.slot7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot7.MaxLength = 20;
      this.slot7.Name = "slot7";
      this.slot7.Size = new System.Drawing.Size(169, 26);
      this.slot7.TabIndex = 9;
      this.slot7.Tag = "6";
      this.slot7.Text = "slot7";
      this.slot7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot7.WordWrap = false;
      this.slot7.Click += new System.EventHandler(this.Slot_Click);
      this.slot7.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot7.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot6
      // 
      this.slot6.BackColor = System.Drawing.Color.Black;
      this.slot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot6.ForeColor = System.Drawing.Color.White;
      this.slot6.Location = new System.Drawing.Point(28, 243);
      this.slot6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot6.MaxLength = 20;
      this.slot6.Name = "slot6";
      this.slot6.Size = new System.Drawing.Size(169, 26);
      this.slot6.TabIndex = 8;
      this.slot6.Tag = "5";
      this.slot6.Text = "slot6";
      this.slot6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot6.WordWrap = false;
      this.slot6.Click += new System.EventHandler(this.Slot_Click);
      this.slot6.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot6.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot5
      // 
      this.slot5.BackColor = System.Drawing.Color.Black;
      this.slot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot5.ForeColor = System.Drawing.Color.White;
      this.slot5.Location = new System.Drawing.Point(28, 214);
      this.slot5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot5.MaxLength = 20;
      this.slot5.Name = "slot5";
      this.slot5.Size = new System.Drawing.Size(169, 26);
      this.slot5.TabIndex = 7;
      this.slot5.Tag = "4";
      this.slot5.Text = "slot5";
      this.slot5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot5.WordWrap = false;
      this.slot5.Click += new System.EventHandler(this.Slot_Click);
      this.slot5.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot5.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot4
      // 
      this.slot4.BackColor = System.Drawing.Color.Black;
      this.slot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot4.ForeColor = System.Drawing.Color.White;
      this.slot4.Location = new System.Drawing.Point(28, 185);
      this.slot4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot4.MaxLength = 20;
      this.slot4.Name = "slot4";
      this.slot4.Size = new System.Drawing.Size(169, 26);
      this.slot4.TabIndex = 6;
      this.slot4.Tag = "3";
      this.slot4.Text = "slot4";
      this.slot4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot4.WordWrap = false;
      this.slot4.Click += new System.EventHandler(this.Slot_Click);
      this.slot4.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot4.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot3
      // 
      this.slot3.BackColor = System.Drawing.Color.Black;
      this.slot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot3.ForeColor = System.Drawing.Color.White;
      this.slot3.Location = new System.Drawing.Point(28, 156);
      this.slot3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot3.MaxLength = 20;
      this.slot3.Name = "slot3";
      this.slot3.Size = new System.Drawing.Size(169, 26);
      this.slot3.TabIndex = 5;
      this.slot3.Tag = "2";
      this.slot3.Text = "slot3";
      this.slot3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot3.WordWrap = false;
      this.slot3.Click += new System.EventHandler(this.Slot_Click);
      this.slot3.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot3.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot2
      // 
      this.slot2.BackColor = System.Drawing.Color.Black;
      this.slot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot2.ForeColor = System.Drawing.Color.White;
      this.slot2.Location = new System.Drawing.Point(28, 127);
      this.slot2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot2.MaxLength = 20;
      this.slot2.Name = "slot2";
      this.slot2.Size = new System.Drawing.Size(169, 26);
      this.slot2.TabIndex = 4;
      this.slot2.Tag = "1";
      this.slot2.Text = "slot2";
      this.slot2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot2.WordWrap = false;
      this.slot2.Click += new System.EventHandler(this.Slot_Click);
      this.slot2.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot2.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // slot1
      // 
      this.slot1.BackColor = System.Drawing.Color.Black;
      this.slot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.slot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slot1.ForeColor = System.Drawing.Color.White;
      this.slot1.Location = new System.Drawing.Point(28, 98);
      this.slot1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
      this.slot1.MaxLength = 20;
      this.slot1.Name = "slot1";
      this.slot1.Size = new System.Drawing.Size(169, 26);
      this.slot1.TabIndex = 3;
      this.slot1.Tag = "0";
      this.slot1.Text = "slot1";
      this.slot1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.slot1.WordWrap = false;
      this.slot1.Click += new System.EventHandler(this.Slot_Click);
      this.slot1.TextChanged += new System.EventHandler(this.Slot_TextChanged);
      this.slot1.Leave += new System.EventHandler(this.Slot_Leave);
      // 
      // unit
      // 
      this.unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unit.ForeColor = System.Drawing.Color.White;
      this.unit.Location = new System.Drawing.Point(3, 61);
      this.unit.Margin = new System.Windows.Forms.Padding(0);
      this.unit.Name = "unit";
      this.unit.Size = new System.Drawing.Size(194, 30);
      this.unit.TabIndex = 2;
      this.unit.Tag = "-1";
      this.unit.Text = "unit";
      this.unit.UseCompatibleTextRendering = true;
      this.unit.UseVisualStyleBackColor = true;
      this.unit.Click += new System.EventHandler(this.Slot_Click);
      // 
      // system
      // 
      this.system.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.system.ForeColor = System.Drawing.Color.White;
      this.system.Location = new System.Drawing.Point(3, 32);
      this.system.Name = "system";
      this.system.Size = new System.Drawing.Size(194, 30);
      this.system.TabIndex = 1;
      this.system.Tag = "-2";
      this.system.Text = "system";
      this.system.UseVisualStyleBackColor = true;
      this.system.Click += new System.EventHandler(this.Slot_Click);
      // 
      // library
      // 
      this.library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.library.ForeColor = System.Drawing.Color.White;
      this.library.Location = new System.Drawing.Point(3, 3);
      this.library.Name = "library";
      this.library.Size = new System.Drawing.Size(194, 30);
      this.library.TabIndex = 0;
      this.library.Tag = "-3";
      this.library.Text = "library";
      this.library.UseVisualStyleBackColor = true;
      this.library.ContextMenuStripChanged += new System.EventHandler(this.library_ContextMenuStripChanged);
      this.library.Click += new System.EventHandler(this.Slot_Click);
      // 
      // SlotHeadingPanel
      // 
      this.SlotHeadingPanel.Controls.Add(this.SlotsLable);
      this.SlotHeadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SlotHeadingPanel.Location = new System.Drawing.Point(10, 10);
      this.SlotHeadingPanel.Margin = new System.Windows.Forms.Padding(0);
      this.SlotHeadingPanel.Name = "SlotHeadingPanel";
      this.SlotHeadingPanel.Size = new System.Drawing.Size(200, 69);
      this.SlotHeadingPanel.TabIndex = 7;
      // 
      // SlotsLable
      // 
      this.SlotsLable.AutoSize = true;
      this.SlotsLable.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SlotsLable.ForeColor = System.Drawing.Color.White;
      this.SlotsLable.Location = new System.Drawing.Point(12, 34);
      this.SlotsLable.Name = "SlotsLable";
      this.SlotsLable.Size = new System.Drawing.Size(32, 14);
      this.SlotsLable.TabIndex = 0;
      this.SlotsLable.Text = "Slots";
      // 
      // Filters
      // 
      this.Filters.AutoScroll = true;
      this.Filters.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Filters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.Filters.Location = new System.Drawing.Point(210, 79);
      this.Filters.Margin = new System.Windows.Forms.Padding(0);
      this.Filters.Name = "Filters";
      this.Filters.Size = new System.Drawing.Size(250, 450);
      this.Filters.TabIndex = 4;
      this.Filters.WrapContents = false;
      // 
      // AddFilter
      // 
      this.AddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.AddFilter.Location = new System.Drawing.Point(213, 532);
      this.AddFilter.Name = "AddFilter";
      this.AddFilter.Size = new System.Drawing.Size(244, 63);
      this.AddFilter.TabIndex = 8;
      this.AddFilter.Text = "Add Filter";
      this.AddFilter.UseVisualStyleBackColor = true;
      this.AddFilter.Click += new System.EventHandler(this.AddFilter_Click);
      // 
      // ErrorText
      // 
      this.ErrorText.AutoSize = true;
      this.ErrorText.ForeColor = System.Drawing.Color.White;
      this.ErrorText.Location = new System.Drawing.Point(463, 532);
      this.ErrorText.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
      this.ErrorText.Name = "ErrorText";
      this.ErrorText.Size = new System.Drawing.Size(29, 13);
      this.ErrorText.TabIndex = 10;
      this.ErrorText.Text = "Error";
      this.ErrorText.Click += new System.EventHandler(this.ErrorText_Click);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.SaveFile);
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.LoadFile);
      this.panel1.Location = new System.Drawing.Point(213, 13);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(244, 63);
      this.panel1.TabIndex = 11;
      // 
      // SaveFile
      // 
      this.SaveFile.Location = new System.Drawing.Point(91, 9);
      this.SaveFile.Name = "SaveFile";
      this.SaveFile.Size = new System.Drawing.Size(72, 24);
      this.SaveFile.TabIndex = 14;
      this.SaveFile.Text = "Save";
      this.SaveFile.UseVisualStyleBackColor = true;
      this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(169, 8);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(42, 25);
      this.button4.TabIndex = 13;
      this.button4.Text = "Run";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.Run_Click);
      // 
      // LoadFile
      // 
      this.LoadFile.Location = new System.Drawing.Point(13, 9);
      this.LoadFile.Name = "LoadFile";
      this.LoadFile.Size = new System.Drawing.Size(72, 24);
      this.LoadFile.TabIndex = 9;
      this.LoadFile.Text = "Load";
      this.LoadFile.UseVisualStyleBackColor = true;
      this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.Filter = "json Files|*.json";
      // 
      // fileSystemWatcher
      // 
      this.fileSystemWatcher.EnableRaisingEvents = true;
      this.fileSystemWatcher.SynchronizingObject = this;
      // 
      // FilterMenu
      // 
      this.FilterMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuUpdate});
      this.FilterMenu.Name = "FilterMenu";
      this.FilterMenu.Size = new System.Drawing.Size(113, 48);
      // 
      // MnuStart
      // 
      this.MnuStart.Name = "MnuStart";
      this.MnuStart.Size = new System.Drawing.Size(112, 22);
      this.MnuStart.Text = "Start";
      this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
      // 
      // MnuUpdate
      // 
      this.MnuUpdate.Name = "MnuUpdate";
      this.MnuUpdate.Size = new System.Drawing.Size(112, 22);
      this.MnuUpdate.Text = "Update";
      this.MnuUpdate.Click += new System.EventHandler(this.MnuUpdate_Click);
      // 
      // frmLuaEmulator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1094, 608);
      this.Controls.Add(this.LayoutPanel);
      this.Name = "frmLuaEmulator";
      this.Text = "DuaLua";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.TextMenu.ResumeLayout(false);
      this.LayoutPanel.ResumeLayout(false);
      this.LayoutPanel.PerformLayout();
      this.Lua_panel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.slotType10)).EndInit();
      this.SlotMenu.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.slotType9)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.slotType1)).EndInit();
      this.SlotHeadingPanel.ResumeLayout(false);
      this.SlotHeadingPanel.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
      this.FilterMenu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button StartButton;
    private System.Windows.Forms.TableLayoutPanel LayoutPanel;
    private System.Windows.Forms.Panel Lua_panel;
    private System.Windows.Forms.Splitter Splitter;
    private FastColoredTextBoxNS.DocumentMap DocMap;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel SlotHeadingPanel;
    private System.Windows.Forms.Label SlotsLable;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button library;
    private System.Windows.Forms.Button unit;
    private System.Windows.Forms.Button system;
    private System.Windows.Forms.TextBox slot10;
    private System.Windows.Forms.TextBox slot9;
    private System.Windows.Forms.TextBox slot8;
    private System.Windows.Forms.TextBox slot7;
    private System.Windows.Forms.TextBox slot6;
    private System.Windows.Forms.TextBox slot5;
    private System.Windows.Forms.TextBox slot4;
    private System.Windows.Forms.TextBox slot3;
    private System.Windows.Forms.TextBox slot2;
    private System.Windows.Forms.TextBox slot1;
    private System.Windows.Forms.FlowLayoutPanel Filters;
    private System.Windows.Forms.Button AddFilter;
    private System.Windows.Forms.Button LoadFile;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.IO.FileSystemWatcher fileSystemWatcher;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label ErrorText;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button SaveFile;
    private System.Windows.Forms.ContextMenuStrip FilterMenu;
    private System.Windows.Forms.ToolStripMenuItem MnuStart;
    private System.Windows.Forms.ToolStripMenuItem MnuUpdate;
    private luatextbox fctb;
    private System.Windows.Forms.ContextMenuStrip TextMenu;
    private System.Windows.Forms.ToolStripMenuItem InsertMenu;
    private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ifThenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem suroundToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ifToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem commentSelectedToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip SlotMenu;
    private System.Windows.Forms.ToolStripMenuItem mnuScreen;
    private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
    private System.Windows.Forms.ToolStripMenuItem coreToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem radayToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gyroToolStripMenuItem;
    private System.Windows.Forms.PictureBox slotType1;
    private System.Windows.Forms.PictureBox slotType2;
    private System.Windows.Forms.PictureBox slotType10;
    private System.Windows.Forms.PictureBox slotType9;
    private System.Windows.Forms.PictureBox slotType8;
    private System.Windows.Forms.PictureBox slotType7;
    private System.Windows.Forms.PictureBox slotType6;
    private System.Windows.Forms.PictureBox slotType5;
    private System.Windows.Forms.PictureBox slotType4;
    private System.Windows.Forms.PictureBox slotType3;
  }
}

