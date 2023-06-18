using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Restaurant
{
    public partial class GestionareComenzi : Form
    {
        List<Comanda> listaComenzi = new List<Comanda>();
        private ErrorProvider errorProvider;

        public GestionareComenzi()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            if (ValidareCampuri())
            {
                try
                {
                    int idComanda = Convert.ToInt32(tbIdComanda.Text);
                    DateTime dataComanda = dateTimePicker1.Value;
                    string produseText = tbListaProduse.Text;
                    string[] produseArray = produseText.Split(',');
                    List<string> produse = new List<string>();

                    foreach (string produs in produseArray)
                    {
                        produse.Add(produs.Trim());
                    }

                    int total = Convert.ToInt32(tbTotal.Text);
                    string statusComanda = cbStatus.Text;

                    Comanda comandaNoua = new Comanda(idComanda, dataComanda, produse, total, statusComanda);
                    listaComenzi.Add(comandaNoua);
                    MessageBox.Show("Comanda a fost plasată cu succes!" + comandaNoua.ToString());
                }
                catch
                {
                    MessageBox.Show("A apărut o eroare la adăugarea comenzii!");
                }
                finally
                {
                    tbIdComanda.Clear();
                    tbListaProduse.Clear();
                    tbTotal.Clear();
                }
            }
        }

        private bool ValidareCampuri()
        {
            bool campuriValide = true;

            if (string.IsNullOrWhiteSpace(tbIdComanda.Text))
            {
                errorProvider.SetError(tbIdComanda, "Introduceți un ID de comandă valid.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbIdComanda, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbListaProduse.Text))
            {
                errorProvider.SetError(tbListaProduse, "Introduceți lista de produse.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbListaProduse, string.Empty);
            }

            if (!int.TryParse(tbTotal.Text, out int total) || total <= 0)
            {
                errorProvider.SetError(tbTotal, "Introduceți un total valid pentru comandă.");
                campuriValide = false;
            }
            else
            {
                errorProvider.SetError(tbTotal, string.Empty);
            }

            return campuriValide;
        }

        private void btnAfiseazaComenzi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Comanda c in listaComenzi)
            {
                ListViewItem itm = new ListViewItem(c.IdComanda.ToString());
                itm.SubItems.Add(c.DataComanda.ToString());
                itm.SubItems.Add(string.Join(", ", c.ListaProduse));
                itm.SubItems.Add(c.Total.ToString());
                itm.SubItems.Add(c.Status);

                listView1.Items.Add(itm);
            }
        }

        private void genereazaChitantaTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.CheckedItems.Count > 0)
                {
                    ListViewItem linieSelectata = listView1.CheckedItems[0];
                    int idComanda = int.Parse(linieSelectata.SubItems[0].Text);
                    string numeFisier = "Chitanta - " + idComanda + ".txt";
                    Comanda comanda = listaComenzi.FirstOrDefault(c => c.IdComanda == idComanda);

                    if (comanda != null)
                    {
                        string raport = comanda.GenerareRaport();
                        File.WriteAllText(numeFisier, raport);
                        MessageBox.Show("Fișierul a fost generat cu succes: " + numeFisier, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Comanda cu id-ul specificat nu a fost găsită!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nu a fost selectată nicio comandă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare în generarea fișierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printeazaChitantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.CheckedItems.Count > 0)
                {
                    ListViewItem linieSelectata = listView1.CheckedItems[0];
                    int idComanda = int.Parse(linieSelectata.SubItems[0].Text);
                    Comanda comanda = listaComenzi.FirstOrDefault(c => c.IdComanda == idComanda);

                    if (comanda != null)
                    {
                        PrintDocument printDocument = new PrintDocument();
                        printDocument.PrintPage += (s, ev) =>
                        {
                            string raport = comanda.GenerareRaport();
                            Font font = new Font("Arial", 12);
                            float x = ev.MarginBounds.Left;
                            float y = ev.MarginBounds.Top;
                            ev.Graphics.DrawString(raport, font, Brushes.Black, x, y);
                            ev.HasMorePages = false;
                        };
                        printDocument.Print();
                    }
                    else
                    {
                        MessageBox.Show("Comanda cu id-ul specificat nu a fost găsită!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nu a fost selectată nicio comandă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare în generarea chitanței: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

