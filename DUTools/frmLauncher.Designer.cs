namespace DUTools
{
  partial class frmLauncher
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
      this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.btnLaunchLuaEditor = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.exitProgram = new System.Windows.Forms.ToolStripMenuItem();
      this.IconMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // TrayIcon
      // 
      this.TrayIcon.BalloonTipText = "ODY";
      this.TrayIcon.BalloonTipTitle = "ODY DUAL Universe Tools";
      this.TrayIcon.ContextMenuStrip = this.IconMenu;
      this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
      this.TrayIcon.Text = "ODY-DU-Tools";
      this.TrayIcon.Visible = true;
      this.TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseClick);
      this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
      // 
      // btnLaunchLuaEditor
      // 
      this.btnLaunchLuaEditor.Location = new System.Drawing.Point(12, 12);
      this.btnLaunchLuaEditor.Name = "btnLaunchLuaEditor";
      this.btnLaunchLuaEditor.Size = new System.Drawing.Size(143, 23);
      this.btnLaunchLuaEditor.TabIndex = 0;
      this.btnLaunchLuaEditor.Text = "Lua edit pad";
      this.btnLaunchLuaEditor.UseVisualStyleBackColor = true;
      this.btnLaunchLuaEditor.Click += new System.EventHandler(this.btnLaunchLuaEditor_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 41);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(143, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Launch a Control board";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // IconMenu
      // 
      this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitProgram});
      this.IconMenu.Name = "IconMenu";
      this.IconMenu.Size = new System.Drawing.Size(181, 48);
      // 
      // exitProgram
      // 
      this.exitProgram.Name = "exitProgram";
      this.exitProgram.Size = new System.Drawing.Size(180, 22);
      this.exitProgram.Text = "Exit Program";
      this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
      // 
      // frmLauncher
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(167, 77);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnLaunchLuaEditor);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLauncher";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ODY Tools";
      this.Load += new System.EventHandler(this.frmLauncher_Load);
      this.IconMenu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NotifyIcon TrayIcon;
    private System.Windows.Forms.Button btnLaunchLuaEditor;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ContextMenuStrip IconMenu;
    private System.Windows.Forms.ToolStripMenuItem exitProgram;
  }
}