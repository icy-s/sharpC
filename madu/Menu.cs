using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Madu
{
    class Menu
    {
        private static string[] menu_options = { "START", "SETTINGS", "LEADERBOARD", "EXIT" };

        public List<int> ShowOptions()
        {
            while (true)
            {
                int choice = Keyboard.ChooseOption("Main Menu", menu_options);
                switch (choice)
                {
                    case 0:
                        return SettingsOptions.DEFAULT.ToList();

                    case 1:
                        return Keyboard.ChooseOptionSettings("SETTINGS");

                    case 2:
                        Score();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }

        public static int GetSpeed(List<int> choises)
        {
            return SettingsOptions.Speed[choises[0]];
        }

        public static string GetSymbol(List<int> choises)
        {
            return SettingsOptions.Symbol[choises[1]];
        }

        public static int GetSoundVolume(List<int> choises)
        {
            return SettingsOptions.SoundVolume[choises[2]];
        }
        public void Score()
        {
            Console.Clear();
            string path = "C:\\Users\\xicey\\source\\repos\\icy-s\\sharpC\\madu\\scores.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                List<(string Name, int Score)> scores = new List<(string, int)>();

                foreach (string line in lines)
                {
                    var parts = line.Split('-');
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int score))
                    {
                        scores.Add((parts[0].Trim(), score));
                    }
                }
                var sortedScores = scores.OrderByDescending(s => s.Score).ToList();

                Console.WriteLine("Scores:\n");

                for (int i = 0; i < sortedScores.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {sortedScores[i].Name} - {sortedScores[i].Score}");
                }
            }
            else
            {
                Console.WriteLine("file not found - creating new");
            }

            Console.WriteLine("\nPress any key to go back to menu");
            Console.ReadKey();
        }
    }
}