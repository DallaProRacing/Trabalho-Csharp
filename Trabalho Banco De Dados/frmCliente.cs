using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Banco_De_Dados
{
    public partial class frmCliente : Form
    {
        int id = 0;
        public frmCliente(int id)
        {
            InitializeComponent();

            this.id = id;

            //Alteração
            if (this.id > 0)
                GetCliente(id);
        }
        public frmCliente(int id, bool excluir)
        {
            InitializeComponent();
            this.id = id;


        }

        private void TravarControles()
        {
            txtNomeCli.Enabled = false;
            mtxCPF.Enabled = false;
            txtIdade.Enabled = false;
            txtAltura.Enabled = false;
            mtxPhone.Enabled = false;

        }

        private bool CamposObrigatoriosPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(txtAltura.Text) ||
                string.IsNullOrWhiteSpace(txtIdade.Text) ||
                string.IsNullOrWhiteSpace(txtNomeCli.Text) ||
                string.IsNullOrWhiteSpace(mtxCPF.Text) ||
                string.IsNullOrWhiteSpace(mtxPhone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void GetCliente(int id)
        {
            ToolStripStatusLabel2.Text = "Conectando...";
            statusStrip2.Refresh();
            try
            {
                using (SqlConnection cn2 = new SqlConnection(Conn.StrCon))
                {
                    cn2.Open();

                    var sql = "Select * from Clientes where ID_Cliente= " + id;

                    using (SqlCommand cmd2 = new SqlCommand(sql, cn2))
                    {
                        ToolStripStatusLabel2.Text = "Buscando CLiente.";
                        statusStrip2.Refresh();

                        using (SqlDataReader dr2 = cmd2.ExecuteReader())
                        {
                            if (dr2.HasRows)
                            {
                                if (dr2.Read())
                                {
                                    txtNomeCli.Text = dr2["NomeCli"].ToString();
                                    txtIdade.Text = dr2["Idade"].ToString();
                                    mtxCPF.Text = dr2["CPF"].ToString();
                                    txtAltura.Text = dr2["Altura"].ToString();
                                    mtxPhone.Text = dr2["Contato"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ToolStripStatusLabel2.Text = "Falha";
                statusStrip2.Refresh();
                MessageBox.Show("Falha ao buscar o Cliente!\n\n" + ex.Message);
            }
        }

        private void SalvarCliente()
        {
            ToolStripStatusLabel2.Text = "Conectando...";
            statusStrip2.Refresh();
            if (CamposObrigatoriosPreenchidos())
            {

                try
                {
                    using (SqlConnection cn2 = new SqlConnection(Conn.StrCon))
                    {
                        cn2.Open();

                        var sql = "";
                        if (this.id == 0)
                            sql = "INSERT INTO Clientes (NomeCli, Idade, CPF, Altura, Contato)" +
                                " VALUES  (@NomeCli, @Idade, @CPF, @Altura, @Contato)";
                        else
                            sql = "UPDATE Clientes Set NomeCli=@NomeCli, Idade=@Idade, CPF=@CPF, Altura=@Altura,Contato=@Contato WHERE ID_Cliente=" + this.id;

                        using (SqlCommand cmd2 = new SqlCommand(sql, cn2))
                        {
                            ToolStripStatusLabel2.Text = "Salvando o Cliente.";
                            statusStrip2.Refresh();

                            cmd2.Parameters.AddWithValue("@NomeCli", txtNomeCli.Text);
                            cmd2.Parameters.AddWithValue("@Idade", txtIdade.Text);
                            cmd2.Parameters.AddWithValue("@CPF", mtxCPF.Text);
                            cmd2.Parameters.AddWithValue("@Altura", txtAltura.Text);
                            cmd2.Parameters.AddWithValue("@Contato", mtxPhone.Text);
                            cmd2.ExecuteNonQuery();
                        }

                        ToolStripStatusLabel2.Text = "Pronto";
                        statusStrip2.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    ToolStripStatusLabel2.Text = "Falha";
                    statusStrip2.Refresh();
                    MessageBox.Show("Não foi possível salvar os dados!\n\n" + ex.Message);
                }
            }
        }       


        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

       
     

        private void btnSalvarC_Click(object sender, EventArgs e)
        {
            SalvarCliente();
            this.Close();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


    }
}
