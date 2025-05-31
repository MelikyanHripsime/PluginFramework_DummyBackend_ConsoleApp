using PluginFramework_DummyBackend_ConsoleApp.DummyRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Models
{
    public class ApplyEffectsRequest
    {
        public Dictionary<Guid, List<Effect>> ImagesWithRequestedEffects { get; set; }

        //In real life will register as singelton instead of passing as rgument
        public ImagesRepository ImagesRepository { get; set;}
    }
}
