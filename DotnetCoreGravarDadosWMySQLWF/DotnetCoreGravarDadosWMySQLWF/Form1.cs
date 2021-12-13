using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DotnetCoreGravarDadosWMySQLWF
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=root;database=db_agenda";

        private int ?id_contato_selecionado = null;

        public Form1()
        {
            InitializeComponent();

            list_contatos.View = View.Details;
            list_contatos.LabelEdit = true;
            list_contatos.AllowColumnReorder = true;
            list_contatos.FullRowSelect = true;
            list_contatos.GridLines = true;

            list_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            list_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            list_contatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            list_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar_contatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;


                if(id_contato_selecionado == null)
                {
                    //insert
                    cmd.CommandText = "INSERT INTO Contato (nome, email, telefone) " +
                                "VALUES" + "(@nome, @email, @telefone) ";



                    cmd.Parameters.AddWithValue("@nome", textNome.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("informação inserida com sucesso", "Concluido!", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //update
                    cmd.CommandText = "UPDATE Contato SET " +
                        "nome=@nome, email=@email, telefone=@telefone " + 
                        "WHERE id=@id ";



                    cmd.Parameters.AddWithValue("@nome", textNome.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("informações atualizadas com sucesso", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                limpar_formulario();

                carregar_contatos();

                /* jeito desorganizado de se fazer >>
                 * string sql = "INSERT INTO Contato (nome, email, telefone) "
                     + "VALUES " + 
                     "('" + textNome.Text + "', '" + textEmail.Text + "', '" + textNumero.Text + "')";
                 //Executar Comando Insert


                 MySqlCommand comando = new MySqlCommand(sql, Conexao);

                 Conexao.Open();

                 comando.ExecuteReader();

                 MessageBox.Show("Processo concluido, informação inserida");*/


            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Erro" + ex.Number + " Ocorreu um: " + ex.Message,
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  Houve um: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            finally
            {
                Conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM Contato WHERE nome LIKE @q OR email LIKE @q";

                

                cmd.Parameters.AddWithValue("@q", "%" + textBusca.Text + "%");
                cmd.Prepare();




                //  string q = "'%" + textBusca.Text + "%'";


                //Criar conexao com mysql
                //   Conexao = new MySqlConnection(data_source);


                /*    string sql = "SELECT * FROM Contato WHERE nome LIKE" + q + "OR email LIKE" + q;

                    Conexao.Open();  

                    //Executar Comando Insert
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                */

                MySqlDataReader reader = cmd.ExecuteReader();

                list_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    // var linha_listview = new ListViewItem(row);

                    list_contatos.Items.Add(new ListViewItem(row));
                }
            }




            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + " Ocorreu um: " + ex.Message,
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  Houve um: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                Conexao.Close();
            }
        }

        private void carregar_contatos()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM Contato ORDER BY id ASC";
                cmd.Prepare();



                MySqlDataReader reader = cmd.ExecuteReader();

                list_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };


                    list_contatos.Items.Add(new ListViewItem(row));
                }
            }




            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + " Ocorreu um: " + ex.Message,
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  Houve um: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                Conexao.Close();
            }
        }

        private void list_contatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = list_contatos.SelectedItems;
            
            foreach(ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                textNome.Text = item.SubItems[1].Text;
                textEmail.Text = item.SubItems[2].Text;
                textTelefone.Text = item.SubItems[3].Text;

                button4.Visible = true;

                //MessageBox.Show("id selecionado = " + id_contato_selecionado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpar_formulario();
        }

        private void limpar_formulario()
        {
            id_contato_selecionado = null;

            textNome.Text = string.Empty;
            textEmail.Text = "";
            textTelefone.Text = "";

            textNome.Focus();

            button4.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluir_contato();
           // MessageBox.Show("Excluindo id = " + id_contato_selecionado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            excluir_contato();
        }

        private void excluir_contato()
        {
            try
            {


                DialogResult conf = MessageBox.Show("Deseja excluir o item selecionado?",
                                "Excluir item selecionado?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (conf == DialogResult.Yes)
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM Contato WHERE id=@id ";


                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    //excluir no db
                    MessageBox.Show("registro excluido com sucesso", "Concluido!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregar_contatos();

                    button4.Visible = false;

                    limpar_formulario();
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + " Ocorreu um: " + ex.Message,
                               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  Houve um: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
