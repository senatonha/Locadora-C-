namespace Teste.Forms
{
    partial class FrmLocacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLocCod = new System.Windows.Forms.Label();
            this.dtpdtfim = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpdtinicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLocValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTipoLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLocCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbmLocAuto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbmLocFunc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLocCliente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DgvListarLoc = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblLocdtFim = new System.Windows.Forms.Label();
            this.lblLocValor = new System.Windows.Forms.Label();
            this.lblLocdtInicio = new System.Windows.Forms.Label();
            this.lblLocTipo = new System.Windows.Forms.Label();
            this.lblLocAuto = new System.Windows.Forms.Label();
            this.lblLocCliente = new System.Windows.Forms.Label();
            this.lblLocFunc = new System.Windows.Forms.Label();
            this.btnDesativarLocacao = new Guna.UI2.WinForms.Guna2Button();
            this.btnLocAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarLoc)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocCod
            // 
            this.lblLocCod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocCod.AutoSize = true;
            this.lblLocCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocCod.ForeColor = System.Drawing.Color.Black;
            this.lblLocCod.Location = new System.Drawing.Point(80, 4);
            this.lblLocCod.Name = "lblLocCod";
            this.lblLocCod.Size = new System.Drawing.Size(81, 25);
            this.lblLocCod.TabIndex = 106;
            this.lblLocCod.Text = "Código:";
            // 
            // dtpdtfim
            // 
            this.dtpdtfim.AutoRoundedCorners = true;
            this.dtpdtfim.BorderRadius = 17;
            this.dtpdtfim.Checked = true;
            this.dtpdtfim.FillColor = System.Drawing.Color.LightPink;
            this.dtpdtfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpdtfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdtfim.Location = new System.Drawing.Point(163, 182);
            this.dtpdtfim.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpdtfim.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpdtfim.Name = "dtpdtfim";
            this.dtpdtfim.Size = new System.Drawing.Size(206, 36);
            this.dtpdtfim.TabIndex = 131;
            this.dtpdtfim.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.dtpdtfim.Value = new System.DateTime(2022, 12, 1, 22, 22, 57, 716);
            // 
            // dtpdtinicio
            // 
            this.dtpdtinicio.AutoRoundedCorners = true;
            this.dtpdtinicio.BorderRadius = 17;
            this.dtpdtinicio.Checked = true;
            this.dtpdtinicio.FillColor = System.Drawing.Color.LightPink;
            this.dtpdtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpdtinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdtinicio.Location = new System.Drawing.Point(163, 139);
            this.dtpdtinicio.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpdtinicio.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpdtinicio.Name = "dtpdtinicio";
            this.dtpdtinicio.Size = new System.Drawing.Size(206, 36);
            this.dtpdtinicio.TabIndex = 129;
            this.dtpdtinicio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.dtpdtinicio.Value = new System.DateTime(2022, 12, 1, 22, 22, 57, 716);
            // 
            // txtLocValor
            // 
            this.txtLocValor.AutoRoundedCorners = true;
            this.txtLocValor.BorderRadius = 17;
            this.txtLocValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocValor.DefaultText = "";
            this.txtLocValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLocValor.ForeColor = System.Drawing.Color.Black;
            this.txtLocValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocValor.Location = new System.Drawing.Point(163, 97);
            this.txtLocValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLocValor.Name = "txtLocValor";
            this.txtLocValor.PasswordChar = '\0';
            this.txtLocValor.PlaceholderText = "";
            this.txtLocValor.SelectedText = "";
            this.txtLocValor.Size = new System.Drawing.Size(206, 36);
            this.txtLocValor.TabIndex = 130;
            // 
            // cmbTipoLoc
            // 
            this.cmbTipoLoc.AutoRoundedCorners = true;
            this.cmbTipoLoc.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoLoc.BorderRadius = 17;
            this.cmbTipoLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoLoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbTipoLoc.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoLoc.ItemHeight = 30;
            this.cmbTipoLoc.Items.AddRange(new object[] {
            "DIÁRIA",
            "SEMANAL",
            "MENSAL"});
            this.cmbTipoLoc.Location = new System.Drawing.Point(163, 46);
            this.cmbTipoLoc.Name = "cmbTipoLoc";
            this.cmbTipoLoc.Size = new System.Drawing.Size(206, 36);
            this.cmbTipoLoc.TabIndex = 129;
            // 
            // txtLocCodigo
            // 
            this.txtLocCodigo.AutoRoundedCorners = true;
            this.txtLocCodigo.BorderRadius = 17;
            this.txtLocCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocCodigo.DefaultText = "";
            this.txtLocCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLocCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtLocCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocCodigo.Location = new System.Drawing.Point(163, 4);
            this.txtLocCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLocCodigo.Name = "txtLocCodigo";
            this.txtLocCodigo.PasswordChar = '\0';
            this.txtLocCodigo.PlaceholderText = "";
            this.txtLocCodigo.SelectedText = "";
            this.txtLocCodigo.Size = new System.Drawing.Size(206, 36);
            this.txtLocCodigo.TabIndex = 129;
            // 
            // cbmLocAuto
            // 
            this.cbmLocAuto.AutoRoundedCorners = true;
            this.cbmLocAuto.BackColor = System.Drawing.Color.Transparent;
            this.cbmLocAuto.BorderRadius = 17;
            this.cbmLocAuto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmLocAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmLocAuto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmLocAuto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmLocAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmLocAuto.ForeColor = System.Drawing.Color.Black;
            this.cbmLocAuto.ItemHeight = 30;
            this.cbmLocAuto.Items.AddRange(new object[] {
            "DISPONÍVEL",
            "INDISPONÍVEL"});
            this.cbmLocAuto.Location = new System.Drawing.Point(150, 119);
            this.cbmLocAuto.Name = "cbmLocAuto";
            this.cbmLocAuto.Size = new System.Drawing.Size(206, 36);
            this.cbmLocAuto.TabIndex = 134;
            this.cbmLocAuto.SelectedIndexChanged += new System.EventHandler(this.cbmLocAuto_SelectedIndexChanged);
            // 
            // cbmLocFunc
            // 
            this.cbmLocFunc.AutoRoundedCorners = true;
            this.cbmLocFunc.BackColor = System.Drawing.Color.Transparent;
            this.cbmLocFunc.BorderRadius = 17;
            this.cbmLocFunc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmLocFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmLocFunc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmLocFunc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmLocFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmLocFunc.ForeColor = System.Drawing.Color.Black;
            this.cbmLocFunc.ItemHeight = 30;
            this.cbmLocFunc.Items.AddRange(new object[] {
            "DISPONÍVEL",
            "INDISPONÍVEL"});
            this.cbmLocFunc.Location = new System.Drawing.Point(150, 63);
            this.cbmLocFunc.Name = "cbmLocFunc";
            this.cbmLocFunc.Size = new System.Drawing.Size(206, 36);
            this.cbmLocFunc.TabIndex = 133;
            // 
            // cmbLocCliente
            // 
            this.cmbLocCliente.AutoRoundedCorners = true;
            this.cmbLocCliente.BackColor = System.Drawing.Color.Transparent;
            this.cmbLocCliente.BorderRadius = 17;
            this.cmbLocCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLocCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocCliente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLocCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLocCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbLocCliente.ItemHeight = 30;
            this.cmbLocCliente.Items.AddRange(new object[] {
            "DISPONÍVEL",
            "INDISPONÍVEL"});
            this.cmbLocCliente.Location = new System.Drawing.Point(149, 10);
            this.cmbLocCliente.Name = "cmbLocCliente";
            this.cmbLocCliente.Size = new System.Drawing.Size(206, 36);
            this.cmbLocCliente.TabIndex = 132;
            // 
            // DgvListarLoc
            // 
            this.DgvListarLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListarLoc.BackgroundColor = System.Drawing.Color.White;
            this.DgvListarLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(209)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListarLoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListarLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListarLoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListarLoc.EnableHeadersVisualStyles = false;
            this.DgvListarLoc.GridColor = System.Drawing.Color.Pink;
            this.DgvListarLoc.Location = new System.Drawing.Point(417, 75);
            this.DgvListarLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListarLoc.Name = "DgvListarLoc";
            this.DgvListarLoc.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvListarLoc.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListarLoc.RowTemplate.Height = 28;
            this.DgvListarLoc.Size = new System.Drawing.Size(406, 455);
            this.DgvListarLoc.TabIndex = 133;
            this.DgvListarLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarLoc_CellClick_1);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox1.Controls.Add(this.cbmLocAuto);
            this.guna2GroupBox1.Controls.Add(this.cbmLocFunc);
            this.guna2GroupBox1.Controls.Add(this.lblLocAuto);
            this.guna2GroupBox1.Controls.Add(this.cmbLocCliente);
            this.guna2GroupBox1.Controls.Add(this.lblLocCliente);
            this.guna2GroupBox1.Controls.Add(this.lblLocFunc);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 306);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(392, 173);
            this.guna2GroupBox1.TabIndex = 134;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Pink;
            this.guna2GroupBox2.Controls.Add(this.dtpdtfim);
            this.guna2GroupBox2.Controls.Add(this.dtpdtinicio);
            this.guna2GroupBox2.Controls.Add(this.lblLocdtFim);
            this.guna2GroupBox2.Controls.Add(this.txtLocValor);
            this.guna2GroupBox2.Controls.Add(this.lblLocValor);
            this.guna2GroupBox2.Controls.Add(this.cmbTipoLoc);
            this.guna2GroupBox2.Controls.Add(this.lblLocdtInicio);
            this.guna2GroupBox2.Controls.Add(this.txtLocCodigo);
            this.guna2GroupBox2.Controls.Add(this.lblLocCod);
            this.guna2GroupBox2.Controls.Add(this.lblLocTipo);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(9, 75);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(392, 225);
            this.guna2GroupBox2.TabIndex = 135;
            // 
            // lblLocdtFim
            // 
            this.lblLocdtFim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocdtFim.AutoSize = true;
            this.lblLocdtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocdtFim.ForeColor = System.Drawing.Color.Black;
            this.lblLocdtFim.Image = global::Teste.Properties.Resources.final_de_semana;
            this.lblLocdtFim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocdtFim.Location = new System.Drawing.Point(35, 182);
            this.lblLocdtFim.Name = "lblLocdtFim";
            this.lblLocdtFim.Size = new System.Drawing.Size(126, 25);
            this.lblLocdtFim.TabIndex = 116;
            this.lblLocdtFim.Text = "    Data Final:";
            // 
            // lblLocValor
            // 
            this.lblLocValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocValor.AutoSize = true;
            this.lblLocValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocValor.ForeColor = System.Drawing.Color.Black;
            this.lblLocValor.Image = global::Teste.Properties.Resources.simbolo_de_preco;
            this.lblLocValor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocValor.Location = new System.Drawing.Point(77, 97);
            this.lblLocValor.Name = "lblLocValor";
            this.lblLocValor.Size = new System.Drawing.Size(84, 25);
            this.lblLocValor.TabIndex = 115;
            this.lblLocValor.Text = "    Valor:";
            // 
            // lblLocdtInicio
            // 
            this.lblLocdtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocdtInicio.AutoSize = true;
            this.lblLocdtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocdtInicio.ForeColor = System.Drawing.Color.Black;
            this.lblLocdtInicio.Image = global::Teste.Properties.Resources.calendario__2_;
            this.lblLocdtInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocdtInicio.Location = new System.Drawing.Point(5, 139);
            this.lblLocdtInicio.Name = "lblLocdtInicio";
            this.lblLocdtInicio.Size = new System.Drawing.Size(156, 25);
            this.lblLocdtInicio.TabIndex = 114;
            this.lblLocdtInicio.Text = "    Data de Inicio:";
            // 
            // lblLocTipo
            // 
            this.lblLocTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocTipo.AutoSize = true;
            this.lblLocTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocTipo.ForeColor = System.Drawing.Color.Black;
            this.lblLocTipo.Image = global::Teste.Properties.Resources.carro__1_1;
            this.lblLocTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocTipo.Location = new System.Drawing.Point(84, 46);
            this.lblLocTipo.Name = "lblLocTipo";
            this.lblLocTipo.Size = new System.Drawing.Size(77, 25);
            this.lblLocTipo.TabIndex = 105;
            this.lblLocTipo.Text = "    Tipo:";
            // 
            // lblLocAuto
            // 
            this.lblLocAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocAuto.AutoSize = true;
            this.lblLocAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocAuto.ForeColor = System.Drawing.Color.Black;
            this.lblLocAuto.Image = global::Teste.Properties.Resources.chave_do_carro__2_;
            this.lblLocAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocAuto.Location = new System.Drawing.Point(10, 119);
            this.lblLocAuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocAuto.Name = "lblLocAuto";
            this.lblLocAuto.Size = new System.Drawing.Size(131, 25);
            this.lblLocAuto.TabIndex = 119;
            this.lblLocAuto.Text = "    Automóvel:";
            this.lblLocAuto.Click += new System.EventHandler(this.lblLocAuto_Click);
            // 
            // lblLocCliente
            // 
            this.lblLocCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocCliente.AutoSize = true;
            this.lblLocCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblLocCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocCliente.ForeColor = System.Drawing.Color.Black;
            this.lblLocCliente.Image = global::Teste.Properties.Resources.homem;
            this.lblLocCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocCliente.Location = new System.Drawing.Point(40, 10);
            this.lblLocCliente.Name = "lblLocCliente";
            this.lblLocCliente.Size = new System.Drawing.Size(99, 25);
            this.lblLocCliente.TabIndex = 117;
            this.lblLocCliente.Text = "    Cliente:";
            // 
            // lblLocFunc
            // 
            this.lblLocFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocFunc.AutoSize = true;
            this.lblLocFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblLocFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLocFunc.ForeColor = System.Drawing.Color.Black;
            this.lblLocFunc.Image = global::Teste.Properties.Resources.carteira_de_identidade__1_;
            this.lblLocFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocFunc.Location = new System.Drawing.Point(1, 63);
            this.lblLocFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocFunc.Name = "lblLocFunc";
            this.lblLocFunc.Size = new System.Drawing.Size(140, 25);
            this.lblLocFunc.TabIndex = 112;
            this.lblLocFunc.Text = "    Funcionário:";
            // 
            // btnDesativarLocacao
            // 
            this.btnDesativarLocacao.AutoRoundedCorners = true;
            this.btnDesativarLocacao.BorderRadius = 21;
            this.btnDesativarLocacao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDesativarLocacao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDesativarLocacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDesativarLocacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDesativarLocacao.FillColor = System.Drawing.Color.LightPink;
            this.btnDesativarLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativarLocacao.ForeColor = System.Drawing.Color.Black;
            this.btnDesativarLocacao.Image = global::Teste.Properties.Resources.fechar;
            this.btnDesativarLocacao.Location = new System.Drawing.Point(107, 536);
            this.btnDesativarLocacao.Name = "btnDesativarLocacao";
            this.btnDesativarLocacao.Size = new System.Drawing.Size(180, 45);
            this.btnDesativarLocacao.TabIndex = 131;
            this.btnDesativarLocacao.Text = "Desabilitar";
            this.btnDesativarLocacao.Click += new System.EventHandler(this.btnDesativarLocacao_Click_1);
            // 
            // btnLocAlterar
            // 
            this.btnLocAlterar.AutoRoundedCorners = true;
            this.btnLocAlterar.BorderRadius = 21;
            this.btnLocAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocAlterar.FillColor = System.Drawing.Color.LightPink;
            this.btnLocAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnLocAlterar.Image = global::Teste.Properties.Resources.interruptor;
            this.btnLocAlterar.Location = new System.Drawing.Point(195, 485);
            this.btnLocAlterar.Name = "btnLocAlterar";
            this.btnLocAlterar.Size = new System.Drawing.Size(180, 45);
            this.btnLocAlterar.TabIndex = 130;
            this.btnLocAlterar.Text = "Alterar";
            this.btnLocAlterar.Click += new System.EventHandler(this.btnLocAlterar_Click_1);
            // 
            // btnLoCadastrar
            // 
            this.btnLoCadastrar.AutoRoundedCorners = true;
            this.btnLoCadastrar.BorderRadius = 21;
            this.btnLoCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoCadastrar.FillColor = System.Drawing.Color.LightPink;
            this.btnLoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnLoCadastrar.Image = global::Teste.Properties.Resources.verificar;
            this.btnLoCadastrar.Location = new System.Drawing.Point(9, 485);
            this.btnLoCadastrar.Name = "btnLoCadastrar";
            this.btnLoCadastrar.Size = new System.Drawing.Size(180, 45);
            this.btnLoCadastrar.TabIndex = 129;
            this.btnLoCadastrar.Text = "Cadastrar";
            this.btnLoCadastrar.Click += new System.EventHandler(this.btnLoCadastrar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Teste.Properties.Resources.locacao__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 69);
            this.panel1.TabIndex = 126;
            // 
            // FrmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 563);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.DgvListarLoc);
            this.Controls.Add(this.btnDesativarLocacao);
            this.Controls.Add(this.btnLocAlterar);
            this.Controls.Add(this.btnLoCadastrar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLocacao";
            this.Text = "LOCAÇÃO";
            this.Load += new System.EventHandler(this.FrmLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarLoc)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLocAuto;
        private System.Windows.Forms.Label lblLocCliente;
        private System.Windows.Forms.Label lblLocdtFim;
        private System.Windows.Forms.Label lblLocValor;
        private System.Windows.Forms.Label lblLocdtInicio;
        private System.Windows.Forms.Label lblLocFunc;
        private System.Windows.Forms.Label lblLocCod;
        private System.Windows.Forms.Label lblLocTipo;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLocCodigo;
        private Guna.UI2.WinForms.Guna2TextBox txtLocValor;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoLoc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpdtfim;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpdtinicio;
        private Guna.UI2.WinForms.Guna2ComboBox cbmLocAuto;
        private Guna.UI2.WinForms.Guna2ComboBox cbmLocFunc;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLocCliente;
        private Guna.UI2.WinForms.Guna2Button btnDesativarLocacao;
        private Guna.UI2.WinForms.Guna2Button btnLocAlterar;
        private Guna.UI2.WinForms.Guna2Button btnLoCadastrar;
        private System.Windows.Forms.DataGridView DgvListarLoc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}