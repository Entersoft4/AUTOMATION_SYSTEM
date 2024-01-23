namespace OTOMASYON_SISTEMI.Forms
{
    partial class kasaform
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
            kasaveritablo = new DataGridView();
            panel1 = new Panel();
            kasatplm = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            refreshbtn = new Button();
            lviewkasa = new ListView();
            columnHeader1 = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kasaveritablo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8786259F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.8448753F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2764969F));
            tableLayoutPanel1.Controls.Add(kasaveritablo, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(836, 428);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // kasaveritablo
            // 
            kasaveritablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kasaveritablo.Dock = DockStyle.Fill;
            kasaveritablo.Location = new Point(177, 217);
            kasaveritablo.Name = "kasaveritablo";
            kasaveritablo.Size = new Size(444, 208);
            kasaveritablo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(kasatplm);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(177, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 208);
            panel1.TabIndex = 1;
            // 
            // kasatplm
            // 
            kasatplm.Anchor = AnchorStyles.None;
            kasatplm.AutoSize = true;
            kasatplm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kasatplm.Location = new Point(67, 140);
            kasatplm.Name = "kasatplm";
            kasatplm.Size = new Size(148, 32);
            kasatplm.TabIndex = 2;
            kasatplm.Text = "Toplam= TL";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(133, 87);
            label2.Name = "label2";
            label2.Size = new Size(182, 37);
            label2.TabIndex = 1;
            label2.Text = "Kasa Durumu";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(144, 50);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 0;
            label1.Text = "FastenPOS";
            // 
            // panel2
            // 
            panel2.Controls.Add(refreshbtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 208);
            panel2.TabIndex = 2;
            // 
            // refreshbtn
            // 
            refreshbtn.Anchor = AnchorStyles.None;
            refreshbtn.BackgroundImage = Properties.Resources.refreshicon;
            refreshbtn.BackgroundImageLayout = ImageLayout.Stretch;
            refreshbtn.FlatStyle = FlatStyle.Flat;
            refreshbtn.Location = new Point(43, 67);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(78, 79);
            refreshbtn.TabIndex = 0;
            refreshbtn.UseVisualStyleBackColor = true;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // lviewkasa
            // 
            lviewkasa.BackColor = Color.Silver;
            lviewkasa.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lviewkasa.Cursor = Cursors.Cross;
            lviewkasa.Dock = DockStyle.Right;
            lviewkasa.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lviewkasa.FullRowSelect = true;
            lviewkasa.GridLines = true;
            lviewkasa.Location = new Point(636, 0);
            lviewkasa.Name = "lviewkasa";
            lviewkasa.Size = new Size(200, 428);
            lviewkasa.TabIndex = 2;
            lviewkasa.UseCompatibleStateImageBehavior = false;
            lviewkasa.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "KASANIN SON DURUMU";
            columnHeader1.Width = 200;
            // 
            // kasaform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 428);
            Controls.Add(lviewkasa);
            Controls.Add(tableLayoutPanel1);
            Name = "kasaform";
            Text = "kasaform";
            Load += kasaform_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kasaveritablo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView kasaveritablo;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label kasatplm;
        private ListView lviewkasa;
        private ColumnHeader columnHeader1;
        private Panel panel2;
        private Button refreshbtn;
    }
}