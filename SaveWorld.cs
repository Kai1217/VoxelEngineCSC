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
    class SaveWorld
    {
        /// <summary>
        /// Opens a binary file holding all world data, saving new changes to file.
        /// </summary>
        public int SaveWorldToFile()
        {
            string FileName = "world.bin";
            FileStream F = new FileStream(FileName, FileMode.Open, FileAccess.Write);
            var savefile = F;

            if (!File.Exists(FileName))
            {
                Console.WriteLine("[FATAL] Failed to open file {0}!\n", FileName);
                return 1;
            } else
            {
                Console.WriteLine("Successfully opened file {0}.\n", FileName);
                return 0;
            }
        }
    }
}
