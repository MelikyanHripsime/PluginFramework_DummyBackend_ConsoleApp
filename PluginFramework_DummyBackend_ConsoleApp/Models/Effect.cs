using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Models
{
    public class Effect 
    {
        public IEffect ApplyEffect {  get; set; }
    }

    public interface IEffect
    {
        public string Name { get; set; }
    }

    public class SizeEffect : IEffect
    {
        public string Name { get; set; }

        public Size? Size { get; set; }
    }

    public class BlurEffect : IEffect
    {
        public string Name { get; set; }

        public int? BlureRadius { get; set; }
    }

    public class Grayscale : IEffect
    {
        public string Name { get; set; }

        public bool? IsGrayscale { get; set; }

    }
}
