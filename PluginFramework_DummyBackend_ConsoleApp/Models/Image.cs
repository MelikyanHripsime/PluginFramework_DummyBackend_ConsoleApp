using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Models
{
    public class Image
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string FileFormat { get; set; }

        public Size? Size { get; set; }          
        public bool IsGrayscale { get; set; }      
        public int? BlurRadius { get; set; }

        public override string? ToString()
        {
            return $"{Name}" + " " + $"Size {Size.Height} {Size.Width}" + " " + $"IsGrayscale {IsGrayscale}" + " " + $"BlurRadius {BlurRadius}" ;
        }
    }

    public class Size
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
