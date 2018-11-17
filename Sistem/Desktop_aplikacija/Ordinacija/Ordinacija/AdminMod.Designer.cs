namespace Ordinacija
{
    partial class AdminMod
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
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeder = new System.Windows.Forms.Panel();
            this.pnlOpcije = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAdmin.SuspendLayout();
            this.pnlOpcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlAdmin.Controls.Add(this.label1);
            this.pnlAdmin.Controls.Add(this.panel2);
            this.pnlAdmin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdmin.Location = new System.Drawing.Point(1, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(193, 49);
            this.pnlAdmin.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 49);
            this.panel2.TabIndex = 1;
            // 
            // pnlHeder
            // 
            this.pnlHeder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlHeder.Location = new System.Drawing.Point(194, 0);
            this.pnlHeder.Name = "pnlHeder";
            this.pnlHeder.Size = new System.Drawing.Size(723, 49);
            this.pnlHeder.TabIndex = 2;
            // 
            // pnlOpcije
            // 
            this.pnlOpcije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOpcije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.pnlOpcije.Controls.Add(this.panel5);
            this.pnlOpcije.Location = new System.Drawing.Point(1, 46);
            this.pnlOpcije.Name = "pnlOpcije";
            this.pnlOpcije.Size = new System.Drawing.Size(193, 458);
            this.pnlOpcije.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(190, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(726, 49);
            this.panel5.TabIndex = 1;
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUserControl.Location = new System.Drawing.Point(194, 49);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(723, 455);
            this.pnlUserControl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin panel";
            // 
            // AdminMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 504);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.pnlOpcije);
            this.Controls.Add(this.pnlHeder);
            this.Controls.Add(this.pnlAdmin);
            this.Name = "AdminMod";
            this.Text = "AdminMod";
            this.Load += new System.EventHandler(this.AdminMod_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlOpcije.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHeder;
        private System.Windows.Forms.Panel pnlOpcije;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Label label1;
    }
}