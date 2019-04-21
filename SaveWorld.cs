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
            var error = new MyException();
            FileStream F = new FileStream("world.bin", FileMode.Open, FileAccess.Write);
            var savefile = F;
            
            try
            {
                bool exists = File.Exists("world.bin");
            }
            catch (FileNotFoundException e)
            {
                throw (error);
               /*  {
                    Console.WriteLine("[FATAL] Could not save world to file!\n");
                    return 1;
                } */
                
            }
            return 0;
        }
    }
    class MyException : SystemException
    {
        public void ErrorMessage()
        {
            Console.WriteLine("[FATAL] Could not save world to file!\n");
            Console.ReadKey();
        }
    }
}
