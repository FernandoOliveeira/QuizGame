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

namespace Quiz_Game.ViewLayer
{
    public partial class PerguntaUm : Form
    {
        public PerguntaUm()
        {
            InitializeComponent();
        }

        private void PerguntaUm_Load(object sender, EventArgs e)
        {
            TSSLVidas.Text = "Vidas: " + MainMenu.Vidas;
        }

        private void RespostaCerta_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, "..", "..", @".\sound effects\ninho-de-mafagafos.wav"));

            SoundPlayer soundPlayer = new SoundPlayer(newPath);
            soundPlayer.Play();
        }

        private void RespostaErrada_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path,"..","..", @".\sound effects\faustao-errou.wav"));

            SoundPlayer soundPlayer = new SoundPlayer(newPath);
            soundPlayer.Play();
        }
    }
}
