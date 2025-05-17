using System;
using System.Xml.Linq;
using Microsoft.Win32.SafeHandles;

namespace sharpC.kangelane
{
    class Program
    {
        static void Main()
        {
            List<Kangelane> kangelased = new List<Kangelane>();


            void LoeKangelasedFailist(string failinimi)
            {
                string[] readLines = File.ReadAllLines(failinimi);
                foreach (string line in readLines)
                {

                    string[] parts = line.Split("/");
                    if (parts.Length == 2)
                    {
                        string nimi = parts[0];
                        string asukoht = parts[1];
                        if (nimi.Contains('*'))
                        {
                            SuperKangelane sk = new SuperKangelane(nimi, asukoht);
                            Console.WriteLine("Kui palju inimesi on ohus?");
                            while (true)
                            {
                                string sis = Console.ReadLine();
                                try
                                {
                                    int ohus = int.Parse(sis);
                                    Console.WriteLine(sk.Kirjelda(ohus));
                                    break;
                                }

                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                        }
                        else
                        {
                            Kangelane ka = new Kangelane(nimi, asukoht);
                            Console.WriteLine("Kui palju inimesi on ohus?");
                            while (true)
                            {
                                string sis = Console.ReadLine();
                                try
                                {
                                    int ohus = int.Parse(sis);
                                    Console.WriteLine(ka.Kirjelda(ohus));
                                    break;
                                }

                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                        }


                    }
                }
            }

            LoeKangelasedFailist("C:/Users/xicey/source/repos/icy-s/sharpC/kangelane/andmed.txt");

        }
    }
}
