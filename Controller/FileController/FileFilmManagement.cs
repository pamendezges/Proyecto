using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MendezPablo_Proyecto.Controller.Implementations;
using MendezPablo_Proyecto.Modelo.Content;

namespace MendezPablo_Proyecto.Controlador.DBController
{
    class FileFilmManagement
    {

        public void SaveToFile(Contents content)
        {
            string path = @"C:\Users\pamendez\Documents\test.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Film film in content.Billboard)
                {
                    sw.WriteLine(film.ToString());

                }

            }
            Console.WriteLine(" \r\n ");
        }

    }
}
