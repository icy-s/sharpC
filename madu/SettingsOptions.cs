using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class SettingsOptions
    {
        public static string[] SettingsOptionsList = { "SPEED", "SYMBOL", "BG THEME VOLUME" };
        
        public static int[] Speed = { 100, 200, 300 };
        public static string[] Symbol = { "*", "#", "@", "&", "-"};
        public static int[] SoundVolume = Enumerable.Range(0, 101).ToArray();

        public static int[] DEFAULT = { 0, 1, 70 };

    }
}