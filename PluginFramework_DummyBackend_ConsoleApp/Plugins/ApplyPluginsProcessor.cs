using PluginFramework_DummyBackend_ConsoleApp.Models;
using PluginFramework_DummyBackend_ConsoleApp.Plugins.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Plugins
{
    public class ApplyPluginsProcessor : IApplyEffectProcessor
    {
        private readonly ResizeImagePlugin resizePlugin;
        private readonly BlurImagePlugin blurPlugin;
        private readonly GrayscaleEffectPlugin grayscalePlugin;

        public ApplyPluginsProcessor() {

            resizePlugin = new ResizeImagePlugin();
            blurPlugin = new BlurImagePlugin();
            grayscalePlugin = new GrayscaleEffectPlugin();
        }

        public ApplyEffectsResponse ProcessEffects(ApplyEffectsRequest applyEffectsRequest)
        {
            foreach (var imageInfo in applyEffectsRequest.ImagesWithRequestedEffects)
            {
                foreach (var effect in imageInfo.Value)
                {
                    // In real implementation will do better way instead of this 
                    resizePlugin.ApplyEffectOnImagePlugin(imageInfo.Key, effect.ApplyEffect, applyEffectsRequest.ImagesRepository);
                    blurPlugin.ApplyEffectOnImagePlugin(imageInfo.Key, effect.ApplyEffect, applyEffectsRequest.ImagesRepository);
                    grayscalePlugin.ApplyEffectOnImagePlugin(imageInfo.Key, effect.ApplyEffect, applyEffectsRequest.ImagesRepository);
                }

            }

            // in real implementation will return ids and response code
            return new ApplyEffectsResponse() { };
        }

    }
}
