using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EpicPotato_Game2.Attributes;
using EpicPotato_Game2.Actions;
using EpicPotato_Game2.Forms;

namespace EpicPotato_Game2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Size = new Size(740, 505);
            tabControl1.Visible = false;
            Start_Status();
        }

        int a;
        Player player1 = new Player();
        Opponent opponent1 = new Opponent();

        private void btt_Options_Click(object sender, EventArgs e)
        {
            Form3 form31 = new Form3();
            form31.ShowDialog();
        }

        private void btt_Status_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                Size = new Size(950, 505);
                tabControl1.Visible = true;
                a++;
            }
            else
            {
                Size = new Size(740, 505);
                tabControl1.Visible = false;
                a = 0;
            }
        }

        /*  Botões de ação do jogador
         *  
         *  Ataque Básico
         *  Ataque forte
         *  Ataque Furioso
         *  Cura
         */
        private void btt_Ataque1_Click(object sender, EventArgs e)
        {
            new Actions_Player(this).Ataque1();
        }

        private void btt_Ataque2_Click(object sender, EventArgs e)
        {
            new Actions_Player(this).Ataque2();
        }

        private void btt_Ataque3_Click(object sender, EventArgs e)
        {
            new Actions_Player(this).Ataque3();
        }

        private void btt_Cura_Click(object sender, EventArgs e)
        {

        }

        /*  Atualiza os Status visiveis nas labels de status do Jogador e do Oponente
         */
        private void Start_Status()
        {
            lbl_Status_Jogador1.Text = player1.Vida.ToString();
            lbl_Status_Jogador2.Text = player1.Cura.ToString();
            lbl_Status_Jogador3.Text = player1.Defesa.ToString();
            lbl_Status_Jogador4.Text = player1.Energia.ToString();
            lbl_Status_Jogador5.Text = player1.Dano_Atq1.ToString();
            lbl_Status_Jogador6.Text = player1.Dano_Atq2.ToString();
            lbl_Status_Jogador7.Text = player1.Dano_Atq3.ToString();

            lbl_Status_Oponente1.Text = opponent1.Vida.ToString();
            lbl_Status_Oponente2.Text = opponent1.Cura.ToString();
            lbl_Status_Oponente3.Text = opponent1.Defesa.ToString();
            lbl_Status_Oponente4.Text = opponent1.Energia.ToString();
            lbl_Status_Oponente5.Text = opponent1.Dano_Atq1.ToString();
            lbl_Status_Oponente6.Text = opponent1.Dano_Atq2.ToString();
            lbl_Status_Oponente7.Text = opponent1.Dano_Atq3.ToString();
        }
    }
}


//private void button7_Click(object sender, EventArgs e)
//{
//    var link = new Form2();
//    link.Location = this.Location;
//    link.StartPosition = FormStartPosition.Manual;
//    link.FormClosing += delegate { this.Show(); };
//    link.Show();
//    this.Hide();
//}