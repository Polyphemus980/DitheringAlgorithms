namespace Dithering
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            originalImagePanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            refreshButton = new Button();
            popularityRadioButton = new RadioButton();
            orderedRelativeRadioButton = new RadioButton();
            orderedRandomRadioButton = new RadioButton();
            errDiffusionRadioButton = new RadioButton();
            averageRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            KgNumeric = new NumericUpDown();
            KbNumeric = new NumericUpDown();
            kRNumeric = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            KNumeric = new NumericUpDown();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            alteredImagePanel = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KgNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KbNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kRNumeric).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KNumeric).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(947, 506);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(originalImagePanel, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(280, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(328, 498);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(322, 50);
            label5.TabIndex = 0;
            label5.Text = "Original image";
            // 
            // originalImagePanel
            // 
            originalImagePanel.BackColor = SystemColors.Control;
            originalImagePanel.Dock = DockStyle.Fill;
            originalImagePanel.Location = new Point(3, 53);
            originalImagePanel.Name = "originalImagePanel";
            originalImagePanel.Size = new Size(322, 442);
            originalImagePanel.TabIndex = 1;
            originalImagePanel.Paint += originalImagePanel_Paint;
            originalImagePanel.Resize += originalImagePanel_Resize;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 230F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(269, 498);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(refreshButton);
            groupBox1.Controls.Add(popularityRadioButton);
            groupBox1.Controls.Add(orderedRelativeRadioButton);
            groupBox1.Controls.Add(orderedRandomRadioButton);
            groupBox1.Controls.Add(errDiffusionRadioButton);
            groupBox1.Controls.Add(averageRadioButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 224);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Algorithms";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(161, 190);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(94, 29);
            refreshButton.TabIndex = 5;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // popularityRadioButton
            // 
            popularityRadioButton.AutoSize = true;
            popularityRadioButton.Location = new Point(7, 144);
            popularityRadioButton.Name = "popularityRadioButton";
            popularityRadioButton.Size = new Size(167, 24);
            popularityRadioButton.TabIndex = 4;
            popularityRadioButton.TabStop = true;
            popularityRadioButton.Text = "popularity algorithm";
            popularityRadioButton.UseVisualStyleBackColor = true;
            popularityRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // orderedRelativeRadioButton
            // 
            orderedRelativeRadioButton.AutoSize = true;
            orderedRelativeRadioButton.Location = new Point(7, 114);
            orderedRelativeRadioButton.Name = "orderedRelativeRadioButton";
            orderedRelativeRadioButton.Size = new Size(200, 24);
            orderedRelativeRadioButton.TabIndex = 3;
            orderedRelativeRadioButton.TabStop = true;
            orderedRelativeRadioButton.Text = "ordered dithering relative";
            orderedRelativeRadioButton.UseVisualStyleBackColor = true;
            orderedRelativeRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // orderedRandomRadioButton
            // 
            orderedRandomRadioButton.AutoSize = true;
            orderedRandomRadioButton.Location = new Point(7, 84);
            orderedRandomRadioButton.Name = "orderedRandomRadioButton";
            orderedRandomRadioButton.Size = new Size(203, 24);
            orderedRandomRadioButton.TabIndex = 2;
            orderedRandomRadioButton.TabStop = true;
            orderedRandomRadioButton.Text = "ordered dithering random";
            orderedRandomRadioButton.UseVisualStyleBackColor = true;
            orderedRandomRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // errDiffusionRadioButton
            // 
            errDiffusionRadioButton.AutoSize = true;
            errDiffusionRadioButton.Location = new Point(7, 54);
            errDiffusionRadioButton.Name = "errDiffusionRadioButton";
            errDiffusionRadioButton.Size = new Size(188, 24);
            errDiffusionRadioButton.TabIndex = 1;
            errDiffusionRadioButton.TabStop = true;
            errDiffusionRadioButton.Text = "error diffusion dithering";
            errDiffusionRadioButton.UseVisualStyleBackColor = true;
            errDiffusionRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // averageRadioButton
            // 
            averageRadioButton.AutoSize = true;
            averageRadioButton.Location = new Point(7, 26);
            averageRadioButton.Name = "averageRadioButton";
            averageRadioButton.Size = new Size(147, 24);
            averageRadioButton.TabIndex = 0;
            averageRadioButton.TabStop = true;
            averageRadioButton.Text = "average dithering";
            averageRadioButton.UseVisualStyleBackColor = true;
            averageRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(KgNumeric);
            groupBox2.Controls.Add(KbNumeric);
            groupBox2.Controls.Add(kRNumeric);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 144);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Params for dithering";
            // 
            // KgNumeric
            // 
            KgNumeric.Location = new Point(66, 102);
            KgNumeric.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            KgNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            KgNumeric.Name = "KgNumeric";
            KgNumeric.Size = new Size(150, 27);
            KgNumeric.TabIndex = 0;
            KgNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            KgNumeric.ValueChanged += kRNumeric_ValueChanged;
            // 
            // KbNumeric
            // 
            KbNumeric.Location = new Point(66, 68);
            KbNumeric.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            KbNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            KbNumeric.Name = "KbNumeric";
            KbNumeric.Size = new Size(150, 27);
            KbNumeric.TabIndex = 2;
            KbNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            KbNumeric.ValueChanged += kRNumeric_ValueChanged;
            // 
            // kRNumeric
            // 
            kRNumeric.Location = new Point(67, 35);
            kRNumeric.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            kRNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            kRNumeric.Name = "kRNumeric";
            kRNumeric.Size = new Size(150, 27);
            kRNumeric.TabIndex = 1;
            kRNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            kRNumeric.ValueChanged += kRNumeric_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 102);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 6;
            label3.Text = "Kg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 5;
            label2.Text = "Kb";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 4;
            label1.Text = "Kr";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(KNumeric);
            groupBox3.Controls.Add(label4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 383);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 112);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Params for popularity";
            // 
            // KNumeric
            // 
            KNumeric.Location = new Point(61, 26);
            KNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            KNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            KNumeric.Name = "KNumeric";
            KNumeric.Size = new Size(150, 27);
            KNumeric.TabIndex = 3;
            KNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            KNumeric.ValueChanged += kRNumeric_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 26);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 7;
            label4.Text = "K";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(alteredImagePanel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(615, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(328, 498);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(322, 50);
            label6.TabIndex = 0;
            label6.Text = "Image after processing";
            // 
            // alteredImagePanel
            // 
            alteredImagePanel.Dock = DockStyle.Fill;
            alteredImagePanel.Location = new Point(3, 53);
            alteredImagePanel.Name = "alteredImagePanel";
            alteredImagePanel.Size = new Size(322, 442);
            alteredImagePanel.TabIndex = 1;
            alteredImagePanel.Paint += alteredImagePanel_Paint;
            alteredImagePanel.Resize += originalImagePanel_Resize;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(947, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(150, 26);
            loadFileToolStripMenuItem.Text = "Load file";
            loadFileToolStripMenuItem.Click += loadFileToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 534);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Dithering algorithms";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KgNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)KbNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)kRNumeric).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KNumeric).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button refreshButton;
        private RadioButton popularityRadioButton;
        private RadioButton orderedRelativeRadioButton;
        private RadioButton orderedRandomRadioButton;
        private RadioButton errDiffusionRadioButton;
        private RadioButton averageRadioButton;
        private NumericUpDown KgNumeric;
        private NumericUpDown KbNumeric;
        private NumericUpDown kRNumeric;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown KNumeric;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Panel originalImagePanel;
        private Panel alteredImagePanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
    }
}
