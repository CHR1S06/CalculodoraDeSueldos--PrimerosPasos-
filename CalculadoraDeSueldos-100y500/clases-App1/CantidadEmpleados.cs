using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeSueldos_100y500.clases_App1
{
    public class CantidadEmpleados
    {
        private int numerosEmp = 0;
        public void cantidadEmp()
        {
            Console.Write("Digite la cantidad de empleados dentro de la empresa: ");
            while (true)
            {
                try
                {
                    numerosEmp = Convert.ToInt32(Console.ReadLine());
                    if(numerosEmp > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Por favor digite una cantidad valida.");
                    }
                }
                catch (FormatException ex)  // Captura de una excepción más específica
                {
                    Console.WriteLine($"Error de formato: {ex.Message}");  // Verifica si llega aquí
                }
                catch (OverflowException ex)  // Para valores fuera del rango de un int
                {
                    Console.WriteLine($"Error de desbordamiento: {ex.Message}");
                }
                catch (Exception ex)  // Captura cualquier otro tipo de excepción
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }
            }
        }

        public int ObtenerEmp()
        {
            return numerosEmp;
        }
    }
}
