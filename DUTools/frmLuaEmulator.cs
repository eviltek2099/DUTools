using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Security;
//using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using FastColoredTextBoxNS;
using LuaInterface;//http://www.godpatterns.com/2006/05/scripting-with-lua-in-c.html
using Newtonsoft.Json;

// https://stackoverflow.com/questions/2834579/print-all-local-variables-accessible-to-the-current-scope-in-lua
//https://stackoverflow.com/questions/20015984/luainterface-problems
//http://www.lua.org/manual/5.2/manual.html#2.2
//syntex
//https://www.codeproject.com/Articles/161871/Fast-Colored-TextBox-for-syntax-highlighting-2

namespace DUTools
{

//class classSlot
//{
//  dynamic ElementForm { get; set; }
//}

public partial class frmLuaEmulator : Form
{

  //classSlot[] Slot;

  //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuaEmulator));

  dynamic[] SlotElements = { null, null, null, null, null, null, null, null, null, null };// new frmScreen();
  public static List<luatextbox> texts = new List<luatextbox>();
  const string DefaultJson = "{\"slots\":{\"0\":{\"name\":\"slot1\",\"type\":{\"events\":[],\"methods\":[]}},\"1\":{\"name\":\"slot2\",\"type\":{\"events\":[],\"methods\":[]}},\"2\":{\"name\":\"slot3\",\"type\":{\"events\":[],\"methods\":[]}},\"3\":{\"name\":\"slot4\",\"type\":{\"events\":[],\"methods\":[]}},\"4\":{\"name\":\"slot5\",\"type\":{\"events\":[],\"methods\":[]}},\"5\":{\"name\":\"slot6\",\"type\":{\"events\":[],\"methods\":[]}},\"6\":{\"name\":\"slot7\",\"type\":{\"events\":[],\"methods\":[]}},\"7\":{\"name\":\"slot8\",\"type\":{\"events\":[],\"methods\":[]}},\"8\":{\"name\":\"slot9\",\"type\":{\"events\":[],\"methods\":[]}},\"9\":{\"name\":\"slot10\",\"type\":{\"events\":[],\"methods\":[]}},\"-1\":{\"name\":\"unit\",\"type\":{\"events\":[],\"methods\":[]}},\"-2\":{\"name\":\"system\",\"type\":{\"events\":[],\"methods\":[]}},\"-3\":{\"name\":\"library\",\"type\":{\"events\":[],\"methods\":[]}}},\"handlers\":[],\"methods\":[],\"events\":[]}";
  Lua lua = new Lua();
  static LuaError lError = new LuaError();
  /// <summary>
  /// Main object for storing all changes to the config Json
  /// </summary>
  ModelJson obj = new ModelJson();
  private static System.Timers.Timer FlushTimer;
  private static System.Timers.Timer UpdateTimer;
  private int CurrentSlot = -4;

  /// <summary>
  /// Currently Selected Script Filter
  /// </summary>
  private Filter filter;

  //int Key = -1;
  public frmLuaEmulator()
  {
    InitializeComponent();
    texts.Add(new luatextbox());

  }

