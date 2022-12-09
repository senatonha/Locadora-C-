using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.Forms
{
    public partial class FrmDesativados : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        //Listar Locacao
        public void ListarTodasLoc()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_locacao = "select tb_locacao.TB_LOCACAO_ID as 'ID',\r\n        tb_locacao.TB_LOCACAO_TIPO as 'TIPO DE LOCAÇÃO',\r\n        tb_locacao.TB_LOCACAO_VALOR as 'VALOR',\r\n        tb_locacao.TB_LOCACAO_DT_INICIO as 'DATA DE INÍCIO',\r\n        tb_locacao.TB_LOCACAO_DT_FIM as 'DATA FINAL',\r\n        tb_cliente.TB_CLIENTE_NOME as 'NOME DO CLIENTE',\r\n        tb_funcionario.TB_FUNCIONARIO_NOME as 'NOME DO FUNCIONÁRIO',\r\n        tb_automovel.TB_AUTOMOVEL_NOME as 'NOME DO AUTOMÓVEL',\r\n        tb_locacao.TB_LOCACAO_STATUS as 'STATUS'\r\nfrom tb_locacao\r\ninner join tb_cliente\r\non tb_locacao.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID\r\ninner join tb_funcionario\r\non tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID\r\ninner join tb_automovel\r\non tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID\r\nwhere TB_LOCACAO_STATUS = 'INDISPONIVEL';";
            con.Open();

            MySqlCommand executaMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executaMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();

            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executaMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);

            dgvListarLoc.DataSource = tabela_locacao;
            con.Close();
        }

        //Listar todos os Cargos
        public void ListarTodosCargos()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_cargo = "select tb_cargo.TB_CARGO_ID as 'ID',\r\n       tb_cargo.TB_CARGO_NOME as 'NOME',\r\n       tb_cargo.tb_cargo_status as 'STATUS'\r\nfrom tb_cargo\r\nwhere tb_cargo.tb_cargo_status = 'INATIVO';";
            con.Open();
            MySqlCommand executaMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executaMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executaMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);

            DgvListarCargo.DataSource = tabela_cargo;
            con.Close();
        }

        //Listar todos os Clientes
        public void ListarTodosClientes()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_cliente = "select tb_cliente.TB_CLIENTE_ID as 'ID',\r\n       tb_cliente.TB_CLIENTE_NOME as 'NOME',\r\n       tb_cliente.TB_CLIENTE_TEL as 'TELEFONE',\r\n       tb_cliente.TB_CLIENTE_SEXO as 'SEXO',\r\n       tb_cliente.TB_CLIENTE_EMAIL as 'EMAIL',\r\n       tb_cliente.TB_CLIENTE_SENHA as 'SENHA',\r\n       tb_cliente.TB_CLIENTE_ENDERECO as 'ENDEREÇO',\r\n       tb_cliente.TB_CLIENTE_COMPLEMENTO as 'COMPLEMENTO',\r\n       tb_cliente.TB_CLIENTE_BAIRRO as 'BAIRRO',\r\n       tb_cliente.TB_CLIENTE_CIDADE as 'CIDADE',\r\n       tb_cliente.TB_CLIENTE_UF as 'UF',\r\n       tb_cliente.TB_CLIENTE_DT_NASC as 'DATA DE NASCIMENTO',\r\n       tb_cliente.TB_CLIENTE_DT_CAD  as 'DATA DE CADASTRO',\r\n       tb_cliente.TB_CLIENTE_STATUS as 'STATUS'\r\nfrom tb_cliente\r\nwhere tb_cliente.tb_cliente_status = 'DESABILITADO';";

            con.Open();
            MySqlCommand executaMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executaMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executaMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            DgvListarCliente.DataSource = tabela_cliente;
            con.Close();
        }

        //Listar todas as Marcas
        public void ListarTodasMarcas()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_marca = "select tb_marca.TB_MARCA_ID as 'ID',\r\n        tb_marca.TB_MARCA_NOME as 'MARCA',\r\n        tb_marca.tb_marca_status as 'STATUS'\r\nfrom tb_marca\r\nwhere tb_marca.tb_marca_status = 'DESABILITADO';";
            con.Open();

            MySqlCommand executaMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executaMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executaMySql_select_marca);
            da_marca.Fill(tabela_marca);

            DgvListarMarca.DataSource = tabela_marca;
            con.Close();
        }

        //Listar todos os Modelos
        public void ListarTodosModelos()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_modelo = "select tb_modelo.TB_MODELO_ID as 'ID',\r\n        tb_modelo.TB_MODELO_DESC as 'MODELO',\r\n        tb_modelo.tb_modelo_status as 'STATUS'\r\nfrom tb_modelo\r\nwhere tb_modelo.tb_modelo_status = 'INDISPONIVEL'";
            con.Open();

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            DgvListarModelo.DataSource = tabela_modelo;
            con.Close();
        }

        //Listar funcionarios
        public void ListarTodosFun()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_funcionario = "select tb_funcionario.TB_FUNCIONARIO_ID as 'ID',\r\n        tb_funcionario.TB_FUNCIONARIO_NOME as 'NOME',\r\n        tb_funcionario.TB_FUNCIONARIO_TEL as 'TELEFONE',\r\n        tb_funcionario.TB_FUNCIONARIO_STATUS as 'STATUS',\r\n        tb_funcionario.TB_FUNCIONARIO_DT_CONTRATO as 'DATA DE CONTRATO',\r\n        tb_cargo.TB_CARGO_NOME as 'CARGO'\r\nfrom tb_funcionario\r\ninner join tb_cargo\r\non tb_funcionario.TB_CARGO_ID = tb_cargo.TB_CARGO_ID\r\nwhere TB_FUNCIONARIO_STATUS = 'INATIVO';";
            con.Open();

            MySqlCommand executaMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executaMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executaMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            dgvListarFun.DataSource = tabela_funcionario;
            con.Close();
        }

        //Listar todos os Automóveis
        public void ListarTodosAuto()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_automovel = "select tb_automovel.TB_AUTOMOVEL_ID as 'ID',\r\n       tb_automovel.TB_AUTOMOVEL_NOME as 'NOME',\r\n       tb_automovel.TB_AUTOMOVEL_ANO_FAB as 'ANO DE FABRICAÇÃO',\r\n       tb_automovel.TB_AUTOMOVEL_COR as 'COR',\r\n       tb_automovel.TB_AUTOMOVEL_KM as 'KM',\r\n       tb_automovel.TB_AUTOMOVEL_VALOR_D as 'VALOR DO AUTOMÓVEL',\r\n       tb_automovel.TB_AUTOMOVEL_STATUS as 'STATUS',\r\n       tb_marca.TB_MARCA_NOME  as 'MARCA',\r\n       tb_modelo.TB_MODELO_DESC as 'MODELO'\r\nfrom tb_automovel\r\ninner join tb_marca\r\non tb_automovel.TB_MARCA_ID = tb_marca.TB_MARCA_ID\r\ninner join tb_modelo\r\non tb_automovel.TB_MODELO_ID = tb_modelo.TB_MODELO_ID\r\nwhere tb_automovel.TB_AUTOMOVEL_STATUS = 'INDISPONÍVEL'";
            con.Open();

            MySqlCommand executaMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executaMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();

            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executaMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            DgvListarAuto.DataSource = tabela_automovel;
            con.Close();
        }

        public FrmDesativados()
        {
            InitializeComponent();
        }


        //LOAD
        private void FrmDesativados_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            ListarTodosCargos();
            ListarTodosClientes();
            ListarTodasMarcas();
            ListarTodosModelos();
            ListarTodosAuto();
            ListarTodasLoc();
            ListarTodosFun();
        
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        //Habilitar automovel
        private void btnHabAuto_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtAutoCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_automovel = @"update tb_automovel
                                    set tb_automovel_status = 'DISPONÍVEL'
                                  where tb_automovel_id = @id";

            MySqlCommand executacmdMySql_update_automovel = new MySqlCommand(sql_update_automovel, con);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_automovel.ExecuteNonQuery();
            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();

            ListarTodosAuto();
            txtAutoCodigo.Clear();
        }


        //Habilitar Cargo
        private void btnHabCargo_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtCarCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cargo = @"update tb_cargo
                                    set tb_cargo_status = 'HABILITADO'
                                  where tb_cargo_id = @id";

            MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);
            executacmdMySql_update_cargo.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_cargo.ExecuteNonQuery();
            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();
            ListarTodosCargos();
            txtCarCodigo.Clear();
        }

        //Habilitar Cliente
        private void btnHabCli_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtCliCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cliente = @"update tb_cliente
                                    set tb_cliente_status = 'HABILITADO'
                                  where tb_cliente_id = @id";

            MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_cliente.ExecuteNonQuery();
            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();
            ListarTodosClientes();
            txtCliCodigo.Clear();
        }

        //Habilitar Marca
        private void btnHabMarca_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtMarCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_marca = @"update tb_marca
                                    set tb_marca_status = 'HABILITADO'
                                  where tb_marca_id = @id";

            MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);
            executacmdMySql_update_marca.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_marca.ExecuteNonQuery();
            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();
            ListarTodasMarcas();
            txtMarCodigo.Clear();
        }

        //Habilitar Modelo
        private void btnHabMo_Click_1(object sender, EventArgs e)
        {

            int codigo;

            codigo = int.Parse(txtMoCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_modelo = @"update tb_modelo
                                    set tb_modelo_status = 'DISPONIVEL'
                                  where tb_modelo_id = @id";

            MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);
            executacmdMySql_update_modelo.Parameters.AddWithValue("@id", codigo);

            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();
            ListarTodosModelos();
            txtMoCodigo.Clear();
        }
        
        //Habilitar locação
        private void BtnAtivarLoc_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtAtivarLoc.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_locacao = @"update tb_locacao
                                    set tb_locacao_status = 'DISPONIVEL'
                                  where tb_locacao_id = @id";

            MySqlCommand executacmdMySql_update_locacao = new MySqlCommand(sql_update_locacao, con);
            executacmdMySql_update_locacao.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_locacao.ExecuteNonQuery();
            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();
            ListarTodasLoc();
            txtAtivarLoc.Clear();
        }

        //Habilitar funcionário
        private void btnAtivarFun_Click_1(object sender, EventArgs e)
        {

            int codigo;

            codigo = int.Parse(txtHabFunc.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_funcionario = @"update tb_funcionario
                                    set tb_funcionario_status = 'HABILITADO'
                                  where tb_funcionario_id = @id";

            MySqlCommand executacmdMySql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_funcionario.ExecuteNonQuery();
            MessageBox.Show("Habilitado com sucesso!!!");
            con.Close();
            ListarTodosFun();
            txtHabFunc.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //Listar Cliente
        private void DgvListarCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCliCodigo.Text = DgvListarCliente.CurrentRow.Cells[0].Value.ToString();
        }

        //Listar Automovel
        private void DgvListarAuto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtAutoCodigo.Text = DgvListarAuto.CurrentRow.Cells[0].Value.ToString();
        }

        //Listar Cargo
        private void DgvListarCargo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCarCodigo.Text = DgvListarCargo.CurrentRow.Cells[0].Value.ToString();
        }

        //Listar Marca
        private void DgvListarMarca_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMarCodigo.Text = DgvListarMarca.CurrentRow.Cells[0].Value.ToString();
        }

        //Listar Modelo
        private void DgvListarModelo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMoCodigo.Text = DgvListarModelo.CurrentRow.Cells[0].Value.ToString();
        }

        //Listar Locacao
        private void dgvListarLoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtAtivarLoc.Text = dgvListarLoc.CurrentRow.Cells[0].Value.ToString();
        }

        //Listar funconario
        private void dgvListarFun_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtHabFunc.Text = dgvListarFun.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
