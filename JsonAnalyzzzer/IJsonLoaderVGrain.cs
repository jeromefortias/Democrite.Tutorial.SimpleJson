using Democrite.Framework.Core.Abstractions;
using Democrite.Framework.Core.Abstractions.Attributes;
using Democrite.Framework.Core.Abstractions.Attributes.MetaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexai.Kaonashi.Dialog
{
    [VGrainCategory("Collector")]
    //[VGrainMetaData()]
    public interface IJsonLoaderVGrain : IVGrain
    {
        Task<string> LoadJsonAsync(string FullPath, IExecutionContext Context);

    }
}
