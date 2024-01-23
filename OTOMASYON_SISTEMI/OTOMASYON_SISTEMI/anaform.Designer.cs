namespace OTOMASYON_SISTEMI
{
    partial class anaform
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            notifyIcon1 = new NotifyIcon(components);
            ustpnl = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            anasaat = new Label();
            anatarih = new Label();
            label1 = new Label();
            logopbox = new PictureBox();
            altpnl = new Panel();
            anaayarlar = new Button();
            anamenu = new Button();
            anakasa = new Button();
            anastok = new Button();
            anarapor = new Button();
            anasiparis = new Button();
            anasatis = new Button();
            anaduzenle = new Button();
            anapnl = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ustpnl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logopbox).BeginInit();
            altpnl.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "FastenPOS";
            notifyIcon1.Visible = true;
            // 
            // ustpnl
            // 
            ustpnl.BackColor = Color.FromArgb(9, 116, 184);
            ustpnl.Controls.Add(tableLayoutPanel1);
            ustpnl.Controls.Add(label1);
            ustpnl.Controls.Add(logopbox);
            ustpnl.Dock = DockStyle.Top;
            ustpnl.Location = new Point(0, 0);
            ustpnl.Name = "ustpnl";
            ustpnl.Size = new Size(846, 50);
            ustpnl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(anasaat, 0, 0);
            tableLayoutPanel1.Controls.Add(anatarih, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(247, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(599, 50);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // anasaat
            // 
            anasaat.Anchor = AnchorStyles.None;
            anasaat.AutoSize = true;
            anasaat.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            anasaat.ForeColor = Color.White;
            anasaat.Location = new Point(122, 10);
            anasaat.Name = "anasaat";
            anasaat.Size = new Size(55, 29);
            anasaat.TabIndex = 1;
            anasaat.Text = "saat";
            // 
            // anatarih
            // 
            anatarih.Anchor = AnchorStyles.None;
            anatarih.AutoSize = true;
            anatarih.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            anatarih.ForeColor = Color.White;
            anatarih.Location = new Point(422, 12);
            anatarih.Name = "anatarih";
            anatarih.Size = new Size(53, 26);
            anatarih.TabIndex = 2;
            anatarih.Text = "tarih";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 6);
            label1.Name = "label1";
            label1.Size = new Size(175, 37);
            label1.TabIndex = 0;
            label1.Text = "FASTENPOS";
            // 
            // logopbox
            // 
            logopbox.Dock = DockStyle.Left;
            logopbox.Image = Properties.Resources.FPOS_beyaz_500_removebg_preview;
            logopbox.Location = new Point(0, 0);
            logopbox.Name = "logopbox";
            logopbox.Size = new Size(81, 50);
            logopbox.SizeMode = PictureBoxSizeMode.Zoom;
            logopbox.TabIndex = 0;
            logopbox.TabStop = false;
            // 
            // altpnl
            // 
            altpnl.BackColor = Color.LightGray;
            altpnl.Controls.Add(anaayarlar);
            altpnl.Controls.Add(anamenu);
            altpnl.Controls.Add(anakasa);
            altpnl.Controls.Add(anastok);
            altpnl.Controls.Add(anarapor);
            altpnl.Controls.Add(anasiparis);
            altpnl.Controls.Add(anasatis);
            altpnl.Controls.Add(anaduzenle);
            altpnl.Dock = DockStyle.Bottom;
            altpnl.Location = new Point(0, 333);
            altpnl.Name = "altpnl";
            altpnl.Size = new Size(846, 50);
            altpnl.TabIndex = 1;
            // 
            // anaayarlar
            // 
            anaayarlar.Dock = DockStyle.Right;
            anaayarlar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anaayarlar.Location = new Point(646, 0);
            anaayarlar.Name = "anaayarlar";
            anaayarlar.Size = new Size(100, 50);
            anaayarlar.TabIndex = 7;
            anaayarlar.Text = "AYARLAR";
            anaayarlar.UseVisualStyleBackColor = true;
            anaayarlar.Click += anaayarlar_Click;
            // 
            // anamenu
            // 
            anamenu.Dock = DockStyle.Right;
            anamenu.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anamenu.Location = new Point(746, 0);
            anamenu.Name = "anamenu";
            anamenu.Size = new Size(100, 50);
            anamenu.TabIndex = 6;
            anamenu.Text = "ANA\r\nMENÜ";
            anamenu.UseVisualStyleBackColor = true;
            anamenu.Click += anamenu_Click;
            // 
            // anakasa
            // 
            anakasa.Dock = DockStyle.Left;
            anakasa.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anakasa.Location = new Point(500, 0);
            anakasa.Name = "anakasa";
            anakasa.Size = new Size(100, 50);
            anakasa.TabIndex = 5;
            anakasa.Text = "KASA\r\nDURUMU";
            anakasa.UseVisualStyleBackColor = true;
            anakasa.Click += anakasa_Click;
            // 
            // anastok
            // 
            anastok.Dock = DockStyle.Left;
            anastok.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anastok.Location = new Point(400, 0);
            anastok.Name = "anastok";
            anastok.Size = new Size(100, 50);
            anastok.TabIndex = 4;
            anastok.Text = "STOK\r\nDURUMU";
            anastok.UseVisualStyleBackColor = true;
            anastok.Click += anastok_Click;
            // 
            // anarapor
            // 
            anarapor.Dock = DockStyle.Left;
            anarapor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anarapor.Location = new Point(300, 0);
            anarapor.Name = "anarapor";
            anarapor.Size = new Size(100, 50);
            anarapor.TabIndex = 3;
            anarapor.Text = "RAPORLAR";
            anarapor.UseVisualStyleBackColor = true;
            anarapor.Click += anarapor_Click;
            // 
            // anasiparis
            // 
            anasiparis.Dock = DockStyle.Left;
            anasiparis.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anasiparis.Location = new Point(200, 0);
            anasiparis.Name = "anasiparis";
            anasiparis.Size = new Size(100, 50);
            anasiparis.TabIndex = 2;
            anasiparis.Text = "SİPARİŞLER";
            anasiparis.UseVisualStyleBackColor = true;
            anasiparis.Click += anasiparis_Click;
            // 
            // anasatis
            // 
            anasatis.Dock = DockStyle.Left;
            anasatis.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anasatis.Location = new Point(100, 0);
            anasatis.Name = "anasatis";
            anasatis.Size = new Size(100, 50);
            anasatis.TabIndex = 1;
            anasatis.Text = "SATIŞ";
            anasatis.UseVisualStyleBackColor = true;
            anasatis.Click += anasatis_Click;
            // 
            // anaduzenle
            // 
            anaduzenle.Dock = DockStyle.Left;
            anaduzenle.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anaduzenle.Location = new Point(0, 0);
            anaduzenle.Name = "anaduzenle";
            anaduzenle.Size = new Size(100, 50);
            anaduzenle.TabIndex = 0;
            anaduzenle.Text = "DÜZENLE";
            anaduzenle.UseVisualStyleBackColor = true;
            anaduzenle.Click += anaduzenle_Click;
            // 
            // anapnl
            // 
            anapnl.Dock = DockStyle.Fill;
            anapnl.Location = new Point(0, 50);
            anapnl.Name = "anapnl";
            anapnl.Size = new Size(846, 283);
            anapnl.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // anaform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 383);
            Controls.Add(anapnl);
            Controls.Add(altpnl);
            Controls.Add(ustpnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(862, 422);
            Name = "anaform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FastenPOS";
            WindowState = FormWindowState.Maximized;
            FormClosing += anaform_FormClosing;
            Load += anaform_Load;
            ustpnl.ResumeLayout(false);
            ustpnl.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logopbox).EndInit();
            altpnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Panel ustpnl;
        private Panel altpnl;
        private PictureBox logopbox;
        private Label label1;
        private Button anasatis;
        private Button anaduzenle;
        private Button anasiparis;
        private Button anastok;
        private Button anarapor;
        private Button anaayarlar;
        private Button anamenu;
        private Button anakasa;
        private Panel anapnl;
        private Label anatarih;
        private Label anasaat;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}