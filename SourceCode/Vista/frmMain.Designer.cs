namespace SourceCode.Vista
{
    partial class frmMain
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
            this.tabOpciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpDeleteUser = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cmbDeleteUser = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreNeg = new System.Windows.Forms.TextBox();
            this.txtDescNeg = new System.Windows.Forms.TextBox();
            this.btnAddNeg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnDeleteNeg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNegocios = new System.Windows.Forms.DataGridView();
            this.txtIDNeg = new System.Windows.Forms.TextBox();
            this.tabOpciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpDeleteUser.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegocios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.tabPage1);
            this.tabOpciones.Controls.Add(this.tabPage2);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabOpciones.Location = new System.Drawing.Point(0, 48);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(670, 355);
            this.tabOpciones.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Administrar Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.47561F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.52439F));
            this.tableLayoutPanel1.Controls.Add(this.grpAddUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvUsers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpDeleteUser, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.45695F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.54305F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grpAddUser
            // 
            this.grpAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpAddUser.Controls.Add(this.btnAddUser);
            this.grpAddUser.Controls.Add(this.lblName);
            this.grpAddUser.Controls.Add(this.lblUsername);
            this.grpAddUser.Controls.Add(this.txtFullname);
            this.grpAddUser.Controls.Add(this.txtUsername);
            this.grpAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddUser.Location = new System.Drawing.Point(3, 3);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(475, 95);
            this.grpAddUser.TabIndex = 1;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Agregar Usuario: ";
            // 
            // btnAddUser
            // 
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddUser.Location = new System.Drawing.Point(307, 31);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(162, 38);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre completo:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(38, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username: ";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(105, 55);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(196, 20);
            this.txtFullname.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvUsers, 2);
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(3, 104);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(650, 216);
            this.dgvUsers.TabIndex = 0;
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.btnDeleteUser);
            this.grpDeleteUser.Controls.Add(this.cmbDeleteUser);
            this.grpDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDeleteUser.Location = new System.Drawing.Point(484, 3);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Size = new System.Drawing.Size(169, 95);
            this.grpDeleteUser.TabIndex = 2;
            this.grpDeleteUser.TabStop = false;
            this.grpDeleteUser.Text = "Eliminar Usuario: ";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Location = new System.Drawing.Point(21, 54);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(128, 28);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // cmbDeleteUser
            // 
            this.cmbDeleteUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteUser.FormattingEnabled = true;
            this.cmbDeleteUser.Location = new System.Drawing.Point(12, 23);
            this.cmbDeleteUser.Name = "cmbDeleteUser";
            this.cmbDeleteUser.Size = new System.Drawing.Size(147, 21);
            this.cmbDeleteUser.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrar Negocios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvNegocios, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.7678F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.2322F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 323);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddNeg);
            this.groupBox1.Controls.Add(this.txtDescNeg);
            this.groupBox1.Controls.Add(this.txtNombreNeg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Negocio: ";
            // 
            // txtNombreNeg
            // 
            this.txtNombreNeg.Location = new System.Drawing.Point(91, 19);
            this.txtNombreNeg.Name = "txtNombreNeg";
            this.txtNombreNeg.Size = new System.Drawing.Size(163, 20);
            this.txtNombreNeg.TabIndex = 0;
            // 
            // txtDescNeg
            // 
            this.txtDescNeg.Location = new System.Drawing.Point(91, 45);
            this.txtDescNeg.Name = "txtDescNeg";
            this.txtDescNeg.Size = new System.Drawing.Size(163, 20);
            this.txtDescNeg.TabIndex = 0;
            // 
            // btnAddNeg
            // 
            this.btnAddNeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNeg.Location = new System.Drawing.Point(278, 24);
            this.btnAddNeg.Name = "btnAddNeg";
            this.btnAddNeg.Size = new System.Drawing.Size(100, 36);
            this.btnAddNeg.TabIndex = 1;
            this.btnAddNeg.Text = "Agregar";
            this.btnAddNeg.UseVisualStyleBackColor = true;
            this.btnAddNeg.Click += new System.EventHandler(this.btnAddNeg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteNeg);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIDNeg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(404, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Negocio: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(426, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // btnDeleteNeg
            // 
            this.btnDeleteNeg.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteNeg.Location = new System.Drawing.Point(36, 45);
            this.btnDeleteNeg.Name = "btnDeleteNeg";
            this.btnDeleteNeg.Size = new System.Drawing.Size(186, 22);
            this.btnDeleteNeg.TabIndex = 1;
            this.btnDeleteNeg.Text = "Eliminar";
            this.btnDeleteNeg.UseVisualStyleBackColor = true;
            this.btnDeleteNeg.Click += new System.EventHandler(this.btnDeleteNeg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID: ";
            // 
            // dgvNegocios
            // 
            this.dgvNegocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvNegocios, 2);
            this.dgvNegocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNegocios.Location = new System.Drawing.Point(3, 82);
            this.dgvNegocios.Name = "dgvNegocios";
            this.dgvNegocios.Size = new System.Drawing.Size(650, 238);
            this.dgvNegocios.TabIndex = 2;
            // 
            // txtIDNeg
            // 
            this.txtIDNeg.Location = new System.Drawing.Point(41, 21);
            this.txtIDNeg.Name = "txtIDNeg";
            this.txtIDNeg.Size = new System.Drawing.Size(163, 20);
            this.txtIDNeg.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 403);
            this.Controls.Add(this.tabOpciones);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabOpciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpDeleteUser.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOpciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.ComboBox cmbDeleteUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNeg;
        private System.Windows.Forms.TextBox txtDescNeg;
        private System.Windows.Forms.TextBox txtNombreNeg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteNeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNegocios;
        private System.Windows.Forms.TextBox txtIDNeg;
    }
}