  private void Form1_Load(object sender, EventArgs e)
  {
    obj = new ModelJson
    {
      slots = new Dictionary<int, Modelslots>(),
      handlers = new List<Modelhandlers>(),
      methods = new List<string>(),
      events = new List<string>()
    };
    obj.slots.Add(0, new Modelslots { name = "slot1", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(1, new Modelslots { name = "slot2", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(2, new Modelslots { name = "slot3", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(3, new Modelslots { name = "slot4", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(4, new Modelslots { name = "slot5", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(5, new Modelslots { name = "slot6", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(6, new Modelslots { name = "slot7", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(7, new Modelslots { name = "slot8", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(8, new Modelslots { name = "slot9", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(9, new Modelslots { name = "slot10", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(-1, new Modelslots { name = "unit", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(-2, new Modelslots { name = "system", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });
    obj.slots.Add(-3, new Modelslots { name = "library", type = new Modeltype { events = new List<string>(), methods = new List<string>() } });


    //--Code to edit/insert items
    //Modelslots thisSlot;
    //obj.slots.TryGetValue(0, out thisSlot);
    //thisSlot.name = "EditedName";

    // This does work and added a filter at startup but is not needed
    //obj.handlers.Add(new Modelhandlers { code = @"screen.setRawHTML(""HI"")", filter = new Modelfilter { args = new List<Modelargs>(), signature = "start()", slotKey = -2 }, key = "1" });

    //obj.handlers.Add(new Modelhandlers { code = "Code here (system.update)", filter = new Modelfilter { args = new List<Modelargs>(), signature = "update()", slotKey = -2 }, key = "2" });
    //--



    PrivateFontCollection pfc = new PrivateFontCollection();
    pfc.AddFontFile(Application.StartupPath + "\\BankGothic-Regular.ttf");
    SlotsLable.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

    // LuaTable lt = (LuaTable)lua.DoString("return {1 = 'example1', 2 = 234, 'foo' = 'Foo Example'}")[0];
    // LuaTable lt4 =  lua.NewTable("");
    //lt["1"] = "example1";
    // lt["2"] = 234;
    //lt["foo"] = "Foo Example";

    var test = new Dictionary<string, int> {
  { "A", 1 },
  { "B", 2 }
};

    //table["C"] = lua.CreateTable(); ((LuaTable)table["C"])["A"] = 3;

    //foreach (var entry in test)
    //{
    //  (LuaTable)lua]["test"])[entry.Key] = entry.Value;
    //}
    //lua.DoString("yourTable = YourExportedFunction('arg1')", "internal");

    lua.DoString("screen = { setHTML = nil }");
    lua.RegisterFunction("screen.setHTML", this, this.GetType().GetMethod("setScreenHTML"));

    // lua.RegisterFunction("system", this, this.GetType().GetMethod("setRawHTML"));
    //lua.RegisterFunction("setHTML", this, this.GetType().GetMethod("setRawHTML"));
    //---------------------------------------

    lua.RegisterFunction("DanSays", this, this.GetType().GetMethod("DanSays"));
    lua.RegisterFunction("ThorSays", this, this.GetType().GetMethod("ThorSays"));
    UpdateControls();
  }
  public void setScreenHTML(string s)
  {

    setRawHTML(s);
  }
  public void setRawHTML(string s)
  {
    //Slots[Tag].setHTML(s);
    Console.WriteLine("setRawHTML>" + s);
  }
  //---------------------------------------
  public LuaTable CreateTable()
  {
    return (LuaTable)lua.DoString("return {}")[0];
  }
  public LuaTable YourExportedFunction(string arg)
  {
    var table = CreateTable();
    table["A"] = arg;
    table["B"] = 123;
    return table;
  }
  //LUA:  yourTable = YourExportedFunction("arg1")
  //---------------------------------------
  private void UpdateControls()
  {
    Modelslots thisSlot;
    obj.slots.TryGetValue(0, out thisSlot); slot1.Text = thisSlot != null ? thisSlot.name : "Slot1";
    obj.slots.TryGetValue(1, out thisSlot); slot2.Text = thisSlot != null ? thisSlot.name : "Slot2";
    obj.slots.TryGetValue(2, out thisSlot); slot3.Text = thisSlot != null ? thisSlot.name : "Slot3";
    obj.slots.TryGetValue(3, out thisSlot); slot4.Text = thisSlot != null ? thisSlot.name : "Slot4";
    obj.slots.TryGetValue(4, out thisSlot); slot5.Text = thisSlot != null ? thisSlot.name : "Slot5";
    obj.slots.TryGetValue(5, out thisSlot); slot6.Text = thisSlot != null ? thisSlot.name : "Slot6";
    obj.slots.TryGetValue(6, out thisSlot); slot7.Text = thisSlot != null ? thisSlot.name : "Slot7";
    obj.slots.TryGetValue(7, out thisSlot); slot8.Text = thisSlot != null ? thisSlot.name : "Slot8";
    obj.slots.TryGetValue(8, out thisSlot); slot9.Text = thisSlot != null ? thisSlot.name : "Slot9";
    obj.slots.TryGetValue(9, out thisSlot); slot10.Text = thisSlot != null ? thisSlot.name : "Slot10";
  }


  private void Run_Click(object sender, EventArgs e)
  {
    fnUpdate_Label("No Errors", ErrorText);
    try
    {
      if (UpdateTimer != null) UpdateTimer.Dispose();
      if (FlushTimer != null) FlushTimer.Dispose();

      UpdateTimer = new System.Timers.Timer();
      FlushTimer = new System.Timers.Timer();

      UpdateTimer.Interval = 100;
      FlushTimer.Interval = 16.6;

      // Hook up the Elapsed event for the timer. 
      UpdateTimer.Elapsed += OnUpdateTimerEvent;
      FlushTimer.Elapsed += OnFlushTimerEvent;

      // Have the timer fire repeated events (true is the default)
      UpdateTimer.AutoReset = true;
      FlushTimer.AutoReset = true;
      // Setup Internal stuff
      string c = @"vec3 = require(""cpml/vec3"");";


        //  c += slot.Value + " = {setRawHTML = setRawHTML};";
        for (int i = -1; i < obj.slots.Count-1; i++)
        {
          string SlotName = obj.slots[i].name; //owner.SourceControl.Text  
          if (i > 0 ) WireupScreenSlotToLua(SlotName, i);
      }

      lua.DoString(c, "internal");
      //--- init all starts
      DoCode("start()");


      // Start the timer
      UpdateTimer.Enabled = true;
      FlushTimer.Enabled = true;

      // lua.DoString("BobSays('Hello');","");
    }

    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }

  private void Handle_Error()
  {

  }
  private void button1_Click(object sender, EventArgs e)
  {
    try
    {
      lua.DoString("function BobSays(value) DanSays(value); end", "system.start");

    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);

    }
  }
  private void button2_Click(object sender, EventArgs e)
  {
    try
    {
      lua.DoString("BobSays('Hello');");
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }


  }

  public void DanSays(string s)
  {
    Console.WriteLine("Dan>" + s);
  }
  public void ThorSays(string s)
  {
    Console.WriteLine("Thor>" + s);
  }
  private void Start_Click(object sender, EventArgs e)
  {
    lua["num"] = 2;
    lua["str"] = "a string";

    double num = (double)lua["num"];
    string str = (string)lua["str"];

    Console.WriteLine("str:" + str + "\tnum:" + num);
    Console.ReadLine();

    //Program program = new Program();
    //Register our C# functions

    lua.DoString("DanSays('Hello'); ThorSays('Hi! Dan')");
    Console.ReadLine();

    Console.WriteLine(lua.ToString());
    Console.ReadLine();

  }


  Style GreenStyle = new TextStyle(new SolidBrush(Color.Red), null, FontStyle.Italic);
  Style BoldStyle = new TextStyle(Brushes.Red, null, FontStyle.Bold);
  EllipseStyle ellipseStyle = new EllipseStyle();
  private void Fctb_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
  {
    try
    {
      if (filter != null && fctb.Text.Length > 0)
      {
        //string[] lines = luaparser.SplitScringLines(fctb.Text);
        //List<string> StringList = luaparser.formatfile(lines, ref luaparser.defs);
        //filter.code = luaparser.ConvertStringArrayToString(StringList.ToArray());


        filter.code = fctb.Text;
        Modelhandlers handler = obj.handlers.Find(h => h.key == filter.Key && h.filter.slotKey == filter.SlotKey);
        handler.code = filter.code;
        if (Int32.TryParse(filter.Key, out int x))
        {

          //Modelhandlers handler = obj.handlers.Find(h => h.key == filter.Key);
          Console.WriteLine("Key:" + filter.Key + "Fctb_TextChanged");

        }




      }
      Range range = e.ChangedRange;
      HighlightRange(range);
    }
    catch (Exception ex)
    {

      throw;
    }


  }
  private void Fctb_TextChangedDelayed(object sender, TextChangedEventArgs e)
  {
    try
    {
      Range range = e.ChangedRange;
      HighlightRange(range);

    }
    catch (Exception ex)
    {

      throw;
    }
  }
  private void Fctb_PaintLine(object sender, PaintLineEventArgs e)
  {
    try
    {
      if (filter != null && lError.line != null && e.LineIndex == lError.line - 1)
      {
        Console.WriteLine("Key " + lError.key + "=" + filter.Key + " & slotKey " + lError.slotKey + "=" + filter.SlotKey);
        if (lError.key == filter.Key && lError.slotKey == filter.SlotKey)
          e.Graphics.FillRectangle(Brushes.DarkRed, 0, e.LineRect.Top, fctb.Width, e.LineRect.Height);
      }
    }
    catch (Exception ex)
    {

      throw;
    }




  }
  //private int CurrentSlot = -4;
  //private Filter filter;
  private void Fctb_Click(object sender, EventArgs e)
  {

    Range range = new Range(fctb);
    range.ClearStyle(StyleIndex.All);
    fctb.SyntaxHighlighter.LuaSyntaxHighlight(range);
    //fastColoredTextBox1.Refresh();
    HighlightVisibleRange();
  }
  const int margin = 2000;
  private void HighlightVisibleRange()
  {
    try
    {
      //expand visible range (+- margin)
      var startLine = Math.Max(0, fctb.VisibleRange.Start.iLine - margin);
      var endLine = Math.Min(fctb.LinesCount - 1, fctb.VisibleRange.End.iLine + margin);
      var range = new Range(fctb, 0, startLine, 0, endLine);
      HighlightRange(range);
    }
    catch (Exception ex)
    {

      throw;
    }

  }
  private void HighlightRange(Range range)
  {
    //clear folding markers
    range.ClearFoldingMarkers();
    //set markers for folding
    range.SetFoldingMarkers(@"N\d\d00", @"N\d\d99");
    //
    //range.ClearStyle(StyleIndex.All);
    //range.SetStyle(fctb.SyntaxHighlighter.BlueStyle, @"N\d+");
    //range.SetStyle(fctb.SyntaxHighlighter.RedStyle, @"[+\-]?[\d\.]+\d+");



    //clear style of changed range
    //e.ChangedRange.ClearStyle(GreenStyle);
    //e.ChangedRange.ClearStyle(BoldStyle);
    range.ClearStyle(ellipseStyle);
    //comment highlighting
    //e.ChangedRange.SetStyle(GreenStyle, @"--.*$", RegexOptions.Multiline);

    //e.ChangedRange.SetStyle(BoldStyle, @"\b(class|struct|enum)\s+(?<range>[\w_]+?)\b");
    range.SetStyle(ellipseStyle, @"\bBabylon\b", RegexOptions.IgnoreCase);


    (fctb.SyntaxHighlighter.BlueBoldStyle as TextStyle).ForeBrush = new SolidBrush(Color.FromArgb(255, 79, 128, 167));
    (fctb.SyntaxHighlighter.BlueStyle as TextStyle).ForeBrush = new SolidBrush(Color.Red);
    (fctb.SyntaxHighlighter.BoldStyle as TextStyle).ForeBrush = new SolidBrush(Color.White);
    (fctb.SyntaxHighlighter.BrownStyle as TextStyle).ForeBrush = new SolidBrush(Color.FromArgb(255, 178, 131, 112));
    (fctb.SyntaxHighlighter.GrayStyle as TextStyle).ForeBrush = new SolidBrush(Color.Yellow);
    (fctb.SyntaxHighlighter.GreenStyle as TextStyle).ForeBrush = new SolidBrush(Color.FromArgb(255, 104, 145, 87));
    (fctb.SyntaxHighlighter.MagentaStyle as TextStyle).ForeBrush = new SolidBrush(Color.FromArgb(255, 176, 199, 165));
    (fctb.SyntaxHighlighter.MaroonStyle as TextStyle).ForeBrush = new SolidBrush(Color.White);
    (fctb.SyntaxHighlighter.RedStyle as TextStyle).ForeBrush = new SolidBrush(Color.White);
    (fctb.SyntaxHighlighter.BlackStyle as TextStyle).ForeBrush = new SolidBrush(Color.White);

    //fctb.DoSelectionVisible();
  }

  private void Fctb_Load(object sender, EventArgs e)
  {

  }




  private void OnUpdateTimerEvent(Object source, System.Timers.ElapsedEventArgs e)
  {
    DoCode("update()");
    //Console.WriteLine("OnUpdateTimerEvent {0}", e.SignalTime);
    Application.DoEvents();
  }
  private void OnFlushTimerEvent(Object source, System.Timers.ElapsedEventArgs e)
  {
    //Console.WriteLine("OnFlushTimerEvent {0}", e.SignalTime);
    Application.DoEvents();
  }
  private void DoCode(string signature)
  {
    try
    {
      obj.handlers.Reverse();
      foreach (var handler in obj.handlers)
      {
        if (handler.filter.signature == signature)
        {
          Console.WriteLine(handler.filter.signature);
          lua.DoString(handler.code, handler.filter.signature + "," + handler.filter.slotKey.ToString() + "," + handler.key);
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
      UpdateTimer.Enabled = false;
      FlushTimer.Enabled = false;
      const char V = ':';
      const char D = ',';
      string[] t = ex.Message.Split(V);
      string[] l = getString(t[0]).Split(D);
      lError = new LuaError()
      {
        slotKey = Convert.ToInt32(l[1]),
        key = l[2],
        signature = l[0],
        line = Convert.ToInt32(t[1]),
        error = t[2]
      };
      fnUpdate_Label(ex.Message, ErrorText);
      //ErrorText.Text = ex.Message;
    }
  }
  public static string getString(string strSource)
  {
    int Start, End;
    if (strSource.Contains("\"") && strSource.Contains("\""))
    {
      Start = strSource.IndexOf("\"", 0) + 1;
      End = strSource.IndexOf("\"", Start);
      return strSource.Substring(Start, End - Start);
    }
    else
    {
      return "";
    }
  }

  public delegate void Update_label_delegate(string msg, Label label);
  public void fnUpdate_Label(string msg, Label label)
  {
    if (label.InvokeRequired)
    {
      label.BeginInvoke(new Update_label_delegate(fnUpdate_Label), new Object[] { msg, ErrorText });
    }
    else
    {
      label.Text = msg;
    }
  }
  #region Slots and Filters
  private void Slot_Leave(object sender, EventArgs e)
  {
    TextBox textBox;
    int Tag;
    if (sender is TextBox)
    {
      textBox = sender as TextBox;
      if (Int32.TryParse(textBox.Tag.ToString(), out Tag))
      {
        string SlotName = textBox.Text;
        if (SlotElements[Tag] != null)
        {

          if (SlotElements[Tag] is frmScreen)
          {
            WireupScreenSlotToLua(SlotName, Tag);
          }
          else if (SlotElements[Tag] is frmDatabase) {
            WireupDatabaseSlotToLua(SlotName, Tag);
          }

        }
          

          
      }
    }
  }
  private void Slot_TextChanged(object sender, EventArgs e)
  {

  }
  private void Slot_Click(object sender, EventArgs e)
  {
    Button button;
    TextBox textBox;
    int Tag;
    if (sender is Button)
    {
      button = sender as Button;
      if (Int32.TryParse(button.Tag.ToString(), out Tag))
      {

      }
    }
    else if (sender is TextBox)
    {
      textBox = sender as TextBox;
      Tag = Int32.Parse(textBox.Tag.ToString());
      //mnu
    }
    else { Tag = -4; }
    CurrentSlot = Tag;
    filter = null;
    fctb.Text = "";
    fctb.Enabled = false;
    Filters.Controls.Clear();// need to release events
    foreach (var handler in obj.handlers)
    {
      if (handler.filter.slotKey == Tag) AddFilterControl(handler);
    }

  }
  private void SlotDatabase_Click(object sender, EventArgs e)
  {
    ToolStripItem item = (sender as ToolStripItem);
    if (item != null)
    {
      ContextMenuStrip owner = item.Owner as ContextMenuStrip;
      if (owner != null)
      {
        int Tag = 0;
        if (Int32.TryParse(owner.SourceControl.Tag.ToString(), out Tag))
        {
          string SlotName = obj.slots[Tag].name; //owner.SourceControl.Text 
          owner.SourceControl.BackgroundImage = Properties.Resources.database; //(Image)resources.GetObject("slotType3.BackgroundImage");
          WireupDatabaseSlotToLua(SlotName, Tag);
        }
      }
    }
  }
  private void SlotScreen_Click(object sender, EventArgs e)
  {
    ToolStripItem item = (sender as ToolStripItem);
    if (item != null)
    {
      ContextMenuStrip owner = item.Owner as ContextMenuStrip;
      if (owner != null)
      {
        int Tag = 0;
        if (Int32.TryParse(owner.SourceControl.Tag.ToString(), out Tag))
        {
          string SlotName = obj.slots[Tag].name; //owner.SourceControl.Text 
          owner.SourceControl.BackgroundImage = Properties.Resources.monitor; //(Image)resources.GetObject("slotType3.BackgroundImage");
          WireupScreenSlotToLua(SlotName, Tag);
        }
      }
    }
  }

  private void WireupScreenSlotToLua(string SlotName, int Tag) {
    if (SlotElements[Tag] == null || SlotElements[Tag].IsDisposed == true)
    {
      SlotElements[Tag] = new frmScreen() as frmScreen;
    }
    frmScreen thisone = SlotElements[Tag];
    if (!thisone.Visible) thisone.Show(this);

    lua.DoString(SlotName + " = { setHTML = nil }");
    lua.RegisterFunction(SlotName + ".setHTML", thisone, thisone.GetType().GetMethod("setHTML"));
  }
  private void WireupDatabaseSlotToLua(string SlotName, int Tag)
  {
    if (SlotElements[Tag] == null || SlotElements[Tag].IsDisposed == true)
    {
      SlotElements[Tag] = new frmDatabase() as frmDatabase;
    }
    frmDatabase thisone = SlotElements[Tag];
    if (!thisone.Visible) thisone.Show(this);

    lua.DoString(SlotName + " = { setString = nil }");
    lua.RegisterFunction(SlotName + ".setString", thisone, thisone.GetType().GetMethod("setString"));
  }

  private void FilterSignature_Click(object sender, EventArgs e)
  {
    FilterClick(sender);
  }
  private void FilterSignatureButton_Click(object sender, EventArgs e)
  {
    FilterClick(sender);
  }
  private void Signature_MouseDown(object sender, MouseEventArgs e)
  {

    Filter filter;
    if (sender is Filter)
    {
      filter = sender as Filter;
      Point newLocation = new Point(e.Location.X + filter.Location.X + Filters.Location.X,
                                  e.Location.Y + filter.Location.Y + Filters.Location.Y);
      FilterClick(sender);
      FilterMenu.Show(this.PointToScreen(newLocation));
    }



  }
  private void FilterClick(object sender)
  {
    if (sender is Filter)
    {
      filter = sender as Filter;
      fctb.Text = filter.code;
      fctb.Enabled = true;

      Modelhandlers handler = obj.handlers.Find(h => h.key == filter.Key && h.filter.slotKey == filter.SlotKey);
      if (Int32.TryParse(handler.key, out int x))
      {
      }
    }
  }

  private void AddFilter_Click(object sender, EventArgs e)
  {
    Modelhandlers newHandler = new Modelhandlers
    {
      code = "",
      filter = new Modelfilter
      {
        args = new List<Modelargs>(),
        signature = "Select Event",
        slotKey = CurrentSlot
      },
      key = NextKey().ToString()
    };
    obj.handlers.Add(newHandler);
    AddFilterControl(newHandler);
    fctb.Enabled = true;
  }
  private void AddFilterControl(Modelhandlers handler)
  {
    filter = new DUTools.Filter();
    filter.Size = new System.Drawing.Size(220, 40);

    filter.SignatureText = handler.filter.signature;
    filter.code = handler.code;

    filter.Key = handler.key;
    filter.SlotKey = handler.filter.slotKey;
    filter.SignatureMouseDown += new MouseEventHandler(this.Signature_MouseDown);
    filter.CloseButtonClick += new EventHandler(this.RemoveFilter_Click);
    filter.SignatureClick += new EventHandler(this.FilterSignature_Click);
    filter.signatureButtonClick += new EventHandler(this.FilterSignatureButton_Click);
    this.Filters.Controls.Add(filter);
    filter.Select();
  }
  #endregion



  private int NextKey()
  {
    int HighestKey = 1;
    foreach (var handler in obj.handlers)
    {
      if (Int32.TryParse(handler.key, out int x))
      {
        if (x > HighestKey)
        {
          HighestKey = x;
        }
      }
    }
    return HighestKey + 1;
  }

  private void RemoveFilter_Click(object sender, EventArgs e)
  {
    Filter filter;
    if (sender is Filter)
    {
      filter = sender as Filter;
      filter.CloseButtonClick -= new System.EventHandler(this.RemoveFilter_Click);
      Modelhandlers handler = obj.handlers.Find(x => x.key == filter.Key);
      if (handler != null) obj.handlers.Remove(handler);
      this.Filters.Controls.Remove(filter);
    }
  }

  private void filter1_Paint(object sender, PaintEventArgs e)
  {

  }

  string OpenFile = "";
  private void LoadFile_Click(object sender, EventArgs e)
  {
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
      try
      {
        var sr = new StreamReader(openFileDialog.FileName);
        OpenFile = sr.ReadToEnd();
        obj = JsonConvert.DeserializeObject<ModelJson>(OpenFile);
        UpdateControls();
        sr.Close();
      }
      catch (SecurityException ex)
      {
        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
        $"Details:\n\n{ex.StackTrace}");
      }
    }
  }
  private void SaveFile_Click(object sender, EventArgs e)
  {
    try
    {
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        var sr = new StreamWriter(saveFileDialog.FileName);
        string json = JsonConvert.SerializeObject(obj);
        sr.Write(json);
        sr.Close();
      }
    }
    catch (SecurityException ex)
    {
      MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
      $"Details:\n\n{ex.StackTrace}");
    }
  }

  //// serialize JSON to a string and then write string to a file
  //File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(obj));

  //// serialize JSON directly to a file
  //using (StreamWriter file = File.CreateText(@"c:\movie.json"))
  //{
  //  JsonSerializer serializer = new JsonSerializer();
  //  serializer.Serialize(file, obj);
  //}
  private void ErrorText_Click(object sender, EventArgs e)
  {

  }

  private void MnuStart_Click(object sender, EventArgs e)
  {
    Modelhandlers handler = obj.handlers.Find(h => h.key == filter.Key && h.filter.slotKey == filter.SlotKey);
    handler.filter.signature = filter.SignatureText = "start()";
    if (Int32.TryParse(handler.key, out int x))
    {

    }
  }

  private void MnuUpdate_Click(object sender, EventArgs e)
  {
    Modelhandlers handler = obj.handlers.Find(h => h.key == filter.Key && h.filter.slotKey == filter.SlotKey);
    handler.filter.signature = filter.SignatureText = "update()";
  }

  private void library_ContextMenuStripChanged(object sender, EventArgs e)
  {

  }

  private void slot1_ContextMenuStripChanged(object sender, EventArgs e)
  {
    var menuItem = sender as MenuItem;
  }


}

class EllipseStyle : Style
{
  public override void Draw(Graphics gr, Point position, Range range)
  {
    //get size of rectangle
    Size size = GetSizeOfRange(range);
    //create rectangle
    Rectangle rect = new Rectangle(position, size);
    //inflate it
    rect.Inflate(2, 2);
    //get rounded rectangle
    var path = GetRoundedRectangle(rect, 7);
    //draw rounded rectangle
    gr.DrawPath(Pens.Red, path);
  }
}
}
