using PluginFramework_DummyBackend_ConsoleApp.DummyRepository;
using PluginFramework_DummyBackend_ConsoleApp.Models;

namespace PluginFramework_DummyBackend_ConsoleApp.Plugins.Interfaces
{
    public interface IApplyEffectOnImagePlugin
    {
        void ApplyEffectOnImagePlugin(Guid imageId, IEffect effect, ImagesRepository imagesRepository);
    }
}
