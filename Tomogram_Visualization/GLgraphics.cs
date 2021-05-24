﻿using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;


namespace Tomogram_Visualization
{
    class GLgraphics
    {
        public void Update()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        public void Setup(int width, int height)
        {
            GL.ClearColor(Color.DarkGray);
            GL.ShadeModel(ShadingModel.Smooth);
            GL.Enable(EnableCap.DepthTest);
            Matrix4 perspectiveMat = Matrix4.CreatePerspectiveFieldOfView(
                    MathHelper.PiOver4,
                    width / (float)height,
                    1,
                    64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspectiveMat);
        }
    }
       
}