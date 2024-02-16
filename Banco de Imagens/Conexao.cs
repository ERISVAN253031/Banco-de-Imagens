using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaHotel
{
    internal class Conexao
    {
        public string conec = "SERVER=localhost; DATABASE=img; UID=root; PWD=; PORT=;"; // STRING DE CONEXÃO

        public MySqlConnection con = null; // VARIAVEL DE CONEXÃO 

        //ABRIR CONEXÃO
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro no servidor " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro no servidor " + ex.Message);
            }
        }

        internal MySqlConnection GetConexao()
        {
            throw new NotImplementedException();
        }
    }
}

