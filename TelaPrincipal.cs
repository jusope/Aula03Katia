using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Katia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form tela;

        private void plPrincipal_Paint(object sender, PaintEventArgs e)
        {
            tela = new TelaCliente
            {
                TopLevel=false,
                FormBorderStyle= FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            plPrincipal.Controls.Add(tela);
            tela.Show();
        }
    }
}
