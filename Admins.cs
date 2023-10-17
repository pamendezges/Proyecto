using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Admins : Persons
    {

        private List<Admin> logins = new List<Admin>();

        public Admins()
        {
            this.logins = new List<Admin>();
        }

        public void AddPerson(Admin a)
        {
            if (a != null)
            {
                logins.Add(a);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeletePerson(Admin a)
        {
            if (a != null & logins.Contains(a))
            {
                logins.Remove(a);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowPersons()
        {
            Console.WriteLine("List of Admins (id, name)");
            int i = 0;
            while (i < logins.Count)
            {
                Console.WriteLine(logins[i].Id + " _ " + logins[i].Name);
                i++;
            }
            Console.WriteLine();
        }

        public void ModifyPerson(Admin a)
        {

        }

    }
}
