using System;
using Newtonsoft.Json;

namespace JsGeneratorLib
{
    public interface INode
    {
        [JsonProperty(Order = 1)]
        string type {
            get;
        }
        SourceLocation loc {
            get;
            set;
        }
    }
}

