using Entidades;

namespace LogicaDeJuego

{
    //logica es las reglas el juego
    //

    public class Logica
    {
        //Hand es clase y manoJugador es field
        public Hand manoJugador;
        public Hand manoComputadora;
        public Random generadorNumerosAleatorios;


        //Metodo de selección del usuario.
        public void JugadorSeleccionarPiedra()
        {
            //piedra es 0   
            //  fortalezas de piedra son tijeras (2) y salamandra (3)
            //  debilidades de piedra son papel (1) y spock (4)
            
            manoJugador = new Hand();
            manoJugador.nombreIdentificador = "Piedra";
            manoJugador.numeroIdentificador = 0;

            manoJugador.fortalezas = new int[2];
            manoJugador.fortalezas[0] = 2;
            manoJugador.fortalezas[1] = 3;

            manoJugador.debilidades = new int[2];
            manoJugador.debilidades[0] = 1;
            manoJugador.debilidades[1] = 4;        
        }

        public void JugadorSeleccionarPapel()
        {
            //1 es papel
            //  fortalezas de papel son piedra (0) y Spock (4)
            //  debilidades de papel son tijeras (2) y salamandra (3)
            
            manoJugador = new Hand();
            manoJugador.nombreIdentificador = "Papel";
            manoJugador.numeroIdentificador = 1;

            manoJugador.fortalezas = new int[2];
            manoJugador.fortalezas[0] = 0;
            manoJugador.fortalezas[1] = 4;

            manoJugador.debilidades = new int[2];
            manoJugador.debilidades[0] = 2;
            manoJugador.debilidades[1] = 3;
        }

        public void JugadorSeleccionarTijeras()
        {
            //2 es tijeras
            //  fortalezas de tijeras son papel (1) y salamandra (3)
            //  debilidades de tijeras son piedra (0) y Spock (4)

            manoJugador = new Hand();
            manoJugador.nombreIdentificador = "Tijeras";
            manoJugador.numeroIdentificador = 2;

            manoJugador.fortalezas = new int[2];
            manoJugador.fortalezas[0] = 1;
            manoJugador.fortalezas[1] = 3;

            manoJugador.debilidades = new int[2];
            manoJugador.debilidades[0] = 0;
            manoJugador.debilidades[1] = 4;
        }

        public void JugadorSeleccionarSalamandra()
        {
            //3 es salamandra
            //  fortalezas de salmandra son papel (1) y Spock (4)
            //  debilidades de salamandra son piedra (0) y tijeras (2)

            manoJugador = new Hand();
            manoJugador.nombreIdentificador = "Salamandra";
            manoJugador.numeroIdentificador = 3;

            manoJugador.fortalezas = new int[2];
            manoJugador.fortalezas[0] = 1;
            manoJugador.fortalezas[1] = 4;

            manoJugador.debilidades = new int[2];
            manoJugador.debilidades[0] = 0;
            manoJugador.debilidades[1] = 2;
        }

        public void JugadorSeleccionarSpock()
        {
            //4 es spock
            //  fortalezas de spock son piedra (0) y tijeras (2)
            //  debilidades de spock son papel (1) y salamandra (3)

            manoJugador = new Hand();
            manoJugador.nombreIdentificador = "Spock";
            manoJugador.numeroIdentificador = 4;

            manoJugador.fortalezas = new int[2];
            manoJugador.fortalezas[0] = 0;
            manoJugador.fortalezas[1] = 2;

            manoJugador.debilidades = new int[2];
            manoJugador.debilidades[0] = 1;
            manoJugador.debilidades[1] = 3;
        }



        //Metodo de selección de la computadora.

        public void ComputadorSeleccionarPiedra()
        {
            //piedra es 0   
            //  fortalezas de piedra son tijeras (2) y salamandra (3)
            //  debilidades de piedra son papel (1) y spock (4)

            manoComputadora = new Hand();
            manoComputadora.nombreIdentificador = "Piedra";
            manoComputadora.numeroIdentificador = 0;

            manoComputadora.fortalezas = new int[2];
            manoComputadora.fortalezas[0] = 2;
            manoComputadora.fortalezas[1] = 3;

            manoComputadora.debilidades = new int[2];
            manoComputadora.debilidades[0] = 1;
            manoComputadora.debilidades[1] = 4;
        }

