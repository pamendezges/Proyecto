using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MendezPablo_Proyecto.Controller.Interfaces;
using MendezPablo_Proyecto.Modelo.Content;

namespace MendezPablo_Proyecto.Controller.Implementations
{
    class Contents : IContentManagement
    {

        private List<Content> billboard = new List<Content>();

        public List<Content> Billboard { get => billboard; set => billboard = value; }

        public Contents()
        {
            Billboard = new List<Content>();
        }

        public void AddContent(Content c)
        {
            if (c != null)
            {
                Billboard.Add(c);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeleteContent(Content c)
        {
            if (c != null & Billboard.Contains(c))
            {
                Billboard.Remove(c);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowContent()
        {
            Console.WriteLine("List of Movies (id, name)");
            int i = 0;
            while (i < Billboard.Count)
            {
                Console.WriteLine(Billboard[i].Id + " _ " + Billboard[i].Title);
                i++;
            }
            Console.WriteLine();
        }

        public void RateContent(Content c) //AVERAGE
        {
            int sum = c.Rating * c.NumOfRates;
            int rate = 0;
            Console.WriteLine("¿Que nota le das a " + c.Title + "?. Selecciona un numero del 1 al 5.");
            rate = Convert.ToInt32(Console.ReadLine());
            sum = sum + rate;
            c.NumOfRates++;
            c.Rating = sum / c.NumOfRates;
        }

    }
}
