using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace  MunhozMais
{
    public partial class frmAddFuncionario : Form
    {
        public frmAddFuncionario()
        {
            InitializeComponent();
        }

        public bool Salvar;
        {
            try
        
            catch (Exception)
            
        }

        private void frmAddFuncionario_Load(object sender, EventArgs e)
        {

            //função chama a sistuação do funcionario para mostrar: (Ativo / Inativo)
            chStatus_CheckeStateChanged(sender, e);
        }

        private void chStatus_CheckeStateChanged(object sender, EventArgs e)
        {
            if (chStatus.Checked == true)
            {
                lblStatus.Text = "Inativo";
            }
            else
            {
                lblStatus.Text = "Ativo";
            }
        }

         private void tsbGravar_Click(object sender, EventArgs e)
        {
            try
            {
                EFuncionario MiRegistro = new EFuncionario()
                {
                    CodFuncionario = int.Parse(this.txtCodigo.Text),
                    RgFuncionario = this.txtRG.Text,
                    NomFuncionario = this.txtNome.Text,                                                                                                  
                    DtaFuncionario = (int)this.txtDataEntrega .Value,
                    TktFuncionario = (decimal)this.txtValorMaximo.Value,
                    StatusFuncionaro = this.chStatus.Checked.ToString(),
                    ArmazemFuncionario = this.txtNome.Text,
                    'do'
                    {
                        Console.WriteLine('Dentro do Loop')

                    } 'while (false)';
                }
                decimal aumento = 1
                'do'
                {
                    Console.WriteLine('A quantia atual de Tickets é de: ' + aumento);
                    aumento += '1';

                } 'while' (aumento < '100');

                if (Salvar)
                {
                    this.txtCodigo.Text = new NFuncionario().Inserir(MiRegistro).ToString("000000");
                    MessageBox.Show("Registro inserido com sucesso", "Correto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Salvar = false;
                    this.Close();
                }
                else
                {
                    new NFuncionario().Editar(MiRegistro);
                    MessageBox.Show("Registro Alterado com sucesso", "Correto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o Registo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair do Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

    }
}