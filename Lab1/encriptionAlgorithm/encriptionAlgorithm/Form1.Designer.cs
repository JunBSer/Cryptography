namespace encriptionAlgorithm;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        pnlMain = new System.Windows.Forms.Panel();
        btnLoad = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        btnDecipher = new System.Windows.Forms.Button();
        btnEncript = new System.Windows.Forms.Button();
        lblMethods = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        rbVigenere = new System.Windows.Forms.RadioButton();
        rbDecimation = new System.Windows.Forms.RadioButton();
        pnlUp = new System.Windows.Forms.Panel();
        tbxKey = new System.Windows.Forms.TextBox();
        tbxText = new System.Windows.Forms.TextBox();
        pnlBottom = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        tbxResult = new System.Windows.Forms.TextBox();
        odMain = new System.Windows.Forms.OpenFileDialog();
        sdMain = new System.Windows.Forms.SaveFileDialog();
        pnlMain.SuspendLayout();
        groupBox1.SuspendLayout();
        pnlUp.SuspendLayout();
        pnlBottom.SuspendLayout();
        SuspendLayout();
        // 
        // pnlMain
        // 
        pnlMain.BackColor = System.Drawing.SystemColors.Info;
        pnlMain.Controls.Add(btnLoad);
        pnlMain.Controls.Add(btnSave);
        pnlMain.Controls.Add(btnDecipher);
        pnlMain.Controls.Add(btnEncript);
        pnlMain.Controls.Add(lblMethods);
        pnlMain.Controls.Add(groupBox1);
        pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
        pnlMain.Location = new System.Drawing.Point(0, 0);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new System.Drawing.Size(354, 632);
        pnlMain.TabIndex = 0;
        // 
        // btnLoad
        // 
        btnLoad.Location = new System.Drawing.Point(93, 489);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new System.Drawing.Size(145, 33);
        btnLoad.TabIndex = 5;
        btnLoad.Text = "Load from file";
        btnLoad.UseVisualStyleBackColor = true;
        btnLoad.Click += btnLoad_Click;
        // 
        // btnSave
        // 
        btnSave.Location = new System.Drawing.Point(93, 415);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(145, 34);
        btnSave.TabIndex = 4;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += button1_Click;
        // 
        // btnDecipher
        // 
        btnDecipher.Location = new System.Drawing.Point(93, 340);
        btnDecipher.Name = "btnDecipher";
        btnDecipher.Size = new System.Drawing.Size(145, 35);
        btnDecipher.TabIndex = 3;
        btnDecipher.Text = "Decipher";
        btnDecipher.UseVisualStyleBackColor = true;
        btnDecipher.Click += btnDecipher_Click;
        // 
        // btnEncript
        // 
        btnEncript.Location = new System.Drawing.Point(93, 260);
        btnEncript.Name = "btnEncript";
        btnEncript.Size = new System.Drawing.Size(145, 36);
        btnEncript.TabIndex = 2;
        btnEncript.Text = "Encript";
        btnEncript.UseVisualStyleBackColor = true;
        btnEncript.Click += btnEncript_Click;
        // 
        // lblMethods
        // 
        lblMethods.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblMethods.Location = new System.Drawing.Point(45, 54);
        lblMethods.Name = "lblMethods";
        lblMethods.Size = new System.Drawing.Size(212, 28);
        lblMethods.TabIndex = 1;
        lblMethods.Text = "Choose Method";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rbVigenere);
        groupBox1.Controls.Add(rbDecimation);
        groupBox1.Location = new System.Drawing.Point(45, 85);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(220, 117);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Methods";
        // 
        // rbVigenere
        // 
        rbVigenere.Location = new System.Drawing.Point(6, 75);
        rbVigenere.Name = "rbVigenere";
        rbVigenere.Size = new System.Drawing.Size(104, 24);
        rbVigenere.TabIndex = 1;
        rbVigenere.TabStop = true;
        rbVigenere.Text = "Vigenere";
        rbVigenere.UseVisualStyleBackColor = true;
        rbVigenere.CheckedChanged += rbVigenere_CheckedChanged;
        // 
        // rbDecimation
        // 
        rbDecimation.Location = new System.Drawing.Point(6, 26);
        rbDecimation.Name = "rbDecimation";
        rbDecimation.Size = new System.Drawing.Size(112, 24);
        rbDecimation.TabIndex = 0;
        rbDecimation.TabStop = true;
        rbDecimation.Text = "Decimation";
        rbDecimation.UseVisualStyleBackColor = true;
        rbDecimation.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // pnlUp
        // 
        pnlUp.BackColor = System.Drawing.SystemColors.GrayText;
        pnlUp.Controls.Add(tbxKey);
        pnlUp.Controls.Add(tbxText);
        pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
        pnlUp.Location = new System.Drawing.Point(354, 0);
        pnlUp.Name = "pnlUp";
        pnlUp.Size = new System.Drawing.Size(645, 227);
        pnlUp.TabIndex = 1;
        // 
        // tbxKey
        // 
        tbxKey.Dock = System.Windows.Forms.DockStyle.Right;
        tbxKey.Location = new System.Drawing.Point(359, 0);
        tbxKey.Multiline = true;
        tbxKey.Name = "tbxKey";
        tbxKey.PlaceholderText = "Input key";
        tbxKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tbxKey.Size = new System.Drawing.Size(286, 227);
        tbxKey.TabIndex = 1;
        // 
        // tbxText
        // 
        tbxText.Dock = System.Windows.Forms.DockStyle.Left;
        tbxText.Location = new System.Drawing.Point(0, 0);
        tbxText.Multiline = true;
        tbxText.Name = "tbxText";
        tbxText.PlaceholderText = "Input planetext";
        tbxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tbxText.Size = new System.Drawing.Size(297, 227);
        tbxText.TabIndex = 0;
        // 
        // pnlBottom
        // 
        pnlBottom.BackColor = System.Drawing.SystemColors.ActiveBorder;
        pnlBottom.Controls.Add(label1);
        pnlBottom.Controls.Add(tbxResult);
        pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlBottom.Location = new System.Drawing.Point(354, 224);
        pnlBottom.Name = "pnlBottom";
        pnlBottom.Size = new System.Drawing.Size(645, 408);
        pnlBottom.TabIndex = 2;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 19.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.HotTrack;
        label1.Location = new System.Drawing.Point(172, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(306, 46);
        label1.TabIndex = 1;
        label1.Text = "Result";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tbxResult
        // 
        tbxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
        tbxResult.Location = new System.Drawing.Point(0, 100);
        tbxResult.Multiline = true;
        tbxResult.Name = "tbxResult";
        tbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        tbxResult.Size = new System.Drawing.Size(645, 308);
        tbxResult.TabIndex = 0;
        // 
        // odMain
        // 
        odMain.Filter = "Text files (*.txt)|*.txt";
        // 
        // sdMain
        // 
        sdMain.Filter = "Text files (*.txt)|*.txt";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        ClientSize = new System.Drawing.Size(999, 632);
        Controls.Add(pnlBottom);
        Controls.Add(pnlUp);
        Controls.Add(pnlMain);
        Text = "Encriptor";
        pnlMain.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        pnlUp.ResumeLayout(false);
        pnlUp.PerformLayout();
        pnlBottom.ResumeLayout(false);
        pnlBottom.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnLoad;

    private System.Windows.Forms.OpenFileDialog odMain;
    private System.Windows.Forms.SaveFileDialog sdMain;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox tbxResult;

    private System.Windows.Forms.TextBox tbxKey;

    private System.Windows.Forms.TextBox tbxText;

    private System.Windows.Forms.Panel pnlBottom;

    private System.Windows.Forms.Panel pnlUp;

    private System.Windows.Forms.Button btnEncript;
    private System.Windows.Forms.Button btnDecipher;

    private System.Windows.Forms.RadioButton rbDecimation;
    private System.Windows.Forms.RadioButton rbVigenere;

    private System.Windows.Forms.Label lblMethods;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Panel pnlMain;

    #endregion
}