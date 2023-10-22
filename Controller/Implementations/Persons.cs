using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MendezPablo_Proyecto.Controller.Interfaces;
using MendezPablo_Proyecto.Modelo.Person;

namespace MendezPablo_Proyecto.Controller.Implementations
{
    class Persons : IPersonManagement
    {

        private List<Person> logins = new List<Person>();

        public List<Person> Logins { get => logins; set => logins = value; }

        public Persons()
        {
            Logins = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            if (p != null)
            {
                Logins.Add(p);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeletePerson(Person p)
        {
            if (p != null & Logins.Contains(p))
            {
                Logins.Remove(p);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowPersons()
        {
            Console.WriteLine("List of Persons (id, name)");
            int i = 0;
            while (i < Logins.Count)
            {
                Console.WriteLine(Logins[i].Id + " _ " + Logins[i].Name);
                i++;
            }
            Console.WriteLine();
        }

        public void ModifyPerson(Person p)
        {

        }



    }
}
