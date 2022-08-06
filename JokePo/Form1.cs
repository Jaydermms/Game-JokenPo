using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokePo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(int opcao)
        {
            Game game = new Game();

            switch (game.Jogar(opcao))
            {
                case Game.Resultado.Empatar:
                    pictureResultado.BackgroundImage = Image.FromFile("img/Empatar.png");
                    goto default;
                case Game.Resultado.Ganhar:
                    pictureResultado.BackgroundImage = Image.FromFile("img/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    pictureResultado.BackgroundImage = Image.FromFile("img/Perder.png");
                    goto default;
                default:
                    pictureJogador.BackgroundImage = game.ImgJogador;
                    pictureMaquina.BackgroundImage = game.ImgMaquina;
                    break;
            }
        }
    }
}
