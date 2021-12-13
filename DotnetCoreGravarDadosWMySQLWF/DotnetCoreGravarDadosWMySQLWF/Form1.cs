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
        MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=root;database=db_agenda";
                //Criar conexao com mysql
                Conexao = new MySqlConnection(data_source);


                string sql = "INSERT INTO Contato (nome, email, telefone) "
                    + "VALUES " + 
                    "('" + textNome.Text + "', '" + textEmail.Text + "', '" + textNumero.Text + "')";
                //Executar Comando Insert


                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Processo concluido, informação inserida");



            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Conexao.Close();
            }
        }
    }
}
