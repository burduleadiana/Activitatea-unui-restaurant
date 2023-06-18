using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class GestionareProduse : Form
    {
        List<Produs> listaProduse = new List<Produs>();
        //private ListView listViewProduse = new ListView();
        private string connString;

        public GestionareProduse()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = meniu.accdb";
        }

        private void AfisareProduseDisponibile()
        {
            listView1.Items.Clear();
            foreach (Produs p in listaProduse)
            {
                ListViewItem itm = new ListViewItem(p.IdProdus.ToString());
                itm.SubItems.Add(p.DenumireProdus);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.Descriere);
                itm.SubItems.Add(p.Stoc.ToString());
                itm.SubItems.Add(string.Join(", ", p.Ingrediente)); // Folosim Join pentru a combina ingrediente separate prin virgulă
                listView1.Items.Add(itm); // Adăugăm elementul în ListView
            }
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            AdaugaProdus formularAdaugareProdus = new AdaugaProdus(listaProduse);
            DialogResult result = formularAdaugareProdus.ShowDialog();

            if (result == DialogResult.OK)
            {
                AfisareProduseDisponibile();
            }
        }

        private void btnAfisareProduse_Click(object sender, EventArgs e)
        {
            AfisareProduseDisponibile();
        }

        private void btnValoareTotala_Click(object sender, EventArgs e)
        {
            float valoareTotala = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                Produs produs = listaProduse[item.Index];
                valoareTotala += produs.calculValoareTotala();
            }

            tbValoareTotala.Text = valoareTotala.ToString();
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    string denumire = itm.SubItems[0].Text;
                    for (int i = listaProduse.Count - 1; i >= 0; i--)
                    {
                        if (listaProduse[i].DenumireProdus == denumire)
                        {
                            listaProduse.RemoveAt(i);
                        }
                    }
                    itm.Remove();
                }

        }

        private void incarcaMeniuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incarcaMeniuDinDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM meniu", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "meniu");
            DataTable tabela = ds.Tables["meniu"];

            listView1.Items.Clear();

            foreach (DataRow row in tabela.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID"].ToString());
                item.SubItems.Add(row["Denumire"].ToString());
                item.SubItems.Add(row["Pret"].ToString());
                item.SubItems.Add(row["Descriere"].ToString());
                item.SubItems.Add(row["Stoc"].ToString());
                item.SubItems.Add(row["Ingrediente"].ToString());

                listView1.Items.Add(item);
            }
        }

        private void genereazaFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder contentBuilder = new StringBuilder();

            // Adaugă titlul "Meniul"
            contentBuilder.AppendLine("Meniul");

            foreach (ListViewItem item in listView1.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    contentBuilder.Append(subItem.Text);
                    contentBuilder.Append("\t"); 
                }

                contentBuilder.AppendLine();
            }
            string fileName = "Meniul.txt";
            System.IO.File.WriteAllText(fileName, contentBuilder.ToString());

            MessageBox.Show("Fișierul text a fost generat cu succes!");
        }

        //private void genereazaFisierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        //{


        //    // Crează un obiect XmlDocument pentru a construi fișierul XML
        //    XmlDocument xmlDoc = new XmlDocument();

        //    // Crează elementul radacina "Meniu"
        //    XmlElement rootElement = xmlDoc.CreateElement("Meniu");
        //    xmlDoc.AppendChild(rootElement);

        //    // Parcurge fiecare element din ListView și adaugă informațiile în fișierul XML
        //    foreach (ListViewItem item in listView1.Items)
        //    {
        //        // Crează un element "Produs"
        //        XmlElement produsElement = xmlDoc.CreateElement("Produs");
        //        rootElement.AppendChild(produsElement);

        //        // Parcurge fiecare sub-element din elementul ListView
        //        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
        //        {
        //            // Obține numele coloanei asociate sub-elementului
        //            string columnName = listView1.Columns[subItem.Index].Text;

        //            // Adaugă valoarea sub-elementului ca atribut al elementului "Produs"
        //            produsElement.SetAttribute(columnName, subItem.Text);
        //        }
        //    }

        //    // Salvează fișierul XML cu numele "Meniu.xml"
        //    string fileName = "Meniu.xml";
        //    xmlDoc.Save(fileName);

        //    MessageBox.Show("Fișierul XML a fost generat cu succes!");
    }
    }


    
 

