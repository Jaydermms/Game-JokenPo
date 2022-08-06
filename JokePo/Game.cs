using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokePo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar,Perder,Empatar
        }
        public Image[] images =
        {
            Image.FromFile("img/Pedra.png"),
            Image.FromFile("img/Papel.png"),
            Image.FromFile("img/Tesoura.png"),
        };

        public Image ImgJogador { get; private set; }
        public Image ImgMaquina { get; private set; }

        public Resultado Jogar(int opcao)
        {
            int pc = EscolhaMquina();
            ImgJogador = images[opcao];
            ImgMaquina = images[pc];

            if(opcao == pc)
            {
               return Resultado.Empatar;
            }else if((opcao == 0 && pc == 2) || (opcao == 2 && pc == 1) || (opcao == 2 && pc == 0))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

        }

        private int EscolhaMquina()
        {
            int mil = DateTime.Now.Millisecond;
            
            if(mil < 333)
            {
                return 0;
            }else if(mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
