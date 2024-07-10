using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Analista : Empleado
    {
        string especialidad;
        string proyectos;

        public Analista(string nombre,int salario,string departamento,int antiguedad,string especialidad, string proyectos)
            :base(nombre,salario,departamento,antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;
        }

        public string Especialidad { get => especialidad; }
        public string Proyectos { get => proyectos; }

        public override string Trabajar()
        {
            return $"El analista esta analizando los datos";
        }

        public override double CalcularBonificacion()
        {
            double bonificacionAnalista = 0.10;
            double bonificacion = base.Salario * bonificacionAnalista;
            return bonificacion;
        }

        public override double SalarioTotal()
        {
            return base.Salario + CalcularBonificacion();
        }

        public string PrepararInforme()
        {
            return $"El analista esta preparando sus informes de {proyectos} ";
        }
    }
}
