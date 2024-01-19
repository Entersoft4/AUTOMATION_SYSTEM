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
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            btnarasck = new Button();
            btnmkrn = new Button();
            btncorba = new Button();
            btnfastfood = new Button();
            btnyanurun = new Button();
            btntatlı = new Button();
            btniçecek = new Button();
            btnanaymk = new Button();
            panel4 = new Panel();
            lviewstok = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
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
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.15226F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 58.8477364F));
            tableLayoutPanel2.Size = new Size(628, 415);
            tableLayoutPanel2.TabIndex = 2;
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
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 415);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnarasck);
            groupBox1.Controls.Add(btnmkrn);
            groupBox1.Controls.Add(btncorba);
            groupBox1.Controls.Add(btnfastfood);
            groupBox1.Controls.Add(btnyanurun);
            groupBox1.Controls.Add(btntatlı);
            groupBox1.Controls.Add(btniçecek);
            groupBox1.Controls.Add(btnanaymk);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 415);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "KATEGORİLER";
            // 
            // btnarasck
            // 
            btnarasck.Cursor = Cursors.Hand;
            btnarasck.Dock = DockStyle.Top;
            btnarasck.FlatAppearance.BorderColor = Color.Black;
            btnarasck.FlatStyle = FlatStyle.Flat;
            btnarasck.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnarasck.Location = new Point(3, 361);
            btnarasck.Name = "btnarasck";
            btnarasck.Size = new Size(194, 47);
            btnarasck.TabIndex = 7;
            btnarasck.Text = "ARA SICAK";
            btnarasck.UseVisualStyleBackColor = true;
            // 
            // btnmkrn
            // 
            btnmkrn.Cursor = Cursors.Hand;
            btnmkrn.Dock = DockStyle.Top;
            btnmkrn.FlatAppearance.BorderColor = Color.Black;
            btnmkrn.FlatStyle = FlatStyle.Flat;
            btnmkrn.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnmkrn.Location = new Point(3, 314);
            btnmkrn.Name = "btnmkrn";
            btnmkrn.Size = new Size(194, 47);
            btnmkrn.TabIndex = 6;
            btnmkrn.Text = "MAKARNA";
            btnmkrn.UseVisualStyleBackColor = true;
            // 
            // btncorba
            // 
            btncorba.Cursor = Cursors.Hand;
            btncorba.Dock = DockStyle.Top;
            btncorba.FlatAppearance.BorderColor = Color.Black;
            btncorba.FlatStyle = FlatStyle.Flat;
            btncorba.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btncorba.Location = new Point(3, 267);
            btncorba.Name = "btncorba";
            btncorba.Size = new Size(194, 47);
            btncorba.TabIndex = 5;
            btncorba.Text = "ÇORBALAR";
            btncorba.UseVisualStyleBackColor = true;
            // 
            // btnfastfood
            // 
            btnfastfood.Cursor = Cursors.Hand;
            btnfastfood.Dock = DockStyle.Top;
            btnfastfood.FlatAppearance.BorderColor = Color.Black;
            btnfastfood.FlatStyle = FlatStyle.Flat;
            btnfastfood.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnfastfood.Location = new Point(3, 220);
            btnfastfood.Name = "btnfastfood";
            btnfastfood.Size = new Size(194, 47);
            btnfastfood.TabIndex = 4;
            btnfastfood.Text = "FAST FOOD";
            btnfastfood.UseVisualStyleBackColor = true;
            // 
            // btnyanurun
            // 
            btnyanurun.Cursor = Cursors.Hand;
            btnyanurun.Dock = DockStyle.Top;
            btnyanurun.FlatAppearance.BorderColor = Color.Black;
            btnyanurun.FlatStyle = FlatStyle.Flat;
            btnyanurun.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnyanurun.Location = new Point(3, 173);
            btnyanurun.Name = "btnyanurun";
            btnyanurun.Size = new Size(194, 47);
            btnyanurun.TabIndex = 3;
            btnyanurun.Text = "YAN ÜRÜNLER";
            btnyanurun.UseVisualStyleBackColor = true;
            // 
            // btntatlı
            // 
            btntatlı.Cursor = Cursors.Hand;
            btntatlı.Dock = DockStyle.Top;
            btntatlı.FlatAppearance.BorderColor = Color.Black;
            btntatlı.FlatStyle = FlatStyle.Flat;
            btntatlı.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btntatlı.Location = new Point(3, 126);
            btntatlı.Name = "btntatlı";
            btntatlı.Size = new Size(194, 47);
            btntatlı.TabIndex = 2;
            btntatlı.Text = "TATLILAR";
            btntatlı.UseVisualStyleBackColor = true;
            // 
            // btniçecek
            // 
            btniçecek.Cursor = Cursors.Hand;
            btniçecek.Dock = DockStyle.Top;
            btniçecek.FlatAppearance.BorderColor = Color.Black;
            btniçecek.FlatStyle = FlatStyle.Flat;
            btniçecek.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btniçecek.Location = new Point(3, 79);
            btniçecek.Name = "btniçecek";
            btniçecek.Size = new Size(194, 47);
            btniçecek.TabIndex = 1;
            btniçecek.Text = "İÇECEKLER";
            btniçecek.UseVisualStyleBackColor = true;
            // 
            // btnanaymk
            // 
            btnanaymk.Cursor = Cursors.Hand;
            btnanaymk.Dock = DockStyle.Top;
            btnanaymk.FlatAppearance.BorderColor = Color.Black;
            btnanaymk.FlatStyle = FlatStyle.Flat;
            btnanaymk.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnanaymk.Location = new Point(3, 32);
            btnanaymk.Name = "btnanaymk";
            btnanaymk.Size = new Size(194, 47);
            btnanaymk.TabIndex = 0;
            btnanaymk.Text = "ANA YEMEK";
            btnanaymk.UseVisualStyleBackColor = true;
            btnanaymk.Click += btnanaymk_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lviewstok);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(110, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 239);
            panel4.TabIndex = 2;
            // 
            // lviewstok
            // 
            lviewstok.BackColor = Color.Gainsboro;
            lviewstok.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lviewstok.Dock = DockStyle.Fill;
            lviewstok.FullRowSelect = true;
            lviewstok.GridLines = true;
            lviewstok.Location = new Point(0, 0);
            lviewstok.Name = "lviewstok";
            lviewstok.Size = new Size(406, 239);
            lviewstok.TabIndex = 1;
            lviewstok.UseCompatibleStateImageBehavior = false;
            lviewstok.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Miktarı ";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ürün Birimi";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün Fiyatı";
            columnHeader4.Width = 75;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnarasck;
        private Button btnmkrn;
        private Button btncorba;
        private Button btnfastfood;
        private Button btnyanurun;
        private Button btntatlı;
        private Button btniçecek;
        private Button btnanaymk;
        private Panel panel4;
        private ListView lviewstok;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}