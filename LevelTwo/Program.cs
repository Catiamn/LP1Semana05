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
            
            else 
            {
                CanvasImage input_image = new CanvasImage(args[0]);
                input_image.MaxWidth(int.Parse(args[1]));
                AnsiConsole.Write(input_image);
            }
        
        }
    }
}
