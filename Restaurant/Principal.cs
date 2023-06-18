using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            GestionareProduse gestionareProduse = new GestionareProduse();
            gestionareProduse.ShowDialog();
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            GestionareComenzi gestionareComenzi = new GestionareComenzi();
            gestionareComenzi.ShowDialog();
        }
    }
}
