using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class ObjectExpression : Expression
    {
        public List<Property> properties
        {
            get; set;
        }
    }
}