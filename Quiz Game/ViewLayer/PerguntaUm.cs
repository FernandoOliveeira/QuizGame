using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Quiz_Game.Control;
using System.Threading;

namespace Quiz_Game.ViewLayer
{
    public partial class PerguntaUm : Form
    {
        Thread thread;

        public PerguntaUm()
        {
            InitializeComponent();
        }

        Functions functions = new Functions();

        private void PerguntaUm_Load(object sender, EventArgs e)
        {
            TSSLVidas.Text = "Vidas: " + MainMenu.Vidas;
        }

        private void RespostaCerta_Click(object sender, EventArgs e)
        {
            functions.TocarRespostaCerta();
        }

        private void RespostaErrada_Click(object sender, EventArgs e)
        {
            functions.TocarRespostaErrada();

            MainMenu.Vidas--;
            TSSLVidas.Text = "Vidas: " + MainMenu.Vidas;

        }

        private void TSSLVidas_TextChanged(object sender, EventArgs e)
        {
            if (MainMenu.Vidas == 0)
            {
                functions.TocarGameOver();

                GameOver gameOver = new GameOver();
                gameOver.ShowDialog();
                this.Close();

            }
        }

    }
}
