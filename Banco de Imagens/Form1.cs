using MySql.Data.MySqlClient;
using SistemaHotel;
using System;
using System.Data;
using System.Drawing.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Banco_de_Imagens
{
    public partial class Form1 : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;
        private int id;

        string imagem;

        public Form1()
        {
            InitializeComponent();
        }

        private void FormatarGrid()
        {
            dtGrid.Columns[0].HeaderText = "Código";
            dtGrid.Columns[1].HeaderText = "Conhecimento";
            dtGrid.Columns[2].HeaderText = "Imagem";

            dtGrid.Columns[0].Visible = false;
            dtGrid.Columns[2].Visible = true;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();

            if (string.IsNullOrEmpty(imagem))
            {
                MessageBox.Show("Selecione uma imagem antes de salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
                return;
            }

            if (string.IsNullOrEmpty(txtNovoConhecimento.Text))
            {
                MessageBox.Show("Digite o número antes de salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.FecharConexao();
                return;
            }

            sql = "INSERT INTO conhecimeto (conhecimento, imagem) VALUES (@conhecimento, @imagem)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@conhecimento", txtNovoConhecimento.Text);
            cmd.Parameters.AddWithValue("@imagem", imgs());

            MySqlCommand cmdVerificar;
            cmdVerificar= new MySqlCommand("SELECT * FROM conhecimeto  WHERE  conhecimento=@conhecimento", con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmdVerificar;
            cmdVerificar.Parameters.AddWithValue("@conhecimento", txtNovoConhecimento.Text);
            DataTable dt= new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count >0)
            {
                MessageBox.Show("Conhecimento já cadastrado!.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNovoConhecimento.Text = "";
                txtNovoConhecimento.Focus();
                return;


            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            AtualizarGrid();
            LimparCampos();
            LimparImagem();

        }

        private void LimparCampos()
        {
            txtbuscar.Text = "";
            txtNovoConhecimento.Text = "";
          
        }

        private void LimparImagem()
        {
            img.Image = Properties.Resources.pasta_1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarGrid();
            FormatarGrid();
        }

        private void ListarGrid()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM conhecimeto ORDER BY conhecimento ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtGrid.DataSource = dt;
            con.FecharConexao();

            dtGrid.AllowUserToAddRows = false;
            FormatarGrid();
        }



        private void AtualizarGrid()
        {
            con.AbrirConexao();

            sql = "UPDATE conhecimeto SET conhecimento = @conhecimento WHERE id = @id";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@conhecimento", txtNovoConhecimento.Text);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@imagem", imgs());

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            LimparCampos();
            ListarGrid();
        }

        private void DtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGrid.Rows[e.RowIndex];
                txtNovoConhecimento.Text = row.Cells["Conhecimento"].Value.ToString();
            
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNovoConhecimento.Text))
            {
                MessageBox.Show("Selecione um registro para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resposta = MessageBox.Show("Deseja realmente excluir este registro?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                con.AbrirConexao();

                sql = "DELETE FROM conhecimeto WHERE conhecimento = @conhecimento";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@conhecimento", txtNovoConhecimento.Text);
                cmd.Parameters.AddWithValue("@imagem", img);

                cmd.ExecuteNonQuery();
                con.FecharConexao();

                LimparCampos();
                ListarGrid();

                MessageBox.Show("Registro excluído com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    
        
        //metodo buscar por nome 

        private void BuscarNome() {
            {
                con.AbrirConexao();

                sql = "SELECT * FROM conhecimeto WHERE conhecimento LIKE @conhecimento ORDER BY CONHECIMENTO ASC ";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@conhecimento", "%" + txtbuscar.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtGrid.DataSource = dt;
                con.FecharConexao();

                FormatarGrid();


            }

        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens(*.jpg; *.jpeg; *.png) |*.jpg; *.png; *.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                imagem = ofd.FileName.ToString();
                img.ImageLocation = imagem;

            }

            
        }

        private byte[] imgs()
        {
            if(imagem == "")
            {
                return null;
            }

            byte[] imgs = null;
            FileStream fs = new FileStream(imagem, FileMode.Open, FileAccess.Read);/// padrão para´pegar imagem no banco 
            BinaryReader br = new BinaryReader(fs);
            imgs = br.ReadBytes((int)fs.Length);
            return imgs;
          
        }

        private void dtGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGrid.Rows[e.RowIndex];
                txtNovoConhecimento.Text = row.Cells["Conhecimento"].Value.ToString();
                ExibirImagem(row);
            }
        }

        private void ExibirImagem(DataGridViewRow row)
        {
            if (row.Cells["Imagem"].Value != DBNull.Value)
            {
                byte[] imagemBytes = (byte[])row.Cells["Imagem"].Value;
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    img.Image = Image.FromStream(ms);
                }
            }
            else
            {
                img.Image = Properties.Resources.pasta_1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}