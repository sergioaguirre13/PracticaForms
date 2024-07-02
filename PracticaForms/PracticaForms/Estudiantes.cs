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
        private string turno;
        private List<string> materias;

        public Estudiantes(string nombre, string apellido, string carrera, string turno,List<string> materias)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.carrera = carrera;
            this.Turno = turno;
            this.materias = materias;
            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Turno { get => turno; set => turno = value; }

        public string Materias
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < materias.Count; i++)
                {
                    sb.Append(materias[i]);

                    if (i < materias.Count - 1)
                    {
                        sb.Append(" - ");
                    }
                }

                return sb.ToString();
            }
        }





    }
}
