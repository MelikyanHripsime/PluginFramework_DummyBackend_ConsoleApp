using PluginFramework_DummyBackend_ConsoleApp.DummyRepository;
using PluginFramework_DummyBackend_ConsoleApp.Models;
using PluginFramework_DummyBackend_ConsoleApp.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Plugins
{
    public class ResizeImagePlugin : IApplyEffectOnImagePlugin
    {
        public ResizeImagePlugin()
        {

        }

        public void ApplyEffectOnImagePlugin(Guid imageId, IEffect effect, ImagesRepository imagesRepository)
        {

            ResizeImage(imageId, effect, imagesRepository);
            
        }

        private void ResizeImage(Guid imageId, IEffect effect, ImagesRepository imagesRepository)
        {
            if (effect is SizeEffect size)
            {

                var image = imagesRepository.GetImageById(imageId);
                image.Size = size.Size;
                imagesRepository.UpdateImage(image);
            }
        }
    }
}
