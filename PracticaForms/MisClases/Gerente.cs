using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Gerente : Empleado
    {
        private int numeroEmpleados;

        public Gerente(string nombre,int salario,string departamento,int antiguedad,int numeroEmpleados)
            :base(nombre,salario,departamento,antiguedad)
        {
            this.numeroEmpleados = numeroEmpleados;
        }

        public int NumeroEmpleados { get => numeroEmpleados; }

        public override string Trabajar()
        {
            return "El gerente esta gestionando el departamento";
        }

        public override double CalcularBonificacion()
        {
            double bonificacionGerente = 0.25;
            double bonificacion = base.Salario * bonificacionGerente;
            return bonificacion;
        }

        public override double SalarioTotal()
        {
            return base.Salario + CalcularBonificacion();
        }

        public string Planificar()
        {
            return $"El gerente esta creando una planificación para {numeroEmpleados} empleados";
        }


    }
}
