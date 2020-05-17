using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_de_ROPA
{
    public static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 

        public static int vcont;

        public static int vcod;
        public static int vestoque;
        public static string vopcao;
        public static int vqtd;
        public static string vcodaux;
        public static string vconector;
        public static string vconf;

        public static int vcontaux;


        public static Double vsubtot;
        public static Double vimp;
        public static Double vtot;



        ////Tab2
        public static int[] vtcod = new int[10];

        public static string[] vtprod = new string[10];

        public static string[] vtproddesc = new string[10];

        public static double[] vtpreco = new double[10];

        public static int[] vtestoque = new int[10];


        //TAB1
        public static int[] vtestoquereal = new int[10];


        //Carrinho de compras
        public static int[] vtcodaux = new int[10];


        public static int[] vtqtd = new int[10];


        [STAThread]
        static void Main()
        {

            //INICIALIZAÇÕES
            vcont = 0;
            vcontaux = 0;

            vsubtot = 0;
            vimp = 0;
            vtot = 0;

            //TAB2

            vtcod[0] = 101;
            vtcod[1] = 102;
            vtcod[2] = 103;
            vtcod[3] = 104;
            vtcod[4] = 105;
            vtcod[5] = 106;
            vtcod[6] = 107;
            vtcod[7] = 108;
            vtcod[8] = 109;
            vtcod[9] = 110;

            vtprod[0] = "ARMADURA WAKANDA";
            vtprod[1] = "REGATA CICLOPE  ";
            vtprod[2] = "KOBE BRIANT     ";
            vtprod[3] = "ESÙ             ";
            vtprod[4] = "CHAPEU ISÃ      ";
            vtprod[5] = "NARUTO          ";
            vtprod[6] = "GOLDEN BIRD     ";
            vtprod[7] = "ATEMPORAL       ";
            vtprod[8] = "KING SPRING     ";
            vtprod[9] = "BOOT AMARELO    ";

            vtproddesc[0] = "Forjada em Vibranium, ara guerreiros que valorizam qualidade e estilo. Se você cultiva uma barba bem cuidada, ainda pode ganhar uma replica dessa pele de urso.";
            vtproddesc[1] = "Direto do Festival AFROPUNK. Estilo urbano, desenhado em parceria com microempreendedores Brasileiros e inspirado no movimento AFROPUNK.";
            vtproddesc[2] = "Conjunto de basquete com autografos psicografados de Kobe Briant, um dos maiores jogadores de todos os tempos.";
            vtproddesc[3] = "O tecido dos Grandes, das personalidades feitos pelos Ashanti. Estilo urbano, desenhado em parceria com microempreendedores Brasileiros e inspirado no movimento AFROPUNK.";
            vtproddesc[4] = "Vestimenta Afrofuturista, apresentada no festival AFROPUNK, em Joanesburgo. A proposta ideal para os Filhos e Guerreiros de Isã.";
            vtproddesc[5] = "Tecido de alta qualidade, originário de Gana. Urban Style, feito em Adrinkas e inspirado nas artes de Naruto. Fruto de uma parceria com microempreendedores de Gana e do Brasil.";
            vtproddesc[6] = "TECIDO de alta qualidade, originário do Reino Ashanti, em Gana. Urban Style, desenhado em parceria com microempreendedores Brasileiros e inspirado pela cultura AFROPUNK.";
            vtproddesc[7] = "TECIDO de alta qualidade, originário do Reino Ashanti, em Gana. Urban Style, desenhado em parceria com microempreendedores Brasileiros e inspirado pela cultura AFROPUNK.";
            vtproddesc[8] = "TECIDO de alta qualidade, originário do Reino Ashanti, em Gana. Urban Style, desenhado em parceria com microempreendedores Brasileiros e inspirado pela cultura AFROPUNK.";
            vtproddesc[9] = "TECIDO de alta qualidade, originário do Reino Ashanti, em Gana. Urban Style, desenhado em parceria com microempreendedores Brasileiros e inspirado pela cultura AFROPUNK.";

            vtpreco[0] = 450;
            vtpreco[1] = 80;
            vtpreco[2] = 220;
            vtpreco[3] = 180;
            vtpreco[4] = 50;
            vtpreco[5] = 100;
            vtpreco[6] = 700;
            vtpreco[7] = 20;
            vtpreco[8] = 80;
            vtpreco[9] = 10;

            vtestoque[0] = 50;
            vtestoque[1] = 50;
            vtestoque[2] = 50;
            vtestoque[3] = 50;
            vtestoque[4] = 50;
            vtestoque[5] = 50;
            vtestoque[6] = 50;
            vtestoque[7] = 50;
            vtestoque[8] = 50;
            vtestoque[9] = 50;

            //TAB1

            vtestoquereal[0] = 5;
            vtestoquereal[1] = 5;
            vtestoquereal[2] = 5;
            vtestoquereal[3] = 5;
            vtestoquereal[4] = 5;
            vtestoquereal[5] = 5;
            vtestoquereal[6] = 5;
            vtestoquereal[7] = 5;
            vtestoquereal[8] = 5;
            vtestoquereal[9] = 5;

            //Carrinho de compras
            vtcodaux[0] = 0;
            vtcodaux[1] = 0;
            vtcodaux[2] = 0;
            vtcodaux[3] = 0;
            vtcodaux[4] = 0;
            vtcodaux[5] = 0;
            vtcodaux[6] = 0;
            vtcodaux[7] = 0;
            vtcodaux[8] = 0;
            vtcodaux[9] = 0;


            vtqtd[0] = 0;
            vtqtd[1] = 0;
            vtqtd[2] = 0;
            vtqtd[3] = 0;
            vtqtd[4] = 0;
            vtqtd[5] = 0;
            vtqtd[6] = 0;
            vtqtd[7] = 0;
            vtqtd[8] = 0;
            vtqtd[9] = 0;
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tela_TAB2());
        }
    }
}
