using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Madu;
using NAudio.Wave;
using System.Transactions;
using System.Security.Cryptography.X509Certificates;

namespace sharpC.madu
{
    class Program
    {
        static void Main(string[] args)
        {

            //фоновая композиция

            AudioFileReader audioFileReader = new AudioFileReader("../../../madu/resources/bg.mp3");

            IWavePlayer waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();



            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Menu menu = new Menu();
            menu.ShowOptions();
            List<int> a = menu.ShowOptions();
            bool DM = Menu.GetDrunkMode(a);
            int Sp = Menu.GetSpeed(a);
            string Sy = Menu.GetSymbol(a);
            int So = Menu.GetSoundVolume(a);
            Console.Clear();

            // стены (вместо рамки)
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // старая рамка
            /*HorizontalLine upLine = new HorizontalLine(0, 78, 0, "-");
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, "-");
            VerticalLine leftLine = new VerticalLine(0, 24, 0, "/");
            VerticalLine rightLine = new VerticalLine(0, 24, 78, "/");
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();*/

            // точки
            Point p = new Point(4, 5, Sy);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, "🚬");
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) //       || означают "или"
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }


        static void WriteGameOver()
        {
            AudioFileReader audioFileReader = new AudioFileReader("../../../madu/resources/dead.mp3");

            IWavePlayer waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("G  A  M  E      O  V  E  R", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("made by: icy, Ṣ̶̬͑̌e̷̖̾͊̚ͅa̶̗͙̓g̶̞̹̿̐͐ư̸̬̗͇̥͒̂l̶̢̀͐l̵̗͚̹͑͆̆ͅT̷͈͍̥̲͑̽ó̵͎̆͘o̸̠͗̊n̸̗͊", xOffset + 2, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
