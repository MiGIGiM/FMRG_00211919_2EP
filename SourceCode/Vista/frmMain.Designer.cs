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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNeg = new System.Windows.Forms.Button();
            this.txtDescNeg = new System.Windows.Forms.TextBox();
            this.txtNombreNeg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteNeg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNegocios = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grpAddProd = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.cmbNombreNeg = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbNombreProd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteProducto = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
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
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.tabPage1);
            this.tabOpciones.Controls.Add(this.tabPage2);
            this.tabOpciones.Controls.Add(this.tabPage3);
            this.tabOpciones.Controls.Add(this.tabPage4);
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
            this.groupBox1.Size = new System.Drawing.Size(396, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Negocio: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(426, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 21);
            this.comboBox2.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre: ";
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
            // txtDescNeg
            // 
            this.txtDescNeg.Location = new System.Drawing.Point(91, 45);
            this.txtDescNeg.Name = "txtDescNeg";
            this.txtDescNeg.Size = new System.Drawing.Size(163, 20);
            this.txtDescNeg.TabIndex = 0;
            // 
            // txtNombreNeg
            // 
            this.txtNombreNeg.Location = new System.Drawing.Point(91, 19);
            this.txtNombreNeg.Name = "txtNombreNeg";
            this.txtNombreNeg.Size = new System.Drawing.Size(163, 20);
            this.txtNombreNeg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteNeg);
            this.groupBox2.Controls.Add(this.cmbNombreNeg);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(405, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Negocio: ";
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
            this.label3.Location = new System.Drawing.Point(32, 24);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(662, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Administrar Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.grpAddProd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvProd, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.32827F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.67173F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(662, 329);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // grpAddProd
            // 
            this.grpAddProd.Controls.Add(this.label5);
            this.grpAddProd.Controls.Add(this.label4);
            this.grpAddProd.Controls.Add(this.btnAddProd);
            this.grpAddProd.Controls.Add(this.txtNameProd);
            this.grpAddProd.Controls.Add(this.cmbNegocios);
            this.grpAddProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddProd.Location = new System.Drawing.Point(3, 3);
            this.grpAddProd.Name = "grpAddProd";
            this.grpAddProd.Size = new System.Drawing.Size(325, 153);
            this.grpAddProd.TabIndex = 0;
            this.grpAddProd.TabStop = false;
            this.grpAddProd.Text = "Agregar Producto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Negocio: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre: ";
            // 
            // btnAddProd
            // 
            this.btnAddProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProd.Location = new System.Drawing.Point(155, 112);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(158, 28);
            this.btnAddProd.TabIndex = 2;
            this.btnAddProd.Text = "Agregar";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // txtNameProd
            // 
            this.txtNameProd.Location = new System.Drawing.Point(94, 78);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.Size = new System.Drawing.Size(141, 20);
            this.txtNameProd.TabIndex = 1;
            // 
            // cmbNegocios
            // 
            this.cmbNegocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocios.FormattingEnabled = true;
            this.cmbNegocios.Location = new System.Drawing.Point(97, 34);
            this.cmbNegocios.Name = "cmbNegocios";
            this.cmbNegocios.Size = new System.Drawing.Size(141, 21);
            this.cmbNegocios.TabIndex = 0;
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dgvProd, 2);
            this.dgvProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProd.Location = new System.Drawing.Point(3, 162);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(656, 164);
            this.dgvProd.TabIndex = 1;
            // 
            // cmbNombreNeg
            // 
            this.cmbNombreNeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreNeg.FormattingEnabled = true;
            this.cmbNombreNeg.Location = new System.Drawing.Point(62, 19);
            this.cmbNombreNeg.Name = "cmbNombreNeg";
            this.cmbNombreNeg.Size = new System.Drawing.Size(141, 21);
            this.cmbNombreNeg.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteProducto);
            this.groupBox3.Controls.Add(this.cmbNombreProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(334, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Producto:";
            // 
            // cmbNombreProd
            // 
            this.cmbNombreProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreProd.FormattingEnabled = true;
            this.cmbNombreProd.Location = new System.Drawing.Point(91, 34);
            this.cmbNombreProd.Name = "cmbNombreProd";
            this.cmbNombreProd.Size = new System.Drawing.Size(170, 21);
            this.cmbNombreProd.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre: ";
            // 
            // btnDeleteProducto
            // 
            this.btnDeleteProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteProducto.Location = new System.Drawing.Point(152, 90);
            this.btnDeleteProducto.Name = "btnDeleteProducto";
            this.btnDeleteProducto.Size = new System.Drawing.Size(129, 35);
            this.btnDeleteProducto.TabIndex = 4;
            this.btnDeleteProducto.Text = "Eliminar";
            this.btnDeleteProducto.UseVisualStyleBackColor = true;
            this.btnDeleteProducto.Click += new System.EventHandler(this.btnDeleteProducto_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvPedidos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(662, 329);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver Historial de Pedidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(662, 329);
            this.dgvPedidos.TabIndex = 0;
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
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grpAddProd.ResumeLayout(false);
            this.grpAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grpAddProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.TextBox txtNameProd;
        private System.Windows.Forms.ComboBox cmbNegocios;
        private System.Windows.Forms.ComboBox cmbNombreNeg;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteProducto;
        private System.Windows.Forms.ComboBox cmbNombreProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvPedidos;
    }
}