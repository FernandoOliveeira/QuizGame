using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game.Control
{
    class Functions
    {
        public void TocarRespostaErrada()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, "..", "..", @".\sound effects\faustao-errou.wav"));

            SoundPlayer soundPlayer = new SoundPlayer(newPath);
            soundPlayer.Play();
        }

        public void TocarRespostaCerta()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, "..", "..", @".\sound effects\Certa Resposta.wav"));

            SoundPlayer soundPlayer = new SoundPlayer(newPath);
            soundPlayer.Play();
        }

        public void TocarGameOver()
        {
            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, "..", "..", @".\sound effects\GameOver.wav"));

            SoundPlayer soundPlayer = new SoundPlayer(newPath);
            soundPlayer.Play();
        }
    }
}
