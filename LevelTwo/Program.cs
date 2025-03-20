using System;
using Spectre.Console;


namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                //makes the default image the "tux.jpg"
                CanvasImage default_image = new CanvasImage("tux.jpg");
                //max size
                default_image.MaxWidth(24);
                //renders the image
                AnsiConsole.Write(default_image);
            }

        
        }
    }
}
