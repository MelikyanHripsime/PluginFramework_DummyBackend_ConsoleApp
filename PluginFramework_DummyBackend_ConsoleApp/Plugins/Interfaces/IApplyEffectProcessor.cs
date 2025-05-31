using PluginFramework_DummyBackend_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Plugins.Interfaces
{
    public interface IApplyEffectProcessor
    {
        ApplyEffectsResponse ProcessEffects(ApplyEffectsRequest applyEffectsRequest);
    }
}
