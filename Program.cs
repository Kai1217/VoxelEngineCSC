using System;
using OpenTK;
using System.IO;

namespace VoxelEngineCSC
{
    class Program
    {
        static void Main(string[] args)
        {
            var createworld = new CreateWorld();
            createworld.CreateWorldFileStream();
            var saveworld = new SaveWorld();
            saveworld.SaveWorldToFile();

            using (var window = new Window(800, 600, "Window"))
            {
                window.Run(60.0);
            }
        }
    }
}
