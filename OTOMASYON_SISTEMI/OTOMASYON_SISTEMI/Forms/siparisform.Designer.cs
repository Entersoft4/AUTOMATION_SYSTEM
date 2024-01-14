namespace OTOMASYON_SISTEMI.Forms
{
    partial class siparisform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            label2 = new Label();
            button2 = new Button();
            panel5 = new Panel();
            label3 = new Label();
            button3 = new Button();
            panel6 = new Panel();
            label4 = new Label();
            button4 = new Button();
            siparistbl = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)siparistbl).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.5774651F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.42254F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(siparistbl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(839, 422);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 416);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 0, 2);
            tableLayoutPanel2.Controls.Add(panel6, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(242, 416);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 98);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(75, 33);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "HAZIRLANIYOR";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(100, 5);
            button1.Name = "button1";
            button1.Size = new Size(35, 25);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 98);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(75, 33);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "TESLİM EDİLDİ";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Cyan;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(100, 5);
            button2.Name = "button2";
            button2.Size = new Size(35, 25);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 211);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 98);
            panel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(75, 33);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 1;
            label3.Text = "ÖDEME ALINDI";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.Lime;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(100, 5);
            button3.Name = "button3";
            button3.Size = new Size(35, 25);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(button4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 315);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 98);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(80, 33);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 1;
            label4.Text = "İPTAL EDİLDİ";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(100, 5);
            button4.Name = "button4";
            button4.Size = new Size(35, 25);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = false;
            // 
            // siparistbl
            // 
            siparistbl.BackgroundColor = Color.Gainsboro;
            siparistbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            siparistbl.Dock = DockStyle.Fill;
            siparistbl.Location = new Point(251, 3);
            siparistbl.Name = "siparistbl";
            siparistbl.Size = new Size(585, 416);
            siparistbl.TabIndex = 1;
            // 
            // siparisform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 422);
            Controls.Add(tableLayoutPanel1);
            Name = "siparisform";
            Text = "siparisform";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)siparistbl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private Panel panel4;
        private Label label2;
        private Button button2;
        private Panel panel5;
        private Label label3;
        private Button button3;
        private Panel panel6;
        private Label label4;
        private Button button4;
        private DataGridView siparistbl;
    }
}