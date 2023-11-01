using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MendezPablo_Proyecto.Controlador.DBController;
using MendezPablo_Proyecto.Controller.Implementations;
using MendezPablo_Proyecto.Modelo.Content;
using MendezPablo_Proyecto.Modelo.Person;
using Microsoft.VisualBasic;

namespace MendezPablo_Proyecto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persons people = new Persons();
            Contents movies = new Contents();

            FileUserManagement fileUserManagement = new FileUserManagement();
            FileAdminManagement fileAdminManagement = new FileAdminManagement();
            FileFilmManagement fileFilmManagement = new FileFilmManagement();
            FileDocumentaryManagement fileDocumentaryManagement = new FileDocumentaryManagement();


            Person a1 = new Admin(1, "Knekro", "1234", 3, true);
            Person a2 = new Admin(2, "Wanillo", "1234", 2, true);
            Person a3 = new Admin(3, "AlexelCapo", "1234", 1, false);
            Person u1 = new User(4, "Paco", "1234", "Basic", 1, false);
            Person u2 = new User(5, "Elisa", "1234", "Premium", 2, true);
            Person u3 = new User(6, "Maria", "1234", "AdVersion", 3, false);

            people.AddPerson(a1);
            people.AddPerson(a2);
            people.AddPerson(a3);
            people.AddPerson(u1);
            people.AddPerson(u2);
            people.AddPerson(u3);

            people.ShowPersons();

            fileUserManagement.SaveToFile(people);
            fileAdminManagement.SaveToFile(people);


            Content f1 = new Film(1, "Titanic", "Emocionante", "Under the Water Productions", "James Cameron", "Leonardo DiCaprio");
            Content f2 = new Film(2, "Titanic", "Emocionante", "Under the Water Productions", "James Cameron", "Leonardo DiCaprio");
            Content f3 = new Film(3, "Titanic", "Emocionante", "Under the Water Productions", "James Cameron", "Leonardo DiCaprio");
            Content d1 = new Documentary(4,"Planeta Tierra", "Naturaleza", "National Geographic", true);
            Content d2 = new Documentary(5,"Planeta Tierra", "Naturaleza", "National Geographic", true);
            Content d3 = new Documentary(6,"Planeta Tierra", "Naturaleza", "National Geographic", true);

            movies.AddContent(f1);
            movies.AddContent(f2);
            movies.AddContent(f3);
            movies.AddContent(d1);
            movies.AddContent(d2);
            movies.AddContent(d3);

            movies.ShowContent();

            fileFilmManagement.SaveToFile(movies);
            fileDocumentaryManagement.SaveToFile(movies);
        }

        public static void UserManagement()
        {



        }

        public static void MenuContent()
        {



        }


    }
}
