using System;
using Newtonsoft.Json;

namespace JsGeneratorLib
{
    public abstract class Node : INode
    {
        [JsonProperty(Order = 1)]
        public string type {
            get {
                return this.GetType ().Name;
            }
        }
        public SourceLocation loc {
            get;
            set;
        }
    }
}

