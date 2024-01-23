namespace OTOMASYON_SISTEMI.Forms
{
    partial class ayarlarform
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
            tableLayoutPanel6 = new TableLayoutPanel();
            stoktbl = new DataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel11 = new Panel();
            yenilebtn = new Button();
            panel12 = new Panel();
            ssilbtn = new Button();
            label16 = new Label();
            panel13 = new Panel();
            sbrmbox = new TextBox();
            label19 = new Label();
            sgunceltbox = new Button();
            smktrtbox = new TextBox();
            label17 = new Label();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stoktbl).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.7834854F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.2165146F));
            tableLayoutPanel6.Controls.Add(stoktbl, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(860, 423);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // stoktbl
            // 
            stoktbl.BackgroundColor = Color.Gainsboro;
            stoktbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stoktbl.Dock = DockStyle.Fill;
            stoktbl.Location = new Point(345, 3);
            stoktbl.Name = "stoktbl";
            stoktbl.Size = new Size(512, 417);
            stoktbl.TabIndex = 0;
            stoktbl.CellMouseClick += stoktbl_CellMouseClick;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(panel11, 0, 0);
            tableLayoutPanel7.Controls.Add(panel12, 0, 1);
            tableLayoutPanel7.Controls.Add(panel13, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25.378F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3779964F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2440071F));
            tableLayoutPanel7.Size = new Size(336, 417);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(yenilebtn);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(330, 99);
            panel11.TabIndex = 0;
            // 
            // yenilebtn
            // 
            yenilebtn.Anchor = AnchorStyles.None;
            yenilebtn.BackColor = Color.Transparent;
            yenilebtn.BackgroundImage = Properties.Resources.refreshicon;
            yenilebtn.BackgroundImageLayout = ImageLayout.Stretch;
            yenilebtn.FlatAppearance.BorderColor = Color.Black;
            yenilebtn.FlatStyle = FlatStyle.Flat;
            yenilebtn.Location = new Point(130, 10);
            yenilebtn.Name = "yenilebtn";
            yenilebtn.Size = new Size(76, 73);
            yenilebtn.TabIndex = 17;
            yenilebtn.UseVisualStyleBackColor = false;
            yenilebtn.Click += yenilebtn_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(ssilbtn);
            panel12.Controls.Add(label16);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 108);
            panel12.Name = "panel12";
            panel12.Size = new Size(330, 99);
            panel12.TabIndex = 1;
            // 
            // ssilbtn
            // 
            ssilbtn.Anchor = AnchorStyles.None;
            ssilbtn.BackColor = Color.Firebrick;
            ssilbtn.FlatAppearance.BorderColor = Color.Black;
            ssilbtn.FlatStyle = FlatStyle.Flat;
            ssilbtn.Location = new Point(169, 26);
            ssilbtn.Name = "ssilbtn";
            ssilbtn.Size = new Size(104, 42);
            ssilbtn.TabIndex = 16;
            ssilbtn.Text = "S İ L";
            ssilbtn.UseVisualStyleBackColor = false;
            ssilbtn.Click += ssilbtn_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(38, 26);
            label16.Name = "label16";
            label16.Size = new Size(135, 42);
            label16.TabIndex = 15;
            label16.Text = "Stok seçtikten \r\nsonra tıklayınız.";
            // 
            // panel13
            // 
            panel13.Controls.Add(sbrmbox);
            panel13.Controls.Add(label19);
            panel13.Controls.Add(sgunceltbox);
            panel13.Controls.Add(smktrtbox);
            panel13.Controls.Add(label17);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 213);
            panel13.Name = "panel13";
            panel13.Size = new Size(330, 201);
            panel13.TabIndex = 2;
            // 
            // sbrmbox
            // 
            sbrmbox.Anchor = AnchorStyles.None;
            sbrmbox.Location = new Point(226, 84);
            sbrmbox.Name = "sbrmbox";
            sbrmbox.Size = new Size(74, 23);
            sbrmbox.TabIndex = 27;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.Location = new Point(179, 85);
            label19.Name = "label19";
            label19.Size = new Size(50, 19);
            label19.TabIndex = 26;
            label19.Text = "Birim:";
            // 
            // sgunceltbox
            // 
            sgunceltbox.Anchor = AnchorStyles.None;
            sgunceltbox.BackColor = Color.ForestGreen;
            sgunceltbox.FlatAppearance.BorderColor = Color.Black;
            sgunceltbox.FlatStyle = FlatStyle.Flat;
            sgunceltbox.Location = new Point(91, 114);
            sgunceltbox.Name = "sgunceltbox";
            sgunceltbox.Size = new Size(156, 42);
            sgunceltbox.TabIndex = 25;
            sgunceltbox.Text = "G Ü N C E L L E";
            sgunceltbox.UseVisualStyleBackColor = false;
            sgunceltbox.Click += sgunceltbox_Click;
            // 
            // smktrtbox
            // 
            smktrtbox.Anchor = AnchorStyles.None;
            smktrtbox.Location = new Point(84, 83);
            smktrtbox.Name = "smktrtbox";
            smktrtbox.Size = new Size(87, 23);
            smktrtbox.TabIndex = 24;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.Location = new Point(24, 84);
            label17.Name = "label17";
            label17.Size = new Size(59, 19);
            label17.TabIndex = 22;
            label17.Text = "Miktar:";
            // 
            // ayarlarform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 423);
            Controls.Add(tableLayoutPanel6);
            Name = "ayarlarform";
            Text = "ayarlarform";
            Load += ayarlarform_Load;
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stoktbl).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView stoktbl;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel11;
        private Panel panel12;
        private Button ssilbtn;
        private Label label16;
        private Panel panel13;
        private TextBox sbrmbox;
        private Label label19;
        private Button sgunceltbox;
        private TextBox smktrtbox;
        private Label label17;
        private Button yenilebtn;
    }
}