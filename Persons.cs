using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Persons : PersonManagement
    {

        private List<Person> logins = new List<Person>();

        public Persons()
        {
            this.logins = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            if (p != null)
            {
                logins.Add(p);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeletePerson(Person p)
        {
            if (p != null & logins.Contains(p))
            {
                logins.Remove(p);
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
            while (i < logins.Count)
            {
                Console.WriteLine(logins[i].Id + " _ " + logins[i].Name);
                i++;
            }
            Console.WriteLine();
        }

        public void ModifyPerson(Person p)
        {

        }

        

    }
}
