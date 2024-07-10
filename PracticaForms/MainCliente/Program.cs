using MisClases;

namespace MainCliente
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente nuevoCliente = new Cliente("Caja Ahorro", "20-35363314-8");
            ClientePlus nuevoClienteplus = new ClientePlus(32, "Caja sueldo", "27-1645821-7");

            nuevoCliente.Nombre = "pipo";
            nuevoCliente.Apellido = "Salcedo";
            nuevoCliente.Edad = 22;

            nuevoClienteplus.Nombre = "Chicho";
            nuevoClienteplus.Apellido = "Serna";
            nuevoClienteplus.Edad = 32;

            if (!Cliente.ValidarCUIT(nuevoCliente.Cuit))
            {
                Console.WriteLine($"Corrija el cuit del cliente {nuevoCliente.Nombre} {nuevoCliente.Apellido}");
            }
            else
            {
                Console.WriteLine($"El cuit del cliente {nuevoCliente.Nombre} {nuevoCliente.Apellido} ha sido validado con exito!");
            }

            if (!Cliente.ValidarCUIT(nuevoClienteplus.Cuit))
            {
                Console.WriteLine($"Corrija el cuit del cliente {nuevoClienteplus.Nombre} {nuevoClienteplus.Apellido}");
            }
            else
            {
                Console.WriteLine($"El cuit del cliente {nuevoClienteplus.Nombre} {nuevoClienteplus.Apellido} ha sido validado con exito!");
            }

            Console.WriteLine("------------------------");

            Console.WriteLine(nuevoCliente.GuardarEnDisco());
            Console.WriteLine(nuevoClienteplus.GuardarEnDisco());

        }
    }
}
