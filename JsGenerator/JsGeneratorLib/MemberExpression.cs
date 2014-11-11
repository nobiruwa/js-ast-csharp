using System;

namespace JsGeneratorLib
{
    public class MemberExpression : Expression
    {
        public MemberExpression ()
        {
        }

        public IExpression @object
        {
            get;
            set;
        }

        public Identifier property {
            get;
            set;
        }

        public bool computed {
            get;
            set;
        }
    }
}

