namespace JsGeneratorLib
{
    public class Property : Node
    {
        public Identifier key
        {
            get; set;
        }
        public IExpression value;
        public Kind kind
        {
            get; set;
        }
        public enum Kind
        {
            init, @get, @set
        }
    }
}