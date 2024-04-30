﻿using JachowskiOS2.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JachowskiOS2.System
{
    public static class Window
    {
        public static int TopSize = 30;
        public static void DrawTop(Process proc)
        {
            CustomDrawing.DrawTopRoundedRectangle(proc.WindowData.WinPos.X, proc.WindowData.WinPos.Y, proc.WindowData.WinPos.Width, TopSize, TopSize/2, GUI.colors.ColorDark);
        }
    }
}
