namespace SourceCode
{
    partial class frmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLogUser = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLogUser
            // 
            this.cmbLogUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbLogUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogUser.FormattingEnabled = true;
            this.cmbLogUser.Location = new System.Drawing.Point(181, 160);
            this.cmbLogUser.Name = "cmbLogUser";
            this.cmbLogUser.Size = new System.Drawing.Size(230, 21);
            this.cmbLogUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(56, 160);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(119, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nombre de usuario: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(99, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contraseña: ";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangePass.Location = new System.Drawing.Point(42, 315);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(190, 35);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Cambiar contraseña";
            this.btnChangePass.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogIn.Location = new System.Drawing.Point(289, 315);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(190, 35);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Iniciar sesión";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::SourceCode.Properties.Resources.hugo_icon;
            this.picLogo.Location = new System.Drawing.Point(198, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(135, 133);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(532, 394);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbLogUser);
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLogUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

