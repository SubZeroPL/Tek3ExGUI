namespace Tek3ExGUI;

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
        ofdBns = new System.Windows.Forms.OpenFileDialog();
        ofdExe = new System.Windows.Forms.OpenFileDialog();
        fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
        panel1 = new System.Windows.Forms.Panel();
        btnStart = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        tabControl1 = new System.Windows.Forms.TabControl();
        tabUnpack = new System.Windows.Forms.TabPage();
        button3 = new System.Windows.Forms.Button();
        textOutput = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        tabPack = new System.Windows.Forms.TabPage();
        button4 = new System.Windows.Forms.Button();
        textInput = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        fbdInput = new System.Windows.Forms.FolderBrowserDialog();
        panel3 = new System.Windows.Forms.Panel();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        textExe = new System.Windows.Forms.TextBox();
        textBns = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        tabControl1.SuspendLayout();
        tabUnpack.SuspendLayout();
        tabPack.SuspendLayout();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // ofdBns
        // 
        ofdBns.DefaultExt = "bns";
        ofdBns.Filter = "BinStream|*.bns|All files|*.*";
        ofdBns.SupportMultiDottedExtensions = true;
        ofdBns.Title = "Choose .bns file";
        // 
        // ofdExe
        // 
        ofdExe.Filter = "PS Exe|SL?S_*.??;SC?S_*.??;SLPM_*.??;PSX.EXE|All files (*.*)|*.*";
        ofdExe.SupportMultiDottedExtensions = true;
        ofdExe.Title = "Choose executable";
        // 
        // fbdOutput
        // 
        fbdOutput.Description = "Choose output folder";
        // 
        // panel1
        // 
        panel1.Controls.Add(btnStart);
        panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        panel1.Location = new System.Drawing.Point(0, 126);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(606, 28);
        panel1.TabIndex = 2;
        // 
        // btnStart
        // 
        btnStart.Location = new System.Drawing.Point(271, 0);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(75, 23);
        btnStart.TabIndex = 0;
        btnStart.Text = "&Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(tabControl1);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(606, 62);
        panel2.TabIndex = 3;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabUnpack);
        tabControl1.Controls.Add(tabPack);
        tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl1.Location = new System.Drawing.Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(606, 62);
        tabControl1.TabIndex = 1;
        // 
        // tabUnpack
        // 
        tabUnpack.Controls.Add(button3);
        tabUnpack.Controls.Add(textOutput);
        tabUnpack.Controls.Add(label3);
        tabUnpack.Location = new System.Drawing.Point(4, 24);
        tabUnpack.Name = "tabUnpack";
        tabUnpack.Padding = new System.Windows.Forms.Padding(3);
        tabUnpack.Size = new System.Drawing.Size(598, 34);
        tabUnpack.TabIndex = 0;
        tabUnpack.Text = "Unpack";
        tabUnpack.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button3.Location = new System.Drawing.Point(518, 6);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 23);
        button3.TabIndex = 8;
        button3.Text = "Browse";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // textOutput
        // 
        textOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textOutput.Location = new System.Drawing.Point(159, 6);
        textOutput.Name = "textOutput";
        textOutput.Size = new System.Drawing.Size(352, 23);
        textOutput.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(7, 9);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(144, 23);
        label3.TabIndex = 2;
        label3.Text = "Output folder:";
        // 
        // tabPack
        // 
        tabPack.Controls.Add(button4);
        tabPack.Controls.Add(textInput);
        tabPack.Controls.Add(label4);
        tabPack.Location = new System.Drawing.Point(4, 24);
        tabPack.Name = "tabPack";
        tabPack.Padding = new System.Windows.Forms.Padding(3);
        tabPack.Size = new System.Drawing.Size(598, 34);
        tabPack.TabIndex = 1;
        tabPack.Text = "Pack";
        tabPack.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button4.Location = new System.Drawing.Point(518, 6);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(75, 23);
        button4.TabIndex = 20;
        button4.Text = "Browse";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // textInput
        // 
        textInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textInput.Location = new System.Drawing.Point(160, 6);
        textInput.Name = "textInput";
        textInput.Size = new System.Drawing.Size(352, 23);
        textInput.TabIndex = 19;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 9);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(144, 23);
        label4.TabIndex = 18;
        label4.Text = "Input folder:";
        // 
        // fbdInput
        // 
        fbdInput.Description = "Choose input folder";
        // 
        // panel3
        // 
        panel3.Controls.Add(button2);
        panel3.Controls.Add(button1);
        panel3.Controls.Add(textExe);
        panel3.Controls.Add(textBns);
        panel3.Controls.Add(label2);
        panel3.Controls.Add(label1);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.Location = new System.Drawing.Point(0, 62);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(606, 65);
        panel3.TabIndex = 4;
        // 
        // button2
        // 
        button2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button2.Location = new System.Drawing.Point(522, 35);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 13;
        button2.Text = "Browse";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        button1.Location = new System.Drawing.Point(522, 6);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 12;
        button1.Text = "Browse";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textExe
        // 
        textExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textExe.Location = new System.Drawing.Point(164, 35);
        textExe.Name = "textExe";
        textExe.Size = new System.Drawing.Size(352, 23);
        textExe.TabIndex = 11;
        // 
        // textBns
        // 
        textBns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBns.Location = new System.Drawing.Point(164, 6);
        textBns.Name = "textBns";
        textBns.Size = new System.Drawing.Size(352, 23);
        textBns.TabIndex = 10;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(10, 38);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(144, 23);
        label2.TabIndex = 9;
        label2.Text = "PSX Executable path:";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(10, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(146, 23);
        label1.TabIndex = 8;
        label1.Text = "BinStream (.bns) file path:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(606, 154);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        MaximizeBox = false;
        MinimizeBox = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        Text = "Tek3ExGUI";
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        tabControl1.ResumeLayout(false);
        tabUnpack.ResumeLayout(false);
        tabUnpack.PerformLayout();
        tabPack.ResumeLayout(false);
        tabPack.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.FolderBrowserDialog fbdInput;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabUnpack;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textOutput;
    private System.Windows.Forms.TextBox textExe;
    private System.Windows.Forms.TextBox textBns;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPack;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox textInput;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Button btnStart;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.FolderBrowserDialog fbdOutput;

    private System.Windows.Forms.OpenFileDialog ofdBns;
    private System.Windows.Forms.OpenFileDialog ofdExe;

    #endregion
}