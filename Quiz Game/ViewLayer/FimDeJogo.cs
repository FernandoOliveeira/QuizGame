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
    public partial class FimDeJogo : Form
    {
        public FimDeJogo()
        {
            InitializeComponent();
        }

        Thread thread;
        Functions functions = new Functions();

        private void VoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            functions.TocarTrololo();

            this.Close();
            thread = new Thread(AbrirMenuPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void AbrirMenuPrincipal()
        {
            Application.Run(new MainMenu());
        }
    }
}
