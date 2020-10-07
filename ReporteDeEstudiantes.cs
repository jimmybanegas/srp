using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EjemploSRP
{
    public class ReporteDeEstudiantes
    {
        private readonly List<Estudiante> _estudiantes;

        public ReporteDeEstudiantes()
        {
            _estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante entry) => _estudiantes.Add(entry);

        public void RemoverIndice
            (int index) => _estudiantes.RemoveAt(index);

        public void GuardarEnArchivo(string pathDirectorio, string nombreArchivo)
        {
            if (!Directory.Exists(pathDirectorio))
            {
                Directory.CreateDirectory(pathDirectorio);
            }

            File.WriteAllText(Path.Combine(pathDirectorio, nombreArchivo), ToString());
        }

        public override string ToString() =>
            string.Join(Environment.NewLine,
                _estudiantes.Select(x => $"Nombre: {x.Nombre}, Apellido: {x.Apellido}, Edad: {x.Edad}"));
    }
}