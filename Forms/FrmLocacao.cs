using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.Forms
{
    public partial class FrmLocacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmLocacao()
        {
            InitializeComponent();
        }
        //Listar todas as Locações
        public void ListarTodasLoc()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_locacao = "select tb_locacao.TB_LOCACAO_ID as 'ID',\r\n        tb_locacao.TB_LOCACAO_TIPO as 'TIPO DE LOCAÇÃO',\r\n        tb_locacao.TB_LOCACAO_VALOR as 'VALOR',\r\n        tb_locacao.TB_LOCACAO_DT_INICIO as 'DATA DE INÍCIO',\r\n        tb_locacao.TB_LOCACAO_DT_FIM as 'DATA FINAL',\r\n        tb_cliente.TB_CLIENTE_NOME as 'NOME DO CLIENTE',\r\n        tb_funcionario.TB_FUNCIONARIO_NOME as 'NOME DO FUNCIONÁRIO',\r\n        tb_automovel.TB_AUTOMOVEL_NOME as 'NOME DO AUTOMÓVEL',\r\n        tb_locacao.TB_LOCACAO_STATUS as 'STATUS'\r\nfrom tb_locacao\r\ninner join tb_cliente\r\non tb_locacao.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID\r\ninner join tb_funcionario\r\non tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID\r\ninner join tb_automovel\r\non tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID\r\nwhere TB_LOCACAO_STATUS = 'DISPONIVEL';";
            con.Open();

            MySqlCommand executaMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executaMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();

            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executaMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);

            DgvListarLoc.DataSource = tabela_locacao;
            con.Close();
        }


        //Listar as chaves estrangeiras da tabela Cliente na tabela Locação
        public void ChaveEstrangCli()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_cliente = "select * from tb_cliente where tb_cliente_status = 'HABILITADO'";
            con.Open();

            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            cmbLocCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocCliente.DataSource = tabela_cliente;
            cmbLocCliente.ValueMember = "tb_cliente_id";
            cmbLocCliente.DisplayMember = "tb_cliente_nome";
            cmbLocCliente.SelectedItem = null;
            con.Close();
        }


        //Listar as chaves estrangeiras da tabela Funcionário na tabela Locação
        public void ChaveEstrangFunc()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_funcionario = "select * from tb_funcionario where tb_funcionario_status = 'HABILITADO'";
            con.Open();

            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            cbmLocFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmLocFunc.DataSource = tabela_funcionario;
            cbmLocFunc.ValueMember = "tb_funcionario_id";
            cbmLocFunc.DisplayMember = "tb_funcionario_nome";
            cbmLocFunc.SelectedItem = null;
            con.Close();
        }


        //Listar as chaves estrangeiras da tabela Automóvel na tabela Locação
        public void ChaveEstrangAuto()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_automovel = "select * from tb_automovel where tb_automovel_status = 'DISPONIVEL'";
            con.Open();

            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();

            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            cbmLocAuto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmLocAuto.DataSource = tabela_automovel;
            cbmLocAuto.ValueMember = "tb_automovel_id";
            cbmLocAuto.DisplayMember = "tb_automovel_nome";
            cbmLocAuto.SelectedItem = null;
            con.Close();
        }

        //LOAD
        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            ListarTodasLoc();
            ChaveEstrangCli();
            ChaveEstrangFunc();
            ChaveEstrangAuto();
        }

        //Cadastrar locação
        private void btnLoCadastrar_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {

                string tipo;
                decimal valord;
                int cliente, funcionario, automovel;
                DateTime dt_inicio, dt_fim;


                tipo = cmbTipoLoc.Text;
                cliente = int.Parse(cmbLocCliente.SelectedValue.ToString());
                funcionario = int.Parse(cbmLocFunc.SelectedValue.ToString());
                automovel = int.Parse(cbmLocAuto.SelectedValue.ToString());
                valord = decimal.Parse(txtLocValor.Text);
                dt_inicio = Convert.ToDateTime(dtpdtinicio.Text);
                dt_fim = Convert.ToDateTime(dtpdtfim.Text);


                string sql_insert = @"insert into tb_locacao
                                    (
                                      tb_locacao_tipo, 
                                      tb_locacao_valor, 
                                      tb_locacao_dt_inicio, 
                                      tb_locacao_dt_fim, 
                                      tb_cliente_id, 
                                      tb_funcionario_id, 
                                      tb_automovel_id 
                                    )
                                      values
                                    (
                                      @tb_locacao_tipo,
                                      @tb_locacao_valor,
                                      @tb_locacao_dt_inicio,
                                      @tb_locacao_dt_fim,
                                      @tb_cliente_id,
                                      @tb_funcionario_id,
                                      @tb_automovel_id
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@tb_locacao_tipo", tipo);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_locacao_valor", valord);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_locacao_dt_inicio", dt_inicio);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_locacao_dt_fim", dt_fim);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_cliente_id", cliente);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_funcionario_id", funcionario);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_id", automovel);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!!!");

                ListarTodasLoc();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }

            cmbLocCliente.Focus();
            txtLocValor.Clear();
            cmbTipoLoc.SelectedItem = null;
            cmbLocCliente.SelectedItem = null;
            cbmLocFunc.SelectedItem = null;
            cmbLocCliente.SelectedItem = null;
            cbmLocAuto.SelectedItem = null;

        }

        //Alterar locação
        private void btnLocAlterar_Click_1(object sender, EventArgs e)
        {
            string tipo;
            decimal valord;
            int codigo, cliente, funcionario, automovel;
            DateTime dt_inicio, dt_fim;

            codigo = int.Parse(txtLocCodigo.Text);
            tipo = cmbTipoLoc.Text;
            cliente = int.Parse(cmbLocCliente.SelectedValue.ToString());
            funcionario = int.Parse(cbmLocFunc.SelectedValue.ToString());
            automovel = int.Parse(cbmLocAuto.SelectedValue.ToString());
            valord = decimal.Parse(txtLocValor.Text);
            dt_inicio = Convert.ToDateTime(dtpdtinicio.Text);
            dt_fim = Convert.ToDateTime(dtpdtfim.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_locacao = @"update tb_locacao 
                                  set tb_locacao_tipo = @tipo,
                                      tb_locacao_valor = @valord,
                                      tb_locacao_dt_inicio = @inicio, 
                                      tb_locacao_dt_fim = @fim, 
                                      tb_cliente_id = @cliente,
                                      tb_funcionario_id = @func ,
                                      tb_automovel_id = @automovel
                                where tb_locacao_id = @id";

            MySqlCommand executacmdMySql_update_locacao = new MySqlCommand(sql_update_locacao, con);

            executacmdMySql_update_locacao.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@tipo", tipo);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@valord", valord);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@inicio", dt_inicio);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@fim", dt_fim);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@cliente", cliente);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@func", funcionario);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@automovel", automovel);

            executacmdMySql_update_locacao.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso!!!");
            ListarTodasLoc();
            ChaveEstrangCli();
            ChaveEstrangFunc();
            ChaveEstrangAuto();
            con.Close();


            cmbLocCliente.Focus();
            txtLocCodigo.Clear();
            txtLocValor.Clear();
            cmbTipoLoc.SelectedItem = null;
            cmbLocCliente.SelectedItem = null;
            cbmLocFunc.SelectedItem = null;
            cmbLocCliente.SelectedItem = null;
            cbmLocAuto.SelectedItem = null;
        }

        //Desabilitar
        private void btnDesativarLocacao_Click_1(object sender, EventArgs e)
        {

            int codigo;

            codigo = int.Parse(txtLocCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_locacao = @"update tb_locacao
                                 set tb_locacao_status = 'INDISPONIVEL'
                               where tb_locacao_id = @id";

            MySqlCommand executacmdMySql_update_locacao = new MySqlCommand(sql_update_locacao, con);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@id", codigo);


            executacmdMySql_update_locacao.ExecuteNonQuery();

            MessageBox.Show("Desabilitado com sucesso!!");
            con.Close();

            ListarTodasLoc();
            txtLocCodigo.Clear();
            cmbLocCliente.Focus();
            txtLocValor.Clear();
            cmbTipoLoc.SelectedItem = null;
            cmbLocCliente.SelectedItem = null;
            cbmLocFunc.SelectedItem = null;
            cmbLocCliente.SelectedItem = null;
            cbmLocAuto.SelectedItem = null;
        }

        //Listar locações
        private void DgvListarLoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtLocCodigo.Text = DgvListarLoc.CurrentRow.Cells[0].Value.ToString();
            cmbTipoLoc.Text = DgvListarLoc.CurrentRow.Cells[1].Value.ToString();
            txtLocValor.Text = DgvListarLoc.CurrentRow.Cells[2].Value.ToString();
            dtpdtinicio.Text = DgvListarLoc.CurrentRow.Cells[3].Value.ToString();
            dtpdtfim.Text = DgvListarLoc.CurrentRow.Cells[4].Value.ToString();
            cmbLocCliente.Text = DgvListarLoc.CurrentRow.Cells[5].Value.ToString();
            cbmLocFunc.Text = DgvListarLoc.CurrentRow.Cells[6].Value.ToString();
            cbmLocAuto.Text = DgvListarLoc.CurrentRow.Cells[7].Value.ToString();
        }

        private void lblLocAuto_Click(object sender, EventArgs e)
        {

        }

        private void cbmLocAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
