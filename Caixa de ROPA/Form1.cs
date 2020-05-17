using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_de_ROPA
{
    public partial class Tela_TAB2 : Form
    {
        public Tela_TAB2()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Outroform = new Form2();
            Outroform.ShowDialog();
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.vcont = 0;
            txtDesc.Text = (Program.vtproddesc[Program.vcont]);


        }

        private void lblSubtot_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Validação da quantidade solicitada X estoque disponível

            


            if(int.Parse(QtdTela.Text) <= Program.vtestoque[Program.vcont])
            {
                //Redução de Estoque
                Program.vtestoque[Program.vcont] = Program.vtestoque[Program.vcont] - int.Parse(QtdTela.Text);
                Program.vtcodaux[Program.vcont] = Program.vtcod[Program.vcont];

                //Atualização do resumo carrinho
                Program.vtqtd[Program.vcont] = int.Parse(QtdTela.Text);
                listCarrinho.Items.Add(Program.vtprod[Program.vcont] + "...... " + Program.vtqtd[Program.vcont]);

                
                //Calculos para o carrinho
                Program.vtpreco[Program.vcont] = Program.vtpreco[Program.vcont] * int.Parse(QtdTela.Text);
                Program.vsubtot = Program.vsubtot + Program.vtpreco[Program.vcont];
                Program.vimp = Program.vsubtot * 0.09;
                Program.vtot = Program.vsubtot + Program.vimp;

                //Atualização dos valores em tela
                txtValorSub.Text = Convert.ToString(Program.vsubtot);
                txtImp.Text = Convert.ToString(Program.vimp);
                txtTot.Text = Convert.ToString(Program.vtot);

            }
                       
        }

        private void Tela_TAB2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCarrinho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorSub_TextChanged(object sender, EventArgs e)
        {
            txtValorSub.Text = Convert.ToString(Program.vsubtot);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtImp.Text = Convert.ToString(Program.vimp);
        }

        private void txtTot_TextChanged(object sender, EventArgs e)
        {
            txtTot.Text = Convert.ToString(Program.vtot);
        }

        private void btnProdB_Click(object sender, EventArgs e)
        {
            Program.vcont = 1;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdC_Click(object sender, EventArgs e)
        {
            Program.vcont = 2;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));

        }

        private void btnProdD_Click(object sender, EventArgs e)
        {
            Program.vcont = 3;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " =============================== COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ===================================       R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdE_Click(object sender, EventArgs e)
        {
            Program.vcont = 4;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdF_Click(object sender, EventArgs e)
        {
            Program.vcont = 5;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdG_Click(object sender, EventArgs e)
        {
            Program.vcont = 6;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdH_Click(object sender, EventArgs e)
        {
            Program.vcont = 7;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdI_Click(object sender, EventArgs e)
        {
            Program.vcont = 8;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnProdJ_Click(object sender, EventArgs e)
        {
            Program.vcont = 9;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ================================ COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ================================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.vcont = 0;
            txtDesc.Text = (Convert.ToString(Program.vtprod[Program.vcont]) + " ============================== COD: " + Convert.ToString(Program.vtcod[Program.vcont]) + " ==============================   R$ " + Convert.ToString(Program.vtpreco[Program.vcont]) + "\n" + Convert.ToString(Program.vtproddesc[Program.vcont]));
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnProdA.Visible = true;
            btnProdB.Visible = true;
            btnProdC.Visible = true;
            btnProdD.Visible = true;
            btnProdE.Visible = true;
            btnProdF.Visible = true;
            btnProdG.Visible = true;
            btnProdH.Visible = true;
            btnProdI.Visible = true;
            btnProdJ.Visible = true;

        }
    }
}
