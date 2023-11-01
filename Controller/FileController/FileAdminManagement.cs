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
    class FileAdminManagement
    {

        public void SaveToFile(Persons people)
        {

            var jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"jsonFiles\AdminList.json");

            if (File.Exists(jsonFolder))
            {
                File.Delete(jsonFolder);
            }

            using (StreamWriter sw = File.CreateText(jsonFolder))
            {
                foreach (Person person in people.Logins)
                {
                    if (person is Admin admin)
                    {
                        string jsonString = JsonSerializer.Serialize(admin);
                        sw.WriteLine(jsonString);
                    }

                }

            }
            Console.WriteLine(" \r\n ");
        }



    }
}
