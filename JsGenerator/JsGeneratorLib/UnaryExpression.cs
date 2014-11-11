namespace JsGeneratorLib
{
    public class UnaryExpression : Expression
    {
        public sealed class UnaryOperator
        {
            private readonly string name;
            private readonly int value;

            public static readonly UnaryOperator NEGATION = new UnaryOperator ("-", 1);
            public static readonly UnaryOperator PLUS = new UnaryOperator ("+", 2);
            public static readonly UnaryOperator BITWISE_NOT = new UnaryOperator ("!", 3);
            public static readonly UnaryOperator LOGICAL_NOT = new UnaryOperator ("~", 4);
            public static readonly UnaryOperator TYPEOF = new UnaryOperator ("typeof", 5);
            public static readonly UnaryOperator VOID = new UnaryOperator ("void", 6);
            public static readonly UnaryOperator DELETE = new UnaryOperator ("delete", 7);

            private UnaryOperator (string name, int value)
            {
                this.name = name;
                this.value = value;
            }

            public override string ToString ()
            {
                return name;
            }
        }
        public UnaryOperator @operator {
            get;
            set;
        }
        public bool prefix {
            get;
            set;
        }
        public IExpression argument {
            get;
            set;
        }
    }
}