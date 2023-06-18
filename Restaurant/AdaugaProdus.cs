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
    public partial class AdaugaProdus : Form
    {
        public List<Produs> listaProduse;
        private ErrorProvider errorProvider;

        public AdaugaProdus(List<Produs> listaProduse)
        {
            InitializeComponent();
            this.listaProduse = listaProduse;
            errorProvider = new ErrorProvider();
        }

        private void btnSalvareProdus_Click(object sender, EventArgs e)
        {
            if (ValidareCampuri())
            {
                int idProdus = int.Parse(tbIdProdus.Text);
                string denumire = tbDenumireProdus.Text;
                float pret = float.Parse(tbPret.Text);
                string descriere = tbDescriere.Text;
                int stoc = int.Parse(tbStoc.Text);
                string ingredienteText = tbIngrediente.Text;

                string[] ingredienteArray = ingredienteText.Split(',');

                List<string> ingrediente = new List<string>();

                foreach (string ingredient in ingredienteArray)
                {
                    ingrediente.Add(ingredient.Trim());
                }

                Produs produsNou = new Produs(idProdus, denumire, pret, descriere, stoc, ingrediente);

                listaProduse.Add(produsNou);

                MessageBox.Show("Produsul a fost adăugat cu succes: " + produsNou.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidareCampuri()
        {
            bool campuriValide = true;

            if (string.IsNullOrWhiteSpace(tbIdProdus.Text))
            {
                errorProvider.SetError(tbIdProdus, "Introduceți un ID de produs valid.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbIdProdus, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbDenumireProdus.Text))
            {
                errorProvider.SetError(tbDenumireProdus, "Introduceți o denumire de produs validă.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbDenumireProdus, string.Empty);
            }

            if (!float.TryParse(tbPret.Text, out float pret) || pret <= 0)
            {
                errorProvider.SetError(tbPret, "Introduceți un preț valid pentru produs.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbPret, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbDescriere.Text))
            {
                errorProvider.SetError(tbDescriere, "Introduceți o descriere validă pentru produs.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbDescriere, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbStoc.Text) || !int.TryParse(tbStoc.Text, out int stoc) || stoc < 0)
            {
                errorProvider.SetError(tbStoc, "Introduceți un stoc valid pentru produs.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbStoc, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbIngrediente.Text))
            {
                errorProvider.SetError(tbIngrediente, "Introduceți ingrediente valide pentru produs.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbIngrediente, string.Empty);
            }

            return campuriValide;
        }
    }
}