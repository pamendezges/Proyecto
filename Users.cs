using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Users : Persons
    {

        private List<User> logins = new List<User>();

        public Users()
        {
            this.logins = new List<User>();
        }

        public void AddPerson(User u)
        {
            if (u != null)
            {
                logins.Add(u);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeletePerson(User u)
        {
            if (u != null & logins.Contains(u))
            {
                logins.Remove(u);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowPersons()
        {
            Console.WriteLine("List of Users (id, name)");
            int i = 0;
            while (i < logins.Count)
            {
                Console.WriteLine(logins[i].Id + " _ " + logins[i].Name);
                i++; 
            }
            Console.WriteLine();
        }

        public void ModifyPerson(User u)
        {

        }

    }
}
