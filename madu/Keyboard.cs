using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Keyboard
    {
        public static int ChooseOption(string title, string[] options)
        {
            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(2, 0);
                Console.WriteLine(title);
                Console.SetCursorPosition(2, 1);
                Console.WriteLine(new string('~', title.Length));

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(2, 2 + i);
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-> " + options[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("   " + options[i]);
                    }
                }

                // ⬅️ Добавляем змею прямо здесь:
                string[] snakeArt = {
    "           /^\\/^\\",
    "         _|__| O|",
    " \\/    /~    \\_/ \\",
    "  \\___|_______/  \\",
    "       \\_____     \\",
    "             `\\    \\            \\",
    "              |    |             \\",
    "             /     /              \\",
    "            /    /                 \\",
    "          /    /                   \\",
    "         /   /                     \\",
    "       /   /           _----_       \\",
    "      /   /         _-~      ~-_    |",
    "     (    (      _-~    _--_    ~-_ _/",
    "      \\    ~-___-~    _-~    ~-_   ~-",
    "        ~-_        _-~          ~-_",
    "           ~--___-~               ~-"
};



                int snakeX = Console.WindowWidth - 45;
                for (int j = 0; j < snakeArt.Length; j++)
                {
                    Console.SetCursorPosition(snakeX, 3 + j);
                    Console.WriteLine(snakeArt[j]);
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex + 1) % options.Length;
                        break;
                    case ConsoleKey.Enter:
                        return selectedIndex;
                }

            } while (true);
        }


        /////////////////////////////////////// 

        public static List<int> ChooseOptionSettings(string title)
        {
            int selectedIndex = 0;
            ConsoleKey key;
            int Sp = 0;
            int Sy = 0;
            int So = 50;
            int Bg = 0;

            List<int> optionslist = new List<int> { SettingsOptions.Speed.Length, SettingsOptions.Symbol.Length, SettingsOptions.SoundVolume.Length, SettingsOptions.BgChoice.Length};
            List<int> param = new List<int> {Sp, Sy, So, Bg };

            do
            {

                Console.Clear();
                Console.SetCursorPosition(37, 7);
                Console.WriteLine(title);
                Console.SetCursorPosition(37, 8);
                Console.WriteLine(new string('~', title.Length));

                for (int i = 0; i < SettingsOptions.SettingsOptionsList.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.SetCursorPosition(35, 10 + (2 * i));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("   " + SettingsOptions.SettingsOptionsList[i]);
                        Console.SetCursorPosition(50, 10 + (2 * i));
                        if (i == 0)
                        { Console.WriteLine("< " + SettingsOptions.Speed[Sp] + " >"); }
                        else if (i == 1)
                        { Console.WriteLine("< " + SettingsOptions.Symbol[Sy] + " >"); }
                        else if (i == 2)
                        { Console.WriteLine("< " + SettingsOptions.SoundVolume[So] + " >"); }
                        else if (i == 3)
                        { Console.WriteLine("< " + SettingsOptions.BgChoice[Bg] + " >"); }

                        Console.ResetColor();

                    }
                    else
                    {
                        Console.SetCursorPosition(35, 10 + (2 * i));
                        Console.WriteLine("   " + SettingsOptions.SettingsOptionsList[i]);
                        Console.SetCursorPosition(50, 10 + (2 * i));
                        if (i == 0)
                        { Console.WriteLine("< " + SettingsOptions.Speed[Sp] + " >"); }
                        else if (i == 1)
                        { Console.WriteLine("< " + SettingsOptions.Symbol[Sy] + " >"); }
                        else if (i == 2)
                        { Console.WriteLine("< " + SettingsOptions.SoundVolume[So] + " >"); }
                        else if (i == 3)
                        { Console.WriteLine("< " + SettingsOptions.BgChoice[Bg] + " >"); }
                    }
                }

                int baseLeft = 35;
                int baseTop = 10 + (2 * SettingsOptions.SettingsOptionsList.Length + 2);

                Console.SetCursorPosition(baseLeft, baseTop);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("less speed value = faster snake (100 > 300)");
                Console.SetCursorPosition(baseLeft, baseTop + 1);
                Console.WriteLine("press ENTER to play or ESC to exit");

                Console.ResetColor();

                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex - 1 + SettingsOptions.SettingsOptionsList.Length) % SettingsOptions.SettingsOptionsList.Length;

                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex + 1) % SettingsOptions.SettingsOptionsList.Length;

                        break;
                    case ConsoleKey.LeftArrow:
                        if (param[selectedIndex] > 0)
                        { param[selectedIndex]--; }
                        Sp = param[0];
                        Sy = param[1];
                        So = param[2];
                        Bg = param[3];
                        break;
                    case ConsoleKey.RightArrow:
                        if (param[selectedIndex] < optionslist[selectedIndex] - 1)
                        { param[selectedIndex]++; }
                        Sp = param[0];
                        Sy = param[1];
                        So = param[2];
                        Bg = param[3];
                        break;
                    case ConsoleKey.Enter:
                        return param;
                    case ConsoleKey.Escape:
                        return null;

                }
            }
            while (true);
        }


    }
}

