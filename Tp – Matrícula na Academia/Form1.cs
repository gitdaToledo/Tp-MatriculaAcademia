using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp___Matrícula_na_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AtualizaBotoes();

            btnLimpar.Click += btnLimpar_Click;
            btnSair.Click += btnSair_Click;

            QttTotalModalidades();
            PrecoTotal();
            txtCor.Text = $"{QttCortesia()}";
        }

        private bool ValidarDadosAluno()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Digite o nome do aluno.");
                txtNome.Focus();
                return false;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Digite o e-mail do aluno.");
                txtEmail.Focus();
                return false;
            }

            if (!rbManha.Checked && !rbTarde.Checked && !rbNoite.Checked)
            {
                MessageBox.Show("Selecione um periodo.");
                return false;
            }

            txtNome.Text = txtNome.Text.ToUpper();


            txtEmail.Text = txtEmail.Text.ToLower();

            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();

            rbManha.Checked = false;
            rbTarde.Checked = false;
            rbNoite.Checked = false;

            AtualizaBotoes();

            listBoxEscolhido.Items.Clear();

            listBoxModa.Items.Clear();

            listBoxModa.Items.Add("Ginástica Rítmica");
            listBoxModa.Items.Add("Hidroginástica");
            listBoxModa.Items.Add("Musculação");
            listBoxModa.Items.Add("Natação");
            listBoxModa.Items.Add("Patinação");
            listBoxModa.Items.Add("Pilates");
            listBoxModa.Items.Add("RPM");
            listBoxModa.Items.Add("Squash");

            listBoxModa.Sorted = true;

            ckYoga.Checked = false;
            ckMed.Checked = false;
            ckTai.Checked = false;
            ckFeng.Checked = false;
            ckCrom.Checked = false;

            QttTotalModalidades();
            PrecoTotal();
            txtCor.Text = $"{QttCortesia()}";

            if (QttCortesia() == 0)
            {
                txtCor.ForeColor = Color.Red;
            }         

            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
            "Deseja realmente sair?",
            "Sair",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
             );

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AtualizaBotoes()
        {
            btnSetaDireita.Enabled = listBoxModa.SelectedItem != null;
            btnSetaEsquerda.Enabled = listBoxEscolhido.SelectedItem != null;

            btnSetaDireitaDupla.Enabled = listBoxModa.Items.Count > 0;
            btnSetaEsquerdaDupla.Enabled = listBoxEscolhido.Items.Count > 0;
        }

        private void listBoxModa_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaBotoes();
        }

        private void listBoxEscolhido_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaBotoes();
        }

        private void btnSetaDireita_Click(object sender, EventArgs e)
        {
            if (listBoxModa.SelectedItem != null && ValidarDadosAluno())
            {
                    listBoxEscolhido.Items.Add(listBoxModa.SelectedItem);
                    listBoxModa.Items.Remove(listBoxModa.SelectedItem);

                AtualizaBotoes();
                PrecoTotal();
                QttTotalModalidades();
            }
            else
            {
                MessageBox.Show("Selecione uma modalidade.");
            }
        }

        private void btnSetaEsquerda_Click(object sender, EventArgs e)
        {
            if (listBoxEscolhido.SelectedItem != null && ValidarDadosAluno())
            {
                    listBoxModa.Items.Add(listBoxEscolhido.SelectedItem);
                    listBoxEscolhido.Items.Remove(listBoxEscolhido.SelectedItem);

                AtualizaBotoes();
                PrecoTotal();
                QttTotalModalidades();
            }
            else
            {
                MessageBox.Show("Selecione uma modalidade.");
            }
        }

        private void btnSetaDireitaDupla_Click(object sender, EventArgs e)
        {
            if (listBoxModa.Items.Count > 0 && ValidarDadosAluno())
            {
                foreach (var item in listBoxModa.Items)
                    {
                        listBoxEscolhido.Items.Add(item);
                    }

                    listBoxModa.Items.Clear();

                AtualizaBotoes();
                PrecoTotal();
                QttTotalModalidades();
            }
        }
 
        private void btnSetaEsquerdaDupla_Click(object sender, EventArgs e)
        {
            if (listBoxEscolhido.Items.Count > 0 && ValidarDadosAluno())
            {
                foreach (var item in listBoxEscolhido.Items)
                {
                    listBoxModa.Items.Add(item);
                }

                listBoxEscolhido.Items.Clear();

                AtualizaBotoes();
                PrecoTotal();
                QttTotalModalidades();
            }
        }

        private int QttCortesia()
        {
            int qttSelecionados = 0;

            if (ckCrom.Checked)
                qttSelecionados++;

            if (ckFeng.Checked)
                qttSelecionados++;

            if (ckMed.Checked)
                qttSelecionados++;

            if (ckTai.Checked)
                qttSelecionados++;

            if (ckYoga.Checked)
                qttSelecionados++;

            return qttSelecionados;
 
        }

        private bool ValidaQttCortesia()
        {
            if (QttCortesia() > 3)
            {
                MessageBox.Show("Você pode selecionar no máximo 3 opções.");
                return false;
            }

            return true;
        }

        private void ckCortesia_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidaQttCortesia())
            {
                ((CheckBox)sender).Checked = false;
            }

            if(QttCortesia() != 0)
            {
                txtCor.ForeColor = Color.Black;
            }
            else
            {
                txtCor.ForeColor = Color.Red;
            }

            txtCor.Text = $"{QttCortesia()}";

        }

        private void PrecoTotal()
        {
            double valorPagar = 0; double valorComDesconto;

            if (listBoxEscolhido.Items.Count == 0)
            {
                txtVlPagar.ForeColor = Color.Red;
                txtVlPagar.Text = "0,00";
            }
            else if (listBoxEscolhido.Items.Count <= 2)
            {
                txtVlPagar.ForeColor = Color.Black;
                valorPagar = 100;
            }
            else if(listBoxEscolhido.Items.Count <= 4)
            {
                txtVlPagar.ForeColor = Color.Black;
                valorPagar = 150;
            }
            else if(listBoxEscolhido.Items.Count <= 6)
            {
                txtVlPagar.ForeColor = Color.Black;
                valorPagar = 200;
            }
            else if(listBoxEscolhido.Items.Count > 6)
            {
                txtVlPagar.ForeColor = Color.Black;
                valorPagar = 250;
            }

            if (rbTarde.Checked)
            {
                valorComDesconto = valorPagar * 0.85;
                txtVlPagar.Text = $"{valorComDesconto:F2}";
            }
            else
            {
                txtVlPagar.Text = $"{valorPagar:F2}";
            }

        }

        private void rbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            PrecoTotal();
            if (rbTarde.Checked)
            {
                MessageBox.Show("Modalidades no perído da Tarde possuem 15% de desconto!");
            }

        }

        private void QttTotalModalidades()
        {
            int qttTotal = 0;

            qttTotal = listBoxEscolhido.Items.Count; 

            if(listBoxEscolhido.Items.Count == 0)
            {
                txtQtd.ForeColor = Color.Red;
                txtQtd.Text = "0";
            }
            else
            {
                txtQtd.ForeColor = Color.Black;
                txtQtd.Text = qttTotal.ToString();
            }

        }

    }
}
