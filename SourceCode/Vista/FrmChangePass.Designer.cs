namespace SourceCode.Vista
{
    partial class FrmChangePass
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
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassActual = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.grpPass1 = new System.Windows.Forms.GroupBox();
            this.grpPass2 = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpUser.SuspendLayout();
            this.grpPass1.SuspendLayout();
            this.grpPass2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(114, 23);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(192, 21);
            this.cmbUser.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SourceCode.Properties.Resources.hugo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(296, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassActual
            // 
            this.txtPassActual.Location = new System.Drawing.Point(112, 19);
            this.txtPassActual.Name = "txtPassActual";
            this.txtPassActual.Size = new System.Drawing.Size(191, 20);
            this.txtPassActual.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(114, 15);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(192, 20);
            this.txtNewPass.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Nombre de usuario: ";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Location = new System.Drawing.Point(9, 22);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(99, 13);
            this.lblCurrentPass.TabIndex = 3;
            this.lblCurrentPass.Text = "Contraseña actual: ";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(9, 18);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(101, 13);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "Nueva contraseña: ";
            // 
            // grpUser
            // 
            this.grpUser.BackColor = System.Drawing.Color.White;
            this.grpUser.Controls.Add(this.cmbUser);
            this.grpUser.Controls.Add(this.lblUsername);
            this.grpUser.Location = new System.Drawing.Point(13, 73);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(329, 51);
            this.grpUser.TabIndex = 4;
            this.grpUser.TabStop = false;
            this.grpUser.Text = " ";
            // 
            // grpPass1
            // 
            this.grpPass1.BackColor = System.Drawing.Color.White;
            this.grpPass1.Controls.Add(this.txtPassActual);
            this.grpPass1.Controls.Add(this.lblCurrentPass);
            this.grpPass1.Location = new System.Drawing.Point(12, 123);
            this.grpPass1.Name = "grpPass1";
            this.grpPass1.Size = new System.Drawing.Size(329, 55);
            this.grpPass1.TabIndex = 4;
            this.grpPass1.TabStop = false;
            this.grpPass1.Text = " ";
            // 
            // grpPass2
            // 
            this.grpPass2.BackColor = System.Drawing.Color.White;
            this.grpPass2.Controls.Add(this.txtNewPass);
            this.grpPass2.Controls.Add(this.lblNewPass);
            this.grpPass2.Location = new System.Drawing.Point(12, 177);
            this.grpPass2.Name = "grpPass2";
            this.grpPass2.Size = new System.Drawing.Size(329, 54);
            this.grpPass2.TabIndex = 5;
            this.grpPass2.TabStop = false;
            this.grpPass2.Text = " ";
            // 
            // btnChangePass
            // 
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangePass.Location = new System.Drawing.Point(248, 244);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(183, 31);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Cambiar contraseña";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // FrmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.grpPass2);
            this.Controls.Add(this.grpPass1);
            this.Controls.Add(this.grpUser);
            this.Name = "FrmChangePass";
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.FrmChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpPass1.ResumeLayout(false);
            this.grpPass1.PerformLayout();
            this.grpPass2.ResumeLayout(false);
            this.grpPass2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassActual;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.GroupBox grpPass1;
        private System.Windows.Forms.GroupBox grpPass2;
        private System.Windows.Forms.Button btnChangePass;
    }
}