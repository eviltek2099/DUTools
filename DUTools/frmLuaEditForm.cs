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
  public partial class frmLuaEditForm : Form
  {
    public static luatextbox texts = new luatextbox();
    public frmLuaEditForm()
    {
      InitializeComponent();
      texts = new luatextbox();

      this.Controls.Add(texts);
      texts.Dock = DockStyle.Fill;
      texts.AutoCompleteBrackets = true;
      texts.AutoCompleteBracketsList = new char[] {
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
      texts.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
      texts.AutoScrollMinSize = new System.Drawing.Size(43, 14);
      texts.BackBrush = null;
      texts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      texts.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
      texts.CaretColor = System.Drawing.Color.White;
      texts.CharHeight = 14;
      texts.CharWidth = 8;
      texts.CommentPrefix = "--";
      texts.Cursor = System.Windows.Forms.Cursors.IBeam;
      texts.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      texts.Dock = System.Windows.Forms.DockStyle.Fill;
      texts.ForeColor = System.Drawing.Color.White;
      texts.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      texts.IsReplaceMode = false;
      texts.Language = FastColoredTextBoxNS.Language.Lua;
      texts.LeftBracket = '(';
      texts.LeftBracket2 = '{';
      texts.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      texts.Location = new System.Drawing.Point(0, 0);
     // texts.Name = "fctb";
      texts.Paddings = new System.Windows.Forms.Padding(0);
      texts.ReservedCountOfLineNumberChars = 3;
      texts.RightBracket = ')';
      texts.RightBracket2 = '}';
      texts.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
    //  texts.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
      texts.ShowFoldingLines = true;
      texts.Size = new System.Drawing.Size(544, 470);
      texts.TabIndex = 1;
      texts.Zoom = 100;
   //   texts.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(texts_TextChanged);
    //  texts.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(texts_TextChangedDelayed);
    //  texts.PaintLine += new System.EventHandler<FastColoredTextBoxNS.PaintLineEventArgs>(texts_PaintLine);
   //   texts.Load += new System.EventHandler(texts_Load);
    //  texts.Click += new System.EventHandler(texts_Click);
    }

    private void LuaEditForm_Load(object sender, EventArgs e)
    {

    }
  }
}
