using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public abstract class Empleado
    {
        string nombre;
        int salario;
        string departamento;
        int antiguedad;

        public Empleado(string nombre, int salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public string Nombre { get => nombre;  }
        public int Salario { get => salario;  }
        public string Departamento { get => departamento;  }
        public int Antiguedad { get => antiguedad;  }

        public abstract string Trabajar();

        public virtual string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario {salario} - Departamento {departamento} - Antiguedad {antiguedad}";
        }

        public virtual double CalcularBonificacion()
        {
            return 0; //seguir
        }

        public abstract double SalarioTotal();
        
    }
}
