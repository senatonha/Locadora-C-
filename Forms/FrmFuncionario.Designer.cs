namespace Teste.Forms
{
    partial class FrmFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FrmFuncioCad = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFuncTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFuncNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFunNome = new System.Windows.Forms.Label();
            this.txtFunCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFunCod = new System.Windows.Forms.Label();
            this.lblFunTel = new System.Windows.Forms.Label();
            this.DgvListarFunc = new System.Windows.Forms.DataGridView();
            this.btnDesativarFun = new Guna.UI2.WinForms.Guna2Button();
            this.btnFunAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnFunCadastro = new Guna.UI2.WinForms.Guna2Button();
            this.dtpFuncContrato = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbFuncCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFunCargo = new System.Windows.Forms.Label();
            this.lblFunContr = new System.Windows.Forms.Label();
            this.FrmCargo = new System.Windows.Forms.TabPage();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtCargoNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFnome = new System.Windows.Forms.Label();
            this.lblFcod = new System.Windows.Forms.Label();
            this.txtCargoCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvListarCargo = new System.Windows.Forms.DataGridView();
            this.btnCarDes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargoAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargoCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.FrmFuncioCad.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarFunc)).BeginInit();
            this.FrmCargo.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FrmFuncioCad);
            this.tabControl1.Controls.Add(this.FrmCargo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 563);
            this.tabControl1.TabIndex = 2;
            // 
            // FrmFuncioCad
            // 
            this.FrmFuncioCad.Controls.Add(this.guna2GroupBox1);
            this.FrmFuncioCad.Controls.Add(this.DgvListarFunc);
            this.FrmFuncioCad.Controls.Add(this.btnDesativarFun);
            this.FrmFuncioCad.Controls.Add(this.btnFunAlterar);
            this.FrmFuncioCad.Controls.Add(this.btnFunCadastro);
            this.FrmFuncioCad.Controls.Add(this.dtpFuncContrato);
            this.FrmFuncioCad.Controls.Add(this.cbFuncCargo);
            this.FrmFuncioCad.Controls.Add(this.panel1);
            this.FrmFuncioCad.Controls.Add(this.lblFunCargo);
            this.FrmFuncioCad.Controls.Add(this.lblFunContr);
            this.FrmFuncioCad.ImageIndex = 0;
            this.FrmFuncioCad.Location = new System.Drawing.Point(4, 38);
            this.FrmFuncioCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FrmFuncioCad.Name = "FrmFuncioCad";
            this.FrmFuncioCad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FrmFuncioCad.Size = new System.Drawing.Size(846, 521);
            this.FrmFuncioCad.TabIndex = 0;
            this.FrmFuncioCad.Text = "FUNCIONÁRIO";
            this.FrmFuncioCad.UseVisualStyleBackColor = true;
            this.FrmFuncioCad.Click += new System.EventHandler(this.FrmFuncioCad_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox1.Controls.Add(this.txtFuncTelefone);
            this.guna2GroupBox1.Controls.Add(this.txtFuncNome);
            this.guna2GroupBox1.Controls.Add(this.lblFunNome);
            this.guna2GroupBox1.Controls.Add(this.txtFunCodigo);
            this.guna2GroupBox1.Controls.Add(this.lblFunCod);
            this.guna2GroupBox1.Controls.Add(this.lblFunTel);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(18, 93);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(437, 183);
            this.guna2GroupBox1.TabIndex = 100;
            this.guna2GroupBox1.Text = "Dados do Funcionário";
            // 
            // txtFuncTelefone
            // 
            this.txtFuncTelefone.AutoRoundedCorners = true;
            this.txtFuncTelefone.BorderRadius = 17;
            this.txtFuncTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncTelefone.DefaultText = "";
            this.txtFuncTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuncTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuncTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFuncTelefone.ForeColor = System.Drawing.Color.Black;
            this.txtFuncTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncTelefone.Location = new System.Drawing.Point(136, 140);
            this.txtFuncTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFuncTelefone.Name = "txtFuncTelefone";
            this.txtFuncTelefone.PasswordChar = '\0';
            this.txtFuncTelefone.PlaceholderText = "";
            this.txtFuncTelefone.SelectedText = "";
            this.txtFuncTelefone.Size = new System.Drawing.Size(206, 36);
            this.txtFuncTelefone.TabIndex = 97;
            // 
            // txtFuncNome
            // 
            this.txtFuncNome.AutoRoundedCorners = true;
            this.txtFuncNome.BorderRadius = 17;
            this.txtFuncNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncNome.DefaultText = "";
            this.txtFuncNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuncNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuncNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFuncNome.ForeColor = System.Drawing.Color.Black;
            this.txtFuncNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncNome.Location = new System.Drawing.Point(135, 98);
            this.txtFuncNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFuncNome.Name = "txtFuncNome";
            this.txtFuncNome.PasswordChar = '\0';
            this.txtFuncNome.PlaceholderText = "";
            this.txtFuncNome.SelectedText = "";
            this.txtFuncNome.Size = new System.Drawing.Size(206, 36);
            this.txtFuncNome.TabIndex = 96;
            // 
            // lblFunNome
            // 
            this.lblFunNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunNome.AutoSize = true;
            this.lblFunNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFunNome.Image = global::Teste.Properties.Resources.carteira_de_identidade__1_;
            this.lblFunNome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFunNome.Location = new System.Drawing.Point(38, 98);
            this.lblFunNome.Name = "lblFunNome";
            this.lblFunNome.Size = new System.Drawing.Size(90, 25);
            this.lblFunNome.TabIndex = 73;
            this.lblFunNome.Text = "    Nome:";
            // 
            // txtFunCodigo
            // 
            this.txtFunCodigo.AutoRoundedCorners = true;
            this.txtFunCodigo.BorderRadius = 17;
            this.txtFunCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFunCodigo.DefaultText = "";
            this.txtFunCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFunCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFunCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFunCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFunCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFunCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFunCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtFunCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFunCodigo.Location = new System.Drawing.Point(135, 56);
            this.txtFunCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFunCodigo.Name = "txtFunCodigo";
            this.txtFunCodigo.PasswordChar = '\0';
            this.txtFunCodigo.PlaceholderText = "";
            this.txtFunCodigo.SelectedText = "";
            this.txtFunCodigo.Size = new System.Drawing.Size(206, 36);
            this.txtFunCodigo.TabIndex = 95;
            // 
            // lblFunCod
            // 
            this.lblFunCod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunCod.AutoSize = true;
            this.lblFunCod.BackColor = System.Drawing.Color.Transparent;
            this.lblFunCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFunCod.Location = new System.Drawing.Point(47, 58);
            this.lblFunCod.Name = "lblFunCod";
            this.lblFunCod.Size = new System.Drawing.Size(81, 25);
            this.lblFunCod.TabIndex = 74;
            this.lblFunCod.Text = "Código:";
            // 
            // lblFunTel
            // 
            this.lblFunTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunTel.AutoSize = true;
            this.lblFunTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFunTel.Image = global::Teste.Properties.Resources.telefone1;
            this.lblFunTel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFunTel.Location = new System.Drawing.Point(13, 140);
            this.lblFunTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunTel.Name = "lblFunTel";
            this.lblFunTel.Size = new System.Drawing.Size(115, 25);
            this.lblFunTel.TabIndex = 77;
            this.lblFunTel.Text = "    Telefone:";
            // 
            // DgvListarFunc
            // 
            this.DgvListarFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListarFunc.BackgroundColor = System.Drawing.Color.White;
            this.DgvListarFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(209)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListarFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListarFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListarFunc.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListarFunc.EnableHeadersVisualStyles = false;
            this.DgvListarFunc.GridColor = System.Drawing.Color.Pink;
            this.DgvListarFunc.Location = new System.Drawing.Point(461, 93);
            this.DgvListarFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListarFunc.Name = "DgvListarFunc";
            this.DgvListarFunc.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListarFunc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListarFunc.RowTemplate.Height = 28;
            this.DgvListarFunc.Size = new System.Drawing.Size(352, 406);
            this.DgvListarFunc.TabIndex = 99;
            this.DgvListarFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarFunc_CellClick_1);
            // 
            // btnDesativarFun
            // 
            this.btnDesativarFun.AutoRoundedCorners = true;
            this.btnDesativarFun.BorderRadius = 21;
            this.btnDesativarFun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesativarFun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesativarFun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesativarFun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesativarFun.FillColor = System.Drawing.Color.LightPink;
            this.btnDesativarFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativarFun.ForeColor = System.Drawing.Color.Black;
            this.btnDesativarFun.Image = global::Teste.Properties.Resources.fechar;
            this.btnDesativarFun.Location = new System.Drawing.Point(153, 465);
            this.btnDesativarFun.Name = "btnDesativarFun";
            this.btnDesativarFun.Size = new System.Drawing.Size(180, 45);
            this.btnDesativarFun.TabIndex = 98;
            this.btnDesativarFun.Text = "Desabilitar";
            this.btnDesativarFun.Click += new System.EventHandler(this.btnDesativarFun_Click_1);
            // 
            // btnFunAlterar
            // 
            this.btnFunAlterar.AutoRoundedCorners = true;
            this.btnFunAlterar.BorderRadius = 21;
            this.btnFunAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFunAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFunAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFunAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFunAlterar.FillColor = System.Drawing.Color.LightPink;
            this.btnFunAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnFunAlterar.Image = global::Teste.Properties.Resources.interruptor;
            this.btnFunAlterar.Location = new System.Drawing.Point(241, 414);
            this.btnFunAlterar.Name = "btnFunAlterar";
            this.btnFunAlterar.Size = new System.Drawing.Size(180, 45);
            this.btnFunAlterar.TabIndex = 97;
            this.btnFunAlterar.Text = "Alterar";
            this.btnFunAlterar.Click += new System.EventHandler(this.btnFunAlterar_Click_1);
            // 
            // btnFunCadastro
            // 
            this.btnFunCadastro.AutoRoundedCorners = true;
            this.btnFunCadastro.BorderRadius = 21;
            this.btnFunCadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFunCadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFunCadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFunCadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFunCadastro.FillColor = System.Drawing.Color.LightPink;
            this.btnFunCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnFunCadastro.Image = global::Teste.Properties.Resources.verificar;
            this.btnFunCadastro.Location = new System.Drawing.Point(55, 414);
            this.btnFunCadastro.Name = "btnFunCadastro";
            this.btnFunCadastro.Size = new System.Drawing.Size(180, 45);
            this.btnFunCadastro.TabIndex = 96;
            this.btnFunCadastro.Text = "Cadastrar";
            this.btnFunCadastro.Click += new System.EventHandler(this.btnFunCadastro_Click_1);
            // 
            // dtpFuncContrato
            // 
            this.dtpFuncContrato.AutoRoundedCorners = true;
            this.dtpFuncContrato.BorderRadius = 17;
            this.dtpFuncContrato.Checked = true;
            this.dtpFuncContrato.FillColor = System.Drawing.Color.LightPink;
            this.dtpFuncContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpFuncContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFuncContrato.Location = new System.Drawing.Point(153, 320);
            this.dtpFuncContrato.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFuncContrato.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpFuncContrato.Name = "dtpFuncContrato";
            this.dtpFuncContrato.Size = new System.Drawing.Size(205, 36);
            this.dtpFuncContrato.TabIndex = 95;
            this.dtpFuncContrato.Value = new System.DateTime(2022, 12, 1, 22, 22, 57, 716);
            // 
            // cbFuncCargo
            // 
            this.cbFuncCargo.AutoRoundedCorners = true;
            this.cbFuncCargo.BackColor = System.Drawing.Color.Transparent;
            this.cbFuncCargo.BorderRadius = 17;
            this.cbFuncCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuncCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncCargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuncCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFuncCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbFuncCargo.ForeColor = System.Drawing.Color.Black;
            this.cbFuncCargo.ItemHeight = 30;
            this.cbFuncCargo.Items.AddRange(new object[] {
            "DISPONÍVEL",
            "INDISPONÍVEL"});
            this.cbFuncCargo.Location = new System.Drawing.Point(152, 363);
            this.cbFuncCargo.Name = "cbFuncCargo";
            this.cbFuncCargo.Size = new System.Drawing.Size(206, 36);
            this.cbFuncCargo.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Teste.Properties.Resources.carteira_de_identidade;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 84);
            this.panel1.TabIndex = 88;
            // 
            // lblFunCargo
            // 
            this.lblFunCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunCargo.AutoSize = true;
            this.lblFunCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblFunCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFunCargo.Image = global::Teste.Properties.Resources.carrinho__1_;
            this.lblFunCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFunCargo.Location = new System.Drawing.Point(54, 363);
            this.lblFunCargo.Name = "lblFunCargo";
            this.lblFunCargo.Size = new System.Drawing.Size(92, 25);
            this.lblFunCargo.TabIndex = 82;
            this.lblFunCargo.Text = "    Cargo:";
            this.lblFunCargo.Click += new System.EventHandler(this.lblFunCargo_Click);
            // 
            // lblFunContr
            // 
            this.lblFunContr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFunContr.AutoSize = true;
            this.lblFunContr.BackColor = System.Drawing.Color.Transparent;
            this.lblFunContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFunContr.Image = global::Teste.Properties.Resources.calendario__2_;
            this.lblFunContr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFunContr.Location = new System.Drawing.Point(167, 292);
            this.lblFunContr.Name = "lblFunContr";
            this.lblFunContr.Size = new System.Drawing.Size(186, 25);
            this.lblFunContr.TabIndex = 74;
            this.lblFunContr.Text = "    Data de Contrato:";
            // 
            // FrmCargo
            // 
            this.FrmCargo.Controls.Add(this.guna2GroupBox2);
            this.FrmCargo.Controls.Add(this.DgvListarCargo);
            this.FrmCargo.Controls.Add(this.btnCarDes);
            this.FrmCargo.Controls.Add(this.btnCargoAlterar);
            this.FrmCargo.Controls.Add(this.btnCargoCadastrar);
            this.FrmCargo.Controls.Add(this.panel2);
            this.FrmCargo.ImageKey = "carrinho.png";
            this.FrmCargo.Location = new System.Drawing.Point(4, 38);
            this.FrmCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FrmCargo.Name = "FrmCargo";
            this.FrmCargo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FrmCargo.Size = new System.Drawing.Size(846, 521);
            this.FrmCargo.TabIndex = 1;
            this.FrmCargo.Text = "CARGO";
            this.FrmCargo.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox2.Controls.Add(this.txtCargoNome);
            this.guna2GroupBox2.Controls.Add(this.lblFnome);
            this.guna2GroupBox2.Controls.Add(this.lblFcod);
            this.guna2GroupBox2.Controls.Add(this.txtCargoCodigo);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(20, 108);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(361, 160);
            this.guna2GroupBox2.TabIndex = 103;
            this.guna2GroupBox2.Text = "Cargo";
            // 
            // txtCargoNome
            // 
            this.txtCargoNome.AutoRoundedCorners = true;
            this.txtCargoNome.BorderRadius = 17;
            this.txtCargoNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargoNome.DefaultText = "";
            this.txtCargoNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCargoNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCargoNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCargoNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCargoNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCargoNome.ForeColor = System.Drawing.Color.Black;
            this.txtCargoNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargoNome.Location = new System.Drawing.Point(112, 99);
            this.txtCargoNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargoNome.Name = "txtCargoNome";
            this.txtCargoNome.PasswordChar = '\0';
            this.txtCargoNome.PlaceholderText = "";
            this.txtCargoNome.SelectedText = "";
            this.txtCargoNome.Size = new System.Drawing.Size(206, 36);
            this.txtCargoNome.TabIndex = 97;
            // 
            // lblFnome
            // 
            this.lblFnome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFnome.AutoSize = true;
            this.lblFnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFnome.Image = global::Teste.Properties.Resources.carrinho__1_;
            this.lblFnome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFnome.Location = new System.Drawing.Point(15, 99);
            this.lblFnome.Name = "lblFnome";
            this.lblFnome.Size = new System.Drawing.Size(90, 25);
            this.lblFnome.TabIndex = 37;
            this.lblFnome.Text = "    Nome:";
            // 
            // lblFcod
            // 
            this.lblFcod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFcod.AutoSize = true;
            this.lblFcod.BackColor = System.Drawing.Color.White;
            this.lblFcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFcod.Location = new System.Drawing.Point(24, 57);
            this.lblFcod.Name = "lblFcod";
            this.lblFcod.Size = new System.Drawing.Size(81, 25);
            this.lblFcod.TabIndex = 38;
            this.lblFcod.Text = "Código:";
            // 
            // txtCargoCodigo
            // 
            this.txtCargoCodigo.AutoRoundedCorners = true;
            this.txtCargoCodigo.BorderRadius = 17;
            this.txtCargoCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargoCodigo.DefaultText = "";
            this.txtCargoCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCargoCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCargoCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCargoCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCargoCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCargoCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCargoCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCargoCodigo.Location = new System.Drawing.Point(112, 57);
            this.txtCargoCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargoCodigo.Name = "txtCargoCodigo";
            this.txtCargoCodigo.PasswordChar = '\0';
            this.txtCargoCodigo.PlaceholderText = "";
            this.txtCargoCodigo.SelectedText = "";
            this.txtCargoCodigo.Size = new System.Drawing.Size(206, 36);
            this.txtCargoCodigo.TabIndex = 96;
            // 
            // DgvListarCargo
            // 
            this.DgvListarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListarCargo.BackgroundColor = System.Drawing.Color.White;
            this.DgvListarCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(209)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListarCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListarCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListarCargo.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvListarCargo.EnableHeadersVisualStyles = false;
            this.DgvListarCargo.GridColor = System.Drawing.Color.Pink;
            this.DgvListarCargo.Location = new System.Drawing.Point(402, 108);
            this.DgvListarCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListarCargo.Name = "DgvListarCargo";
            this.DgvListarCargo.RowHeadersWidth = 62;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListarCargo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListarCargo.RowTemplate.Height = 28;
            this.DgvListarCargo.Size = new System.Drawing.Size(404, 387);
            this.DgvListarCargo.TabIndex = 102;
            this.DgvListarCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarCargo_CellClick_1);
            // 
            // btnCarDes
            // 
            this.btnCarDes.AutoRoundedCorners = true;
            this.btnCarDes.BorderRadius = 21;
            this.btnCarDes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCarDes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCarDes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCarDes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCarDes.FillColor = System.Drawing.Color.LightPink;
            this.btnCarDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarDes.ForeColor = System.Drawing.Color.Black;
            this.btnCarDes.Image = global::Teste.Properties.Resources.fechar;
            this.btnCarDes.Location = new System.Drawing.Point(85, 412);
            this.btnCarDes.Name = "btnCarDes";
            this.btnCarDes.Size = new System.Drawing.Size(228, 45);
            this.btnCarDes.TabIndex = 101;
            this.btnCarDes.Text = "Desabilitar";
            this.btnCarDes.Click += new System.EventHandler(this.btnCarDes_Click_1);
            // 
            // btnCargoAlterar
            // 
            this.btnCargoAlterar.AutoRoundedCorners = true;
            this.btnCargoAlterar.BorderRadius = 21;
            this.btnCargoAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargoAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargoAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargoAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargoAlterar.FillColor = System.Drawing.Color.LightPink;
            this.btnCargoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargoAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnCargoAlterar.Image = global::Teste.Properties.Resources.interruptor;
            this.btnCargoAlterar.Location = new System.Drawing.Point(85, 351);
            this.btnCargoAlterar.Name = "btnCargoAlterar";
            this.btnCargoAlterar.Size = new System.Drawing.Size(228, 45);
            this.btnCargoAlterar.TabIndex = 100;
            this.btnCargoAlterar.Text = "Alterar";
            this.btnCargoAlterar.Click += new System.EventHandler(this.btnCargoAlterar_Click_1);
            // 
            // btnCargoCadastrar
            // 
            this.btnCargoCadastrar.AutoRoundedCorners = true;
            this.btnCargoCadastrar.BorderRadius = 21;
            this.btnCargoCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargoCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargoCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargoCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargoCadastrar.FillColor = System.Drawing.Color.LightPink;
            this.btnCargoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargoCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCargoCadastrar.Image = global::Teste.Properties.Resources.verificar;
            this.btnCargoCadastrar.Location = new System.Drawing.Point(85, 290);
            this.btnCargoCadastrar.Name = "btnCargoCadastrar";
            this.btnCargoCadastrar.Size = new System.Drawing.Size(228, 45);
            this.btnCargoCadastrar.TabIndex = 99;
            this.btnCargoCadastrar.Text = "Cadastrar";
            this.btnCargoCadastrar.Click += new System.EventHandler(this.btnCargoCadastrar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Teste.Properties.Resources.carrinho;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 80);
            this.panel2.TabIndex = 47;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carteira-de-identidade.png");
            this.imageList1.Images.SetKeyName(1, "carrinho.png");
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFuncionario";
            this.Text = "FUNCIONÁRIO";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.tabControl1.ResumeLayout(false);
            this.FrmFuncioCad.ResumeLayout(false);
            this.FrmFuncioCad.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarFunc)).EndInit();
            this.FrmCargo.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarCargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FrmFuncioCad;
        private System.Windows.Forms.Label lblFunCargo;
        private System.Windows.Forms.Label lblFunContr;
        private System.Windows.Forms.TabPage FrmCargo;
        private System.Windows.Forms.Label lblFcod;
        private System.Windows.Forms.Label lblFnome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblFunTel;
        private System.Windows.Forms.Label lblFunCod;
        private System.Windows.Forms.Label lblFunNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFuncCargo;
        private Guna.UI2.WinForms.Guna2TextBox txtFunCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtFuncTelefone;
        private Guna.UI2.WinForms.Guna2TextBox txtFuncNome;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFuncContrato;
        private Guna.UI2.WinForms.Guna2Button btnDesativarFun;
        private Guna.UI2.WinForms.Guna2Button btnFunAlterar;
        private Guna.UI2.WinForms.Guna2Button btnFunCadastro;
        private Guna.UI2.WinForms.Guna2Button btnCarDes;
        private Guna.UI2.WinForms.Guna2Button btnCargoAlterar;
        private Guna.UI2.WinForms.Guna2Button btnCargoCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox txtCargoNome;
        private Guna.UI2.WinForms.Guna2TextBox txtCargoCodigo;
        private System.Windows.Forms.DataGridView DgvListarFunc;
        private System.Windows.Forms.DataGridView DgvListarCargo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}