using System;
using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class NewExpression : Expression
    {
        public NewExpression ()
        {
        }

        public IExpression callee {
            get;
            set;
        }

        public List<IExpression> arguments {
            get;
            set;
        }
    }
}

