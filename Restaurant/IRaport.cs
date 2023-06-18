using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal interface IRaport
    {
            string GenerareRaport(); // Metoda pentru generarea raportului

            void SalvareRaport(string filePath); // Metoda pentru salvarea raportului într-un fișier

            void RestaurareRaport(string filePath); // Metoda pentru restaurarea raportului dintr-un fișier
    }

    
}
