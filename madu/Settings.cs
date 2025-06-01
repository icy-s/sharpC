using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Settings
    {
        public static void OpenSettings()
        {
            List<int> choises = Keyboard.ChooseOptionSettings("SETTINGS");

            if (choises == null)
            {
                return; // пользователь нажал Escape — выход из настроек
            }


        }
    }
}