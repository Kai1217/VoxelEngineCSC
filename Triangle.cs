using System;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Graphics;
using OpenTK.Input;

namespace VoxelEngineCSC
{
    public class Triange
    {
        public struct Vertex
        {
            public const int Size = (4 + 4) * 4;

            private readonly Vector4 _position;
            private readonly Color4 _color;

            public Vertex(Vector4 position, Color4 color)
            {
                _position = position;
                _color = color;
            }
        }
    } 
}