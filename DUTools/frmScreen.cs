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
  public partial class frmScreen : Form
  {
    private string[] screenText = { @"<html><head>
<style>
body {
  background: #000;
  color: #fff;
  font-size: 1vw;
  font-weight: 400;
  width: 100vw;
  height: 100vh;
  padding: 0vh;
}
</style>
</head><body>", "", "</body></html>" };
    public frmScreen()
    {
      InitializeComponent();
    }
    public void setHTML(string htmlText)
    {
      if (this.IsDisposed != true)
      {
        screenText[1] = htmlText;
        htmlScreen.DocumentText = screenText[0] + screenText[1] + screenText[2];
      }
    }
    private void frmScreen_Load(object sender, EventArgs e)
    {
      setHTML("");
    }

  }
}
