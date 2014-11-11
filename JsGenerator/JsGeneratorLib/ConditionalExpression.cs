using System;

namespace JsGeneratorLib
{
    public class ConditionalExpression : Expression
    {
        public ConditionalExpression ()
        {
        }

        public IExpression test
        {
            get;
            set;
        }

        public IExpression alternate
        {
            get;
            set;
        }

        public IExpression consequent
        {
            get;
            set;
        }
    }
}

