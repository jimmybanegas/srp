using System.IO;

namespace EjemploSRP
{
    public class AdministradorDeArchivos
    {
        public void GuardarEnArchivo(string pathDirectorio, string nombreArchivo, ReporteDeEstudiantes reporte)
        {
            if (!Directory.Exists(pathDirectorio))
            {
                Directory.CreateDirectory(pathDirectorio);
            }
            File.WriteAllText(Path.Combine(pathDirectorio, nombreArchivo), reporte.ToString());
        }
    }
}