        public void ComputadorSeleccionarPapel()
        {
            //1 es papel
            //  fortalezas de papel son piedra (0) y Spock (4)
            //  debilidades de papel son tijeras (2) y salamandra (3)

            manoComputadora = new Hand();
            manoComputadora.nombreIdentificador = "Papel";
            manoComputadora.numeroIdentificador = 1;

            manoComputadora.fortalezas = new int[2];
            manoComputadora.fortalezas[0] = 0;
            manoComputadora.fortalezas[1] = 4;

            manoComputadora.debilidades = new int[2];
            manoComputadora.debilidades[0] = 2;
            manoComputadora.debilidades[1] = 3;
        }

        public void ComputadorSeleccionarTijeras()
        {
            //2 es tijeras
            //  fortalezas de tijeras son papel (1) y salamandra (3)
            //  debilidades de tijeras son piedra (0) y Spock (4)

            manoComputadora = new Hand();
            manoComputadora.nombreIdentificador = "Tijeras";
            manoComputadora.numeroIdentificador = 2;

            manoComputadora.fortalezas = new int[2];
            manoComputadora.fortalezas[0] = 1;
            manoComputadora.fortalezas[1] = 3;

            manoComputadora.debilidades = new int[2];
            manoComputadora.debilidades[0] = 0;
            manoComputadora.debilidades[1] = 4;
        }

        public void ComputadorSeleccionarSalamandra()
        {
            //3 es salamandra
            //  fortalezas de salmandra son papel (1) y Spock (4)
            //  debilidades de salamandra son piedra (0) y tijeras (2)

            manoComputadora = new Hand();
            manoComputadora.nombreIdentificador = "Salamandra";
            manoComputadora.numeroIdentificador = 3;

            manoComputadora.fortalezas = new int[2];
            manoComputadora.fortalezas[0] = 1;
            manoComputadora.fortalezas[1] = 4;

            manoComputadora.debilidades = new int[2];
            manoComputadora.debilidades[0] = 0;
            manoComputadora.debilidades[1] = 2;
        }

        public void ComputadorSeleccionarSpock()
        {
            //4 es spock
            //  fortalezas de spock son piedra (0) y tijeras (2)
            //  debilidades de spock son papel (1) y salamandra (3)

            manoComputadora = new Hand();
            manoComputadora.nombreIdentificador = "Spock";
            manoComputadora.numeroIdentificador = 4;

            manoComputadora.fortalezas = new int[2];
            manoComputadora.fortalezas[0] = 0;
            manoComputadora.fortalezas[1] = 2;

            manoComputadora.debilidades = new int[2];
            manoComputadora.debilidades[0] = 1;
            manoComputadora.debilidades[1] = 3;
        }


        //Metodo de comparación de seleccion de usuario y computadora
        public void ComparacionDeRespuestas()
        {
            //Situación 1: El jugador tiene una mano que le gana a la mano de la computadora.
            bool jugadorGano = false;

            for (int i = 0; i < 2; i++)
            {
                if (manoJugador.numeroIdentificador == manoComputadora.debilidades[i])
                {
                    jugadorGano = true;
                }

            }

            //Situación 2: La computadora tiene una mano que le gana a la mano del jugador.
            bool computadorGano = false;

            for(int i = 0; i < 2; i++)
            {
                if(manoComputadora.numeroIdentificador == manoJugador.debilidades[i])
                {
                    computadorGano = true;
                }
            }

            //Situación 3: El jugador y la computadora escogen la misma mano.
            //Si ambos valores son falsos es un empate
            if(jugadorGano==false && computadorGano==false)
            {
                Console.WriteLine("Se ha detectado un empate");
            }

            else if (jugadorGano==true)
            {
                Console.WriteLine("Usted ha ganado.");
            }

            else if(computadorGano==true)
            {
                Console.WriteLine("Usted ha perdido");
            }

        }

        //Metodo de reinicio del juego 

        //ComputdoraSeleccionAleatoria
    }
}