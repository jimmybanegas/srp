using System;

namespace EjemploSRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new ReporteDeEstudiantes();
            report.AgregarEstudiante(new Estudiante() { Nombre = "Adan", Apellido = "Primero", Edad = 50 });
            report.AgregarEstudiante(new Estudiante() { Nombre = "Eva", Apellido = "Primero", Edad = 30 });
            Console.WriteLine(report.ToString());

            var saver = new AdministradorDeArchivos();
            saver.GuardarEnArchivo(@"Reportes", "ListaDeEstudiantes.txt", report);
        }
    }
}
