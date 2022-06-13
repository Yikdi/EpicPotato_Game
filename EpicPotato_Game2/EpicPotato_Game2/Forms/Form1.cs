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

namespace EpicPotato_Game2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Size = new Size(740, 505);
            tabControl1.Visible = false;

            Atributos_Jogador();
            Atributos_Oponente();
        }

        int a;
        Player player1 = new Player();
        Opponent opponent1 = new Opponent();

        private void btt_Options_Click(object sender, EventArgs e)
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

        // ataque 1 do jogador
        private void btt_Ataque1_Click(object sender, EventArgs e)
        {
            new Actions_Player(this).Ataque1_Jogador();
        }

        private void btt_Ataque2_Click(object sender, EventArgs e)
        {

        }

        private void btt_Ataque3_Click(object sender, EventArgs e)
        {

        }

        private void btt_Defesa_Click(object sender, EventArgs e)
        {

        }

        private void btt_Meditar_Click(object sender, EventArgs e)
        {

        }

        /*  Define os atributos do jogador buscando eles na classe jogador
         */
        private void Atributos_Jogador()
        {
            pb_Vida_jogador.Maximum = player1.Vida;
            pb_Vida_jogador.Value = pb_Vida_jogador.Maximum;
        }

        /*  Define os atributos do Oponente buscando eles na classe Oponente
         */
        private void Atributos_Oponente()
        {
            pb_Vida_Oponente.Maximum = opponent1.Vida;
            pb_Vida_Oponente.Value = pb_Vida_Oponente.Maximum;
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