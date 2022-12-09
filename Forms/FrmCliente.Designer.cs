namespace Teste.Forms
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbpCadastraCliente = new System.Windows.Forms.TabPage();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpClienteCadastro = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpClienteDtNasc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbmClienteUf = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtClienteCidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClibairro = new System.Windows.Forms.Label();
            this.txtClienteBairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCliend = new System.Windows.Forms.Label();
            this.txtClienteComplem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClicomp = new System.Windows.Forms.Label();
            this.txtClienteEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClicidade = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtClienteSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtClienteEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbmClienteSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtClienteTel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtClienteNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtClienteCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClicod = new System.Windows.Forms.Label();
            this.tbpConsultaCliente = new System.Windows.Forms.TabPage();
            this.DgvListarClientes = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblClidtcadast = new System.Windows.Forms.Label();
            this.lblClidtnasc = new System.Windows.Forms.Label();
            this.lblCliuf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClitel = new System.Windows.Forms.Label();
            this.lblClisexo = new System.Windows.Forms.Label();
            this.lblCliemail = new System.Windows.Forms.Label();
            this.lblClisenha = new System.Windows.Forms.Label();
            this.lblClinome = new System.Windows.Forms.Label();
            this.btnCliDes = new Guna.UI2.WinForms.Guna2Button();
            this.btnClienteAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnClienteCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl2.SuspendLayout();
            this.tbpCadastraCliente.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tbpConsultaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbpCadastraCliente);
            this.tabControl2.Controls.Add(this.tbpConsultaCliente);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.tabControl2.ImageList = this.imageList1;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(854, 563);
            this.tabControl2.TabIndex = 3;
            // 
            // tbpCadastraCliente
            // 
            this.tbpCadastraCliente.BackColor = System.Drawing.Color.Transparent;
            this.tbpCadastraCliente.Controls.Add(this.guna2GroupBox3);
            this.tbpCadastraCliente.Controls.Add(this.guna2GroupBox2);
            this.tbpCadastraCliente.Controls.Add(this.guna2GroupBox1);
            this.tbpCadastraCliente.Controls.Add(this.btnCliDes);
            this.tbpCadastraCliente.Controls.Add(this.btnClienteAlterar);
            this.tbpCadastraCliente.Controls.Add(this.btnClienteCadastrar);
            this.tbpCadastraCliente.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCadastraCliente.ImageIndex = 0;
            this.tbpCadastraCliente.Location = new System.Drawing.Point(4, 38);
            this.tbpCadastraCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCadastraCliente.Name = "tbpCadastraCliente";
            this.tbpCadastraCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCadastraCliente.Size = new System.Drawing.Size(846, 521);
            this.tbpCadastraCliente.TabIndex = 0;
            this.tbpCadastraCliente.Text = "CADASTRAR";
            this.tbpCadastraCliente.Click += new System.EventHandler(this.tbpCadastraCliente_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.guna2GroupBox3.Controls.Add(this.dtpClienteCadastro);
            this.guna2GroupBox3.Controls.Add(this.dtpClienteDtNasc);
            this.guna2GroupBox3.Controls.Add(this.lblClidtcadast);
            this.guna2GroupBox3.Controls.Add(this.lblClidtnasc);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.PaleVioletRed;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(17, 335);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(795, 127);
            this.guna2GroupBox3.TabIndex = 94;
            this.guna2GroupBox3.Text = "Datas";
            // 
            // dtpClienteCadastro
            // 
            this.dtpClienteCadastro.AutoRoundedCorners = true;
            this.dtpClienteCadastro.BorderRadius = 17;
            this.dtpClienteCadastro.Checked = true;
            this.dtpClienteCadastro.FillColor = System.Drawing.Color.LightPink;
            this.dtpClienteCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpClienteCadastro.ForeColor = System.Drawing.Color.Black;
            this.dtpClienteCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClienteCadastro.Location = new System.Drawing.Point(463, 79);
            this.dtpClienteCadastro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpClienteCadastro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpClienteCadastro.Name = "dtpClienteCadastro";
            this.dtpClienteCadastro.Size = new System.Drawing.Size(186, 36);
            this.dtpClienteCadastro.TabIndex = 86;
            this.dtpClienteCadastro.Value = new System.DateTime(2022, 12, 1, 22, 22, 57, 716);
            this.dtpClienteCadastro.ValueChanged += new System.EventHandler(this.dtpClienteCadastro_ValueChanged);
            // 
            // dtpClienteDtNasc
            // 
            this.dtpClienteDtNasc.AutoRoundedCorners = true;
            this.dtpClienteDtNasc.BorderRadius = 17;
            this.dtpClienteDtNasc.Checked = true;
            this.dtpClienteDtNasc.FillColor = System.Drawing.Color.LightPink;
            this.dtpClienteDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpClienteDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClienteDtNasc.Location = new System.Drawing.Point(117, 79);
            this.dtpClienteDtNasc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpClienteDtNasc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpClienteDtNasc.Name = "dtpClienteDtNasc";
            this.dtpClienteDtNasc.Size = new System.Drawing.Size(186, 36);
            this.dtpClienteDtNasc.TabIndex = 85;
            this.dtpClienteDtNasc.Value = new System.DateTime(2022, 12, 1, 22, 22, 57, 716);
            this.dtpClienteDtNasc.ValueChanged += new System.EventHandler(this.dtpClienteDtNasc_ValueChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox2.Controls.Add(this.cbmClienteUf);
            this.guna2GroupBox2.Controls.Add(this.txtClienteCidade);
            this.guna2GroupBox2.Controls.Add(this.lblClibairro);
            this.guna2GroupBox2.Controls.Add(this.txtClienteBairro);
            this.guna2GroupBox2.Controls.Add(this.lblCliend);
            this.guna2GroupBox2.Controls.Add(this.txtClienteComplem);
            this.guna2GroupBox2.Controls.Add(this.lblClicomp);
            this.guna2GroupBox2.Controls.Add(this.txtClienteEnd);
            this.guna2GroupBox2.Controls.Add(this.lblCliuf);
            this.guna2GroupBox2.Controls.Add(this.pictureBox1);
            this.guna2GroupBox2.Controls.Add(this.lblClicidade);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(438, 15);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(374, 314);
            this.guna2GroupBox2.TabIndex = 89;
            this.guna2GroupBox2.Text = "Localização";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // cbmClienteUf
            // 
            this.cbmClienteUf.AutoRoundedCorners = true;
            this.cbmClienteUf.BackColor = System.Drawing.Color.Transparent;
            this.cbmClienteUf.BorderRadius = 17;
            this.cbmClienteUf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmClienteUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmClienteUf.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmClienteUf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmClienteUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbmClienteUf.ForeColor = System.Drawing.Color.Black;
            this.cbmClienteUf.ItemHeight = 30;
            this.cbmClienteUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbmClienteUf.Location = new System.Drawing.Point(147, 237);
            this.cbmClienteUf.Name = "cbmClienteUf";
            this.cbmClienteUf.Size = new System.Drawing.Size(206, 36);
            this.cbmClienteUf.TabIndex = 77;
            // 
            // txtClienteCidade
            // 
            this.txtClienteCidade.AutoRoundedCorners = true;
            this.txtClienteCidade.BorderRadius = 17;
            this.txtClienteCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteCidade.DefaultText = "";
            this.txtClienteCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteCidade.ForeColor = System.Drawing.Color.Black;
            this.txtClienteCidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteCidade.Location = new System.Drawing.Point(147, 195);
            this.txtClienteCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteCidade.Name = "txtClienteCidade";
            this.txtClienteCidade.PasswordChar = '\0';
            this.txtClienteCidade.PlaceholderText = "";
            this.txtClienteCidade.SelectedText = "";
            this.txtClienteCidade.Size = new System.Drawing.Size(206, 36);
            this.txtClienteCidade.TabIndex = 80;
            // 
            // lblClibairro
            // 
            this.lblClibairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClibairro.AutoSize = true;
            this.lblClibairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClibairro.Location = new System.Drawing.Point(70, 155);
            this.lblClibairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClibairro.Name = "lblClibairro";
            this.lblClibairro.Size = new System.Drawing.Size(69, 25);
            this.lblClibairro.TabIndex = 54;
            this.lblClibairro.Text = "Bairro:";
            // 
            // txtClienteBairro
            // 
            this.txtClienteBairro.AutoRoundedCorners = true;
            this.txtClienteBairro.BorderRadius = 17;
            this.txtClienteBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteBairro.DefaultText = "";
            this.txtClienteBairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteBairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteBairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteBairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteBairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteBairro.ForeColor = System.Drawing.Color.Black;
            this.txtClienteBairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteBairro.Location = new System.Drawing.Point(147, 155);
            this.txtClienteBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteBairro.Name = "txtClienteBairro";
            this.txtClienteBairro.PasswordChar = '\0';
            this.txtClienteBairro.PlaceholderText = "";
            this.txtClienteBairro.SelectedText = "";
            this.txtClienteBairro.Size = new System.Drawing.Size(206, 36);
            this.txtClienteBairro.TabIndex = 79;
            // 
            // lblCliend
            // 
            this.lblCliend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliend.AutoSize = true;
            this.lblCliend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCliend.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCliend.Location = new System.Drawing.Point(37, 71);
            this.lblCliend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliend.Name = "lblCliend";
            this.lblCliend.Size = new System.Drawing.Size(102, 25);
            this.lblCliend.TabIndex = 55;
            this.lblCliend.Text = "Endereço:";
            this.lblCliend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClienteComplem
            // 
            this.txtClienteComplem.AutoRoundedCorners = true;
            this.txtClienteComplem.BorderRadius = 17;
            this.txtClienteComplem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteComplem.DefaultText = "";
            this.txtClienteComplem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteComplem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteComplem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteComplem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteComplem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteComplem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteComplem.ForeColor = System.Drawing.Color.Black;
            this.txtClienteComplem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteComplem.Location = new System.Drawing.Point(147, 113);
            this.txtClienteComplem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteComplem.Name = "txtClienteComplem";
            this.txtClienteComplem.PasswordChar = '\0';
            this.txtClienteComplem.PlaceholderText = "";
            this.txtClienteComplem.SelectedText = "";
            this.txtClienteComplem.Size = new System.Drawing.Size(206, 36);
            this.txtClienteComplem.TabIndex = 78;
            // 
            // lblClicomp
            // 
            this.lblClicomp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClicomp.AutoSize = true;
            this.lblClicomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClicomp.Location = new System.Drawing.Point(-1, 113);
            this.lblClicomp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClicomp.Name = "lblClicomp";
            this.lblClicomp.Size = new System.Drawing.Size(140, 25);
            this.lblClicomp.TabIndex = 53;
            this.lblClicomp.Text = "Complemento:";
            // 
            // txtClienteEnd
            // 
            this.txtClienteEnd.AutoRoundedCorners = true;
            this.txtClienteEnd.BorderRadius = 17;
            this.txtClienteEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteEnd.DefaultText = "";
            this.txtClienteEnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteEnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteEnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteEnd.ForeColor = System.Drawing.Color.Black;
            this.txtClienteEnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteEnd.Location = new System.Drawing.Point(147, 71);
            this.txtClienteEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteEnd.Name = "txtClienteEnd";
            this.txtClienteEnd.PasswordChar = '\0';
            this.txtClienteEnd.PlaceholderText = "";
            this.txtClienteEnd.SelectedText = "";
            this.txtClienteEnd.Size = new System.Drawing.Size(206, 36);
            this.txtClienteEnd.TabIndex = 77;
            // 
            // lblClicidade
            // 
            this.lblClicidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClicidade.AutoSize = true;
            this.lblClicidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClicidade.Location = new System.Drawing.Point(58, 195);
            this.lblClicidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClicidade.Name = "lblClicidade";
            this.lblClicidade.Size = new System.Drawing.Size(81, 25);
            this.lblClicidade.TabIndex = 52;
            this.lblClicidade.Text = "Cidade:";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox1.Controls.Add(this.txtClienteSenha);
            this.guna2GroupBox1.Controls.Add(this.txtClienteEmail);
            this.guna2GroupBox1.Controls.Add(this.cbmClienteSexo);
            this.guna2GroupBox1.Controls.Add(this.txtClienteTel);
            this.guna2GroupBox1.Controls.Add(this.txtClienteNome);
            this.guna2GroupBox1.Controls.Add(this.txtClienteCodigo);
            this.guna2GroupBox1.Controls.Add(this.lblClitel);
            this.guna2GroupBox1.Controls.Add(this.lblClisexo);
            this.guna2GroupBox1.Controls.Add(this.lblCliemail);
            this.guna2GroupBox1.Controls.Add(this.lblClisenha);
            this.guna2GroupBox1.Controls.Add(this.lblClicod);
            this.guna2GroupBox1.Controls.Add(this.lblClinome);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(17, 15);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(402, 314);
            this.guna2GroupBox1.TabIndex = 93;
            this.guna2GroupBox1.Text = "Dados Pessoais";
            // 
            // txtClienteSenha
            // 
            this.txtClienteSenha.AutoRoundedCorners = true;
            this.txtClienteSenha.BorderRadius = 16;
            this.txtClienteSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteSenha.DefaultText = "";
            this.txtClienteSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteSenha.ForeColor = System.Drawing.Color.Black;
            this.txtClienteSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteSenha.Location = new System.Drawing.Point(135, 267);
            this.txtClienteSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteSenha.Name = "txtClienteSenha";
            this.txtClienteSenha.PasswordChar = '\0';
            this.txtClienteSenha.PlaceholderText = "";
            this.txtClienteSenha.SelectedText = "";
            this.txtClienteSenha.Size = new System.Drawing.Size(206, 34);
            this.txtClienteSenha.TabIndex = 88;
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.AutoRoundedCorners = true;
            this.txtClienteEmail.BorderRadius = 16;
            this.txtClienteEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteEmail.DefaultText = "";
            this.txtClienteEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteEmail.ForeColor = System.Drawing.Color.Black;
            this.txtClienteEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteEmail.Location = new System.Drawing.Point(135, 227);
            this.txtClienteEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.PasswordChar = '\0';
            this.txtClienteEmail.PlaceholderText = "";
            this.txtClienteEmail.SelectedText = "";
            this.txtClienteEmail.Size = new System.Drawing.Size(206, 34);
            this.txtClienteEmail.TabIndex = 87;
            // 
            // cbmClienteSexo
            // 
            this.cbmClienteSexo.AutoRoundedCorners = true;
            this.cbmClienteSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbmClienteSexo.BorderRadius = 17;
            this.cbmClienteSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmClienteSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmClienteSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmClienteSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmClienteSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbmClienteSexo.ForeColor = System.Drawing.Color.Black;
            this.cbmClienteSexo.ItemHeight = 30;
            this.cbmClienteSexo.Items.AddRange(new object[] {
            "FEMININO",
            "MASCULINO",
            "NÃO INFORMAR",
            "OUTROS"});
            this.cbmClienteSexo.Location = new System.Drawing.Point(135, 179);
            this.cbmClienteSexo.Name = "cbmClienteSexo";
            this.cbmClienteSexo.Size = new System.Drawing.Size(206, 36);
            this.cbmClienteSexo.TabIndex = 83;
            // 
            // txtClienteTel
            // 
            this.txtClienteTel.AutoRoundedCorners = true;
            this.txtClienteTel.BorderRadius = 16;
            this.txtClienteTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteTel.DefaultText = "";
            this.txtClienteTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteTel.ForeColor = System.Drawing.Color.Black;
            this.txtClienteTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteTel.Location = new System.Drawing.Point(135, 139);
            this.txtClienteTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteTel.Name = "txtClienteTel";
            this.txtClienteTel.PasswordChar = '\0';
            this.txtClienteTel.PlaceholderText = "";
            this.txtClienteTel.SelectedText = "";
            this.txtClienteTel.Size = new System.Drawing.Size(206, 34);
            this.txtClienteTel.TabIndex = 86;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.AutoRoundedCorners = true;
            this.txtClienteNome.BorderRadius = 16;
            this.txtClienteNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteNome.DefaultText = "";
            this.txtClienteNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteNome.ForeColor = System.Drawing.Color.Black;
            this.txtClienteNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteNome.Location = new System.Drawing.Point(135, 96);
            this.txtClienteNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.PasswordChar = '\0';
            this.txtClienteNome.PlaceholderText = "";
            this.txtClienteNome.SelectedText = "";
            this.txtClienteNome.Size = new System.Drawing.Size(206, 34);
            this.txtClienteNome.TabIndex = 85;
            // 
            // txtClienteCodigo
            // 
            this.txtClienteCodigo.AutoRoundedCorners = true;
            this.txtClienteCodigo.BorderRadius = 17;
            this.txtClienteCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteCodigo.DefaultText = "";
            this.txtClienteCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtClienteCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtClienteCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteCodigo.Location = new System.Drawing.Point(135, 55);
            this.txtClienteCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClienteCodigo.Name = "txtClienteCodigo";
            this.txtClienteCodigo.PasswordChar = '\0';
            this.txtClienteCodigo.PlaceholderText = "";
            this.txtClienteCodigo.SelectedText = "";
            this.txtClienteCodigo.Size = new System.Drawing.Size(206, 36);
            this.txtClienteCodigo.TabIndex = 84;
            // 
            // lblClicod
            // 
            this.lblClicod.AutoSize = true;
            this.lblClicod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClicod.Location = new System.Drawing.Point(56, 54);
            this.lblClicod.Name = "lblClicod";
            this.lblClicod.Size = new System.Drawing.Size(81, 25);
            this.lblClicod.TabIndex = 78;
            this.lblClicod.Text = "Código:";
            // 
            // tbpConsultaCliente
            // 
            this.tbpConsultaCliente.Controls.Add(this.DgvListarClientes);
            this.tbpConsultaCliente.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbpConsultaCliente.ImageKey = "lista-de-afazeres.png";
            this.tbpConsultaCliente.Location = new System.Drawing.Point(4, 38);
            this.tbpConsultaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpConsultaCliente.Name = "tbpConsultaCliente";
            this.tbpConsultaCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpConsultaCliente.Size = new System.Drawing.Size(846, 521);
            this.tbpConsultaCliente.TabIndex = 1;
            this.tbpConsultaCliente.Text = "CONSULTAR";
            this.tbpConsultaCliente.UseVisualStyleBackColor = true;
            // 
            // DgvListarClientes
            // 
            this.DgvListarClientes.BackgroundColor = System.Drawing.Color.White;
            this.DgvListarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(209)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListarClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvListarClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListarClientes.EnableHeadersVisualStyles = false;
            this.DgvListarClientes.GridColor = System.Drawing.Color.Pink;
            this.DgvListarClientes.Location = new System.Drawing.Point(3, 2);
            this.DgvListarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListarClientes.Name = "DgvListarClientes";
            this.DgvListarClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListarClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListarClientes.RowTemplate.Height = 28;
            this.DgvListarClientes.Size = new System.Drawing.Size(840, 517);
            this.DgvListarClientes.TabIndex = 90;
            this.DgvListarClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarClientes_CellClick_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconCli.png");
            this.imageList1.Images.SetKeyName(1, "lista-de-afazeres.png");
            // 
            // lblClidtcadast
            // 
            this.lblClidtcadast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClidtcadast.AutoSize = true;
            this.lblClidtcadast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClidtcadast.Image = global::Teste.Properties.Resources.calendario__2_;
            this.lblClidtcadast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClidtcadast.Location = new System.Drawing.Point(469, 51);
            this.lblClidtcadast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClidtcadast.Name = "lblClidtcadast";
            this.lblClidtcadast.Size = new System.Drawing.Size(186, 25);
            this.lblClidtcadast.TabIndex = 84;
            this.lblClidtcadast.Text = "    Data de cadastro:";
            this.lblClidtcadast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClidtcadast.Click += new System.EventHandler(this.lblClidtcadast_Click);
            // 
            // lblClidtnasc
            // 
            this.lblClidtnasc.AutoSize = true;
            this.lblClidtnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClidtnasc.Image = global::Teste.Properties.Resources.bolo_de_aniversario__1_;
            this.lblClidtnasc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClidtnasc.Location = new System.Drawing.Point(112, 51);
            this.lblClidtnasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClidtnasc.Name = "lblClidtnasc";
            this.lblClidtnasc.Size = new System.Drawing.Size(211, 25);
            this.lblClidtnasc.TabIndex = 83;
            this.lblClidtnasc.Text = "    Data de nascimento:";
            this.lblClidtnasc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClidtnasc.Click += new System.EventHandler(this.lblClidtnasc_Click_1);
            // 
            // lblCliuf
            // 
            this.lblCliuf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCliuf.AutoSize = true;
            this.lblCliuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCliuf.Image = global::Teste.Properties.Resources.estados_unidos;
            this.lblCliuf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCliuf.Location = new System.Drawing.Point(75, 237);
            this.lblCliuf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliuf.Name = "lblCliuf";
            this.lblCliuf.Size = new System.Drawing.Size(64, 25);
            this.lblCliuf.TabIndex = 56;
            this.lblCliuf.Text = "    UF:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Teste.Properties.Resources.endereco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(4, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 51);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // lblClitel
            // 
            this.lblClitel.AutoSize = true;
            this.lblClitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClitel.Image = global::Teste.Properties.Resources.telefone1;
            this.lblClitel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClitel.Location = new System.Drawing.Point(16, 139);
            this.lblClitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClitel.Name = "lblClitel";
            this.lblClitel.Size = new System.Drawing.Size(115, 25);
            this.lblClitel.TabIndex = 79;
            this.lblClitel.Text = "    Telefone:";
            // 
            // lblClisexo
            // 
            this.lblClisexo.AutoSize = true;
            this.lblClisexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClisexo.Image = global::Teste.Properties.Resources.sexos1;
            this.lblClisexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClisexo.Location = new System.Drawing.Point(44, 179);
            this.lblClisexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClisexo.Name = "lblClisexo";
            this.lblClisexo.Size = new System.Drawing.Size(84, 25);
            this.lblClisexo.TabIndex = 80;
            this.lblClisexo.Text = "    Sexo:";
            // 
            // lblCliemail
            // 
            this.lblCliemail.AutoSize = true;
            this.lblCliemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCliemail.Image = global::Teste.Properties.Resources.e_mail;
            this.lblCliemail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCliemail.Location = new System.Drawing.Point(35, 224);
            this.lblCliemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliemail.Name = "lblCliemail";
            this.lblCliemail.Size = new System.Drawing.Size(93, 25);
            this.lblCliemail.TabIndex = 81;
            this.lblCliemail.Text = "    E-mail:";
            // 
            // lblClisenha
            // 
            this.lblClisenha.AutoSize = true;
            this.lblClisenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClisenha.Image = global::Teste.Properties.Resources.senha;
            this.lblClisenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClisenha.Location = new System.Drawing.Point(32, 267);
            this.lblClisenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClisenha.Name = "lblClisenha";
            this.lblClisenha.Size = new System.Drawing.Size(96, 25);
            this.lblClisenha.TabIndex = 82;
            this.lblClisenha.Text = "    Senha:";
            // 
            // lblClinome
            // 
            this.lblClinome.AutoSize = true;
            this.lblClinome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClinome.Image = global::Teste.Properties.Resources.homem;
            this.lblClinome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClinome.Location = new System.Drawing.Point(38, 96);
            this.lblClinome.Name = "lblClinome";
            this.lblClinome.Size = new System.Drawing.Size(90, 25);
            this.lblClinome.TabIndex = 77;
            this.lblClinome.Text = "    Nome:";
            // 
            // btnCliDes
            // 
            this.btnCliDes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCliDes.AutoRoundedCorners = true;
            this.btnCliDes.BorderRadius = 21;
            this.btnCliDes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCliDes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCliDes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCliDes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCliDes.FillColor = System.Drawing.Color.LightPink;
            this.btnCliDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliDes.ForeColor = System.Drawing.Color.Black;
            this.btnCliDes.Image = global::Teste.Properties.Resources.fechar;
            this.btnCliDes.Location = new System.Drawing.Point(519, 468);
            this.btnCliDes.Name = "btnCliDes";
            this.btnCliDes.Size = new System.Drawing.Size(180, 45);
            this.btnCliDes.TabIndex = 92;
            this.btnCliDes.Text = "Desabilitar";
            this.btnCliDes.Click += new System.EventHandler(this.btnCliDes_Click_1);
            // 
            // btnClienteAlterar
            // 
            this.btnClienteAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClienteAlterar.AutoRoundedCorners = true;
            this.btnClienteAlterar.BorderRadius = 21;
            this.btnClienteAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClienteAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClienteAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClienteAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClienteAlterar.FillColor = System.Drawing.Color.LightPink;
            this.btnClienteAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnClienteAlterar.Image = global::Teste.Properties.Resources.interruptor;
            this.btnClienteAlterar.Location = new System.Drawing.Point(333, 468);
            this.btnClienteAlterar.Name = "btnClienteAlterar";
            this.btnClienteAlterar.Size = new System.Drawing.Size(180, 45);
            this.btnClienteAlterar.TabIndex = 85;
            this.btnClienteAlterar.Text = "Alterar";
            this.btnClienteAlterar.Click += new System.EventHandler(this.btnClienteAlterar_Click_1);
            // 
            // btnClienteCadastrar
            // 
            this.btnClienteCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClienteCadastrar.AutoRoundedCorners = true;
            this.btnClienteCadastrar.BorderRadius = 21;
            this.btnClienteCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClienteCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClienteCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClienteCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClienteCadastrar.FillColor = System.Drawing.Color.LightPink;
            this.btnClienteCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnClienteCadastrar.Image = global::Teste.Properties.Resources.verificar;
            this.btnClienteCadastrar.Location = new System.Drawing.Point(147, 468);
            this.btnClienteCadastrar.Name = "btnClienteCadastrar";
            this.btnClienteCadastrar.Size = new System.Drawing.Size(180, 45);
            this.btnClienteCadastrar.TabIndex = 84;
            this.btnClienteCadastrar.Text = "Cadastrar";
            this.btnClienteCadastrar.Click += new System.EventHandler(this.btnClienteCadastrar_Click_1);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.tabControl2);
            this.Name = "FrmCliente";
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tabControl2.ResumeLayout(false);
            this.tbpCadastraCliente.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.tbpConsultaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbpCadastraCliente;
        private System.Windows.Forms.Label lblClicidade;
        private System.Windows.Forms.Label lblCliuf;
        private System.Windows.Forms.Label lblClicomp;
        private System.Windows.Forms.Label lblCliend;
        private System.Windows.Forms.Label lblClibairro;
        private System.Windows.Forms.TabPage tbpConsultaCliente;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteComplem;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteEnd;
        private Guna.UI2.WinForms.Guna2ComboBox cbmClienteUf;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteCidade;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteBairro;
        private Guna.UI2.WinForms.Guna2Button btnClienteCadastrar;
        private Guna.UI2.WinForms.Guna2Button btnClienteAlterar;
        private Guna.UI2.WinForms.Guna2Button btnCliDes;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteEmail;
        private Guna.UI2.WinForms.Guna2ComboBox cbmClienteSexo;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteTel;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteNome;
        private Guna.UI2.WinForms.Guna2TextBox txtClienteCodigo;
        private System.Windows.Forms.Label lblClitel;
        private System.Windows.Forms.Label lblClisexo;
        private System.Windows.Forms.Label lblCliemail;
        private System.Windows.Forms.Label lblClisenha;
        private System.Windows.Forms.Label lblClicod;
        private System.Windows.Forms.Label lblClinome;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpClienteCadastro;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpClienteDtNasc;
        private System.Windows.Forms.Label lblClidtcadast;
        private System.Windows.Forms.Label lblClidtnasc;
        private System.Windows.Forms.DataGridView DgvListarClientes;
    }
}