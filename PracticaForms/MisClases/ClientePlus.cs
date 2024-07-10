using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class ClientePlus : Cliente
    {
        private int _puntos;

        public int Puntos { get => _puntos; set => _puntos = value; }

        public ClientePlus(int puntos,string cuentaBancaria,string cuit)
            :base(cuentaBancaria,cuit)
        {
            _puntos = puntos;
        }

        public override string GuardarEnDisco()
        {
            return $"{base.GuardarEnDisco()} - Puntos: {Puntos}";
        }
    }
}
