using System;
using OpenTK;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using System.IO;
using System.Drawing;

namespace VisualEditor.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading up OpenGL. Please wait...", 0, DisplayDevice.Default);
            Console.WriteLine("OpenGL 2.0.0 has been loaded!", 0, DisplayDevice.Default);
            {
                GameWindow window = new GameWindow(800, 600);
                Game game = new Game(window);
                window.Title = String.Format("Visual Editor BETA V0.0.0.1, OpenGL 2.0 Version!");
                window.Run();
                //test this.
            }
        }
    }
}