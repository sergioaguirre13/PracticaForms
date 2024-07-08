using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTruchaParc
{
    public class Computadora
    {
        private int capacidadDeDisco;
        private int memoriaRam;
        private string procesador;
        private string sistemaOperativo;
        private List<string> programas;

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public Computadora(int capacidadDeDisco, int memoriaRam, string procesador, string sistemaOperativo)
            :this()
        {
            this.capacidadDeDisco = capacidadDeDisco;
            this.memoriaRam = memoriaRam;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
        }

        public int CapacidadDeDisco { get => capacidadDeDisco; }
        public int MemoriaRam { get => memoriaRam; }
        public string Procesador { get => procesador;  }
        public string SistemaOperativo { get => sistemaOperativo;  }
        public string Programas     
            { 
                get
                {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < GetProgramas().Count; i++)
                {
                    sb.Append(GetProgramas()[i]);

                    if (i < GetProgramas().Count - 1)
                    {
                        sb.Append(" - ");
                    }
                }


                return sb.ToString(); 
                 }
        }

        public List<string> GetProgramas()
        {
            return programas;
        }

        public void SetPrograma(string programa)
        {
            programas.Add(programa);
        }

        public static List<string> ListadoDeProcesadores()
        {
            return new List<string>() {"Intel","AMD", "Pepes CPU", "Chicho Tech", "Peron intel" };
        }
     }
 }

