using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hand
    {
        public string nombreIdentificador;

        //"Piedra"
        //"Papel"
        //"Tijeras"
        //"Salamandra"
        //"Spock"

        public int numeroIdentificador;

        // 0 = Piedra 
        // 1 = Papel 
        // 2 = Tijeras
        // 3 = Salamandra
        // 4 = Spock
        
        //arreglo para fortalezas...se guarda quién le gana a quién
        //cada elemento va a tener 2 fortalezas
        public int[] fortalezas;

        //arreglo para debilidades
        //cada elemento va a tener 2 debilidades
        public int[] debilidades;

    }
}
