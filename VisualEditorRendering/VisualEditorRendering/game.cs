using System;
using OpenTK;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace VisualEditor.cs
{
    class Game
    {
        public GameWindow window;

        public Game(GameWindow windowInput)
        {
            this.window = windowInput;

            window.Load += window_Load;
            window.RenderFrame += Window_RenderFrame;
            window.UpdateFrame += Window_UpdateFrame;
            window.Closing += Window_Closing;
        }//no.

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        void window_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.FromArgb(2, 65, 245));
        }

        private void Window_UpdateFrame(object sender, FrameEventArgs e)
        {

        }

        private void Window_RenderFrame(object sender, FrameEventArgs e)
        {

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Flush();

            GL.Begin(PrimitiveType.Quads);
            //load up the quads immediately!

            GL.Color3(Color.BlueViolet);
            GL.Vertex2(0, 0);
            GL.Color3(Color.OrangeRed);
            GL.Vertex2(0.9f, 0);
            GL.Color3(Color.YellowGreen);
            GL.Vertex2(1, -0.9f);
            GL.Color3(Color.Green);
            GL.Vertex2(0, -1);

            GL.End();
            window.SwapBuffers();
        }
    }
}