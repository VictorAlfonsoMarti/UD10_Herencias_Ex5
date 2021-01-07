using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias_Ex5
{
    class Test
    {
        public static void TestMain()
        {
            // ATRIBUTOS
            Series[] cadenaSeries;
            Videojuego[] cadenaVideojuegos;

            Series s1 = new Series("Serie1", 1, false, "genero1", "creador1");
            Series s2 = new Series("Serie2", 20, false, "genero2", "creador2");
            Series s3 = new Series("Serie3", 3, false, "genero3", "creador3");
            Series s4 = new Series("Serie4", 4, false, "genero4", "creador4");
            Series s5 = new Series("Serie5", 5, false, "genero5", "creador5");

            Videojuego v1 = new Videojuego("Videojuego1", 1, false, "genero1", "compañia1");
            Videojuego v2 = new Videojuego("Videojuego2", 20, false, "genero2", "compañia2");
            Videojuego v3 = new Videojuego("Videojuego3", 3, false, "genero3", "compañia3");
            Videojuego v4 = new Videojuego("Videojuego4", 4, false, "genero4", "compañia4");
            Videojuego v5 = new Videojuego("Videojuego5", 5, false, "genero5", "compañia5");

            cadenaSeries = new Series[5] { s1, s2, s3, s4, s5 };
            cadenaVideojuegos = new Videojuego[5] { v1, v2, v3, v4, v5 };

            // entregamos algunas series y videojuegos y mostramos
            cadenaSeries[1].entregar();
            cadenaSeries[2].entregar();
            cadenaSeries[4].entregar();

            cadenaVideojuegos[2].entregar();
            cadenaVideojuegos[3].entregar();

            int objetosEntregados = 0;


            // recorremos los arrays y printamos si estan entregados
                    foreach (Series x in cadenaSeries)
                    {
                        if (x.isEntregado())
                        {
                            objetosEntregados++;
                            x.ToString();
                            Console.WriteLine("\n");
                        }
                    }

                    foreach (Videojuego x in cadenaVideojuegos)
                    {
                        if (x.isEntregado())
                        {
                            objetosEntregados++;
                            x.ToString();
                            Console.WriteLine("\n");
                        }
                    }

                    Console.WriteLine("El número de objetos entregados es de: {0}", objetosEntregados);



            //comparamos videojuegos y series y mostramos el que más tiene
                    Series serieLarga = new Series();
                    Videojuego videojuegoLargo = new Videojuego();

                    for (int x = 0; x < cadenaSeries.Length; x++)
                    {
                        foreach (Series y in cadenaSeries)
                        {
                            if (y.compareTo(cadenaSeries[x]))
                            {
                                serieLarga = y;
                            }
                        }
                    }
                    Console.WriteLine("La serie más larga es: ");
                    serieLarga.ToString();

                    for (int x = 0; x < cadenaVideojuegos.Length; x++)
                    {
                        foreach (Videojuego y in cadenaVideojuegos)
                        {
                            if (y.compareTo(cadenaVideojuegos[x]))
                            {
                                videojuegoLargo = y;
                            }
                        }
                    }
                    Console.WriteLine("El videojuego más largo es: ");
                    videojuegoLargo.ToString();
        }
    }
}
