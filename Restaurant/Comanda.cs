using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Comanda : ICloneable, IComparable<Comanda>, IRaport
    {
        private int idComanda;
        private DateTime dataComanda;
        private List<string> listaProduse;
        private float total;
        private string status;

        public Comanda(int idComanda, DateTime dataComanda, List<string> listaProduse, float total, string status)
        {
            this.idComanda = idComanda;
            this.dataComanda = dataComanda;
            this.listaProduse = listaProduse;
            this.total = total;
            this.status = status;
        }

        public int IdComanda { get => idComanda; set => idComanda = value; }
        public DateTime DataComanda { get => dataComanda; set => dataComanda = value; }
        public float Total { get => total; set => total = value; }
        internal List<string> ListaProduse { get => listaProduse; set => listaProduse = value; }
        public string Status { get => status; set => status = value; }

        //public float CalculeazaTotal()
        //{
        //    float total = 0;
        //    foreach (string produs in ListaProduse)
        //    {
        //        total += produs.Pret;
        //    }
        //    Total = total;
        //    return total;
        //}

        public object Clone()
        {
            Comanda clone = new Comanda(idComanda, dataComanda, listaProduse, total, status);
            clone.listaProduse = new List<string>(listaProduse) ;
            clone.total = total;
            return clone;
        }

        public int CompareTo(Comanda other)
        {
            return idComanda.CompareTo(other.idComanda);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string GenerareRaport()
        {
            string raport = "Detalii comanda:\n";
            raport += "ID: " + IdComanda + "\n";
            raport += "Data: " + DataComanda.ToString() + "\n";
            raport += "Produse:\n";

            foreach (string produs in ListaProduse)
            {
                raport += "- " + produs + "\n";
            }

            raport += "Total: " + Total.ToString()+"RON" + "\n";
            raport += "Status: " + Status + "\n";

            return raport;
        }

        public void SalvareRaport(string filePath)
        {
            string raport = GenerareRaport();
            File.WriteAllText(filePath, raport);
        }

        public void RestaurareRaport(string filePath)
        {
            string raport = GenerareRaport();
            File.WriteAllText(filePath, raport);
        }
    }
}
