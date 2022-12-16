using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LogicaDeJuego;


namespace ProyectoFinal
{
   internal class Program
    {
        static void Main(string[] args) 
        {
            //Variable para la pantalla de inicio para la selección del usuario.
            int seleccionDelUsuario = 0;

            // 003 Método selección disponible para el usuario. WHILE
            while (seleccionDelUsuario!=4)
            {
                //002 Se despliega el mensaje de bienvenida.
                MensajeBienvenida();

                //003 Se muestran las opciones disponibles.
                MostrarOpcionesDeSeleccion();

                //Se llama el método y se guarda la variable en seleccionDelUsuario
                seleccionDelUsuario = CapturarNumero();

                // 004 1-> Método mostrar créditos.
                if (seleccionDelUsuario==1)
                {
                    MostrarCreditos();
                }

                // 005 2-> Mostrar las instrucciones.
                else if (seleccionDelUsuario == 2)
                {
                    MostrarInstrucciones();
                }

                // 006 3-> Iniciar Juego.
                else if (seleccionDelUsuario == 3)
                {
                    Console.WriteLine("Ha escogido iniciar el juego");
                    Console.ReadLine();
                    IniciarJuego();
                }

                // 007 4-> Salir del juego.
                else if (seleccionDelUsuario == 4)
                {
                    Console.WriteLine("Ha escogido salir del juego.\n¡Hasta la próxima!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("El valor escrito no forma parte de las opciones del menú.");
                    Console.ReadLine();
                }
            }
        }

        // 002 Método mensaje de bienvenida.
        public static void MensajeBienvenida()
        {
            Console.Clear();
            Console.WriteLine("Bienvenid@ al juego de piedra, papel, tijera, salamandra, Spock");
        }

        public static void MostrarOpcionesDeSeleccion()
        {
            Console.WriteLine("Por favor digite su selección y presione 'Enter' para continuar.");
            Console.WriteLine("1 -> Mostrar los créditos. \n2 -> Mostrar las instrucciones. \n3 -> Iniciar el juego. \n4 -> Salir.");
        }

        // 003 Método selección disponible para el usuario-desplegar selecciones.
        // Se procede a capturar la selección del usuario y se guarda.
        public static int CapturarNumero()
        {
            try
            {
                string numeroEscritoPorElUsuario;
                numeroEscritoPorElUsuario = Console.ReadLine();
                return int.Parse(numeroEscritoPorElUsuario);
            }
            catch
            {
                Console.WriteLine("Error: Solo se aceptan los números ofrecidos en la selección.");
                Console.ReadLine();
                return -1;
            }
        }

        // 004 1-> Método mostrar créditos.
        public static void MostrarCreditos()
        {
            Console.Clear();
            Console.WriteLine("Concepto del juego creado por Sam Kass y Karen Bryla.");
            Console.WriteLine("Aplicación creada por Ariana Díaz");
            Console.ReadLine();
        }

        // 005 2-> Mostrar las instrucciones.
        public static void MostrarInstrucciones()
        {
            //008 Se generan las instrucciones hasta el punto 024
            Console.WriteLine("El juego consiste de 3 rondas.");
            Console.WriteLine();
            Console.WriteLine("En cada ronda debe seleccionar uno de las opciones disponibles para su mano.");
            Console.WriteLine();
            Console.WriteLine("Las opciones a escoger son:");
            Console.WriteLine("\t-> Piedra: quiebra las tijeras y aplasta la salamandra.");
            Console.WriteLine("\t-> Papel: envuelve la piedra y refuta a Spock.");
            Console.WriteLine("\t-> Tijera: corta el papel y decapita a la salamandra.");
            Console.WriteLine("\t-> Salamandra: se come el papel y envenena a Spock.");
            Console.WriteLine("\t-> Spock: rompe a las tijeras y vaporiza la piedra.");
            Console.WriteLine();
            Console.WriteLine("Deberá seleccionar un elemento que gane al elemento escogido al azar por la computadora antes que termine el límite de tiempo.");
            Console.WriteLine();
            Console.WriteLine("Cada ronda tendrá un límite de tiempo menor a la anterior.");
            Console.WriteLine();
            Console.WriteLine("Tendrá disponibles las opciones que puede escoger en la pantalla.");
            Console.WriteLine();
            Console.WriteLine("La computadora elegirá uno de los mismos ítems al azar.");
            Console.WriteLine();
            Console.WriteLine("Cuando termine el tiempo se mostrará el resultado de ambas selecciones.");
            Console.WriteLine();
            Console.WriteLine("Si el jugador y la computadora empatan, se repite la ronda.");
            Console.WriteLine();
            Console.WriteLine("Al terminar la ronda se pasará a la siguiente");
            Console.WriteLine();
            Console.WriteLine("Si gana la mayoría de rondas, ganará el juego.");
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void IniciarJuego()
        {
            //creo la variable para capturar la respuesta del jugador
            int respuestaDelJugador;

            //se crea una instancia/objeto Logica()
            Logica juegoActual = new Logica();

            //Creo la seleccion Random del computador
            int seleccionDelComputador = juegoActual.SeleccionAleatoriaComputador();

            



            do
            {
                //Se indica al jugador la ronda en que se encuentra
                Console.Clear();
                Console.WriteLine("Usted de encuentra en la ronda {0}", juegoActual.numeroDeRonda);
                Console.WriteLine();
                Console.WriteLine("Digite su selección: ");
                Console.WriteLine("0 = Piedra");
                Console.WriteLine("1 = Papel");
                Console.WriteLine("2 = Tijeras");
                Console.WriteLine("3 = Salamandra");
                Console.WriteLine("4 = Spock");
                Console.WriteLine();
                respuestaDelJugador = CapturarNumero();
                seleccionDelComputador = juegoActual.SeleccionAleatoriaComputador();

                if (respuestaDelJugador == 0)
                {
                    //jugador elige piedra                    
                    juegoActual.JugadorSeleccionarPiedra();
                    Console.WriteLine("Usted ha seleccionado 'Piedra'");

                    if (seleccionDelComputador == 0)
                    {
                        //computador elige piedra
                        juegoActual.ComputadorSeleccionarPiedra();
                        Console.WriteLine("El computador seleccionó 'Piedra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 1)
                    {
                        //computador elige papel
                        juegoActual.ComputadorSeleccionarPapel();
                        Console.WriteLine("El computador seleccionó 'Papel'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 2)
                    {
                        //computador elige tijera
                        juegoActual.ComputadorSeleccionarTijeras();
                        Console.WriteLine("El computador seleccionó 'Tijeras'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 3)
                    {
                        //computador elige salamandra
                        juegoActual.ComputadorSeleccionarSalamandra();
                        Console.WriteLine("El computador seleccionó 'Salamandra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else
                    {
                        //computador elige Spock
                        juegoActual.ComputadorSeleccionarSpock();
                        Console.WriteLine("El computador seleccionó 'Spock'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    
                }
                else if (respuestaDelJugador == 1)
                {
                    //jugador elige papel
                    juegoActual.JugadorSeleccionarPapel();
                    Console.WriteLine("Usted ha seleccionado 'Papel'");

                    if (seleccionDelComputador == 0)
                    {
                        //computador elige piedra
                        juegoActual.ComputadorSeleccionarPiedra();
                        Console.WriteLine("El computador seleccionó 'Piedra'");
                        juegoActual.ComparacionDeRespuestas();
                    }
                    else if (seleccionDelComputador == 1)
                    {
                        //computador elige papel
                        juegoActual.ComputadorSeleccionarPapel();
                        Console.WriteLine("El computador seleccionó 'Papel'");
                        juegoActual.ComparacionDeRespuestas();
                    }
                    else if (seleccionDelComputador == 2)
                    {
                        //computador elige tijera
                        juegoActual.ComputadorSeleccionarTijeras();
                        Console.WriteLine("El computador seleccionó 'Tijeras'");
                        juegoActual.ComparacionDeRespuestas();
                    }
                    else if (seleccionDelComputador == 3)
                    {
                        //computador elige salamandra
                        juegoActual.ComputadorSeleccionarSalamandra();
                        Console.WriteLine("El computador seleccionó 'Salamandra'");
                        juegoActual.ComparacionDeRespuestas();
                    }
                    else
                    {
                        //computador elige Spock
                        juegoActual.ComputadorSeleccionarSpock();
                        Console.WriteLine("El computador seleccionó 'Spock'");
                        juegoActual.ComparacionDeRespuestas();
                    }
                    juegoActual.SubirDeRonda();
                }
                else if (respuestaDelJugador == 2)
                {
                    //jugador elige tijera
                    juegoActual.JugadorSeleccionarTijeras();
                    Console.WriteLine("Usted ha seleccionado 'Tijeras'");

                    if (seleccionDelComputador == 0)
                    {
                        //computador elige piedra
                        juegoActual.ComputadorSeleccionarPiedra();
                        Console.WriteLine("El computador seleccionó 'Piedra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 1)
                    {
                        //computador elige papel
                        juegoActual.ComputadorSeleccionarPapel();
                        Console.WriteLine("El computador seleccionó 'Papel'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 2)
                    {
                        //computador elige tijera
                        juegoActual.ComputadorSeleccionarTijeras();
                        Console.WriteLine("El computador seleccionó 'Tijeras'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 3)
                    {
                        //computador elige salamandra
                        juegoActual.ComputadorSeleccionarSalamandra();
                        Console.WriteLine("El computador seleccionó 'Salamandra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else
                    {
                        //computador elige Spock
                        juegoActual.ComputadorSeleccionarSpock();
                        Console.WriteLine("El computador seleccionó 'Spock'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    
                }
                else if (respuestaDelJugador == 3)
                {
                    //jugador elige salamandra
                    juegoActual.JugadorSeleccionarSalamandra();
                    Console.WriteLine("Usted ha seleccionado 'Salamandra'");

                    if (seleccionDelComputador == 0)
                    {
                        //computador elige piedra
                        juegoActual.ComputadorSeleccionarPiedra();
                        Console.WriteLine("El computador seleccionó 'Piedra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 1)
                    {
                        //computador elige papel
                        juegoActual.ComputadorSeleccionarPapel();
                        Console.WriteLine("El computador seleccionó 'Papel'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 2)
                    {
                        //computador elige tijera
                        juegoActual.ComputadorSeleccionarTijeras();
                        Console.WriteLine("El computador seleccionó 'Tijeras'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 3)
                    {
                        //computador elige salamandra
                        juegoActual.ComputadorSeleccionarSalamandra();
                        Console.WriteLine("El computador seleccionó 'Salamandra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else
                    {
                        //computador elige Spock
                        juegoActual.ComputadorSeleccionarSpock();
                        Console.WriteLine("El computador seleccionó 'Spock'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    
                }
                else if (respuestaDelJugador == 4)
                {
                    //jugador elige Spock
                    juegoActual.JugadorSeleccionarSpock();
                    Console.WriteLine("Usted ha seleccionado 'Spock'");

                    if (seleccionDelComputador == 0)
                    {
                        //computador elige piedra
                        juegoActual.ComputadorSeleccionarPiedra();
                        Console.WriteLine("El computador seleccionó 'Piedra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 1)
                    {
                        //computador elige papel
                        juegoActual.ComputadorSeleccionarPapel();
                        Console.WriteLine("El computador seleccionó 'Papel'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 2)
                    {
                        //computador elige tijera
                        juegoActual.ComputadorSeleccionarTijeras();
                        Console.WriteLine("El computador seleccionó 'Tijeras'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else if (seleccionDelComputador == 3)
                    {
                        //computador elige salamandra
                        juegoActual.ComputadorSeleccionarSalamandra();
                        Console.WriteLine("El computador seleccionó 'Salamandra'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    else
                    {
                        //computador elige Spock
                        juegoActual.ComputadorSeleccionarSpock();
                        Console.WriteLine("El computador seleccionó 'Spock'");
                        juegoActual.ComparacionDeRespuestas();
                        juegoActual.SubirDeRonda();
                    }
                    
                }
                else
                {
                    Console.WriteLine("Por favor digite un número del 0 al 4");
                }

            } while (juegoActual.numeroDeRonda < 4);

            
                       
        }
        
    }
}