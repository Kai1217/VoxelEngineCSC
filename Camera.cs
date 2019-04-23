using OpenTK;
using System.IO;
using System;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;

namespace VoxelEngineCSC
{
    class Camera
    {
        public Vector3 Position = Vector3.Zero;
        public Vector3 Orientation = new Vector3((float)Math.PI, 0f, 0f);
        public float MoveSpeed = 0.2f;
        public float MouseSensitivity = 0.0025f;

        public Matrix4 GetViewMatrix()
        {
            Vector3 lookat = new Vector3();

            lookat.X = (float)(Math.Sin((float)Orientation.X) * Math.Cos((float)Orientation.Y));
            lookat.Y = (float)Math.Sin((float)Orientation.Y);
            lookat.Z = (float)(Math.Cos((float)Orientation.Z) * Math.Cos((float)Orientation.Y));

            return Matrix4.LookAt(Position, Position + lookat, Vector3.UnitY);
        }
    }
}