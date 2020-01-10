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
    public partial class GameOver : Form
    {
        Thread thread;

        public GameOver()
        {
            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();

            thread = new Thread(AbrirMainMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void AbrirMainMenu()
        {
            Application.Run(new MainMenu());
        }
    }
}
