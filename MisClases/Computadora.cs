using System.Drawing;
using System.Text.RegularExpressions;

namespace MisClases
{
    public class Computadora
    {
        private int memoriaRam;
        private int capacidadDisco;
        private string procesador;
        private string sistemaOperativo;
        private List<string> programas;

        private Computadora()
        {
            this.programas = new List<string>();
        }

        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo)
           : this()
        {
            this.memoriaRam = memoriaRam;
            this.capacidadDisco = capacidadDisco;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
            
        }

        public int MemoriaRam { get => memoriaRam; }
        public int CapacidadDisco { get => capacidadDisco; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }
        public List<string> Programas { get => programas; }


        public List<string> getProgramas()
        {
            return programas;
        }

        public void setProgramas()
        {
            programas.Add(""); 
        }

        public static List<string> ListadoDeProcesadores()
        {
            List<string> listaProcesadores = new List<string>() { "procesador1", "procesador2", "procesador3", "procesador4", "procesador5" };

            return listaProcesadores;
        }


    }
}
