using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//reprezinta un produs disponibil in restaurant
namespace Restaurant
{
     public class Produs : ICloneable, IComparable
    {
        private int idProdus;
        private string denumireProdus;
        private float pret;
        private string descriere;
        private int stoc;
        private List<string> ingrediente;

        public Produs(int idProdus, string denumireProdus, float pret, string descriere, int stoc, List<string> ingrediente)
        {
            this.idProdus = idProdus;
            this.denumireProdus = denumireProdus;
            this.pret = pret;
            this.descriere = descriere;
            this.stoc = stoc;
            this.ingrediente=ingrediente;
        }


        public string DenumireProdus { get => denumireProdus; set => denumireProdus = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public int Stoc { get => stoc; set => stoc = value; }
        public List<string> Ingrediente { get => ingrediente; set => ingrediente = value; }
        public int IdProdus { get => idProdus; set => idProdus = value; }

        //supraincarcarea operatorului <
        public static bool operator <(Produs p1, Produs p2)
        {
            return p1.pret < p2.pret;
        }

        public static bool operator>(Produs p1, Produs p2)
        {
            return p1.pret > p2.pret;
        }

        //supraincarcarea operatorului +
        public static float operator+(Produs p1, Produs p2)
        {
            return p1.pret + p2.pret;
        }
        //supraincarcarea operatorului ++ (incrementarea pretului cu 10%)
        public static Produs operator++(Produs p)
        {
            p.pret += p.pret * 0.1f;
            return p;
        }

        //supraincarcarea operatorului -- (decrementarea pretului cu 10%)
        public static Produs operator--(Produs p)
        {
            p.pret -= p.pret * 0.1f;
            return p;
        }

        //supraincarcarea operatorului de cast la intreg pentru pret
        public static explicit operator int(Produs p)
        {
            return (int)p.pret;
        }

        public float calculValoareTotala()
        {
            return pret * stoc;
        }

        public void actualizeazaStoc(int cantitate)
        {
            if (Stoc + cantitate < 0)
            {
                throw new Exception("Stocul nu poate fi negativ");
            }
            Stoc += cantitate;
        }

        public void AdaugaIngredient(string ingredient)
        {
            Ingrediente.Add(ingredient);
        }

        public void EliminaIngredient(string ingredient)
        {
            Ingrediente.Remove(ingredient);
        }

        

        //metoda pentru clonarea unui obiect de tip Produs
        public object Clone()
        {
            return new Produs(idProdus,denumireProdus, pret, descriere, stoc, ingrediente);
        }

        //metoda CompareTo pentru sortarea obiectelor de tip Produs
        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return 1;
            }

            Produs otherProdus = obj as Produs;
            if (otherProdus != null)
            {
                return this.pret.CompareTo(otherProdus.pret);

            }
            else
            {
                throw new Exception("Obiectul nu este de tip Produs");
            }
        }

        public override string ToString()
        {
            string message= $"Produsul cu id:\"{IdProdus}\" - \"{DenumireProdus}\" a fost adăugat cu succes!\n\n" +
                $"Preț: {Pret}\n" +
                $"Descriere: {Descriere}\n" +
                $"Stoc: {Stoc}\n" +
                $"Ingrediente: {string.Join(", ", Ingrediente)}";
            return message;
        }
    }
}
