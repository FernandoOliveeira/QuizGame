using Quiz_Game.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game.ViewLayer
{
    public partial class PerguntaTres : Form
    {
        public PerguntaTres()
        {
            InitializeComponent();
        }

        Thread thread;
        Functions functions = new Functions();

        private void PerguntaTres_Load(object sender, EventArgs e)
        {
            TSSLVidas.Text = "Vidas: " + MainMenu.Vidas;
        }

        private void RespostaErrada_Click(object sender, EventArgs e)
        {
            functions.TocarRespostaErrada();

            MainMenu.Vidas--;
            TSSLVidas.Text = "Vidas: " + MainMenu.Vidas;
        }

        private void RespostaCerta_Click(object sender, EventArgs e)
        {
            functions.TocarRespostaCerta();

            this.Close();
            thread = new Thread(AbrirPerguntaQuatro);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void AbrirPerguntaQuatro()
        {
            throw new NotImplementedException();
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
