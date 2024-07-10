using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Desarrollador : Empleado
    {
        string lenguajeProgramacion;
        int experiencia;

        public Desarrollador(string nombre,int salario,string departamento,int antiguedad,string lenguajeProgramacion, int experiencia)
            :base(nombre,salario,departamento,antiguedad)
        {
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.experiencia = experiencia;
        }

        public string LenguajeProgramacion { get => lenguajeProgramacion; }
        public int Experiencia { get => experiencia;  }

        public override string Trabajar()
        {
            return $"El desarrollador esta codeando en {lenguajeProgramacion}";
        }

        public override double CalcularBonificacion()
        {
            double bonificacionDesarrolador = 0.15;
            double bonificacion = base.Salario * bonificacionDesarrolador;
            return bonificacion;
        }

        public override double SalarioTotal()
        {
            return base.Salario + CalcularBonificacion();
        }

        public string DepurarCodigo()
        {
            return $"El programador esta depurando codigo en {lenguajeProgramacion} ";
        }


    }
}


