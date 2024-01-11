namespace OTOMASYON_SISTEMI.Forms
{
    partial class menuform
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
            tablaypnl = new TableLayoutPanel();
            kasabtn = new Button();
            stokbtn = new Button();
            raporbtn = new Button();
            siparisbtn = new Button();
            satisbtn = new Button();
            duzenlebtn = new Button();
            tablaypnl.SuspendLayout();
            SuspendLayout();
            // 
            // tablaypnl
            // 
            tablaypnl.ColumnCount = 3;
            tablaypnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablaypnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablaypnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tablaypnl.Controls.Add(kasabtn, 2, 1);
            tablaypnl.Controls.Add(stokbtn, 1, 1);
            tablaypnl.Controls.Add(raporbtn, 0, 1);
            tablaypnl.Controls.Add(siparisbtn, 2, 0);
            tablaypnl.Controls.Add(satisbtn, 1, 0);
            tablaypnl.Controls.Add(duzenlebtn, 0, 0);
            tablaypnl.Dock = DockStyle.Fill;
            tablaypnl.Location = new Point(0, 0);
            tablaypnl.Name = "tablaypnl";
            tablaypnl.RowCount = 2;
            tablaypnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaypnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaypnl.Size = new Size(798, 297);
            tablaypnl.TabIndex = 1;
            // 
            // kasabtn
            // 
            kasabtn.Anchor = AnchorStyles.None;
            kasabtn.BackColor = Color.FromArgb(9, 116, 184);
            kasabtn.FlatAppearance.BorderColor = Color.Black;
            kasabtn.FlatStyle = FlatStyle.Flat;
            kasabtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kasabtn.ForeColor = Color.White;
            kasabtn.Location = new Point(535, 156);
            kasabtn.Margin = new Padding(5);
            kasabtn.Name = "kasabtn";
            kasabtn.Size = new Size(258, 132);
            kasabtn.TabIndex = 5;
            kasabtn.Text = "K A S A\r\nD U R U M U";
            kasabtn.UseVisualStyleBackColor = false;
            kasabtn.Click += kasabtn_Click;
            // 
            // stokbtn
            // 
            stokbtn.Anchor = AnchorStyles.None;
            stokbtn.BackColor = Color.FromArgb(9, 116, 184);
            stokbtn.FlatAppearance.BorderColor = Color.Black;
            stokbtn.FlatStyle = FlatStyle.Flat;
            stokbtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            stokbtn.ForeColor = Color.White;
            stokbtn.Location = new Point(270, 156);
            stokbtn.Margin = new Padding(5);
            stokbtn.Name = "stokbtn";
            stokbtn.Size = new Size(255, 132);
            stokbtn.TabIndex = 4;
            stokbtn.Text = "S T O K\r\nD U R U M U";
            stokbtn.UseVisualStyleBackColor = false;
            stokbtn.Click += stokbtn_Click;
            // 
            // raporbtn
            // 
            raporbtn.Anchor = AnchorStyles.None;
            raporbtn.BackColor = Color.FromArgb(9, 116, 184);
            raporbtn.FlatAppearance.BorderColor = Color.Black;
            raporbtn.FlatStyle = FlatStyle.Flat;
            raporbtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            raporbtn.ForeColor = Color.White;
            raporbtn.Location = new Point(5, 156);
            raporbtn.Margin = new Padding(5);
            raporbtn.Name = "raporbtn";
            raporbtn.Size = new Size(255, 132);
            raporbtn.TabIndex = 3;
            raporbtn.Text = "R A P O R L A R";
            raporbtn.UseVisualStyleBackColor = false;
            raporbtn.Click += raporbtn_Click;
            // 
            // siparisbtn
            // 
            siparisbtn.Anchor = AnchorStyles.None;
            siparisbtn.BackColor = Color.FromArgb(9, 116, 184);
            siparisbtn.FlatAppearance.BorderColor = Color.Black;
            siparisbtn.FlatStyle = FlatStyle.Flat;
            siparisbtn.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold, GraphicsUnit.Point, 162);
            siparisbtn.ForeColor = Color.White;
            siparisbtn.Location = new Point(535, 8);
            siparisbtn.Margin = new Padding(5);
            siparisbtn.Name = "siparisbtn";
            siparisbtn.Size = new Size(258, 131);
            siparisbtn.TabIndex = 2;
            siparisbtn.Text = "S İ P A R İ Ş L E R";
            siparisbtn.UseVisualStyleBackColor = false;
            siparisbtn.Click += siparisbtn_Click;
            // 
            // satisbtn
            // 
            satisbtn.Anchor = AnchorStyles.None;
            satisbtn.BackColor = Color.FromArgb(9, 116, 184);
            satisbtn.FlatAppearance.BorderColor = Color.Black;
            satisbtn.FlatStyle = FlatStyle.Flat;
            satisbtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satisbtn.ForeColor = Color.White;
            satisbtn.Location = new Point(270, 8);
            satisbtn.Margin = new Padding(5);
            satisbtn.Name = "satisbtn";
            satisbtn.Size = new Size(255, 131);
            satisbtn.TabIndex = 1;
            satisbtn.Text = "S A T I Ş";
            satisbtn.UseVisualStyleBackColor = false;
            satisbtn.Click += satisbtn_Click;
            // 
            // duzenlebtn
            // 
            duzenlebtn.Anchor = AnchorStyles.None;
            duzenlebtn.BackColor = Color.FromArgb(9, 116, 184);
            duzenlebtn.FlatAppearance.BorderColor = Color.Black;
            duzenlebtn.FlatStyle = FlatStyle.Flat;
            duzenlebtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            duzenlebtn.ForeColor = Color.White;
            duzenlebtn.Location = new Point(5, 8);
            duzenlebtn.Margin = new Padding(5);
            duzenlebtn.Name = "duzenlebtn";
            duzenlebtn.Size = new Size(255, 131);
            duzenlebtn.TabIndex = 0;
            duzenlebtn.Text = "D Ü Z E N L E";
            duzenlebtn.UseVisualStyleBackColor = false;
            duzenlebtn.Click += duzenlebtn_Click;
            // 
            // menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 297);
            Controls.Add(tablaypnl);
            Name = "menuform";
            Text = "menuform";
            Load += menuform_Load;
            tablaypnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button kasabtn;
        private Button stokbtn;
        private Button raporbtn;
        private Button siparisbtn;
        private Button satisbtn;
        private Button duzenlebtn;
        public TableLayoutPanel tablaypnl;
    }
}