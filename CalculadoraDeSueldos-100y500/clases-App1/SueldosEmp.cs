using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CalculadoraDeSueldos_100y500.clases_App1;

namespace CalculadoraDeSueldos_100y500.clases_App1
{
    public class SueldosEmp
    {
        private int SueldoProm = 0;
        private int SueldoPorencimaProm = 0;
        private double TotalSueldo = 0;
        public void ObtenerSueldo(int cantidadEmpleados)
        {
            Thread.Sleep(3000);
            Console.Clear();
            double cantidad;
            for (int i = 1; i <= cantidadEmpleados; i++)
            {
                Console.Write($"Favor ingrese la cantidad del ({i}) empleado: ");
                while(true)
                {
                    try
                    {
                        cantidad = Convert.ToDouble(Console.ReadLine());
                        if (cantidad >= 100 && cantidad <= 500)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Favor ingrese un valor dentro del rango.");
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

                TotalSueldo += cantidad;

                if(cantidad >= 100 && cantidad <= 300)
                {
                    SueldoProm++;
                }
                if(cantidad > 300)
                {
                    SueldoPorencimaProm++;
                }
            }
        }

        public int ObtenerSueldoProm()
        {
            return SueldoProm;
        }

        public int ObtenerSueldoPorEncima()
        {
            return SueldoPorencimaProm;
        }

        public double ObtenerSueldoTotal()
        {
            return TotalSueldo;
        }
    }
}
