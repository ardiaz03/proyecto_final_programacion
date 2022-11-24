using Entidades;
namespace LogicaDeJuego

{
    public class Logica
    {
        //propiedades publicas de la clase logica del juego
        public Hand manoJugador;

        public Hand manoComputadora;

        //Agregar las reglas del juego

        //Metodo de seleccion del usuario
        public void JugadorSeleccionarPiedra()
        {
            //piedra es 0   
            //  fortalezas de piedra son tijeras (2) y salamandra (3)
            //  debilidades de piedra son papel (1) y spock (4)
            
            manoJugador = new Hand();
            manoJugador.nombreDeSeleccion = "Piedra";
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
            manoJugador.nombreDeSeleccion = "Papel";
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
            manoJugador.nombreDeSeleccion = "Tijeras";
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
            manoJugador.nombreDeSeleccion = "Salamandra";
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
            manoJugador.nombreDeSeleccion = "Spock";
            manoJugador.numeroIdentificador = 4;

            manoJugador.fortalezas = new int[2];
            manoJugador.fortalezas[0] = 0;
            manoJugador.fortalezas[1] = 2;

            manoJugador.debilidades = new int[2];
            manoJugador.debilidades[0] = 1;
            manoJugador.debilidades[1] = 3;
        }



        //Metodo de seleccion de la computadora

        public void ComputadorSeleccionarPiedra()
        {
            //piedra es 0   
            //  fortalezas de piedra son tijeras (2) y salamandra (3)
            //  debilidades de piedra son papel (1) y spock (4)

            manoComputadora = new Hand();
            manoComputadora.nombreDeSeleccion = "Piedra";
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
            manoComputadora.nombreDeSeleccion = "Papel";
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
            manoComputadora.nombreDeSeleccion = "Tijeras";
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
            manoComputadora.nombreDeSeleccion = "Salamandra";
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
            manoComputadora.nombreDeSeleccion = "Spock";
            manoComputadora.numeroIdentificador = 4;

            manoComputadora.fortalezas = new int[2];
            manoComputadora.fortalezas[0] = 0;
            manoComputadora.fortalezas[1] = 2;

            manoComputadora.debilidades = new int[2];
            manoComputadora.debilidades[0] = 1;
            manoComputadora.debilidades[1] = 3;
        }


        //Metodo de comparacion de seleccion de usuario y computadora

        public void ComparacionDeRespuestas()
        {

        }

        //Metodo de reinicio del juego 
    }
}