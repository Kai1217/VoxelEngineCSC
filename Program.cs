using System;

namespace VoxelEngineCSC
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var window = new Window(800, 600, "Window"))
            {
                window.Run(60.0);
            }
        }
    }
}
