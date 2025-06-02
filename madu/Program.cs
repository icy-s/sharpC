using Madu;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace sharpC.madu
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.SetWindowSize(79, 25);
                Console.SetBufferSize(79, 25);
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                int defaultVolumeInt = SettingsOptions.DEFAULT[2]; // третий элемент списка
                float defaultVolume = defaultVolumeInt / 100f;

                float currentVolume = defaultVolume;
                int currentTrackIndex = 0; // индекс текущего трека — изначально 0
                string selectedTrack = SettingsOptions.BgChoice[0]; // первая композиция по умолчанию
                string musicPath = $"../../../madu/resources/{selectedTrack}.mp3";

                // Инициализация проигрывателя
                AudioFileReader audioFileReader = new AudioFileReader(musicPath)
                {
                    Volume = defaultVolume
                };
                LoopStream loop = new LoopStream(audioFileReader)
                {
                    EnableLooping = true,
                };
                IWavePlayer waveOutDevice = new WaveOutEvent();
                waveOutDevice.Init(loop);
                waveOutDevice.Play();

            while (true)
                {
                    Console.Clear();

                    Menu menu = new Menu();

                    List<int> a;
                    while (true)
                    {
                        a = menu.ShowOptions();
                        if (a != null) break;
                    }

                    int Sp = Menu.GetSpeed(a);
                    string Sy = Menu.GetSymbol(a);

                    // Проверяем, есть ли громкость в меню (индекс 2)
                    if (a.Count > 2)
                    {
                        currentVolume = a[2] / 100f; // обновляем текущую громкость только если пользователь изменил
                    }

                    // Обновляем индекс трека, если в меню есть значение
                    if (a.Count > 3)
                    {
                        currentTrackIndex = a[3];
                    }

                    selectedTrack = SettingsOptions.BgChoice[currentTrackIndex];
                    musicPath = $"../../../madu/resources/{selectedTrack}.mp3";

                    // Остановить и освободить текущий плеер и аудиофайл, если они есть
                    if (waveOutDevice != null)
                    {
                        waveOutDevice.Stop();
                        waveOutDevice.Dispose();
                        waveOutDevice = null;
                    }
                    if (audioFileReader != null)
                    {
                        audioFileReader.Dispose();
                        audioFileReader = null;
                    }

                    audioFileReader = new AudioFileReader(musicPath);
                    audioFileReader.Volume = currentVolume;

                    loop = new LoopStream(audioFileReader)
                    {
                        EnableLooping = true
                    };

                    waveOutDevice = new WaveOutEvent();
                    waveOutDevice.Init(loop);
                    waveOutDevice.Play();

                    Console.Clear();
                    string Name = "";

                    while (true)
                    {
                        Console.Write("your name: ");
                        Name = Console.ReadLine()?.Trim(); // Убираем пробелы

                        if (!string.IsNullOrEmpty(Name) && Name.Length >= 3)
                        {
                            break;
                        }

                        Console.WriteLine("at least 3 characters.\n");
                    }

                    int score = 0;

                    Walls walls = new Walls(80, 25);
                    walls.Draw();

                    Point p = new Point(4, 5, Sy);
                    Snake snake = new Snake(p, 4, Direction.RIGHT);
                    snake.Draw();

                    FoodCreator foodCreator = new FoodCreator(80, 25, "🚬");
                    Point food = foodCreator.CreateFood();
                    food.Draw();

                    while (true)
                    {
                        if (walls.IsHit(snake) || snake.IsHitTail())
                            break;

                        if (snake.Eat(food))
                        {
                            score++;
                            food = foodCreator.CreateFood();
                            food.Draw();
                            Console.SetCursorPosition(0, 24);
                            Console.Write($"Player: {Name} | Score: {score}");
                        }
                        else
                        {
                            snake.Move();
                        }

                        Thread.Sleep(Sp);

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            snake.HandleKey(key.Key);
                        }
                    }

                    WriteGameOver(Name, score);
                }
            }



            static void WriteGameOver(string name, int score)
            {
                AudioFileReader audioFileReader = new AudioFileReader("../../../madu/resources/dead.mp3");

                IWavePlayer waveOutDevice = new WaveOutEvent();
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                string path = "C:\\Users\\iData.ICEYAY\\source\\repos\\icy-s\\sharpC\\madu\\scores.txt";
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(name + " - " + score);
                }

                int xOffset = 25;
                int yOffset = 8;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(xOffset, yOffset++);
                WriteText("============================", xOffset, yOffset++);
                WriteText("G  A  M  E      O  V  E  R", xOffset + 1, yOffset++);
                WriteText("press any key to continue", xOffset + 2, yOffset++);
                WriteText("============================", xOffset, yOffset++);
                Console.ReadKey();
                Console.Clear();
            }

            static void WriteText(String text, int xOffset, int yOffset)
            {
                Console.SetCursorPosition(xOffset, yOffset);
                Console.WriteLine(text);
            }

        }
    }