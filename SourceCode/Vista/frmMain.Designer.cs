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
            this.AdminUsuarios = new System.Windows.Forms.TabPage();
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
            this.AdminNegocios = new System.Windows.Forms.TabPage();
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
            this.cmbNombreNeg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNegocios = new System.Windows.Forms.DataGridView();
            this.AdminProductos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.grpAddProd = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProducto = new System.Windows.Forms.Button();
            this.cmbNombreProd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VerPedidos = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.AdminPedidos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPedido = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteDir = new System.Windows.Forms.Button();
            this.dgvDeletePedido = new System.Windows.Forms.DataGridView();
            this.AdminDirecciones = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.btnAddDir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnBorrarDireccion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEliminarDir = new System.Windows.Forms.TextBox();
            this.dgvEliminarDir = new System.Windows.Forms.DataGridView();
            this.tabOpciones.SuspendLayout();
            this.AdminUsuarios.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpDeleteUser.SuspendLayout();
            this.AdminNegocios.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegocios)).BeginInit();
            this.AdminProductos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grpAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.VerPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.AdminPedidos.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletePedido)).BeginInit();
            this.AdminDirecciones.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarDir)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOpciones
            // 
            this.tabOpciones.Controls.Add(this.AdminUsuarios);
            this.tabOpciones.Controls.Add(this.AdminNegocios);
            this.tabOpciones.Controls.Add(this.AdminProductos);
            this.tabOpciones.Controls.Add(this.VerPedidos);
            this.tabOpciones.Controls.Add(this.AdminPedidos);
            this.tabOpciones.Controls.Add(this.AdminDirecciones);
            this.tabOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabOpciones.Location = new System.Drawing.Point(0, 12);
            this.tabOpciones.Name = "tabOpciones";
            this.tabOpciones.SelectedIndex = 0;
            this.tabOpciones.Size = new System.Drawing.Size(670, 391);
            this.tabOpciones.TabIndex = 0;
            // 
            // AdminUsuarios
            // 
            this.AdminUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.AdminUsuarios.Controls.Add(this.tableLayoutPanel1);
            this.AdminUsuarios.Location = new System.Drawing.Point(4, 22);
            this.AdminUsuarios.Name = "AdminUsuarios";
            this.AdminUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.AdminUsuarios.Size = new System.Drawing.Size(662, 365);
            this.AdminUsuarios.TabIndex = 0;
            this.AdminUsuarios.Text = "Administrar Usuarios";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 359);
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
            this.grpAddUser.Size = new System.Drawing.Size(475, 106);
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
            this.dgvUsers.Location = new System.Drawing.Point(3, 115);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(650, 241);
            this.dgvUsers.TabIndex = 0;
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.btnDeleteUser);
            this.grpDeleteUser.Controls.Add(this.cmbDeleteUser);
            this.grpDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDeleteUser.Location = new System.Drawing.Point(484, 3);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Size = new System.Drawing.Size(169, 106);
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
            // AdminNegocios
            // 
            this.AdminNegocios.Controls.Add(this.tableLayoutPanel2);
            this.AdminNegocios.Location = new System.Drawing.Point(4, 22);
            this.AdminNegocios.Name = "AdminNegocios";
            this.AdminNegocios.Padding = new System.Windows.Forms.Padding(3);
            this.AdminNegocios.Size = new System.Drawing.Size(662, 365);
            this.AdminNegocios.TabIndex = 1;
            this.AdminNegocios.Text = "Administrar Negocios";
            this.AdminNegocios.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 359);
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
            this.groupBox1.Size = new System.Drawing.Size(396, 82);
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
            this.groupBox2.Size = new System.Drawing.Size(248, 82);
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
            // cmbNombreNeg
            // 
            this.cmbNombreNeg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreNeg.FormattingEnabled = true;
            this.cmbNombreNeg.Location = new System.Drawing.Point(62, 19);
            this.cmbNombreNeg.Name = "cmbNombreNeg";
            this.cmbNombreNeg.Size = new System.Drawing.Size(141, 21);
            this.cmbNombreNeg.TabIndex = 0;
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
            this.dgvNegocios.Location = new System.Drawing.Point(3, 91);
            this.dgvNegocios.Name = "dgvNegocios";
            this.dgvNegocios.Size = new System.Drawing.Size(650, 265);
            this.dgvNegocios.TabIndex = 2;
            // 
            // AdminProductos
            // 
            this.AdminProductos.Controls.Add(this.tableLayoutPanel3);
            this.AdminProductos.Location = new System.Drawing.Point(4, 22);
            this.AdminProductos.Name = "AdminProductos";
            this.AdminProductos.Size = new System.Drawing.Size(662, 365);
            this.AdminProductos.TabIndex = 2;
            this.AdminProductos.Text = "Administrar Productos";
            this.AdminProductos.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(662, 365);
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
            this.grpAddProd.Size = new System.Drawing.Size(325, 170);
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
            this.dgvProd.Location = new System.Drawing.Point(3, 179);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(656, 183);
            this.dgvProd.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteProducto);
            this.groupBox3.Controls.Add(this.cmbNombreProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(334, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 170);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Producto:";
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
            // VerPedidos
            // 
            this.VerPedidos.Controls.Add(this.dgvPedidos);
            this.VerPedidos.Location = new System.Drawing.Point(4, 22);
            this.VerPedidos.Name = "VerPedidos";
            this.VerPedidos.Size = new System.Drawing.Size(662, 365);
            this.VerPedidos.TabIndex = 3;
            this.VerPedidos.Text = "Ver Historial de Pedidos";
            this.VerPedidos.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(662, 365);
            this.dgvPedidos.TabIndex = 0;
            // 
            // AdminPedidos
            // 
            this.AdminPedidos.Controls.Add(this.tableLayoutPanel4);
            this.AdminPedidos.Location = new System.Drawing.Point(4, 22);
            this.AdminPedidos.Name = "AdminPedidos";
            this.AdminPedidos.Size = new System.Drawing.Size(662, 365);
            this.AdminPedidos.TabIndex = 4;
            this.AdminPedidos.Text = "Administrar Pedidos";
            this.AdminPedidos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(662, 365);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.btnAddPedido);
            this.groupBox4.Controls.Add(this.cmbProductos);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbDireccion);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 359);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Pedido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SourceCode.Properties.Resources.Web_LPC_397x265_2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddPedido
            // 
            this.btnAddPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPedido.Location = new System.Drawing.Point(180, 133);
            this.btnAddPedido.Name = "btnAddPedido";
            this.btnAddPedido.Size = new System.Drawing.Size(129, 37);
            this.btnAddPedido.TabIndex = 3;
            this.btnAddPedido.Text = "Agregar Pedido";
            this.btnAddPedido.UseVisualStyleBackColor = true;
            this.btnAddPedido.Click += new System.EventHandler(this.btnAddPedido_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(78, 95);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(197, 21);
            this.cmbProductos.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Producto: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dirección: ";
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Location = new System.Drawing.Point(78, 52);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(197, 21);
            this.cmbDireccion.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtIdPedido);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnDeleteDir);
            this.groupBox5.Controls.Add(this.dgvDeletePedido);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(334, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 359);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar Pedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(67, 36);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(36, 20);
            this.txtIdPedido.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Id: ";
            // 
            // btnDeleteDir
            // 
            this.btnDeleteDir.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteDir.Location = new System.Drawing.Point(177, 36);
            this.btnDeleteDir.Name = "btnDeleteDir";
            this.btnDeleteDir.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteDir.TabIndex = 1;
            this.btnDeleteDir.Text = "Eliminar";
            this.btnDeleteDir.UseVisualStyleBackColor = true;
            this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
            // 
            // dgvDeletePedido
            // 
            this.dgvDeletePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletePedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDeletePedido.Location = new System.Drawing.Point(3, 134);
            this.dgvDeletePedido.Name = "dgvDeletePedido";
            this.dgvDeletePedido.Size = new System.Drawing.Size(319, 222);
            this.dgvDeletePedido.TabIndex = 0;
            // 
            // AdminDirecciones
            // 
            this.AdminDirecciones.Controls.Add(this.tableLayoutPanel5);
            this.AdminDirecciones.Location = new System.Drawing.Point(4, 22);
            this.AdminDirecciones.Name = "AdminDirecciones";
            this.AdminDirecciones.Size = new System.Drawing.Size(662, 365);
            this.AdminDirecciones.TabIndex = 5;
            this.AdminDirecciones.Text = "Administrar direcciones";
            this.AdminDirecciones.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(662, 365);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtDir);
            this.groupBox6.Controls.Add(this.btnAddDir);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(325, 359);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Agregar dirección: ";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(6, 64);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(313, 20);
            this.txtDir.TabIndex = 3;
            // 
            // btnAddDir
            // 
            this.btnAddDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDir.Location = new System.Drawing.Point(72, 101);
            this.btnAddDir.Name = "btnAddDir";
            this.btnAddDir.Size = new System.Drawing.Size(164, 28);
            this.btnAddDir.TabIndex = 2;
            this.btnAddDir.Text = "Agregar";
            this.btnAddDir.UseVisualStyleBackColor = true;
            this.btnAddDir.Click += new System.EventHandler(this.btnAddDir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dirección: ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvEliminarDir);
            this.groupBox7.Controls.Add(this.txtEliminarDir);
            this.groupBox7.Controls.Add(this.btnBorrarDireccion);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(334, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(325, 359);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Eliminar dirección: ";
            // 
            // btnBorrarDireccion
            // 
            this.btnBorrarDireccion.Location = new System.Drawing.Point(172, 41);
            this.btnBorrarDireccion.Name = "btnBorrarDireccion";
            this.btnBorrarDireccion.Size = new System.Drawing.Size(134, 27);
            this.btnBorrarDireccion.TabIndex = 0;
            this.btnBorrarDireccion.Text = "Eliminar";
            this.btnBorrarDireccion.UseVisualStyleBackColor = true;
            this.btnBorrarDireccion.Click += new System.EventHandler(this.btnBorrarDireccion_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dirección: ";
            // 
            // txtEliminarDir
            // 
            this.txtEliminarDir.Location = new System.Drawing.Point(83, 45);
            this.txtEliminarDir.Name = "txtEliminarDir";
            this.txtEliminarDir.Size = new System.Drawing.Size(40, 20);
            this.txtEliminarDir.TabIndex = 2;
            // 
            // dgvEliminarDir
            // 
            this.dgvEliminarDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarDir.Location = new System.Drawing.Point(13, 113);
            this.dgvEliminarDir.Name = "dgvEliminarDir";
            this.dgvEliminarDir.Size = new System.Drawing.Size(292, 215);
            this.dgvEliminarDir.TabIndex = 3;
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
            this.AdminUsuarios.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpDeleteUser.ResumeLayout(false);
            this.AdminNegocios.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegocios)).EndInit();
            this.AdminProductos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.grpAddProd.ResumeLayout(false);
            this.grpAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.VerPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.AdminPedidos.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletePedido)).EndInit();
            this.AdminDirecciones.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOpciones;
        private System.Windows.Forms.TabPage AdminUsuarios;
        private System.Windows.Forms.TabPage AdminNegocios;
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
        private System.Windows.Forms.TabPage AdminProductos;
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
        private System.Windows.Forms.TabPage VerPedidos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.TabPage AdminPedidos;
        private System.Windows.Forms.TabPage AdminDirecciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddPedido;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteDir;
        private System.Windows.Forms.DataGridView dgvDeletePedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAddDir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnBorrarDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEliminarDir;
        private System.Windows.Forms.DataGridView dgvEliminarDir;
    }
}