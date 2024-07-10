namespace MisClases
{
    public class Cliente
    {
        private string _apellido;
        private string _cuentaBancaria;
        private string _cuit;
        private int _edad;
        private string _nombre;

        public Cliente(string cuentaBancaria, string cuit)
        {
            _cuentaBancaria = cuentaBancaria;
            _cuit = cuit;
        }

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string CuentaBancaria { get => _cuentaBancaria; }
        public string Cuit { get => _cuit; set => _cuit = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public static bool ValidarCUIT(string numeroDeCUIT)
        {
           int cantidadGuiones = 0;

            foreach (char letras in numeroDeCUIT)
            {
                if (letras == '-')
                {
                    cantidadGuiones++;
                }
            }

            if (numeroDeCUIT.Length == 13 && cantidadGuiones == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string GuardarEnDisco()
        {
            return $"Nombre {Nombre} - Apellido {Apellido} - Edad {Edad} - cuenta bancaria {CuentaBancaria} - CUIT {Cuit}";
        }




    }
}
