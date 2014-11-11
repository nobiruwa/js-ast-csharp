using System;
using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class CallExpression : Expression
    {
        public CallExpression ()
        {
        }

        public IExpression callee
        {
            get;
            set;
        }

        public List<IExpression> arguments
        {
            get;
            set;
        }
    }
}

