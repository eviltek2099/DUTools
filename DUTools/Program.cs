using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUTools
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      // Application.Run(new LuaEditForm());
      //frmLuaEditForm luaForm = new frmLuaEditForm();
       // luaForm.Show();
     // Application.Run(new frmLuaEmulator());
      Application.Run(new frmLauncher());
    }
  }
}
