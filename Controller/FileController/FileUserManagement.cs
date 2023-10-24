using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MendezPablo_Proyecto.Controller.Implementations;
using MendezPablo_Proyecto.Modelo.Person;

namespace MendezPablo_Proyecto.Controlador.DBController
{
    class FileUserManagement
    {

        public void SaveToFile(Persons person)
        {
            string path = @"C:\Users\pamendez\Documents\UserList.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (User user in person.Logins)
                {
                    string jsonString = JsonSerializer.Serialize(user);
                    sw.WriteLine(jsonString);

                }

            }
            Console.WriteLine(" \r\n ");
        }



    }
}
