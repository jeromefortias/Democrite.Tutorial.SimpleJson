using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexai.Kaonashi.Dialog
{
    [GenerateSerializer]
    public class InspectorState
    {
        [Id(0)]
        public int counter { get; set; }
    }
}
