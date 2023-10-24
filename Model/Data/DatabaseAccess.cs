using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto.Modelo.Data
{
    class DatabaseAccess
    {

        //public static string path = "C:\\Users\\pamendez\\source\\repos\\ahorkadoAinaraDB\\palabras.txt";
        //static public void leerFichero()
        //{

        //    StreamReader miTexto = new StreamReader(path);
        //    System.Console.Write(miTexto.ReadToEnd());

        //}

        //static public void volcadoFichero()
        //{

        //    string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\pamendez\source\repos\ahorkadoAinaraDB\ahorkado.mdb";
        //    string consulta = "SELECT * FROM palabras";
        //    string data = "";

        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //    }

        //    using (OleDbConnection conexion = new OleDbConnection(ruta))
        //    {
        //        // Create a command and set its connection    
        //        OleDbCommand comando = new OleDbCommand(consulta, conexion);
        //        // Open the connection and execute the select command.    
        //        try
        //        {
        //            // Open connecton    
        //            conexion.Open();

        //            Console.WriteLine("Conexión con la base de datos establecida.");

        //            // Execute command    
        //            using (StreamWriter sw = File.CreateText(path))
        //            {
        //                using (OleDbDataReader miTabla = comando.ExecuteReader())
        //                {
        //                    while (miTabla.Read())
        //                    {
        //                        data = miTabla["Id"].ToString() + miTabla["palabra"].ToString() + miTabla["nivel"].ToString();
        //                        sw.WriteLine(data);
        //                    }
        //                }
        //            }
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Problemicas txato!!" + ex.Message);
        //        }

        //    }
        //}

        //static public void leerBD()
        //{
        //    string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\pamendez\source\repos\ahorkadoAinaraDB\ahorkado.mdb";
        //    string consulta = "SELECT * FROM palabras";
        //    // Create a connection    
        //    using (OleDbConnection conexion = new OleDbConnection(ruta))
        //    {
        //        // Create a command and set its connection    
        //        OleDbCommand comando = new OleDbCommand(consulta, conexion);
        //        // Open the connection and execute the select command.    
        //        try
        //        {
        //            // Open connecton    
        //            conexion.Open();
        //            // Execute command    
        //            using (OleDbDataReader miTabla = comando.ExecuteReader())
        //            {
        //                Console.WriteLine("------------Tabla Clientes----------------");
        //                while (miTabla.Read())
        //                {
        //                    Console.WriteLine("{0} {1} {2}", miTabla["Id"].ToString(), miTabla["palabra"].ToString(), miTabla["nivel"].ToString());
        //                }
        //            }
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Problemicas txato!!" + ex.Message);
        //        }

        //    }
        //    System.Console.ReadKey();


        //}
        //static public void eliminarDeDB()
        //{
        //    string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\pamendez\source\repos\ahorkadoAinaraDB\ahorkado.mdb";
        //    string consulta = "DELETE FROM palabras WHERE Id=";
        //    int id;

        //    System.Console.WriteLine("¿Qué id quieres eliminar?");
        //    id = int.Parse(System.Console.ReadLine());
        //    consulta = consulta + id;

        //    // Create a connection    
        //    using (OleDbConnection conexion = new OleDbConnection(ruta))
        //    {
        //        // Create a command and set its connection    
        //        OleDbCommand comando = new OleDbCommand(consulta, conexion);
        //        // Open the connection and execute the select command.    
        //        try
        //        {
        //            // Open connecton    
        //            conexion.Open();
        //            // Execute command    

        //            OleDbDataReader miTabla = comando.ExecuteReader();

        //            Console.WriteLine("Eliminado!");
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Problemicas txato!!" + ex.Message);
        //        }

        //    }
        //    System.Console.ReadKey();


        //}
        //static public void insertarEnBD()
        //{
        //    //La ruta de la BD
        //    string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\pamendez\source\repos\ahorkadoAinaraDB\ahorkado.mdb";
        //    //Leemos lo que vamos a insertar
        //    System.Console.WriteLine("Inserta el identificador de la palabra, por favor:");
        //    int id = int.Parse(System.Console.ReadLine());
        //    System.Console.WriteLine("Inserta una palabra, por favor:");
        //    String palabra = System.Console.ReadLine();
        //    System.Console.WriteLine("Inserta el nivel de dificultad de la palabra, por favor:");
        //    int nivel = int.Parse(System.Console.ReadLine());

        //    //Preparamos la query(consulta)
        //    string consulta = "INSERT INTO Palabras(Id, palabra, nivel) VALUES (" + id + "  , '" + palabra + "'," + nivel + ")";
        //    System.Console.WriteLine(consulta);
        //    // Create a connection    
        //    using (OleDbConnection conexion = new OleDbConnection(ruta))
        //    {
        //        // Create a command and set its connection    
        //        OleDbCommand comando = new OleDbCommand(consulta, conexion);
        //        // Open the connection and execute the select command.    
        //        try
        //        {
        //            // Open connecton    
        //            conexion.Open();
        //            // Execute command    
        //            OleDbDataReader miTabla = comando.ExecuteReader();
        //            Console.WriteLine("Insertado correctamente");
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Problemicas txato!!" + ex.Message);
        //        }

        //    }
        //    System.Console.ReadKey();

        //}
        //static public void actualizarEnBD()
        //{
        //    //La ruta de la BD
        //    string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\pamendez\source\repos\ahorkadoAinaraDB\ahorkado.mdb";
        //    int opc;
        //    int id;
        //    String palabra = "";
        //    int nivel = 0;
        //    String consultaBase = "UPDATE palabras SET  ";
        //    String consultaPalabra = "";
        //    String consultaNivel = "";
        //    System.Console.WriteLine("¿Qué id quieres actualizar?");
        //    id = int.Parse(System.Console.ReadLine());
        //    System.Console.WriteLine("¿Qué quieres actualizar?\n 1)Palabra\n 2)Nivel\n 0)Salir");
        //    opc = int.Parse(System.Console.ReadLine());
        //    do
        //    {
        //        switch (opc)
        //        {
        //            case 1:
        //                //Leemos lo que vamos a insertar
        //                System.Console.WriteLine("Inserta una palabra, por favor:");
        //                palabra = System.Console.ReadLine();
        //                consultaPalabra = consultaBase + " Palabra = '" + palabra + "' WHERE Id = " + id;
        //                break;
        //            case 2:
        //                System.Console.WriteLine("Inserta el nivel, por favor:");
        //                nivel = int.Parse(System.Console.ReadLine());
        //                consultaNivel = consultaBase + " Nivel = " + nivel + " WHERE Id = " + id;
        //                break;
        //            default:
        //                Console.WriteLine("Una opción de la lista!!");
        //                break;
        //        }
        //        System.Console.WriteLine("¿Qué quieres actualizar?\n 1)Palabra\n 2)Nivel\n 0)Salir");
        //        opc = int.Parse(System.Console.ReadLine());

        //    } while (opc != 0);

        //    //Ver consulta
        //    System.Console.WriteLine(consultaPalabra);
        //    System.Console.WriteLine(consultaNivel);
        //    // Create a connection    
        //    using (OleDbConnection conexion = new OleDbConnection(ruta))
        //    {
        //        // Create a command and set its connection    
        //        OleDbCommand comandoNom = new OleDbCommand(consultaPalabra, conexion);
        //        OleDbCommand comandoEdad = new OleDbCommand(consultaNivel, conexion);
        //        // Open the connection and execute the select command.    
        //        try
        //        {
        //            // Open connecton    
        //            conexion.Open();
        //            // Execute command
        //            if (consultaPalabra != "")
        //            {
        //                OleDbDataReader miTabla = comandoNom.ExecuteReader();
        //            }
        //            if (consultaNivel != "")
        //            {
        //                OleDbDataReader miTabla = comandoEdad.ExecuteReader();
        //            }

        //            Console.WriteLine("Actualizado correctamente");
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Problemicas txato!!" + ex.Message);
        //        }

        //    }
        //    System.Console.ReadKey();

        //}


        //static public void leerCoches()
        //{
        //    string ruta = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\pamendez\source\repos\ahorkadoAinaraDB\ahorkado.mdb";
        //    string consulta = "SELECT * FROM tCoches";
        //    // Create a connection    
        //    using (OleDbConnection conexion = new OleDbConnection(ruta))
        //    {
        //        // Create a command and set its connection    
        //        OleDbCommand comando = new OleDbCommand(consulta, conexion);
        //        // Open the connection and execute the select command.    
        //        try
        //        {
        //            // Open connecton    
        //            conexion.Open();
        //            // Execute command    
        //            using (OleDbDataReader miTabla = comando.ExecuteReader())
        //            {
        //                Console.WriteLine("------------Tabla Coches----------------");
        //                while (miTabla.Read())
        //                {
        //                    Console.WriteLine("{0} {1} {2} {3} {4}", miTabla["Id"].ToString(), miTabla["marca"].ToString(), miTabla["modelo"].ToString(), miTabla["km"].ToString(), miTabla["precio"].ToString());
        //                }
        //            }
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Problemicas txato!!" + ex.Message);
        //        }

        //    }
        //    System.Console.ReadKey();


        //}

        //static void Main(string[] args)
        //{
        //    int opc;
        //    string menu = "¿Qué quieres hacer?\n 1)Leer Fichero\n 2)Leer BD \n 3)Actualizar BD\n 4)Eliminar de DB\n 5)Insertar en DB\n 6)Volcar a Fichero\n 0)Salir";
        //    System.Console.WriteLine(menu);
        //    opc = int.Parse(System.Console.ReadLine());
        //    do
        //    {
        //        switch (opc)
        //        {
        //            case 1:

        //                leerFichero();

        //                break;
        //            case 2:
        //                leerBD();
        //                break;
        //            case 3:
        //                actualizarEnBD();
        //                break;
        //            case 4:
        //                eliminarDeDB();
        //                break;
        //            case 5:
        //                insertarEnBD();
        //                break;
        //            case 6:
        //                volcadoFichero();
        //                break;
        //            default:
        //                Console.WriteLine("Una opción de la lista!!");
        //                break;
        //        }
        //        System.Console.WriteLine(menu);
        //        opc = int.Parse(System.Console.ReadLine());

        //    } while (opc != 0);


        //    Console.ReadKey();
        //}

    }
}
