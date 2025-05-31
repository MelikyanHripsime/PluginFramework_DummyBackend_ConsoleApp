using PluginFramework_DummyBackend_ConsoleApp.DummyRepository;
using PluginFramework_DummyBackend_ConsoleApp.Models;
using PluginFramework_DummyBackend_ConsoleApp.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Plugins
{
    public class GrayscaleEffectPlugin : IApplyEffectOnImagePlugin
    {
        public void ApplyEffectOnImagePlugin(Guid imageId, IEffect effect, ImagesRepository imagesRepository)
        {
            ChangeBlurRadius(imageId, effect, imagesRepository);
        }

        private void ChangeBlurRadius(Guid imageId, IEffect effect, ImagesRepository imagesRepository)
        {
            if (effect is Grayscale sizeEfect)
            {
                var image = imagesRepository.GetImageById(imageId);
                image.IsGrayscale = sizeEfect.IsGrayscale.Value;
                imagesRepository.UpdateImage(image);
            }

        }
    }
}
