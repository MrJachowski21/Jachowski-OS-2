using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JachowskiOS2.Graphics;
using JachowskiOS;

namespace JachowskiOS2.System
{
    public static class Boot
    {
        public static void onBoot()
        {
            Kernel.RunGUI = true;
            GUI.Wallpaper = new Bitmap(Resources.Files.JachowskiOS2BackgroundRaw);
            GUI.Cursor = new Bitmap(Resources.Files.JachowskiOSCursorRaw);
            GUI.StartGUI();
        }
    }
}
