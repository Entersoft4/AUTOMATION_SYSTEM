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
            kasadurumu = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            kasaveritablo = new DataGridView();
            panel1 = new Panel();
            kasatplm = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kasaveritablo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // kasadurumu
            // 
            kasadurumu.BackColor = Color.Silver;
            kasadurumu.BorderStyle = BorderStyle.None;
            kasadurumu.Cursor = Cursors.Cross;
            kasadurumu.Dock = DockStyle.Right;
            kasadurumu.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kasadurumu.FormattingEnabled = true;
            kasadurumu.ItemHeight = 17;
            kasadurumu.Location = new Point(600, 0);
            kasadurumu.Name = "kasadurumu";
            kasadurumu.Size = new Size(236, 428);
            kasadurumu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0021572F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9956779F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0021572F));
            tableLayoutPanel1.Controls.Add(kasaveritablo, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(600, 428);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // kasaveritablo
            // 
            kasaveritablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kasaveritablo.Dock = DockStyle.Fill;
            kasaveritablo.Location = new Point(141, 217);
            kasaveritablo.Name = "kasaveritablo";
            kasaveritablo.Size = new Size(317, 208);
            kasaveritablo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(kasatplm);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(141, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 208);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // kasatplm
            // 
            kasatplm.Anchor = AnchorStyles.None;
            kasatplm.AutoSize = true;
            kasatplm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kasatplm.Location = new Point(3, 140);
            kasatplm.Name = "kasatplm";
            kasatplm.Size = new Size(148, 32);
            kasatplm.TabIndex = 2;
            kasatplm.Text = "Toplam= TL";
            kasatplm.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(69, 87);
            label2.Name = "label2";
            label2.Size = new Size(182, 37);
            label2.TabIndex = 1;
            label2.Text = "Kasa Durumu";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(80, 50);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 0;
            label1.Text = "FastenPOS";
            label1.Click += label1_Click_1;
            // 
            // kasaform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 428);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(kasadurumu);
            Name = "kasaform";
            Text = "kasaform";
            Load += kasaform_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kasaveritablo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox kasadurumu;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView kasaveritablo;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label kasatplm;
    }
}