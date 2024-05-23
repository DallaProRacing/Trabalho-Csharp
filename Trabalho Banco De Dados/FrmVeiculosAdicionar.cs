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
    public partial class FrmVeiculosAdicionar : Form
    {
        int id = 0;
        public FrmVeiculosAdicionar(int id)
        {
            

            InitializeComponent();
            this.id = id;

            //Alteração
            if (this.id > 0)
                GetVeiculo(id);
        }
        private bool CamposObrigatoriosPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text) ||
                string.IsNullOrWhiteSpace(txtCor.Text) ||
                string.IsNullOrWhiteSpace(txtFabricacao.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text) ||
                string.IsNullOrWhiteSpace(cbxAutomatico.Text) ||
                string.IsNullOrWhiteSpace(cbxCombustivel.Text))

            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public FrmVeiculosAdicionar(int id,bool excluir)
        {
            InitializeComponent();
            this.id = id;

            //Exclusão
            if (excluir)
                if (this.id > 0)
                {
                    GetVeiculo(id);
                    TravarControles();
                    btnSalvar.Visible = false;
                    btnExcluir.Visible = true;

                }
                else
                    this.Close();
        }

        private void TravarControles()
        {
            txtNome.Enabled = false;
            txtModelo.Enabled = false;
            txtAno.Enabled = false;
            txtFabricacao.Enabled = false;
            txtCor.Enabled = false;
            cbxAutomatico.Enabled = false;
            cbxCombustivel.Enabled = false;
            txtValor.Enabled = false;
        }
        private void GetVeiculo(int id)
        {
            
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "Select * from tb_veiculos where id= " + id;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNome.Text = dr["Nome"].ToString();
                                    txtModelo.Text = dr["Modelo"].ToString();
                                    txtAno.Text = dr["Ano"].ToString();
                                    txtFabricacao.Text = dr["Fabricacao"].ToString();
                                    txtCor.Text = dr["Cor"].ToString();

                                    switch (Convert.ToInt32(dr["Combustivel"]))
                                    {
                                        case 1:
                                            cbxCombustivel.Text = "1 Gasolina";
                                            break;
                                        case 2:
                                            cbxCombustivel.Text = "2 Álcool";
                                            break;
                                        case 3:
                                            cbxCombustivel.Text = "3 Flex";
                                            break;
                                        case 4:
                                            cbxCombustivel.Text = "4 Diesel";
                                            break;
                                        case 5:
                                            cbxCombustivel.Text = "5 Gás Natual";
                                            break;
                                    }

                                    if (Convert.ToBoolean(dr["Automatico"]))
                                        cbxAutomatico.Text = "Sim";
                                    else
                                        cbxAutomatico.Text = "Não";

                                    txtValor.Text = dr["Valor"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Falha ao buscar o veículo!\n\n" + ex.Message);
            }
        }

        private void SalvarVeiculo()
        {
            
            if (CamposObrigatoriosPreenchidos())
            {

                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = "";
                        if (this.id == 0)
                            sql = "INSERT INTO tb_Veiculos (Nome, Modelo, Ano, Fabricacao, Cor, Combustivel, Automatico, Valor)" +
                                " VALUES  (@Nome, @Modelo, @Ano, @Fabricacao, @Cor, @Combustivel, @Automatico, @Valor)";
                        else
                            sql = "UPDATE tb_Veiculos Set Nome=@Nome, Modelo=@Modelo, Ano=@Ano, Fabricacao=@Fabricacao, Cor=@Cor, " +
                                "Combustivel=@Combustivel, Automatico=@Automatico, Valor=@Valor WHERE id=" + this.id;

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            

                            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                            cmd.Parameters.AddWithValue("@Modelo", txtModelo.Text);
                            cmd.Parameters.AddWithValue("@Ano", txtAno.Text);
                            cmd.Parameters.AddWithValue("@Fabricacao", txtFabricacao.Text);
                            cmd.Parameters.AddWithValue("@Cor", txtCor.Text);
                            cmd.Parameters.AddWithValue("@Combustivel", cbxCombustivel.Text.Substring(0, 1));
                            cmd.Parameters.AddWithValue("@Automatico", cbxAutomatico.Text.Substring(0, 1) == "S" ? 1 : 0);
                            cmd.Parameters.AddWithValue("@Valor", txtValor.Text.Replace(",", "."));
                            cmd.ExecuteNonQuery();
                        }

                        
                       
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Não foi possível salvar os dados!\n\n" + ex.Message);
                }

            }
        }

        private void FrmVeiculosAdicionar_Load(object sender, EventArgs e)
        {
            // Evento Load do formulário
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Evento Click do label10
        }

        private void label14_Click(object sender, EventArgs e)
        {
            // Evento Click do label14
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Evento Click do label12
        }

        private void label15_Click(object sender, EventArgs e)
        {
            // Evento Click do label15
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Evento TextChanged do textBox6
        }

        private void label16_Click(object sender, EventArgs e)
        {
            // Evento Click do label16
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Evento TextChanged do textBox2
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarVeiculo();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja Excluir?","Excluir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resp == DialogResult.Yes)
            {

                ExcluirVeiculo();
                this.Close();
            }
        }
        
        private void ExcluirVeiculo()
        {            

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "DELETE FROM tb_veiculos where id=" + id;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        

                        cmd.ExecuteNonQuery();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Falha ao excluir o veículo!\n\n" + ex.Message);
            }
        }
        
    }
}
