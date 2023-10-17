using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace MendezPablo_Proyecto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persons people = new Persons();
            Admins administrators = new Admins();
            Users users = new Users();
            Contents movies = new Contents();
            Films films = new Films();
            Documentaries documentaries = new Documentaries();

            Admin a1 = new Admin(1, "Knekro", "1234", 3, true);
            Admin a2 = new Admin(2, "Wanillo", "1234", 2, true);
            Admin a3 = new Admin(3, "AlexelCapo", "1234", 1, false);
            User u1 = new User(11, "Paco", "1234", "Basic", 1, false);
            User u2 = new User(12, "Elisa", "1234", "Premium", 2, true);
            User u3 = new User(13, "María", "1234", "AdVersion", 3, false);

            people.AddPerson(a1);
            people.AddPerson(a2);
            people.AddPerson(a3);
            administrators.AddPerson(a1);
            administrators.AddPerson(a2);
            administrators.AddPerson(a3);

            people.AddPerson(u1);
            people.AddPerson(u2);
            people.AddPerson(u3);
            users.AddPerson(u1);
            users.AddPerson(u2);
            users.AddPerson(u3);

            people.ShowPersons();
            administrators.ShowPersons();
            users.ShowPersons();


        }

        public static void UserManagement()
        {



        }

        public static void MenuContent()
        {



        }


    }
}
