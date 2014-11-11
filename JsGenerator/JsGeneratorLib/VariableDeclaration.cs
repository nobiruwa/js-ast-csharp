using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class VariableDeclaration : Declaration
    {
        public List<VariableDeclarator> declarations
        {
            get; set;
        }
        public Kind kind
        {
            get; set;
        }
        public enum Kind
        {
            @var,
            @let,
            @const
        }
    }
}