using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste.Forms
{
    public partial class FrmCliente : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;


        //Listar todos os Clientes
        public void ListarTodosClientes()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_cliente = "select tb_cliente.TB_CLIENTE_ID as 'ID',\r\n       tb_cliente.TB_CLIENTE_NOME as 'NOME',\r\n       tb_cliente.TB_CLIENTE_TEL as 'TELEFONE',\r\n       tb_cliente.TB_CLIENTE_SEXO as 'SEXO',\r\n       tb_cliente.TB_CLIENTE_EMAIL as 'EMAIL',\r\n       tb_cliente.TB_CLIENTE_SENHA as 'SENHA',\r\n       tb_cliente.TB_CLIENTE_ENDERECO as 'ENDEREÇO',\r\n       tb_cliente.TB_CLIENTE_COMPLEMENTO as 'COMPLEMENTO',\r\n       tb_cliente.TB_CLIENTE_BAIRRO as 'BAIRRO',\r\n       tb_cliente.TB_CLIENTE_CIDADE as 'CIDADE',\r\n       tb_cliente.TB_CLIENTE_UF as 'UF',\r\n       tb_cliente.TB_CLIENTE_DT_NASC as 'DATA DE NASCIMENTO',\r\n       tb_cliente.TB_CLIENTE_DT_CAD  as 'DATA DE CADASTRO',\r\n       tb_cliente.TB_CLIENTE_STATUS as 'STATUS'\r\nfrom tb_cliente\r\nwhere tb_cliente.tb_cliente_status = 'HABILITADO';";

            con.Open();
            MySqlCommand executaMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executaMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executaMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            DgvListarClientes.DataSource = tabela_cliente;
            con.Close();
        }

        public FrmCliente()
        {
            InitializeComponent();
           
        }

        private void tbpCadastraCliente_Click(object sender, EventArgs e)
        {

        
        }

        //LOAD
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            ListarTodosClientes();
        }

        //Cadastrar
        private void btnClienteCadastrar_Click_1(object sender, EventArgs e)
        {
        //    CodigosGerais c = new CodigosGerais();
        //    if (c.CampoVazio(txtClienteNome, "Nome do Cliente"))
        //        return;
        //    CodigosGerais c1 = new CodigosGerais();
        //    if (c1.CampoVazio(txtClienteTel, "Telefone do Cliente"))
        //        return;
        //    CodigosGerais c2 = new CodigosGerais();
        //    if (c2.CampoVazio(cbmClienteSexo, "Sexo do Cliente"))
        //        return;
        //    CodigosGerais c3 = new CodigosGerais();
        //    if (c3.CampoVazio(txtClienteEmail, "Email do Cliente"))
        //        return;
        //    CodigosGerais c4 = new CodigosGerais();
        //    if (c4.CampoVazio(txtClienteSenha, "Senha do Cliente"))
        //        return;
        //    CodigosGerais c5 = new CodigosGerais();
        //    if (c5.CampoVazio(txtClienteEnd, "Endereço do Cliente"))
        //        return;
        //    CodigosGerais c6 = new CodigosGerais();
        //    if (c6.CampoVazio(txtClienteBairro, "Bairro do Cliente"))
        //        return;
        //    CodigosGerais c7 = new CodigosGerais();
        //    if (c7.CampoVazio(txtClienteCidade, "Cidade do Cliente"))
        //        return;
        //    CodigosGerais c8 = new CodigosGerais();
        //    if (c8.CampoVazio(cbmClienteUf, "UF do Cliente"))
        //        return;
        //    CodigosGerais c9 = new CodigosGerais();
        //    if (c9.CampoVazio(dtpClienteDtNasc, "Data de Nasc. do Cliente"))
        //        return;
        //    CodigosGerais c10 = new CodigosGerais();
        //    if (c10.CampoVazio(dtpClienteCadastro, "Data de Cad. do Cliente"))
        //        return;

            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                string nome;
                string telefone;
                string sexo;
                string email;
                string senha;
                string endereco;
                string complemento;
                string bairro;
                string cidade;
                string uf;
                DateTime dt_nasc, dt_cad;


                nome = txtClienteNome.Text;
                telefone = txtClienteTel.Text;
                sexo = cbmClienteSexo.Text;
                email = txtClienteEmail.Text;
                senha = txtClienteSenha.Text;
                endereco = txtClienteEnd.Text;
                complemento = txtClienteComplem.Text;
                bairro = txtClienteBairro.Text;
                cidade = txtClienteCidade.Text;
                uf = cbmClienteUf.Text;
                dt_nasc = Convert.ToDateTime(dtpClienteDtNasc.Text);
                dt_cad = Convert.ToDateTime(dtpClienteCadastro.Text);

                string sql_insert = @"insert into tb_cliente
                                        (
                                        tb_cliente_nome, 
                                        tb_cliente_tel,
                                        tb_cliente_sexo,
                                        tb_cliente_email,
                                        tb_cliente_senha,
                                        tb_cliente_endereco,
                                        tb_cliente_complemento,
                                        tb_cliente_bairro,
                                        tb_cliente_cidade,
                                        tb_cliente_uf,
                                        tb_cliente_dt_nasc,
                                        tb_cliente_dt_cad
                                        )
                                        values 
                                        (
                                        @cliente_nome,
                                        @cliente_tel,
                                        @cliente_sexo,
                                        @cliente_email,
                                        @cliente_senha,
                                        @cliente_endereco,
                                        @cliente_complemento,
                                        @cliente_bairro,
                                        @cliente_cidade,
                                        @cliente_uf,
                                        @cliente_dt_nasc,
                                        @cliente_dt_cad
                                        )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@cliente_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_tel", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_sexo", sexo);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_senha", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_endereco", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_complemento", complemento);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_bairro", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_cidade", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_uf", uf);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_nasc", dt_nasc);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_cad", dt_cad);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!!!");
                ListarTodosClientes();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

            txtClienteNome.Clear();
            txtClienteTel.Clear();
            txtClienteEmail.Clear();
            txtClienteSenha.Clear();
            txtClienteEnd.Clear();
            txtClienteComplem.Clear();
            txtClienteBairro.Clear();
            txtClienteCidade.Clear();
            cbmClienteSexo.SelectedItem = null;
            cbmClienteUf.SelectedItem = null;
            txtClienteNome.Focus();
        }

        //Alterar
        private void btnClienteAlterar_Click_1(object sender, EventArgs e)
        {
            int codigo;
            string nome;
            string telefone;
            string sexo;
            string email;
            string senha;
            string endereco;
            string complemento;
            string bairro;
            string cidade;
            string UF;
            DateTime dt_nasc, dt_cad;

            codigo = int.Parse(txtClienteCodigo.Text);
            nome = txtClienteNome.Text;
            telefone = txtClienteTel.Text;
            sexo = cbmClienteSexo.Text;
            email = txtClienteEmail.Text;
            senha = txtClienteSenha.Text;
            endereco = txtClienteEnd.Text;
            complemento = txtClienteComplem.Text;
            bairro = txtClienteBairro.Text;
            cidade = txtClienteCidade.Text;
            UF = cbmClienteUf.Text;
            dt_nasc = Convert.ToDateTime(dtpClienteDtNasc.Text);
            dt_cad = Convert.ToDateTime(dtpClienteCadastro.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cliente = @"update tb_cliente
               set tb_cliente_nome = @nome, 
                tb_cliente_tel = @tel,
                tb_cliente_sexo = @sexo,
                tb_cliente_email = @email,
                tb_cliente_senha = @senha,
                tb_cliente_endereco = @endereco,
                tb_cliente_complemento = @complemento,
                tb_cliente_bairro = @bairro,
                tb_cliente_cidade = @cidade,
                tb_cliente_uf = @uf,
                tb_cliente_dt_nasc = @dt_nasc,
                tb_cliente_dt_cad = @dt_cad
            where tb_cliente_id = @id";

            MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);

            executacmdMySql_update_cliente.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@tel", telefone);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@email", email);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@sexo", sexo);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@senha", senha);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@endereco", endereco);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@complemento", complemento);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@bairro", bairro);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@cidade", cidade);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@uf", UF);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@dt_nasc", dt_nasc);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@dt_cad", dt_cad);

            executacmdMySql_update_cliente.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso!!!");
            ListarTodosClientes();
            con.Close();

            txtClienteCodigo.Clear();
            txtClienteNome.Clear();
            txtClienteTel.Clear();
            txtClienteEmail.Clear();
            txtClienteSenha.Clear();
            txtClienteEnd.Clear();
            txtClienteComplem.Clear();
            txtClienteBairro.Clear();
            txtClienteCidade.Clear();
            txtClienteNome.Focus();
            cbmClienteSexo.SelectedItem = null;
            cbmClienteUf.SelectedItem = null;
        }

        //Desabilitar
        private void btnCliDes_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtClienteCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_cliente = @"update tb_cliente
                                    set tb_cliente_status = 'DESABILITADO'
                                  where tb_cliente_id = @id";

            MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);
            executacmdMySql_update_cliente.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_cliente.ExecuteNonQuery();
            MessageBox.Show("Desabilitado com sucesso!!!");
            con.Close();

            ListarTodosClientes();

            txtClienteCodigo.Clear();
            txtClienteNome.Clear();
            txtClienteTel.Clear();
            txtClienteEmail.Clear();
            txtClienteSenha.Clear();
            txtClienteEnd.Clear();
            txtClienteComplem.Clear();
            txtClienteBairro.Clear();
            txtClienteCidade.Clear();
            txtClienteNome.Focus();
            cbmClienteSexo.SelectedItem = null;
            cbmClienteUf.SelectedItem = null;
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void dtpClienteDtNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblClidtnasc_Click_1(object sender, EventArgs e)
        {

        }

        private void lblClidtcadast_Click(object sender, EventArgs e)
        {

        }

        private void dtpClienteCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        //Listar Clientes
        private void DgvListarClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtClienteCodigo.Text = DgvListarClientes.CurrentRow.Cells[0].Value.ToString();
            txtClienteNome.Text = DgvListarClientes.CurrentRow.Cells[1].Value.ToString();
            txtClienteTel.Text = DgvListarClientes.CurrentRow.Cells[2].Value.ToString();
            cbmClienteSexo.Text = DgvListarClientes.CurrentRow.Cells[3].Value.ToString();
            txtClienteEmail.Text = DgvListarClientes.CurrentRow.Cells[4].Value.ToString();
            txtClienteSenha.Text = DgvListarClientes.CurrentRow.Cells[5].Value.ToString();
            txtClienteEnd.Text = DgvListarClientes.CurrentRow.Cells[6].Value.ToString();
            txtClienteComplem.Text = DgvListarClientes.CurrentRow.Cells[7].Value.ToString();
            txtClienteBairro.Text = DgvListarClientes.CurrentRow.Cells[8].Value.ToString();
            txtClienteCidade.Text = DgvListarClientes.CurrentRow.Cells[9].Value.ToString();
            cbmClienteUf.Text = DgvListarClientes.CurrentRow.Cells[10].Value.ToString();
            dtpClienteDtNasc.Text = DgvListarClientes.CurrentRow.Cells[11].Value.ToString();
            dtpClienteCadastro.Text = DgvListarClientes.CurrentRow.Cells[12].Value.ToString();
        }
    }
}
