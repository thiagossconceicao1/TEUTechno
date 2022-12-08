using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int operador;
            string Frutas = "";

            operador = int.Parse (txtSelecione.Text);

            switch (operador)
            {
                case 1: Frutas = "Banana";
                    break;
                case 2: Frutas = "Maça";
                    break;
                case 3: Frutas = "Pera";
                    break;
                case 4: Frutas = "Melancia";
                    break;
                case 5: Frutas = "nenhuma fruta selecionada.";
                    break;
            }
            txtFrutaselecionada.Text = Frutas;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executar o metodo criado
            limparCampos();
        }
        //CRIAR O METODO PARA LIMPAR OS COMPONETES(TODO METODO É CRIADO DENTRO DA CLASS MAS SEMPRE FORA DE OUTRO METODO)
        public void limparCampos()
        {
            txtFrutaselecionada.Clear();
            txtSelecione.Text = "";
            ltbFrutas.Items.Clear();
            cbbFrutaslistadas.Items.Clear();
            cbbFrutaslistadas.Text = "";

            txtSelecione.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            cbbFrutaslistadas.Items.Clear();
            ltbFrutas.Items.Add(txtFrutaselecionada.Text);
            cbbFrutaslistadas.Items.Add(txtFrutaselecionada.Text);
            
        }

        private void cbbFrutaslistadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ltbFrutas.Items.Add(txtFrutaselecionada.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //formas de sair 
            //Close();
            //this.Close();
            //usar o Application sempre
           

            DialogResult res;

            res = MessageBox.Show("Deseja sair?",
                "Menssagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }
        }
    }
}
