namespace Slot
{
  partial class DU_Filter
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.CloseButton = new System.Windows.Forms.Label();
      this.variable = new System.Windows.Forms.TextBox();
      this.rightPar = new System.Windows.Forms.Label();
      this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
      this.signatureButton = new System.Windows.Forms.Label();
      this.signature = new System.Windows.Forms.Label();
      this.leftPar = new System.Windows.Forms.Label();
      this.inputPanel = new System.Windows.Forms.Panel();
      this.inputLayout = new System.Windows.Forms.TableLayoutPanel();
      this.MainLayout.SuspendLayout();
      this.inputPanel.SuspendLayout();
      this.inputLayout.SuspendLayout();
      this.SuspendLayout();
      // 
      // CloseButton
      // 
      this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.CloseButton.AutoSize = true;
      this.CloseButton.ForeColor = System.Drawing.Color.White;
      this.CloseButton.Location = new System.Drawing.Point(231, 10);
      this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(14, 13);
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
      this.variable.Location = new System.Drawing.Point(3, 5);
      this.variable.Name = "variable";
      this.variable.Size = new System.Drawing.Size(78, 16);
      this.variable.TabIndex = 2;
      this.variable.Text = "*";
      this.variable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.variable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.variable_MouseClick);
      this.variable.TextChanged += new System.EventHandler(this.variable_TextChanged);
      // 
      // rightPar
      // 
      this.rightPar.AutoSize = true;
      this.rightPar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rightPar.ForeColor = System.Drawing.Color.White;
      this.rightPar.Location = new System.Drawing.Point(213, 0);
      this.rightPar.Margin = new System.Windows.Forms.Padding(0);
      this.rightPar.Name = "rightPar";
      this.rightPar.Size = new System.Drawing.Size(8, 33);
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
      this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
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
      this.MainLayout.Size = new System.Drawing.Size(245, 33);
      this.MainLayout.TabIndex = 4;
      this.MainLayout.Click += new System.EventHandler(this.signature_Click);
      // 
      // signatureButton
      // 
      this.signatureButton.AutoSize = true;
      this.signatureButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this.signatureButton.ForeColor = System.Drawing.Color.White;
      this.signatureButton.Location = new System.Drawing.Point(0, 0);
      this.signatureButton.Margin = new System.Windows.Forms.Padding(0);
      this.signatureButton.Name = "signatureButton";
      this.signatureButton.Size = new System.Drawing.Size(20, 33);
      this.signatureButton.TabIndex = 8;
      this.signatureButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // signature
      // 
      this.signature.AutoSize = true;
      this.signature.Dock = System.Windows.Forms.DockStyle.Fill;
      this.signature.ForeColor = System.Drawing.Color.White;
      this.signature.Location = new System.Drawing.Point(20, 0);
      this.signature.Margin = new System.Windows.Forms.Padding(0);
      this.signature.Name = "signature";
      this.signature.Size = new System.Drawing.Size(92, 33);
      this.signature.TabIndex = 5;
      this.signature.Text = "action";
      this.signature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.signature.Click += new System.EventHandler(this.signature_Click);
      // 
      // leftPar
      // 
      this.leftPar.AutoSize = true;
      this.leftPar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.leftPar.ForeColor = System.Drawing.Color.White;
      this.leftPar.Location = new System.Drawing.Point(112, 0);
      this.leftPar.Margin = new System.Windows.Forms.Padding(0);
      this.leftPar.Name = "leftPar";
      this.leftPar.Size = new System.Drawing.Size(9, 33);
      this.leftPar.TabIndex = 4;
      this.leftPar.Text = "(";
      this.leftPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // inputPanel
      // 
      this.inputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(131)))), ((int)(((byte)(209)))));
      this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.inputPanel.Controls.Add(this.inputLayout);
      this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.inputPanel.Location = new System.Drawing.Point(124, 3);
      this.inputPanel.Name = "inputPanel";
      this.inputPanel.Size = new System.Drawing.Size(86, 27);
      this.inputPanel.TabIndex = 7;
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
      this.inputLayout.Size = new System.Drawing.Size(84, 25);
      this.inputLayout.TabIndex = 6;
      // 
      // DU_Filter
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
      this.Controls.Add(this.MainLayout);
      this.Name = "DU_Filter";
      this.Size = new System.Drawing.Size(245, 33);
      this.MainLayout.ResumeLayout(false);
      this.MainLayout.PerformLayout();
      this.inputPanel.ResumeLayout(false);
      this.inputLayout.ResumeLayout(false);
      this.inputLayout.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label CloseButton;
    private System.Windows.Forms.TextBox variable;
    private System.Windows.Forms.Label rightPar;
    private System.Windows.Forms.TableLayoutPanel MainLayout;
    private System.Windows.Forms.Label signature;
    private System.Windows.Forms.Label leftPar;
    private System.Windows.Forms.TableLayoutPanel inputLayout;
    private System.Windows.Forms.Panel inputPanel;
    private System.Windows.Forms.Label signatureButton;
  }
}
