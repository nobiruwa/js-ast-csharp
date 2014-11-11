using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class Function : Node
    {
        public Function ()
        {
        }

        [JsonProperty(Order = 2)]
        public Identifier id { get; set; }
        [JsonProperty(Order = 3)]
        public List<IPattern> @params { get; set; }
        [JsonProperty(Order = 4)]
        public List<IExpression> defaults
        {
            get; set;
        }
        [JsonProperty(Order = 5)]
        public Identifier rest
        {
            get; set;
        }
        [JsonProperty(Order = 6)]
        public BlockStatement body
        {
            get; set;
        }
        [JsonProperty(Order = 7)]
        public Boolean generator
        {
            get; set;
        }
        [JsonProperty(Order = 8)]
        public Boolean expression
        {
            get; set;
        }
    }
}

