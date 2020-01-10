using System;
using System.Windows.Forms;
using Quiz_Game.Control;

namespace Quiz_Game.ViewLayer
{
    public partial class PerguntaUm : Form
    {
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
