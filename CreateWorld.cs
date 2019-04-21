using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;
using System.IO;

namespace VoxelEngineCSC
{
    public class CreateWorld
    {
        /// <summary>
        /// Creates a binary file storing all world data.
        /// </summary>
        public void CreateWorldFileStream(/* Int32 SCX, Int32 SCY, Int32 SCZ, Int32 CX, Int32 CY, int CZ, string FileName*/)
        {
            FileStream F = new FileStream("world.bin", FileMode.Create, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}