using System;

namespace notes
{
    class Program
    {
        public static string[] items = {};
        public static string[] goals = {};
        public static bool[] state = {};
        public static int[] prices = {};
        public static string[] total = {};
        public static void Main(String[] args)
        {
            int indx = 0;
            string[] options = {"0. Guarda note", "1.Aggiungi","2.Elimina","3.Modifica"};
            string output = "";
            System.Console.WriteLine("                  LISTA MANAGER               ");
            int i = 0;
            while(true)
            {
                try
                {
                    Console.Clear();
                }
                catch(IOException z){};
                
                output="";
                System.Console.WriteLine(indx.ToString());
                System.Console.WriteLine("Seleziona un azione:\n");
                foreach(string z in options)
                    {
                        if (options[indx]==z)
                        {
                            output = output + ">" + z + "\n";
                        }
                        else
                        {
                            output = output + z + "\n";
                        }
                    }
                System.Console.WriteLine(output);
                var key = Console.ReadKey();
                string lastoutput = output;
                output="";
                if (key.Key==ConsoleKey.UpArrow)
                {
                    try
                    {
                        indx--;
                        foreach(string z in options)
                        {
                            if (options[indx]==z)
                            {
                                output = output + ">" + z + "\n";
                            }
                            else
                            {
                                output = output + z + "\n";
                            }
                        }
                    }
                    catch(IndexOutOfRangeException a)
                    {
                        output=lastoutput;
                        indx++;
                    }
                }
                else if (key.Key==ConsoleKey.DownArrow)
                {
                    try
                    {
                        indx++;
                        foreach(string z in options)
                        {
                            if (options[indx]==z)
                            {
                                output = output + ">" + z + "\n";
                            }
                            else
                            {
                                output = output + z + "\n";
                            }
                        }
                    }
                    catch(IndexOutOfRangeException a)
                    {
                        indx--;
                        output=lastoutput;
                    }
                }
                else if (key.Key==ConsoleKey.Enter)
                {
                    if (indx == 0)
                    {
                        System.Console.WriteLine("ciao");
                        foreach(string z in total)
                        {
                            System.Console.WriteLine(z);
                            System.Console.WriteLine("ciao");
                        }
                    }
                    else
                    {
                        if (indx == 1)
                        {
                            add(total);
                        }
                        Console.Clear();
                    }
                }
                else if (key.Key!=ConsoleKey.Escape)
                    output = lastoutput;
                else 
                {
                    Environment.Exit(0);
                    Console.Clear();
                }
                i++;
            }
        }

        static int count = 1;
        static void add(string[] tt)
        {
            System.Console.WriteLine("Inserire nome articolo");
            string name = Console.ReadLine();
            System.Console.WriteLine("Inserire prezzo articolo");
            bool k = true;
            while(k)
            {
                try
                {
                    int prezzo = Convert.ToInt32(Console.ReadLine());
                    items.Append(name);
                    prices.Append(prezzo);
                    total.Append(count.ToString() + name + " " + prezzo.ToString());
                    count++;
                    k = false;
                }
                catch (FormatException A)
                {
                    System.Console.WriteLine("Perfavore inserisci un numero");
                }
            }
        }
    }
}