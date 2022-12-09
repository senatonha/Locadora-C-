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
    public partial class FrmAutomovel : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        //private object executacmdMySql_update_marca;

        public FrmAutomovel()
        {
            InitializeComponent();
        }

        //Listar todas as Marcas
        public void ListarTodasMarcas()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_marca = "select tb_marca.TB_MARCA_ID as 'ID',\r\n        tb_marca.TB_MARCA_NOME as 'MARCA',\r\n        tb_marca.tb_marca_status as 'STATUS'\r\nfrom tb_marca\r\nwhere tb_marca.tb_marca_status = 'HABILITADO';";
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

            string sql_select_modelo = "select tb_modelo.TB_MODELO_ID as 'ID',\r\n        tb_modelo.TB_MODELO_DESC as 'MODELO',\r\n        tb_modelo.tb_modelo_status as 'STATUS'\r\nfrom tb_modelo\r\nwhere tb_modelo.tb_modelo_status = 'DISPONIVEL'";
            con.Open();

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            DgvListarModelo.DataSource = tabela_modelo;
            con.Close();
        }


        //Listar todos os Automóveis
        public void ListarTodosAuto()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_automovel = "select tb_automovel.TB_AUTOMOVEL_ID as 'ID',\r\n       tb_automovel.TB_AUTOMOVEL_NOME as 'NOME',\r\n       tb_automovel.TB_AUTOMOVEL_ANO_FAB as 'ANO DE FABRICAÇÃO',\r\n       tb_automovel.TB_AUTOMOVEL_COR as 'COR',\r\n       tb_automovel.TB_AUTOMOVEL_KM as 'KM',\r\n       tb_automovel.TB_AUTOMOVEL_VALOR_D as 'VALOR DO AUTOMÓVEL',\r\n       tb_automovel.TB_AUTOMOVEL_STATUS as 'STATUS',\r\n       tb_marca.TB_MARCA_NOME  as 'MARCA',\r\n       tb_modelo.TB_MODELO_DESC as 'MODELO'\r\nfrom tb_automovel\r\ninner join tb_marca\r\non tb_automovel.TB_MARCA_ID = tb_marca.TB_MARCA_ID\r\ninner join tb_modelo\r\non tb_automovel.TB_MODELO_ID = tb_modelo.TB_MODELO_ID\r\nwhere tb_automovel.TB_AUTOMOVEL_STATUS = 'DISPONIVEL';";
            con.Open();

            MySqlCommand executaMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executaMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();

            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executaMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            DgvListarAuto.DataSource = tabela_automovel;
            con.Close();
        }


        //Listar as chaves estrangeiras da tabela Marca na tabela Automóvel
        public void ChaveEstrangMar()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_marca = "select * from tb_marca where tb_marca_status = 'HABILITADO'";
            con.Open();

            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);

            cbmAutoMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmAutoMarca.DataSource = tabela_marca;
            cbmAutoMarca.ValueMember = "tb_marca_id";
            cbmAutoMarca.DisplayMember = "tb_marca_nome";
            cbmAutoMarca.SelectedItem = null;
            con.Close();
        }


        //Listar as chaves estrangeiras da tabela Modelo na tabela Automóvel
        public void ChaveEstrangMod()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sql_select_modelo = "select * from tb_modelo where tb_modelo_status = 'DISPONIVEL'";
            con.Open();

            MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
            executacmdMySql_select_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
            da_modelo.Fill(tabela_modelo);

            cbmAutoModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmAutoModelo.DataSource = tabela_modelo;
            cbmAutoModelo.ValueMember = "tb_modelo_id";
            cbmAutoModelo.DisplayMember = "tb_modelo_desc";
            cbmAutoModelo.SelectedItem = null;
            con.Close();
        }
      
        //Listar Auto
        private void DgvListarAuto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAutoCodigo.Text = DgvListarAuto.CurrentRow.Cells[0].Value.ToString();
            txtAutoNome.Text = DgvListarAuto.CurrentRow.Cells[1].Value.ToString();
            num_ano.Text = DgvListarAuto.CurrentRow.Cells[2].Value.ToString();
            txtAutoCor.Text = DgvListarAuto.CurrentRow.Cells[3].Value.ToString();
            txtAutoKM.Text = DgvListarAuto.CurrentRow.Cells[4].Value.ToString();
            txtAutoValF.Text = DgvListarAuto.CurrentRow.Cells[5].Value.ToString();
            cmbAutoStatus.Text = DgvListarAuto.CurrentRow.Cells[6].Value.ToString();
            cbmAutoMarca.Text = DgvListarAuto.CurrentRow.Cells[7].Value.ToString();
            cbmAutoModelo.Text = DgvListarAuto.CurrentRow.Cells[8].Value.ToString();

        }

        //LOAD
        private void FrmAutomovel_Load(object sender, EventArgs e)
        {
            ListarTodosAuto();
            ListarTodasMarcas();
            ListarTodosModelos();
            ChaveEstrangMar();
            ChaveEstrangMod();
        }

       
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //Cadastrar automovel
        private void btnCadAuto_Click(object sender, EventArgs e)
        {
            {
            //    CodigosGerais c = new CodigosGerais();
            //    if (c.CampoVazio(txtAutoNome, "Nome do automóvel"))
            //        return;
            //    CodigosGerais c1 = new CodigosGerais();
            //    if (c1.CampoVazio(num_ano, "Ano de fabricação"))
            //        return;
            //    CodigosGerais c2 = new CodigosGerais();
            //    if (c2.CampoVazio(txtAutoCor, "Cor do automóvel"))
            //        return;
            //    CodigosGerais c3 = new CodigosGerais();
            //    if (c3.CampoVazio(txtAutoKM, "KM do automóvel"))
            //        return;
            //    CodigosGerais c4 = new CodigosGerais();
            //    if (c4.CampoVazio(txtAutoValF, "Valor de locação"))
            //        return;
            //    CodigosGerais c5 = new CodigosGerais();
            //    if (c5.CampoVazio(cmbAutoStatus, "Status do automóvel"))
            //        return;
            //    CodigosGerais c6 = new CodigosGerais();
            //    if (c6.CampoVazio(cbmAutoMarca, "Marca do automóvel"))
            //        return;
            //    CodigosGerais c7 = new CodigosGerais();
            //    if (c7.CampoVazio(cbmAutoModelo, "Modelo do automóvel"))
            //        return;

                MySqlConnection con = new MySqlConnection(conexao);

                try
                {
                    string nome, cor, status;
                    int marca, modelo;
                    decimal KM, valor_d;
                    int dt_fab;

                    nome = txtAutoNome.Text;
                    cor = txtAutoCor.Text;
                    status = cmbAutoStatus.Text;
                    marca = int.Parse(cbmAutoMarca.SelectedValue.ToString());
                    modelo = int.Parse(cbmAutoModelo.SelectedValue.ToString());
                    KM = decimal.Parse(txtAutoKM.Text);
                    valor_d = decimal.Parse(txtAutoValF.Text);
                    dt_fab = int.Parse(num_ano.Text);


                    string sql_insert = @"insert into tb_automovel
                                    (
                                    tb_automovel_nome,  
                                    tb_automovel_ano_fab,  
                                    tb_automovel_cor, 
                                    tb_automovel_km,
                                    tb_automovel_valor_d,
                                    tb_automovel_status, 
                                    tb_marca_id, 
                                    tb_modelo_id
                                    )
                                      values
                                    (
                                      @tb_automovel_nome,
                                      @tb_automovel_ano_fab,
                                      @tb_automovel_cor,
                                      @tb_automovel_km,
                                      @tb_automovel_locacao,
                                      @tb_automovel_status,
                                      @tb_marca_id,
                                      @tb_modelo_id
                                    )";

                    MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                    executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_nome", nome);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_ano_fab", dt_fab);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_cor", cor);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_km", KM);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_locacao", valor_d);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_automovel_status", status);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_marca_id", marca);
                    executacmdMySql_insert.Parameters.AddWithValue("@tb_modelo_id", modelo);

                    con.Open();
                    executacmdMySql_insert.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cadastrado com sucesso!!!");

                    ListarTodosAuto();
                    ChaveEstrangMar();
                    ChaveEstrangMod();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Aconteceu um erro:" + erro);
                }

                txtAutoNome.Clear();
                txtAutoNome.Focus();
                // dtpDataFab.Clear();
                txtAutoCor.Clear();
                txtAutoKM.Clear();
                txtAutoValF.Clear();
                cmbAutoStatus.SelectedItem = null;
                cbmAutoMarca.SelectedItem = null;
                cbmAutoModelo.SelectedItem = null;


            }
        }

        //Alterar Auto
        private void btnAutoAlterar_Click_1(object sender, EventArgs e)
        {

            string nome, cor, status;
            int codigo, marca, modelo, dt_fab;
            decimal KM, valor_d;


            nome = txtAutoNome.Text;
            cor = txtAutoCor.Text;
            status = cmbAutoStatus.Text;
            dt_fab = int.Parse(num_ano.Text);
            codigo = int.Parse(txtAutoCodigo.Text);
            marca = int.Parse(cbmAutoMarca.SelectedValue.ToString());
            modelo = int.Parse(cbmAutoModelo.SelectedValue.ToString());
            KM = decimal.Parse(txtAutoKM.Text);
            valor_d = decimal.Parse(txtAutoValF.Text);


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_automovel = @"update tb_automovel 
                                set tb_automovel_nome = @nome,  
                                    tb_automovel_ano_fab = @fabricacao,
                                    tb_automovel_cor = @cor, 
                                    tb_automovel_km = @km,
                                    tb_automovel_valor_d = @locacao,
                                    tb_automovel_status = @status, 
                                    tb_marca_id = @marca,
                                    tb_modelo_id = @modelo
                              where tb_automovel_id = @id";

            MySqlCommand executacmdMySql_update_automovel = new MySqlCommand(sql_update_automovel, con);

            executacmdMySql_update_automovel.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@nome", nome);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@fabricacao", dt_fab);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@cor", cor);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@km", KM);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@locacao", valor_d);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@status", status);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@marca", marca);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@modelo", modelo);



            executacmdMySql_update_automovel.ExecuteNonQuery();

            MessageBox.Show("Atualização realizada com sucesso!!!");
            con.Close();

            ListarTodosAuto();

            txtAutoCodigo.Clear();
            txtAutoNome.Clear();
            txtAutoNome.Focus();
            txtAutoCor.Clear();
            txtAutoKM.Clear();
            txtAutoValF.Clear();
            cmbAutoStatus.SelectedItem = null;
            cbmAutoMarca.SelectedItem = null;
            cbmAutoModelo.SelectedItem = null;

        }

        //Desabilitar
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            int codigo;

            codigo = int.Parse(txtAutoCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_automovel = @"update tb_automovel
                                 set tb_automovel_status = 'INDISPONÍVEL'
                               where tb_automovel_id = @id";

            MySqlCommand executacmdMySql_update_automovel = new MySqlCommand(sql_update_automovel, con);
            executacmdMySql_update_automovel.Parameters.AddWithValue("@id", codigo);


            executacmdMySql_update_automovel.ExecuteNonQuery();

            MessageBox.Show("Desabilitado com sucesso!!");
            con.Close();

            ListarTodosAuto();

            txtAutoCodigo.Clear();
            txtAutoNome.Clear();
            txtAutoNome.Focus();
            txtAutoCor.Clear();
            txtAutoKM.Clear();
            txtAutoValF.Clear();
            cbmAutoMarca.SelectedItem = null;
            cmbAutoStatus.SelectedItem = null;
            cbmAutoModelo.SelectedItem = null;
        }

 
        private void FrmMarca_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Alterar marca
        private void btnMarAlterar_Click_1(object sender, EventArgs e)
        {
            int codigo;
            string nome;

            codigo = int.Parse(txtMarCodigo.Text);
            nome = txtMarNome.Text;

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_marca = @"update tb_marca
                                        set tb_marca_nome = @tb_marca_nome
                                        where tb_marca_id = @id";

            MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);

            executacmdMySql_update_marca.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_marca.Parameters.AddWithValue("@tb_marca_nome", nome);

            executacmdMySql_update_marca.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Cadastrado com sucesso!!!");

            ListarTodasMarcas();

            txtMarCodigo.Clear();
            txtMarNome.Clear();
            txtMarNome.Focus();
        }

        //Cadastrar marca
        private void btnMarCadastrar_Click_1(object sender, EventArgs e)
        {

            //CodigosGerais c = new CodigosGerais();
            //if (c.CampoVazio(txtMarNome, "Nome da Marca"))
              //  return;

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;

                nome = txtMarNome.Text;

                string sql_insert = @"insert into tb_marca
                                    (
                                      tb_marca_nome
                                    )
                                      values
                                    (
                                      @tb_marca_nome
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@tb_marca_nome", nome);
                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!!!");

                ListarTodasMarcas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }

            txtMarCodigo.Clear();
            txtMarNome.Clear();
            txtMarNome.Focus();
        
    }
        //Desabilitar marca
        private void btnMarDes_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtMarCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_marca = @"update tb_marca
                                        set tb_marca_status = 'DESABILITADO'
                                      where tb_marca_id = @id";

            MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);
            executacmdMySql_update_marca.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_marca.ExecuteNonQuery();
            MessageBox.Show("Desabilitado com sucesso!!!");
            con.Close();

            ListarTodasMarcas();

            txtMarCodigo.Clear();
            txtMarNome.Clear();
            txtMarNome.Focus();
        }

        //Cadastrar Modelo
        private void btnModCadastrar_Click_1(object sender, EventArgs e)
        {
        //    CodigosGerais c = new CodigosGerais();
        //    if (c.CampoVazio(txtModDesc, "Descrição do Modelo"))
        //        return;
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string desc;

                desc = txtModDesc.Text;

                string sql_insert = @"insert into tb_modelo
                                    (
                                      tb_modelo_desc
                                    )
                                      values
                                    (
                                      @modelo_desc
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@modelo_desc", desc);
                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Cadastrado com sucesso!!!");

                ListarTodosModelos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro:" + erro);
            }

            txtModDesc.Clear();
            txtModDesc.Focus();
        }

        //Alterar modelo
        private void btnModAlterar_Click_1(object sender, EventArgs e)
        {
            int codigo;
            string desc;

            codigo = int.Parse(txtModCodigo.Text);
            desc = txtModDesc.Text;

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_modelo = @"update tb_modelo
                                        set tb_modelo_desc = @modelo_desc
                                        where tb_modelo_id = @id";

            MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);
            executacmdMySql_update_modelo.Parameters.AddWithValue("@id", codigo);
            executacmdMySql_update_modelo.Parameters.AddWithValue("@modelo_desc", desc);

            executacmdMySql_update_modelo.ExecuteNonQuery();
            MessageBox.Show("Atualizado com sucesso!!!");
            con.Close();

            ListarTodosModelos();

            txtModCodigo.Clear();
            txtModDesc.Clear();
            txtModDesc.Focus();
        }

        //Desabilitar Modelo
        private void btnMoDes_Click_1(object sender, EventArgs e)
        {
            int codigo;

            codigo = int.Parse(txtModCodigo.Text);

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_update_modelo = @"update tb_modelo
                                     set tb_modelo_status = 'INDISPONIVEL'
                                   where tb_modelo_id = @id";

            MySqlCommand executacmdMySql_update_modelo = new MySqlCommand(sql_update_modelo, con);
            executacmdMySql_update_modelo.Parameters.AddWithValue("@id", codigo);

            executacmdMySql_update_modelo.ExecuteNonQuery();
            MessageBox.Show("Desabilitado com sucesso!!!");
            con.Close();

            ListarTodosModelos();

            txtModCodigo.Clear();
            txtModDesc.Clear();
            txtModDesc.Focus();
        }

        //Listar Modelo
        private void DgvListarModelo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtModCodigo.Text = DgvListarModelo.CurrentRow.Cells[0].Value.ToString();
            txtModDesc.Text = DgvListarModelo.CurrentRow.Cells[1].Value.ToString();
        }

        private void DgvListarMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Listar Marca
        private void DgvListarMarca_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtMarCodigo.Text = DgvListarMarca.CurrentRow.Cells[0].Value.ToString();
            txtMarNome.Text = DgvListarMarca.CurrentRow.Cells[1].Value.ToString();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
