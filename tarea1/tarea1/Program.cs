using System;

namespace tarea1
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                double suma = 0;
                int contador = 0;

                double numero;

                do
                {
                    Console.WriteLine("Ingrese un número (0 para finalizar):");
                    numero = double.Parse(Console.ReadLine());

                    if (numero != 0)
                    {
                        suma += numero;
                        contador++;
                    }
                } while (numero != 0);

                if (contador > 0)
                {
                    double promedio = suma / contador;
                    Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
                }
                else
                {
                    Console.WriteLine("No se ingresaron números.");
                Console.ReadLine();
                }
            }
        }



            }
  



        