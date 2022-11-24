using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hand
    {
        public string nombreDeSeleccion;

        //Piedra
        //Papel
        //Tijeras
        //Salamandra
        //Spock

        public int numeroIdentificador;

        // 0 = Piedra 
        // 1 = Papel 
        // 2 = Tijeras
        // 3 = Salamandra
        // 4 = Spock
        


        //arreglo para fortalezas...se guarda quien le gana a quien
        public int[] fortalezas;

        //arreglo para debilidades
        public int[] debilidades;

        //arreglo para empates
        public int[] empates;
    }
}
