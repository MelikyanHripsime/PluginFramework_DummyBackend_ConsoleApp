using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework_DummyBackend_ConsoleApp.Models
{
    public class ApplyEffectsResponse
    {
        public IEnumerable<Guid> ChangedImages {  get; set; }
    }
}