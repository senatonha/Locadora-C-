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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Teste.Forms
{
    public partial class FrmFuncionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        //Listar todos os Cargos
        public void ListarTodosCargos()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_cargo = "select tb_cargo.TB_CARGO_ID as 'ID',\r\n       tb_cargo.TB_CARGO_NOME as 'NOME',\r\n       tb_cargo.tb_cargo_status as 'STATUS'\r\nfrom tb_cargo\r\nwhere tb_cargo.tb_cargo_status = 'HABILITADO';";
            con.Open();
            MySqlCommand executaMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executaMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executaMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);

            DgvListarCargo.DataSource = tabela_cargo;
            con.Close();
        }


        //Listar todos os Funcionários
        public void ListarTodosFunc()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_funcionario = "select tb_funcionario.TB_FUNCIONARIO_ID as 'ID',\r\n       tb_funcionario.TB_FUNCIONARIO_NOME as 'NOME',\r\n        tb_funcionario.TB_FUNCIONARIO_TEL as 'TELEFONE',\r\n        tb_funcionario.TB_FUNCIONARIO_STATUS as 'STATUS',\r\n        tb_funcionario.TB_FUNCIONARIO_DT_CONTRATO as 'DATA DE CONTRATO',\r\n        tb_cargo.TB_CARGO_NOME as 'CARGO'\r\nfrom tb_funcionario\r\ninner join tb_cargo\r\non tb_funcionario.TB_CARGO_ID = tb_cargo.TB_CARGO_ID\r\nwhere TB_FUNCIONARIO_STATUS = 'HABILITADO';";
           
            con.Open();
            MySqlCommand executaMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executaMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();
            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executaMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            DgvListarFunc.DataSource = tabela_funcionario;
            con.Close();
        }


        //Listar as chaves estrangeiras da tabela Cargo na tabela Funcionário
        public void ChaveEstrangFunc()
        {
            MySqlConnection con = new MySqlConnection(conexao);


            string sql_select_cargo = "select * from tb_cargo where tb_cargo_status = 'HABILITADO'";
            con.Open();
            MySqlCommand executaMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executaMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executaMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);

            cbFuncCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuncCargo.DataSource = tabela_cargo;
            cbFuncCargo.ValueMember = "tb_cargo_id";
            cbFuncCargo.DisplayMember = "tb_cargo_nome";
            cbFuncCargo.SelectedItem = null;
            con.Close();
        }


        public FrmFuncionario()
        {
            InitializeComponent();
        }

        //LOAD
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
           //InitializeComponent();
            //MySqlConnection con = new MySqlConnection(conexao);
            ListarTodosCargos();
            ListarTodosFunc();
            ChaveEstrangFunc();
        
        }

        //Cadastrar funcionario
        private void btnFunCadastro_Click_1(object sender, EventArgs e)
        {
            //CodigosGerais c = new CodigosGerais();
            //if (c.CampoVazio(txtFuncNome, "Nome do funcionário"))
            //    return;
            //CodigosGerais c1 = new CodigosGerais();
            //if (c1.CampoVazio(txtFuncTelefone, "Telefone do funcionário"))
            //    return;
            //CodigosGerais c2 = new CodigosGerais();
            //if (c2.CampoVazio(dtpFuncContrato, "Data de contrato"))
            //    return;
            //CodigosGerais c3 = new CodigosGerais();
            //if (c3.CampoVazio(cbFuncCargo, "Cargo do funcionário"))
            //    return;

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, telefone;
                int cargo;
                DateTime data_cont;

                nome = txtFuncNome.Text;
                telefone = txtFuncTelefone.Text;
                data_cont = Convert.ToDateTime(dtpFuncContrato.Text);
                cargo = int.Parse(cbFuncCargo.SelectedValue.ToString());


                string sql_insert = @"insert into tb_funcionario
                                    (
                                    tb_funcionario_nome,  
                                    tb_funcionario_tel,  
                                    tb_funcionario_dt_contrato, 
                                    tb_cargo_id
                                    )
                                      values
                                    (
                                      @tb_funcionario_nome,
                                      @tb_funcionario_tel,
                                      @tb_funcionario_dt_contrato,
                                      @tb_cargo_id
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@tb_funcionario_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_funcionario_tel", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_funcionario_dt_contrato", data_cont);
                executacmdMySql_insert.Parameters.AddWithValue("@tb_cargo_id", cargo);

                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!!!");

                ListarTodosFunc();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }

            txtFuncNome.Clear();
            txtFuncNome.Focus();
            txtFuncTelefone.Clear();
            dtpFuncContrato.Text = String.Empty;
            cbFuncCargo.SelectedItem = null;

        }

        //Alterar funcionario
        private void btnFunAlterar_Click_1(object sender, EventArgs e)
        {
            int codigo, cargo;
            string nome, telefone;
            DateTime data_cont;

            codigo = int.Parse(txtFunCodigo.Text);
            nome = txtFuncNome.Text;
            telefone = txtFuncTelefone.Text;
            data_cont = Convert.ToDateTime(dtpFuncContrato.Text);

            cargo = int.Parse(cbFuncCargo.SelectedValue.ToString());


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_funcionario = @"update tb_funcionario
               set tb_funcionario_nome = @nome,  
                                    tb_funcionario_tel = @telefone,  
                                    tb_funcionario_dt_contrato = @data_cont,
                                    tb_cargo_id = @cargo
            where tb_funcionario_id = @id";


            MySqlCommand executacmdMySql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

            executacmdMySql_update_funcionario.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@telefone", telefone);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@data_cont", data_cont);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@cargo", cargo);



            executacmdMySql_update_funcionario.ExecuteNonQuery();

            MessageBox.Show("Atualizado com sucesso com sucesso!!");
            ListarTodosFunc();
            con.Close();

            txtFunCodigo.Clear();
            txtFuncNome.Clear();
            txtFuncNome.Focus();
            txtFuncTelefone.Clear();
            dtpFuncContrato.Text = String.Empty;
            cbFuncCargo.SelectedItem = null;
        }

        //Desativar funcionario
        private void btnDesativarFun_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtFunCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_funcionario = @"update tb_funcionario
                                 set tb_funcionario_status = 'INATIVO'
                               where tb_funcionario_id = @id";

            MySqlCommand executacmdMySql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);
            executacmdMySql_update_funcionario.Parameters.AddWithValue("@id", codigo);


            executacmdMySql_update_funcionario.ExecuteNonQuery();

            MessageBox.Show("Desabilitado com sucesso!!");
            con.Close();

            ListarTodosFunc();

            txtFunCodigo.Clear();
            txtFuncNome.Clear();
            txtFuncNome.Focus();
            txtFuncTelefone.Clear();
            dtpFuncContrato.Text = String.Empty;
            cbFuncCargo.SelectedItem = null;
        }

        //Cadastrar cargo
        private void btnCargoCadastrar_Click_1(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                nome = txtCargoNome.Text;


                string sql_insert = @"insert into tb_cargo
                                    (
                                       tb_cargo_nome
                                    )
                                       values 
                                    (
                                       @tb_cargo_nome
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@tb_cargo_nome", nome);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!!!");
                ListarTodosCargos();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }

            txtCargoNome.Clear();
            txtCargoNome.Focus();
        }

        //Alterar cargo
        private void btnCargoAlterar_Click_1(object sender, EventArgs e)
        {
            int codigo;
            string nome;

            codigo = int.Parse(txtCargoCodigo.Text);
            nome = txtCargoNome.Text;

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cargo = @"update tb_cargo
                                        set tb_cargo_nome = @tb_cargo_nome
                                        where tb_cargo_id = @id";

            MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

            executacmdMySql_update_cargo.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_cargo.Parameters.AddWithValue("@tb_cargo_nome", nome);

            executacmdMySql_update_cargo.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Alterado com sucesso!!!");

            ListarTodosCargos();

            txtCargoCodigo.Clear();
            txtCargoNome.Clear();
            txtCargoNome.Focus();
        }

        //Desabilitar cargo
        private void btnCarDes_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtCargoCodigo.Text);


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cargo = @"update tb_cargo
                                 set tb_cargo_status = 'INATIVO'
                               where tb_cargo_id = @id";

            MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

            executacmdMySql_update_cargo.Parameters.AddWithValue("@id", codigo);


            executacmdMySql_update_cargo.ExecuteNonQuery();

            MessageBox.Show("Desabilitado com sucesso!!");
            ListarTodosCargos();
            con.Close();


            txtCargoNome.Clear();
            txtCargoNome.Focus();
            txtCargoCodigo.Clear();
        }

        private void lblFunCargo_Click(object sender, EventArgs e)
        {

        }

        //Cell Click Listar Funcionario
        private void DgvListarFunc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFunCodigo.Text = DgvListarFunc.CurrentRow.Cells[0].Value.ToString();
                txtFuncNome.Text = DgvListarFunc.CurrentRow.Cells[1].Value.ToString();
                txtFuncTelefone.Text = DgvListarFunc.CurrentRow.Cells[2].Value.ToString();
                dtpFuncContrato.Text = DgvListarFunc.CurrentRow.Cells[4].Value.ToString();
                cbFuncCargo.Text = DgvListarFunc.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }
        }

        //Cell Click Listar  Cargo
        private void DgvListarCargo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCargoCodigo.Text = DgvListarCargo.CurrentRow.Cells[0].Value.ToString();
                txtCargoNome.Text = DgvListarCargo.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }
        }

        private void FrmFuncioCad_Click(object sender, EventArgs e)
        {

        }
    }
}
