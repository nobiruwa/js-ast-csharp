using System;

namespace JsGeneratorLib
{
    public class Literal : Expression
    {
        public sealed class Value {
            private readonly string name;
            private readonly int value;

            public static readonly Value STRING = new Value("string", 1);
            public static readonly Value BOOLEAN = new Value("boolean", 2);
            public static readonly Value NULL = new Value("null", 3);
            public static readonly Value NUMBER = new Value("number", 4);
            public static readonly Value REGEXP = new Value("RegExp", 5);

            private Value(string name, int value) {
                this.name = name;
                this.value = value;
            }

            public override string ToString ()
            {
                return name;
            }
        }
        public Literal ()
        {
        }

        public Value value {
            get;
            set;
        }
    }
}

