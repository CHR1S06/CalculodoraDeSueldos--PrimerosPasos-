using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace CalculadoraDeSueldos_100y500.clases_App1
{
    public class App1
    {
        public static void Programa()
        {
            Console.WriteLine("Bienvenido al programa de calculo de sueldos.");
            CantidadEmpleados cantidadEmpleados = new CantidadEmpleados();
            cantidadEmpleados.cantidadEmp();
            int numEmpleados = cantidadEmpleados.ObtenerEmp();

            SueldosEmp sueldosEmp = new SueldosEmp();
            sueldosEmp.ObtenerSueldo(cantidadEmpleados.ObtenerEmp());

            ComprobacionDeSueldos comprobacion = new ComprobacionDeSueldos();
            comprobacion.Comprobacion(sueldosEmp);
        }
    }
}
