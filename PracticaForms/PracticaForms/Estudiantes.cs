using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForms
{
    public class Estudiantes
    {
        private string nombre;
        private string apellido;
        private string carrera;

        public Estudiantes(string nombre, string apellido, string carrera)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.carrera = carrera;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public override string ToString()
        {
            return $"Nombre: {Nombre} - Apellido: {Apellido} - Carrera: {Carrera}";

        }
    }
}
