namespace OTOMASYON_SISTEMI.Forms
{
    partial class stokform
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
            rprveritablo = new DataGridView();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            cat_btn5 = new Button();
            cat_btn4 = new Button();
            cat_btn3 = new Button();
            cat_btn2 = new Button();
            cat_btn1 = new Button();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rprveritablo).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.58522F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.41478F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(840, 421);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(209, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 415);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1536674F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.6926651F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1536674F));
            tableLayoutPanel2.Controls.Add(rprveritablo, 1, 1);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.15226F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 58.8477364F));
            tableLayoutPanel2.Size = new Size(628, 415);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // rprveritablo
            // 
            rprveritablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rprveritablo.Dock = DockStyle.Fill;
            rprveritablo.Location = new Point(110, 173);
            rprveritablo.Name = "rprveritablo";
            rprveritablo.Size = new Size(406, 239);
            rprveritablo.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(110, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 164);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(109, 71);
            label2.Name = "label2";
            label2.Size = new Size(179, 37);
            label2.TabIndex = 1;
            label2.Text = "Stok Durumu";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(122, 34);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 0;
            label3.Text = "FastenPOS";
            // 
            // panel2
            // 
            panel2.Controls.Add(cat_btn5);
            panel2.Controls.Add(cat_btn4);
            panel2.Controls.Add(cat_btn3);
            panel2.Controls.Add(cat_btn2);
            panel2.Controls.Add(cat_btn1);
            panel2.Controls.Add(vScrollBar1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 415);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // cat_btn5
            // 
            cat_btn5.Dock = DockStyle.Top;
            cat_btn5.Location = new Point(0, 237);
            cat_btn5.Name = "cat_btn5";
            cat_btn5.Size = new Size(190, 50);
            cat_btn5.TabIndex = 7;
            cat_btn5.Text = "YAN ÜRÜNLER";
            cat_btn5.UseVisualStyleBackColor = true;
            // 
            // cat_btn4
            // 
            cat_btn4.Dock = DockStyle.Top;
            cat_btn4.Location = new Point(0, 187);
            cat_btn4.Name = "cat_btn4";
            cat_btn4.Size = new Size(190, 50);
            cat_btn4.TabIndex = 6;
            cat_btn4.Text = "TATLILAR";
            cat_btn4.UseVisualStyleBackColor = true;
            // 
            // cat_btn3
            // 
            cat_btn3.Dock = DockStyle.Top;
            cat_btn3.Location = new Point(0, 137);
            cat_btn3.Name = "cat_btn3";
            cat_btn3.Size = new Size(190, 50);
            cat_btn3.TabIndex = 5;
            cat_btn3.Text = "LAHMACUN";
            cat_btn3.UseVisualStyleBackColor = true;
            // 
            // cat_btn2
            // 
            cat_btn2.Dock = DockStyle.Top;
            cat_btn2.Location = new Point(0, 87);
            cat_btn2.Name = "cat_btn2";
            cat_btn2.Size = new Size(190, 50);
            cat_btn2.TabIndex = 4;
            cat_btn2.Text = "ÇORBALAR";
            cat_btn2.UseVisualStyleBackColor = true;
            // 
            // cat_btn1
            // 
            cat_btn1.Dock = DockStyle.Top;
            cat_btn1.Location = new Point(0, 37);
            cat_btn1.Name = "cat_btn1";
            cat_btn1.Size = new Size(190, 50);
            cat_btn1.TabIndex = 3;
            cat_btn1.Text = "İÇECEKLER";
            cat_btn1.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(190, 37);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(10, 378);
            vScrollBar1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 1;
            label1.Text = "KATEGORİLER";
            // 
            // stokform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 421);
            Controls.Add(tableLayoutPanel1);
            Name = "stokform";
            Text = "stokform";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rprveritablo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private VScrollBar vScrollBar1;
        private Button cat_btn5;
        private Button cat_btn4;
        private Button cat_btn3;
        private Button cat_btn2;
        private Button cat_btn1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView rprveritablo;
        private Panel panel3;
        private Label label2;
        private Label label3;
    }
}