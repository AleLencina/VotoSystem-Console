using System;
using System.Collections.Generic;

namespace SistemaVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            // SE DECLARAN VARIABLES GLOBALES
            int dni;
            string nombre, me;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // SE CREA DICCIONARIO PARA ALMACENAR USUARIOS Y DNI
            Dictionary<string, int> votante = new Dictionary<string, int>();
            
            // SE AGREGAN USUARIOS AL DICCIONARIO
            votante.Add("gustavo", 666);
            votante.Add("ileana", 123);
            votante.Add("rosa", 456);
            votante.Add("1", 1);

            // SE CREA DICCIONARIO PARA ALMACENAR CANDIDATOS Y SUS VOTOS
            Dictionary<string, int> candidatos = new Dictionary<string, int>();

            // SE AGREGAN CANDIDATOS AL DICCIONARIO
            candidatos.Add("rj", 53);
            candidatos.Add("ec", 28);
            candidatos.Add("mc", 15);
            candidatos.Add("jp", 45);

            menu();
            
            void menu()
            {
                // SE MUESTRA EN PANTALLA ENCABEZADO Y MENU
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     \n                   ================================================================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                      ░▒▓||||     ** SISTEMA DE VOTOS ® © - V 1.0 -   **   ||||▓▒░ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                   ================================================================ \n\n\n");

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("                             ╔═══════════════════════════════════╗ ");
                Console.WriteLine("                             ║    1) -       VOTAR               ║ ");
                Console.WriteLine("                             ╠═══════════════════════════════════╣ ");
                Console.WriteLine("                             ║    2) -    ESTADISTICAS           ║ ");
                Console.WriteLine("                             ╠═══════════════════════════════════╣ ");
                Console.WriteLine("                             ║    3) -       SALIR               ║ ");
                Console.WriteLine("                             ╚═══════════════════════════════════╝ \n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("             »»»»  ");

                me = Console.ReadLine();

                // SE ENVIA EL NRO ELEGIDO DEL MENU AL SWITCH Y SE EJECUTA EL BLOQUE
                switch (me)
                {
                    case "1":
                        ingreso();
                        break;
                    case "2":
                        estadisticas();
                        ; break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\n         SALIENDO del SISTEMA de VOTOS ....");
                        Console.ReadKey();
                        ; break;

                }
            }
            void ingreso()
            {
                 Console.Clear();
                    
                // SE MUESTRA LA PANTALLA PARA EL INGRESO DE DATOS
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine("     \n                   ================================================================");
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("                      ░▒▓||||     ** SISTEMA DE VOTOS ® © - V 1.0 -   **   ||||▓▒░ ");
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine("                   ================================================================ \n\n\n");

                 Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine("                        -> INGRESO DE DATOS <-  \n\n\n ");

                // SE PIDEN LOS DATOS PARA LA VALIDACION DE USUARIO
                 Console.ForegroundColor = ConsoleColor.Cyan;
                 Console.WriteLine("           NOMBRE:\n");
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.Write("                 »»»» ");

                 nombre = Console.ReadLine();

                 Console.ForegroundColor = ConsoleColor.Cyan;
                 Console.WriteLine("           DNI:\n");
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.Write("                 »»»»   ");

                 dni = Convert.ToInt16(Console.ReadLine());

                 validar();
            }

            void votar()
            {
                    string sel;

                // SE MUESTRA EN PANTALLA ENCABEZADO Y TABLA DE CANDIDATOS
                    Console.Clear();

                    Console.WriteLine("\n\n               NOMBRE: " + nombre + "       DNI: " + votante[nombre] + "     PADRON:  6859321" );
                    Console.WriteLine("         ───────────────────────────────────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n       --   SELECCIONE UN CANDIDATO: \n\n");

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("         ╔══════════════════════════════════╦══════════════════════════════════╗ ");
                    Console.WriteLine("         ║                                  ║                                  ║ ");
                    Console.WriteLine("         ║      1) - ROBERTO JUAREZ         ║      3) - MATIAS CAVANA          ║ ");
                    Console.WriteLine("         ║                                  ║                                  ║ ");
                    Console.WriteLine("         ╠══════════════════════════════════╬══════════════════════════════════╣ ");
                    Console.WriteLine("         ║                                  ║                                  ║ ");
                    Console.WriteLine("         ║      2) - ENRIQUE CENTENO        ║      4) - JUAN PEREZ             ║ ");
                    Console.WriteLine("         ║                                  ║                                  ║ ");
                    Console.WriteLine("         ╚══════════════════════════════════╩══════════════════════════════════╝ \n");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("             »»»»  ");

                    sel = Console.ReadLine();
                    
                    // EL SWICTH TOMA EL NRO INGRESADO Y SE EJECUTA EL BLOQUE CORRESPONDIENTE
                switch (sel)
                {
                    // SE MUESTRA UN MENSAJE EN PANTALLA, SE SUMA UN VOTO AL ELEGIDO Y SE VUELVE AL MENU PRINCIPAL 
                        case "1":
                            Console.WriteLine("\n           ->  ROBERTO JUAREZ recibió su voto");
                            ++candidatos["rj"];
                            Console.ReadKey();
                            menu();
                            break;
                        case "2":
                            Console.WriteLine("\n           ->  ENRIQUE CENTENO recibió su voto");
                            ++candidatos["ec"];
                            Console.ReadKey();
                            menu();
                            ; break;
                        case "3":
                            Console.WriteLine("\n           ->  MATIAS CAVANA recibió su voto");
                            ++candidatos["mc"];
                            Console.ReadKey();
                            menu();
                            ; break;
                        case "4":
                            Console.WriteLine("\n           ->  JUAN PEREZ recibió su voto");
                            ++candidatos["jp"];
                            Console.ReadKey();
                            menu();
                            ; break;
                        
                }
                Console.ReadLine();
            }

            void validar()
            {
                // SE VERIFICA QUE EL NOMBRE Y EL DNI SE ENCUENTREN EN EL DICCIONARIO
                    if (votante.ContainsKey(nombre) & votante.ContainsValue(dni))
                    {
                        votar();
                    }
                //  SI LOS DATOS SON INCORRECTOS SE MUESTRA UN MENSAJE EN PANTALLA Y SE VUELVEN A PEDIR EL INGRESO DE DATOS
                    else
                    {
                        Console.WriteLine("DATOS INCORRECTOS, VUELVA A INTENARLO ... ");
                        Console.ReadLine();
                        Console.Clear();
                        ingreso();
                    }
            }
            void estadisticas()
            {
                // SE DECLARAN LAS VARIABLES PARA MOSTRAR LOS DATOS EN LAS TABLAS DE ESTADISTICAS
                int rj = candidatos["rj"], ec = candidatos["ec"], mc = candidatos["mc"], jp = candidatos["jp"], votos =0, restan=0;
                float prj, pec, pmc, pjp;

                // SE RECORRE EL DICCIONARIO DE CANDIDATOS Y SE SUMAN LOS VOTOS
                foreach (KeyValuePair<string, int> c in candidatos)
                {
                    votos = votos + c.Value;
                }
                restan = 1000 - votos;
                
                // SE CALCULAN LOS PONCETAJES DE VOTOS POR CANDIDATO
                prj = (100 * candidatos["rj"]) / votos;
                pec = (100 * candidatos["ec"]) / votos;
                pmc = (100 * candidatos["mc"]) / votos;
                pjp = (100 * candidatos["jp"]) / votos;

                // SE MUESTRA EN PANTALLA TABLAS DE ESTADISTICAS CON SUS VALORES
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\n\n                            ┌────────────────────────────────────┐");
                Console.WriteLine("                            │         --- ESTADISTICAS ---       │");
                Console.WriteLine("                            └────────────────────────────────────┘\n");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("                    ┌──────────────────────────┬────────────────────────┐");
                Console.WriteLine("                    │>  CANDIDATO MAS VOTADO   │  - ROBERTO JUAREZ -    │");
                Console.WriteLine("                    ├──────────────────────────┼────────────────────────┤");
                Console.WriteLine("                    │>  CANDIDATO MENOS VOTADO │  - MATIAS CAVANA -     │ ");
                Console.WriteLine("                    ├──────────────────────────┼───────────┬────────────┘");
                Console.WriteLine("                    │>  CANTIDAD DE VOTANTES   │    "+votos+"    │ ");
                Console.WriteLine("                    ├──────────────────────────┼───────────┤");
                Console.WriteLine("                    │>  CANTIDAD POR VOTAR     │    "+restan+"    │    ");
                Console.WriteLine("                    └──────────────────────────┴───────────┘\n\n");


                Console.WriteLine("                    ┌──────────────────────────┬───────────┬────────────┐");
                Console.WriteLine("                    │        CANDIDATO         │   VOTOS   │  % VOTOS   │");
                Console.WriteLine("                    ├──────────────────────────┼───────────┼────────────┤");
                Console.WriteLine("                    │>  ROBERTO JUAREZ         │     "+rj+"    │    "+prj+" %    │ ");
                Console.WriteLine("                    ├──────────────────────────┼───────────┼────────────┤");
                Console.WriteLine("                    │>  ENRIQUE CENTENO        │     "+ec+ "    │    "+pec+ " %    │ ");
                Console.WriteLine("                    ├──────────────────────────┼───────────┼────────────┤");
                Console.WriteLine("                    │>  MATIAS CAVANA          │     "+mc+ "    │    "+pmc+ " %    │ ");
                Console.WriteLine("                    ├──────────────────────────┼───────────┼────────────┤");
                Console.WriteLine("                    │>  JUAN PEREZ             │     "+jp+ "    │    "+ pjp + " %    │ ");
                Console.WriteLine("                    └──────────────────────────┴───────────┴────────────┘");

                Console.ReadKey();
                menu();
                // FIN
            }
            
        }
    }
}
