//COPYRIGHT by Alberto

using System;

namespace Scomposizione_metodo_Ruffini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma che ti semplifica la divisione con il metodo di Ruffini");

            string ancora;
            do
            {
                int ncof = 0;   //numero di coeficienti
                int[] coefic = new int[ncof];   //valori dei coeficienti
                int div;    //termine noto del divisore
                string si;  //se hai inserito i dati giusti
                int n;

                do
                {
                    do
                    {
                        Console.WriteLine("Quanti coeficienti ha il dividendo? (sono il grado del dividendo + 1)");
                        ncof = Convert.ToInt32(Console.ReadLine()); //quanti coeficienti
                    } while (ncof <= 1);

                    coefic = new int[ncof];

                    for (int i = 0; i < ncof; i += 1)   //acquisizione dividendo
                    {
                        if (i == (ncof - 1))
                        {
                            Console.Write("Inserisci il termine noto --> ");
                            coefic[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        else if (i != ncof)
                        {
                            Console.Write("Inserisci il " + (i + 1) + "° coeficiente --> ");
                            coefic[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }   //acquisizione dividendo

                    n = coefic[(ncof - 1)];

                    do
                    {
                        Console.WriteLine("Qual è il termine noto del divisore (quello senza l'incognita)");
                        div = Convert.ToInt32(Console.ReadLine()); //termine noto del divisore
                    } while (div == 0);

                    Console.WriteLine("Quindi la tua divisione è:");
                    Console.Write("(");

                    int f = (ncof - 1);

                    for (int i = 0; i < (ncof - 1); i += 1)   //controllo divisione
                    {
                        Console.Write(coefic[i] + "x^");
                        Console.Write(f + " + ");
                        f -= 1;
                    }   //controllo divisione

                    Console.Write(coefic[(ncof - 1)]);
                    Console.Write(")");
                    Console.WriteLine(" : (x + " + div + ")");

                    Console.Write("E' coretto (S/N) --> ");
                    si = Console.ReadLine();

                } while (si == "n" ^ si == "N"); //ciclo della fase di acquisizione

                int[] Q = new int[(ncof - 1)];  //quoziente
                int R = 0;  //resto
                double opdiv;  //opposto del divisore

                if (div < 0)
                {
                    opdiv = Math.Sqrt((div * div));
                }

                else
                {
                    opdiv = div - (div * div);
                }

                Q[0] = coefic[0];
                div = Convert.ToInt32(opdiv);

                for (int i = 1; i < (ncof - 1); i += 1)  //il calcolo effettivo
                {
                    Q[i] = coefic[i] + (div * Q[(i - 1)]);
                }   //il calcolo effettivo

                R = n + (div * Q[ncof - 2]);

                Console.WriteLine("Il risultato è:");
                Console.Write("Q = ");

                int g = (ncof - 2);

                for (int i = 0; i < (ncof - 2); i += 1)   //risultato divisione
                {
                    Console.Write(Q[i] + "x^");
                    Console.Write(g + " + ");
                    g -= 1;
                }   //risultato divisione

                Console.Write(Q[ncof - 2]);
                Console.WriteLine(" R = " + R);

                Console.WriteLine("");
                Console.WriteLine("Devi fare un altra divisione? (S/N)");
                ancora = Console.ReadLine();

            } while (ancora == "s" ^ ancora == "S");

            Console.WriteLine("");
            Console.WriteLine("Grazie per aver usato il mio programma a presto :)");
            Console.WriteLine("~Alberto");
            Console.ReadKey();
        }
    }
}

//Ciao :)