using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DUTools
{
  /// <summary>
  /// Custom control for dealing with DU Filters
  /// </summary>
  class Filter : Panel
  {
    //-------------------------
    private Label CloseButton;
    private TextBox variable;
    private Label rightPar;
    private TableLayoutPanel MainLayout;
    private Label signature;
    private Label leftPar;
    private TableLayoutPanel inputLayout;
    private Panel inputPanel;
    private Label signatureButton;
    //-------------------------  
    public event EventHandler CloseButtonClick;
    public event EventHandler SignatureClick;
    public event MouseEventHandler SignatureMouseDown;
    public event EventHandler signatureButtonClick;
    public event EventHandler variableTextChanged;


    private String signatureText = "FilterText";
    private bool hasVariable = false;
    public int SlotKey { get; set; }
    public String Key { get; set; }
    public String code { get; set; }
    public String SignatureText
    {
      get { return signatureText; }
      set {
        signatureText = value;
        Invalidate();
      }
    }
    public bool HasVariable
    {
      get { return hasVariable; }
      //set {
      //  hasVariable = value;
      //  Invalidate();
      //}
    }

    public Filter()
    {
      InitializeComponent();
    }
    private void InitializeComponent()
    {
      this.CloseButton = new System.Windows.Forms.Label();
      this.variable = new System.Windows.Forms.TextBox();
      this.rightPar = new System.Windows.Forms.Label();
      this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
      this.signature = new System.Windows.Forms.Label();
      this.leftPar = new System.Windows.Forms.Label();
      this.inputLayout = new System.Windows.Forms.TableLayoutPanel();
      this.inputPanel = new System.Windows.Forms.Panel();
      this.signatureButton = new System.Windows.Forms.Label();
      this.MainLayout.SuspendLayout();
      this.inputLayout.SuspendLayout();
      this.inputPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // CloseButton
      // 
      this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.CloseButton.AutoSize = true;
      this.CloseButton.ForeColor = System.Drawing.Color.White;
      this.CloseButton.Location = new System.Drawing.Point(143, 0);
      this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(25, 49);
      this.CloseButton.TabIndex = 0;
      this.CloseButton.Text = "X";
      this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
      // 
      // variable
      // 
      this.variable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(209)))));
      this.variable.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.variable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.variable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.variable.ForeColor = System.Drawing.Color.White;
      this.variable.Location = new System.Drawing.Point(3, 13);
      this.variable.Name = "variable";
      this.variable.Size = new System.Drawing.Size(39, 16);
      this.variable.TabIndex = 2;
      this.variable.Text = "*";
      this.variable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.variable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.variable_MouseClick);
      this.variable.TextChanged += new System.EventHandler(this.variable_TextChanged);
      // 
      // rightPar
      // 
      this.rightPar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rightPar.AutoSize = true;
      this.rightPar.ForeColor = System.Drawing.Color.White;
      this.rightPar.Location = new System.Drawing.Point(135, 0);
      this.rightPar.Margin = new System.Windows.Forms.Padding(0);
      this.rightPar.Name = "rightPar";
      this.rightPar.Size = new System.Drawing.Size(8, 49);
      this.rightPar.TabIndex = 3;
      this.rightPar.Text = ")";
      this.rightPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainLayout
      // 
      this.MainLayout.BackColor = System.Drawing.Color.Transparent;
      this.MainLayout.ColumnCount = 6;
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.MainLayout.Controls.Add(this.signatureButton, 0, 0);
      this.MainLayout.Controls.Add(this.signature, 1, 0);
      this.MainLayout.Controls.Add(this.CloseButton, 5, 0);
      this.MainLayout.Controls.Add(this.rightPar, 4, 0);
      this.MainLayout.Controls.Add(this.leftPar, 2, 0);
      this.MainLayout.Controls.Add(this.inputPanel, 3, 0);
      this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainLayout.Location = new System.Drawing.Point(0, 0);
      this.MainLayout.Margin = new System.Windows.Forms.Padding(0);
      this.MainLayout.Name = "MainLayout";
      this.MainLayout.RowCount = 1;
      this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.MainLayout.Size = new System.Drawing.Size(168, 49);
      this.MainLayout.TabIndex = 4;
      this.MainLayout.Click += new System.EventHandler(this.signature_Click);
      // 
      // signature
      // 
      this.signature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.signature.AutoSize = true;
      this.signature.ForeColor = System.Drawing.Color.White;
      this.signature.Location = new System.Drawing.Point(20, 0);
      this.signature.Margin = new System.Windows.Forms.Padding(0);
      this.signature.Name = "signature";
      this.signature.Size = new System.Drawing.Size(53, 49);
      this.signature.TabIndex = 5;
      this.signature.Text = hasVariable ? signatureText : signatureText + "()";
      this.signature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.signature.Click += new System.EventHandler(this.signature_Click);
      // 
      // leftPar
      // 
      this.leftPar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.leftPar.AutoSize = true;
      this.leftPar.ForeColor = System.Drawing.Color.White;
      this.leftPar.Location = new System.Drawing.Point(73, 0);
      this.leftPar.Margin = new System.Windows.Forms.Padding(0);
      this.leftPar.Name = "leftPar";
      this.leftPar.Size = new System.Drawing.Size(9, 49);
      this.leftPar.TabIndex = 4;
      this.leftPar.Text = "(";
      this.leftPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // inputLayout
      // 
      this.inputLayout.BackColor = System.Drawing.Color.Transparent;
      this.inputLayout.ColumnCount = 1;
      this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.inputLayout.Controls.Add(this.variable, 0, 1);
      this.inputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.inputLayout.Location = new System.Drawing.Point(0, 0);
      this.inputLayout.Margin = new System.Windows.Forms.Padding(0);
      this.inputLayout.Name = "inputLayout";
      this.inputLayout.RowCount = 3;
      this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.inputLayout.Size = new System.Drawing.Size(45, 41);
      this.inputLayout.TabIndex = 6;
      // 
      // inputPanel
      // 
      this.inputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(209)))));
      this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.inputPanel.Controls.Add(this.inputLayout);
      this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.inputPanel.Location = new System.Drawing.Point(85, 3);
      this.inputPanel.Name = "panel1";
      this.inputPanel.Size = new System.Drawing.Size(47, 43);
      this.inputPanel.TabIndex = 7;
      // 
      // signatureButton
      // 
      this.signatureButton.AutoSize = true;
      this.signatureButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.signatureButton.ForeColor = System.Drawing.Color.White;
      this.signatureButton.Location = new System.Drawing.Point(0, 0);
      this.signatureButton.Margin = new System.Windows.Forms.Padding(0);
      this.signatureButton.Name = "signatureButton";
      this.signatureButton.Size = new System.Drawing.Size(20, 49);
      this.signatureButton.TabIndex = 8;
      this.signatureButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.signature.Click += new System.EventHandler(this.signatureButton_Click);
      this.signatureButton.MouseDown += new MouseEventHandler(this.signatureButton_MouseDown);
      // 
      // DU_Filter
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
      this.Controls.Add(this.MainLayout);
      this.Name = "DU_Filter";
      this.Size = new System.Drawing.Size(168, 49);
      this.MainLayout.ResumeLayout(false);
      this.MainLayout.PerformLayout();
      this.inputLayout.ResumeLayout(false);
      this.inputLayout.PerformLayout();
      this.inputPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      if (this.CloseButtonClick != null)
        this.CloseButtonClick(this, e);
    }
    private void signatureButton_Click(object sender, EventArgs e)
    {
      if (this.signatureButtonClick != null)
        this.signatureButtonClick(this, e);
    }
    private void signatureButton_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.SignatureMouseDown != null)
        this.SignatureMouseDown(this, e);
    }
    private void variable_TextChanged(object sender, EventArgs e)
    {
      if (this.variableTextChanged != null)
        this.variableTextChanged(this, e);
    }
    private void variable_MouseClick(object sender, MouseEventArgs e)
    {

    }
    private void signature_Click(object sender, EventArgs e)
    {
      if (this.SignatureClick != null)
        this.SignatureClick(this, e);
    }
    protected override void OnMouseEnter(EventArgs e)
    {
      base.OnMouseEnter(e);
      //clr1 = color1;
      //clr2 = color2;
      //color1 = m_hovercolor1;
      //color2 = m_hovercolor2;
    }
    protected override void OnMouseLeave(EventArgs e)
    {
      base.OnMouseLeave(e);
      //color1 = clr1;
      //color2 = clr2;
      //SetBorderColor(borderColor);
    }
    protected override void OnMouseDown(MouseEventArgs mevent)
    {
      base.OnMouseDown(mevent);
      //color1 = clickcolor1;
      //color2 = clickcolor2;

      //int red = borderColor.R - 40;
      //int green = borderColor.G - 40;
      //int blue = borderColor.B - 40;
      //if (red < 0)
      //  red = 0;
      //if (green < 0)
      //  green = 0;
      //if (blue < 0)
      //  blue = 0;

      //buttonborder_2 = Color.FromArgb(red, green, blue);
      //buttonborder_1 = borderColor;
      this.Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs mevent)
    {
      base.OnMouseUp(mevent);
      OnMouseLeave(mevent);
      //color1 = clr1;
      //color2 = clr2;
      //SetBorderColor(borderColor);
      this.Invalidate();
    }
    protected override void OnLostFocus(EventArgs e)
    {
      base.OnLostFocus(e);
      //color1 = clr1;
      //color2 = clr2;
      this.Invalidate();
    }
    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);
      //textX = (int)((this.Width / 3) - 1);
      //textY = (int)((this.Height / 3) + 5);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      string rawSignatureText = signatureText.Trim(new Char[] { ' ', '(', ')' });
      this.signature.Text = hasVariable ? rawSignatureText : rawSignatureText + "()";
      leftPar.Visible = hasVariable;
      inputPanel.Visible = hasVariable;
      rightPar.Visible = hasVariable;

      this.MainLayout.ColumnStyles[2].Width = hasVariable ? 9F : 0;
      this.MainLayout.ColumnStyles[3].Width = hasVariable ? 50F : 0;
      this.MainLayout.ColumnStyles[4].Width = hasVariable ? 9F : 0;

      //Color c1 = Color.FromArgb(color1Transparent, color1);
      //Color c2 = Color.FromArgb(color2Transparent, color2);

      //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
      //Pen pen = new System.Drawing.Pen(b);
      //e.Graphics.FillRectangle(b, 0, 0, this.Width, this.Height);

      Brush br = new SolidBrush(Color.White);
      Point[] Points = {
        new Point(this.Height / 4,  this.Height / 2 - this.Height / 4),
        new Point(this.Height / 4, this.Height / 2 + this.Height / 4),
        new Point(this.Height / 2, this.Height / 2)
      };

      e.Graphics.FillPolygon(br, Points);


      for (int i = 0; i < 2; i++)
      {
        e.Graphics.DrawLine(new Pen(new SolidBrush(Color.White)), this.Width - i, 0, this.Width - i, this.Height);
        e.Graphics.DrawLine(new Pen(new SolidBrush(Color.White)), 0, this.Height - i, this.Width, this.Height - i);

        e.Graphics.DrawLine(new Pen(new SolidBrush(Color.White)), 0 + i, 0, 0 + i, this.Height);
        e.Graphics.DrawLine(new Pen(new SolidBrush(Color.White)), 0, 0 + i, this.Width, i);
      }

      //Point p = new Point(textX, textY);
      //SolidBrush frcolor = new SolidBrush(this.ForeColor);
      //e.Graphics.DrawString(text, this.Font, frcolor, p);

      //b.Dispose();
    }
  }
}
