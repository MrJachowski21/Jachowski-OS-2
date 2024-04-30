using Cosmos.Core.Memory;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using JachowskiOS.System;
using JachowskiOS2.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace JachowskiOS
{
    public class Kernel : Sys.Kernel
    {
        public static string Version = "1.0.0";
        public static string Path = @"0:\";
        public static CosmosVFS fs;
        public static bool RunGUI;
        int lastHeapCollect;
        protected override void BeforeRun()
        {
            Console.SetWindowSize(90, 30);
            Console.OutputEncoding = Cosmos.System.ExtendedASCII.CosmosEncodingProvider.Instance.GetEncoding(437);
            fs = new Cosmos.System.FileSystem.CosmosVFS();
            Cosmos.System.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Booting JachowskiOS 2 " + Version);
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected override void Run()
        {
            if (!RunGUI)
            {
                Console.Write(Path + ">");
                var command = Console.ReadLine();
                ConsoleCommands.RunCommand(command);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                GUI.Update();
            }
            if (lastHeapCollect >= 20)//Czyści niepotrzebny ram, jednocześnie nie zabija fpsów ;p
            {
                Heap.Collect();
                lastHeapCollect = 0;
            }
            else
                lastHeapCollect++;
        }
    }
}