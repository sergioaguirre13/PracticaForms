using MisClases;

namespace MainEmpleado
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empleado gerente1 = new Gerente("Sergio", 1000, "Ventas", 14, 3);
            Gerente gerente2 = new Gerente("Chicha", 800, "Turismo", 4, 6);

            Empleado dev1 = new Desarrollador("Mirko", 200, "Ventas", 4, "C#", 2);
            Desarrollador dev2 = new Desarrollador("Joseph", 150, "Turismo", 2, "Javascript", 5);

            Empleado analista1 = new Analista("Jijo", 200, "Ventas", 5, "Analisis de ventas", "proyeccion primer semestre");
            Analista analista2 = new Analista("Micho", 120, "Turismo", 2, "Data Analist especializado en turismo", "Viajes low cost");

            List<Empleado> Empleados = new List<Empleado>() {  gerente1, gerente2, dev1,dev2, analista1, analista2 };

            foreach (Empleado trabajador in Empleados)
            {
                Console.WriteLine($" El salario total de {trabajador.Nombre} es {trabajador.SalarioTotal()}");
            }

            Console.WriteLine("----------------");

            foreach (Empleado trabajador in Empleados)
            {
                Console.WriteLine(trabajador.Trabajar());
            }

            Console.WriteLine("----------------");



            foreach (Empleado trabajador in Empleados)
            {
                if (trabajador.GetType() == typeof(Gerente))
                {
                    Console.WriteLine(((Gerente)trabajador).Planificar());
                }
                else if (trabajador.GetType() == typeof(Desarrollador))
                {
                    Console.WriteLine(((Desarrollador)trabajador).DepurarCodigo());
                }
                else if (trabajador.GetType() == typeof(Analista))
                {
                    Console.WriteLine(((Analista)trabajador).PrepararInforme());
                }
            }
        }
    }
}
