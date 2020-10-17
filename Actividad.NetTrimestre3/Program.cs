using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Actividad.NetTrimestre3
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Menu();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    // 1. Leer un número por teclado y definir si es par o impar
                    case 1:
                        Console.Clear();
                        ParImpar();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 2. Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10
                    case 2:
                        Console.Clear();
                        TablasMultiplicarN();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 3. Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10
                    case 3:
                        Console.Clear();
                        TablasMultiplicar();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 4. Leer un número por teclado y definir si es primo o no
                    case 4:
                        Console.Clear();
                        NumeroPrimo();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 5. Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente
                    case 5:
                        Console.Clear();
                        OrdenarVector();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    /* 6. Datos los vectores
                    edad = [12,50,23,10,18,35,41,85,16,45]
                    nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                    Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                    que el nombre no existe */
                    case 6:
                        Console.Clear();
                        LeerNombreMostrarEdad();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    /* 7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres
                    con su edad. */
                    case 7:
                        Console.Clear();
                        EdadMayorMenor();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    // 8. Dado una palabra definir si es palíndromo o no.
                    case 8:
                        Console.Clear();
                        Palidromo();
                        Console.WriteLine("Presione una tecla para regresar al menu...");
                        Console.ReadKey();
                        break;
                    case 0:
                        
                        break;
                    default:
                        OpcionIncorrecta();
                        option = int.Parse(Console.ReadLine());
                        break;
                }
            } while (option != 0);

            
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                "\t\t\tMENU" +
                "\n1. Numero par o impar" +
                "\n2. Tablas de multiplicar de n del 1 al 10" +
                "\n3. Tablas de multiplicar del 2 al 9" +
                "\n4. Numero primo" +
                "\n5. Ordenar numeros de forma ascendente" +
                "\n6. Leer nombre y mostrar edad" +
                "\n7. Edad mayor y menor" +
                "\n8. Palabra palindromo" +
                "\n0. Salir del programa" +
                "\nIngresa el numero de ejercicio que quieres ver..."
            );            
        }

        static void OpcionIncorrecta()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Esta opcion no existe...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presione una tecla para regresar al menu...");
            Console.ReadKey();
            Menu();
        }

        // 1. Leer un número por teclado y definir si es par o impar
        static void ParImpar()
        {
            int num;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());
            if(num%2 == 0)
            {
                Console.WriteLine(num + " es par");
            } else
            {
                Console.WriteLine(num + " es impar");

            }
        }

        // 2. Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10
        static void TablasMultiplicarN()
        {
            int num, result;
            Console.WriteLine("Ingresa el numero de tabla de multiplicar que quieres ver");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine(num + " x " + i + " = " + result);
            } 

        }

        // 3. Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10
        static void TablasMultiplicar()
        {
            int result;
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("Tabla del " + i);
                for (int j = 1; j <= 10; j++)
                {
                    result = i*j;
                    Console.WriteLine(i + " x " + j + " = " + result);
                }
                Console.WriteLine();
            }
        }

        // 4. Leer un número por teclado y definir si es primo o no
        static void NumeroPrimo()
        {
            int num, m;
            bool esPrimo = true;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("El numero no es primo");
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo == true)
                Console.WriteLine("El numero es primo");
        }

        // 5. Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente
        static void OrdenarVector()
        {
            int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            int temp;

            Console.WriteLine("Vector inicial desordenado");
            mostrarVector(edades);

            for (int i = 1; i < edades.Length; i++)
            {
                for (int j = 0; j < edades.Length - i; j++)
                {
                    if(edades[j] > edades[j + 1])
                    {
                        temp = edades[j];
                        edades[j] = edades[j + 1];
                        edades[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Vector final ordenado");
            mostrarVector(edades);
        }

        static void mostrarVector(int[] vector)
        {
            foreach(int item in vector)
            {
                Console.Write(item + "|");
            }
            Console.WriteLine();
        }

        /* 6. Datos los vectores
            edad = [12,50,23,10,18,35,41,85,16,45]
            nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
            Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
            que el nombre no existe */
        static void LeerNombreMostrarEdad()
        {
            int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            string nombre;
            bool existe = false;

            Console.WriteLine("Ingrese un nombre para ver su edad");
            nombre = Console.ReadLine();

            for(int i = 0; i < nombres.Length; i++)
            {
                if (nombre.ToLower() == nombres[i])
                {
                    Console.WriteLine("La edad de " + nombres[i] + " es " + edades[i]);
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine("Este nombre no existe");
            }
        }

        /* 7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres
        con su edad. */
        static void EdadMayorMenor()
        {
            int[] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            int mayor = -1, menor = int.MaxValue;
            string nombreMayor="", nombreMenor="";

            Console.WriteLine("Considerando lo siguiente");
            mostrarVector(edades);

            foreach (string item in nombres)
            {
                Console.Write(item + "|");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < edades.Length; i++)
            {
                if(edades[i] > mayor)
                {
                    mayor = edades[i];
                    nombreMayor = nombres[i];
                } else if(edades[i] < menor)
                {
                    menor = edades[i];
                    nombreMenor = nombres[i];
                }
            }

            Console.WriteLine(
                "El mayor es " + nombreMayor + " con " + mayor + " años de edad" +
                "\nEl menor es " + nombreMenor + " con " + menor + " años de edad"
            );
        }

        // 8. Dado una palabra definir si es palíndromo o no.
        static void Palidromo()
        {
            string palabra, palabraInvertida="";

            Console.WriteLine("Ingrese una palabra para verificar si es palidromo o no");
            palabra = Console.ReadLine();

            foreach(char letra in palabra)
            {
                palabraInvertida = letra + palabraInvertida;
            }

            if(RemoverEspaciosBlancos(palabra) == RemoverEspaciosBlancos(palabraInvertida))
            {
                Console.WriteLine("La palabra '" + palabra + "' es un palidromo");

            } else
            {
                Console.WriteLine("La palabra '" + palabra + "' no es un palidromo");
            }

        }

        static string RemoverEspaciosBlancos(string palabra)
        {
            return Regex.Replace(palabra, @"\s+", "");
        }
    }
}
