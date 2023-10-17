using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Films : Contents
    {

        private List<Film> billboard = new List<Film>();

        public Films() : base() { }

        public void AddFilm(Film f)
        {
            if (f != null)
            {
                billboard.Add(f);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeleteFilm(Film f)
        {
            if (f != null & billboard.Contains(f))
            {
                billboard.Remove(f);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowFilms()
        {
            int i = 0;
            while (i < billboard.Count)
            {
                Console.WriteLine(billboard[i].Id + " _ " + billboard[i].Title);
            }
        }

        public void RateFilm(Film f)
        {
            int sum = f.Rating * f.NumOfRates;
            int rate = 0;
            Console.WriteLine("¿Que nota le das a " + f.Title + "?. Selecciona un numero del 1 al 5.");
            rate = Convert.ToInt32(Console.ReadLine());
            sum = sum + rate;
            f.NumOfRates++;
            f.Rating = sum / f.NumOfRates;
        }

    }
}
