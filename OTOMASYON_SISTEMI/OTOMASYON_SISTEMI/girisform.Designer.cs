namespace OTOMASYON_SISTEMI
{
    partial class girisform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisform));
            girisbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            giristbox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // girisbtn
            // 
            girisbtn.Anchor = AnchorStyles.None;
            girisbtn.BackColor = Color.FromArgb(9, 116, 184);
            girisbtn.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisbtn.ForeColor = Color.White;
            girisbtn.Location = new Point(281, 281);
            girisbtn.Name = "girisbtn";
            girisbtn.Size = new Size(184, 74);
            girisbtn.TabIndex = 0;
            girisbtn.Text = "G İ R İ Ş";
            girisbtn.UseVisualStyleBackColor = false;
            girisbtn.Click += girisbtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(9, 116, 184);
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(232, 74);
            label1.Name = "label1";
            label1.Size = new Size(276, 65);
            label1.TabIndex = 1;
            label1.Text = "FastenPOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(9, 116, 184);
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(232, 139);
            label2.Name = "label2";
            label2.Size = new Size(276, 50);
            label2.TabIndex = 2;
            label2.Text = "HOŞGELDİNİZ";
            // 
            // giristbox
            // 
            giristbox.Anchor = AnchorStyles.None;
            giristbox.Location = new Point(281, 235);
            giristbox.Name = "giristbox";
            giristbox.PasswordChar = '*';
            giristbox.Size = new Size(184, 23);
            giristbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(232, 189);
            label3.Name = "label3";
            label3.Size = new Size(275, 20);
            label3.TabIndex = 4;
            label3.Text = "Giriş yapmak için şifreyi giriniz";
            // 
            // girisform
            // 
            AcceptButton = girisbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_image_for_FPOS;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(744, 418);
            Controls.Add(label3);
            Controls.Add(giristbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(girisbtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "girisform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FastenPOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisbtn;
        private Label label1;
        private Label label2;
        private TextBox giristbox;
        private Label label3;
    }
}
