namespace OTOMASYON_SISTEMI.Forms
{
    partial class raporform
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
            urunbtn = new Button();
            calisanbtn = new Button();
            rezervebtn = new Button();
            cesitbtn = new Button();
            masabtn = new Button();
            iptalbtn = new Button();
            odemebtn = new Button();
            teslımbtn = new Button();
            gunsonbtn = new Button();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            rprtbl4 = new DataGridView();
            rprtbl3 = new DataGridView();
            rprtbl2 = new DataGridView();
            rprtbl1 = new DataGridView();
            panel3 = new Panel();
            label10 = new Label();
            label11 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rprtbl4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rprtbl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rprtbl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rprtbl1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1497F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.8503F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(830, 414);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 408);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(urunbtn, 0, 8);
            tableLayoutPanel2.Controls.Add(calisanbtn, 0, 7);
            tableLayoutPanel2.Controls.Add(rezervebtn, 0, 6);
            tableLayoutPanel2.Controls.Add(cesitbtn, 0, 5);
            tableLayoutPanel2.Controls.Add(masabtn, 0, 4);
            tableLayoutPanel2.Controls.Add(iptalbtn, 0, 3);
            tableLayoutPanel2.Controls.Add(odemebtn, 0, 2);
            tableLayoutPanel2.Controls.Add(teslımbtn, 0, 1);
            tableLayoutPanel2.Controls.Add(gunsonbtn, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(202, 408);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // urunbtn
            // 
            urunbtn.Dock = DockStyle.Fill;
            urunbtn.Location = new Point(3, 323);
            urunbtn.Name = "urunbtn";
            urunbtn.Size = new Size(196, 34);
            urunbtn.TabIndex = 8;
            urunbtn.Text = "Ürün Raporu";
            urunbtn.UseVisualStyleBackColor = true;
            urunbtn.Click += urunbtn_Click;
            // 
            // calisanbtn
            // 
            calisanbtn.Dock = DockStyle.Fill;
            calisanbtn.Location = new Point(3, 283);
            calisanbtn.Name = "calisanbtn";
            calisanbtn.Size = new Size(196, 34);
            calisanbtn.TabIndex = 7;
            calisanbtn.Text = "Çalışan Raporu";
            calisanbtn.UseVisualStyleBackColor = true;
            calisanbtn.Click += calisanbtn_Click;
            // 
            // rezervebtn
            // 
            rezervebtn.Dock = DockStyle.Fill;
            rezervebtn.Location = new Point(3, 243);
            rezervebtn.Name = "rezervebtn";
            rezervebtn.Size = new Size(196, 34);
            rezervebtn.TabIndex = 6;
            rezervebtn.Text = "Rezerve Raporu";
            rezervebtn.UseVisualStyleBackColor = true;
            rezervebtn.Click += rezervebtn_Click;
            // 
            // cesitbtn
            // 
            cesitbtn.Dock = DockStyle.Fill;
            cesitbtn.Location = new Point(3, 203);
            cesitbtn.Name = "cesitbtn";
            cesitbtn.Size = new Size(196, 34);
            cesitbtn.TabIndex = 5;
            cesitbtn.Text = "Ödeme Çeşitleri";
            cesitbtn.UseVisualStyleBackColor = true;
            cesitbtn.Click += cesitbtn_Click;
            // 
            // masabtn
            // 
            masabtn.Dock = DockStyle.Fill;
            masabtn.Location = new Point(3, 163);
            masabtn.Name = "masabtn";
            masabtn.Size = new Size(196, 34);
            masabtn.TabIndex = 4;
            masabtn.Text = "Masa Özeti";
            masabtn.UseVisualStyleBackColor = true;
            masabtn.Click += masabtn_Click;
            // 
            // iptalbtn
            // 
            iptalbtn.Dock = DockStyle.Fill;
            iptalbtn.Location = new Point(3, 123);
            iptalbtn.Name = "iptalbtn";
            iptalbtn.Size = new Size(196, 34);
            iptalbtn.TabIndex = 3;
            iptalbtn.Text = "İptal Özeti";
            iptalbtn.UseVisualStyleBackColor = true;
            iptalbtn.Click += iptalbtn_Click;
            // 
            // odemebtn
            // 
            odemebtn.Dock = DockStyle.Fill;
            odemebtn.Location = new Point(3, 83);
            odemebtn.Name = "odemebtn";
            odemebtn.Size = new Size(196, 34);
            odemebtn.TabIndex = 2;
            odemebtn.Text = "Ödeme Özeti";
            odemebtn.UseVisualStyleBackColor = true;
            odemebtn.Click += odemebtn_Click;
            // 
            // teslımbtn
            // 
            teslımbtn.Dock = DockStyle.Fill;
            teslımbtn.Location = new Point(3, 43);
            teslımbtn.Name = "teslımbtn";
            teslımbtn.Size = new Size(196, 34);
            teslımbtn.TabIndex = 1;
            teslımbtn.Text = "Teslim Özeti";
            teslımbtn.UseVisualStyleBackColor = true;
            teslımbtn.Click += teslımbtn_Click;
            // 
            // gunsonbtn
            // 
            gunsonbtn.Dock = DockStyle.Fill;
            gunsonbtn.Location = new Point(3, 3);
            gunsonbtn.Name = "gunsonbtn";
            gunsonbtn.Size = new Size(196, 34);
            gunsonbtn.TabIndex = 0;
            gunsonbtn.Text = "Gün Sonu Raporu";
            gunsonbtn.UseVisualStyleBackColor = true;
            gunsonbtn.Click += gunsonbtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(211, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 408);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(rprtbl4, 1, 1);
            tableLayoutPanel3.Controls.Add(rprtbl3, 0, 1);
            tableLayoutPanel3.Controls.Add(rprtbl2, 1, 0);
            tableLayoutPanel3.Controls.Add(rprtbl1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 95);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(616, 313);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // rprtbl4
            // 
            rprtbl4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rprtbl4.Dock = DockStyle.Fill;
            rprtbl4.Location = new Point(313, 161);
            rprtbl4.Margin = new Padding(5);
            rprtbl4.Name = "rprtbl4";
            rprtbl4.Size = new Size(298, 147);
            rprtbl4.TabIndex = 3;
            // 
            // rprtbl3
            // 
            rprtbl3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rprtbl3.Dock = DockStyle.Fill;
            rprtbl3.Location = new Point(5, 161);
            rprtbl3.Margin = new Padding(5);
            rprtbl3.Name = "rprtbl3";
            rprtbl3.Size = new Size(298, 147);
            rprtbl3.TabIndex = 2;
            // 
            // rprtbl2
            // 
            rprtbl2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rprtbl2.Dock = DockStyle.Fill;
            rprtbl2.Location = new Point(313, 5);
            rprtbl2.Margin = new Padding(5);
            rprtbl2.Name = "rprtbl2";
            rprtbl2.Size = new Size(298, 146);
            rprtbl2.TabIndex = 1;
            // 
            // rprtbl1
            // 
            rprtbl1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rprtbl1.Dock = DockStyle.Fill;
            rprtbl1.Location = new Point(5, 5);
            rprtbl1.Margin = new Padding(5);
            rprtbl1.Name = "rprtbl1";
            rprtbl1.Size = new Size(298, 146);
            rprtbl1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 95);
            panel3.TabIndex = 0;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label10.Location = new Point(262, 40);
            label10.Name = "label10";
            label10.Size = new Size(90, 37);
            label10.TabIndex = 3;
            label10.Text = "Rapor";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(235, 3);
            label11.Name = "label11";
            label11.Size = new Size(157, 37);
            label11.TabIndex = 2;
            label11.Text = "FastenPOS";
            // 
            // raporform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 414);
            Controls.Add(tableLayoutPanel1);
            Name = "raporform";
            Text = "raporform";
            Load += raporform_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rprtbl4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rprtbl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rprtbl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rprtbl1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private Button urunbtn;
        private Button calisanbtn;
        private Button rezervebtn;
        private Button cesitbtn;
        private Button masabtn;
        private Button iptalbtn;
        private Button odemebtn;
        private Button teslımbtn;
        private Button gunsonbtn;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView rprtbl4;
        private DataGridView rprtbl3;
        private DataGridView rprtbl2;
        private DataGridView rprtbl1;
    }
}