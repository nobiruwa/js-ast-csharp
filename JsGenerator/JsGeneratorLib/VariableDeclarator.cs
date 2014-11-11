namespace JsGeneratorLib
{
    public class VariableDeclarator : Node
    {
        public IPattern id
        {
            get; set;
        }
        public IExpression init
        {
            get; set;
        }
    }
}