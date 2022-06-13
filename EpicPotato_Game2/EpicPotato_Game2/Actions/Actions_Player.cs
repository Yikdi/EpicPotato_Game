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

        public Actions_Player(Form1 _frm11) 
        {
            frm11 = _frm11;
        }

        public void Ataque1_Jogador()
        {
            frm11.pb_Vida_Oponente.Value = frm11.pb_Vida_Oponente.Value - player1.Dano_Atq1;
        }
    }
}
