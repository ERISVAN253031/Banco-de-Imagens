using System;
using System.Windows.Forms;

namespace Banco_de_Imagens
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnInserirImg = new System.Windows.Forms.Button();
            this.txtNovoConhecimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(52, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pesquisar por nº Conh:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Azure;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(55, 248);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 44);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Azure;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(261, 248);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(127, 44);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Azure;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Fechar.Location = new System.Drawing.Point(966, 576);
            this.Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(158, 54);
            this.Fechar.TabIndex = 16;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // dtGrid
            // 
            this.dtGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.GridColor = System.Drawing.Color.Black;
            this.dtGrid.Location = new System.Drawing.Point(55, 312);
            this.dtGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersWidth = 51;
            this.dtGrid.Size = new System.Drawing.Size(332, 242);
            this.dtGrid.TabIndex = 15;
            this.dtGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(231, 154);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(157, 22);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnInserirImg
            // 
            this.btnInserirImg.BackColor = System.Drawing.Color.Azure;
            this.btnInserirImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInserirImg.Location = new System.Drawing.Point(425, 576);
            this.btnInserirImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirImg.Name = "btnInserirImg";
            this.btnInserirImg.Size = new System.Drawing.Size(158, 54);
            this.btnInserirImg.TabIndex = 11;
            this.btnInserirImg.Text = "Inserir Imagem";
            this.btnInserirImg.UseVisualStyleBackColor = false;
            this.btnInserirImg.Click += new System.EventHandler(this.btnInserirImg_Click);
            // 
            // txtNovoConhecimento
            // 
            this.txtNovoConhecimento.Location = new System.Drawing.Point(231, 199);
            this.txtNovoConhecimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovoConhecimento.Name = "txtNovoConhecimento";
            this.txtNovoConhecimento.Size = new System.Drawing.Size(157, 22);
            this.txtNovoConhecimento.TabIndex = 20;
            this.txtNovoConhecimento.TextChanged += new System.EventHandler(this.txtNovoConhecimento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(52, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cadastrar por nº conh:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.Azure;
            this.img.ErrorImage = null;
            this.img.Image = global::Banco_de_Imagens.Properties.Resources.pasta_1;
            this.img.Location = new System.Drawing.Point(425, 37);
            this.img.Margin = new System.Windows.Forms.Padding(4);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(699, 517);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 14;
            this.img.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_de_Imagens.Properties.Resources.logo_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(55, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1169, 663);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNovoConhecimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.img);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnInserirImg);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Imagens ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void txtNovoConhecimento_TextChanged(object sender, EventArgs e)
        {
          
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnInserirImg;
        private System.Windows.Forms.TextBox txtNovoConhecimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

