using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CalculadoraDeSueldos_100y500.clases_App1
{
    public class ComprobacionDeSueldos
    {
        public void Comprobacion(SueldosEmp sueldos)
        {
            Thread.Sleep(3000);
            Console.Clear();

            int EmpProm = sueldos.ObtenerSueldoProm();
            int EmpEncima = sueldos.ObtenerSueldoPorEncima();
            double TotalSueldo = sueldos.ObtenerSueldoTotal();
            Console.WriteLine($"Los Empleados que ganan entre 100 y 300 son: {EmpProm}");
            Console.WriteLine($"Los Empleados que mas de 300 son: {EmpEncima}");
            Console.WriteLine($"La cantidad que gasta la empresa en personal es: {TotalSueldo}");
        }
    }
}
