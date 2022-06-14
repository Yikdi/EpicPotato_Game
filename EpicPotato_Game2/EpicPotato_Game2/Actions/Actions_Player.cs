using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpicPotato_Game2.Attributes;

namespace EpicPotato_Game2.Actions
{
    public class Actions_Player
    {
        Player player1 = new Player();

        private Form1 frm11;
        public Actions_Player(Form1 frm12) 
        {
            frm11 = frm12;
        }

        int Dano1, Dano2, Dano3, Cura;
        string Vida;

        public void Ataque1()
        {
            try
            {
                Dano1 = int.Parse(frm11.lbl_Status_Jogador1.Text);
                Vida = frm11.lbl_Vida_Oponente.Text;

                //if (Dano1 <= 10 && Dano1 >= 0)
                {
                    Dano1 = Dano1 - 1;
                    Vida.Remove(0).Insert(0, "");
                }

                frm11.lbl_Vida_Oponente.Text = Vida;
            }
            catch
            {

            }
        }

        public void Ataque2()
        {
            try
            {

            }
            catch
            {

            }
        }

        public void Ataque3()
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
