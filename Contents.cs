using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Contents : ContentManagement
    {

        private List<Content> billboard = new List<Content>();

        public Contents()
        {
            this.billboard = new List<Content>();
        }

        public void AddContent(Content c)
        {
            if (c != null)
            {
                billboard.Add(c);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeleteContent(Content c)
        {
            if (c != null & billboard.Contains(c))
            {
                billboard.Remove(c);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowContent()
        {
            int i = 0;
            while (i < billboard.Count)
            {
                Console.WriteLine(billboard[i].Id + " _ " + billboard[i].Title);
            }
        }

        public void RateContent(Content c)
        {
            int sum = c.Rating * c.NumOfRates;
            int rate = 0;
            Console.WriteLine("¿Que nota le das a " + c.Title + "?. Selecciona un numero del 1 al 5.");
            rate = Convert.ToInt32(Console.ReadLine());
            sum = sum+rate;
            c.NumOfRates++;
            c.Rating = sum / c.NumOfRates;
        }

    }
}
