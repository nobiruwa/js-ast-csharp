using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class SequenceExpression : Expression
    {
        public List<IExpression> expressions
        {
            get; set;
        }
    }
}