namespace DUTools
{
  partial class frmScreen
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
      this.htmlScreen = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // htmlScreen
      // 
      this.htmlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
      this.htmlScreen.Location = new System.Drawing.Point(0, 0);
      this.htmlScreen.MinimumSize = new System.Drawing.Size(20, 20);
      this.htmlScreen.Name = "htmlScreen";
      this.htmlScreen.Size = new System.Drawing.Size(1064, 729);
      this.htmlScreen.TabIndex = 0;
      // 
      // frmScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1064, 729);
      this.Controls.Add(this.htmlScreen);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmScreen";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ScreenUnit";
      this.Load += new System.EventHandler(this.frmScreen_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser htmlScreen;
  }
}