﻿using Quiz_Game.ViewLayer;
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

namespace Quiz_Game
{
    public partial class MainMenu : Form
    {
        Thread thread;

        public MainMenu()
        {
            InitializeComponent();
        }

        public static int Vidas { get; private set; } // Número de continues que o player terá

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            btnStartGame.Left = (this.ClientSize.Width - btnStartGame.Width) / 2; // Mantém o btnStartGame centralizado
            btnStartGame.Top = (this.ClientSize.Height - btnStartGame.Height) / 2; // Mantém o btnStartGame centralizado
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Vidas = 3; // Quantidade de vidas inicial
            this.Close();
            thread = new Thread(AbrirPerguntaUm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void AbrirPerguntaUm()
        {
            Application.Run(new PerguntaUm());
        }
    }
}
