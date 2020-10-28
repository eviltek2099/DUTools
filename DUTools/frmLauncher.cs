using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUTools
{
  public partial class frmLauncher : Form
  {
    public frmLauncher()
    {
      InitializeComponent();
    }

    private void btnLaunchLuaEditor_Click(object sender, EventArgs e)
    {
      frmLuaEditForm Form = new frmLuaEditForm();
      Form.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      frmLuaEmulator Form = new frmLuaEmulator();
      Form.Show(this);
    }

    private void frmLauncher_Load(object sender, EventArgs e)
    {
      Rectangle workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
      int left = workingArea.Width - this.Width;
      int top = workingArea.Height - this.Height;

      this.Location = new Point(left, top);
    }

    private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      this.Activate();
    }
    private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
    {
      this.Activate();
    }

    private void exitProgram_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
  }
}
