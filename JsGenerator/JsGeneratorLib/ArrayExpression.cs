using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class ArrayExpression : Expression
    {
        public List<IExpression> elements
        {
            get; set;
        }
    }
}