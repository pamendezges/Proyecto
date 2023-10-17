using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Documentaries : Contents
    {

        private List<Documentary> billboard = new List<Documentary>();

        public Documentaries() : base() { }

        public void AddDocumentary(Documentary d)
        {
            if (d != null)
            {
                billboard.Add(d);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeleteDocumentary(Documentary d)
        {
            if (d != null & billboard.Contains(d))
            {
                billboard.Remove(d);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowDocumentary()
        {
            int i = 0;
            while (i < billboard.Count)
            {
                Console.WriteLine(billboard[i].Id + " _ " + billboard[i].Title);
            }
        }

        public void RateDocumentary(Documentary d)
        {
            int sum = d.Rating * d.NumOfRates;
            int rate = 0;
            Console.WriteLine("¿Que nota le das a " + d.Title + "?. Selecciona un numero del 1 al 5.");
            rate = Convert.ToInt32(Console.ReadLine());
            sum = sum + rate;
            d.NumOfRates++;
            d.Rating = sum / d.NumOfRates;
        }

    }
}
