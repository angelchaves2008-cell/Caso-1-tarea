using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
    namespace Caso_1_tarea


    {

        class Program

        {

            static void Main(string[] args)

            {

                double nota = 0;

                bool correcto = false;

                Console.WriteLine("APROBACION DE UN CURSO");

                Console.WriteLine();

                // Pide la nota hasta que escriban un dato correcto

                while (correcto == false)

                {

                    Console.Write("Digite la nota final (0 a 100): ");

                    string texto = Console.ReadLine();

                    // Revisa si lo que escribieron es un numero

                    if (double.TryParse(texto, out nota) == false)

                    {

                        Console.WriteLine("Error: tiene que escribir un numero.");

                    }

                    else if (nota < 0 || nota > 100)

                    {

                        // Revisa que este dentro de la escala

                        Console.WriteLine("Error: la nota debe estar entre 0 y 100.");

                    }

                    else

                    {

                        correcto = true;

                    }

                }

                // Compara con la nota minima para aprobar que es 70

                if (nota >= 70)

                {

                    Console.WriteLine("El estudiante APRUEBA.");

                }

                else

                {

                    Console.WriteLine("El estudiante REPRUEBA.");

                }

                Console.ReadKey();

            }

        }

    }

   
