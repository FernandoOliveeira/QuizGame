﻿using Quiz_Game.Control;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Quiz_Game.ViewLayer
{
    public partial class PerguntaDois : Form
    {
        public PerguntaDois()
        {
            InitializeComponent();
        }

        Thread thread;
        Functions functions = new Functions();

        private void PerguntaDois_Load(object sender, EventArgs e)
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
            thread = new Thread(AbrirPerguntaTres);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

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

        private void AbrirPerguntaTres()
        {
            Application.Run(new PerguntaTres());
        }

    }
}
