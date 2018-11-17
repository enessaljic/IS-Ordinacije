namespace Ordinacija
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrijava = new Bunifu.Framework.UI.BunifuTileButton();
            this.linklblZaboravili = new System.Windows.Forms.LinkLabel();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPrijava);
            this.panel1.Controls.Add(this.linklblZaboravili);
            this.panel1.Controls.Add(this.txtLozinka);
            this.panel1.Controls.Add(this.txtKorisnickoIme);
            this.panel1.Controls.Add(this.lblNaslov);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 457);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.btnPrijava.color = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.btnPrijava.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(147)))), ((int)(((byte)(157)))));
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijava.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnPrijava.ForeColor = System.Drawing.Color.White;
            this.btnPrijava.Image = null;
            this.btnPrijava.ImagePosition = 0;
            this.btnPrijava.ImageZoom = 0;
            this.btnPrijava.LabelPosition = 41;
            this.btnPrijava.LabelText = "Prijava";
            this.btnPrijava.Location = new System.Drawing.Point(124, 342);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(178, 52);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // linklblZaboravili
            // 
            this.linklblZaboravili.AutoSize = true;
            this.linklblZaboravili.BackColor = System.Drawing.Color.Transparent;
            this.linklblZaboravili.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblZaboravili.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(194)))), ((int)(((byte)(216)))));
            this.linklblZaboravili.Location = new System.Drawing.Point(209, 293);
            this.linklblZaboravili.Name = "linklblZaboravili";
            this.linklblZaboravili.Size = new System.Drawing.Size(127, 15);
            this.linklblZaboravili.TabIndex = 3;
            this.linklblZaboravili.TabStop = true;
            this.linklblZaboravili.Text = "Zaboravili ste lozinku?";
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.Color.Gray;
            this.txtLozinka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.ForeColor = System.Drawing.Color.White;
            this.txtLozinka.Location = new System.Drawing.Point(124, 230);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(202, 27);
            this.txtLozinka.TabIndex = 2;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.Gray;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(124, 151);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(202, 27);
            this.txtKorisnickoIme.TabIndex = 1;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaslov.Location = new System.Drawing.Point(84, 54);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(263, 39);
            this.lblNaslov.TabIndex = 4;
            this.lblNaslov.Text = "Prijava korisnika";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(426, 457);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 496);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.LinkLabel linklblZaboravili;
        private Bunifu.Framework.UI.BunifuTileButton btnPrijava;
    }
}

