using System;

namespace JsGeneratorLib
{
    public class BinaryExpression : Expression
    {
        public sealed class BinaryOperator
        {
            private readonly string name;
            private readonly int value;

            public static readonly BinaryOperator EQUALS = new BinaryOperator("==", 1);
            public static readonly BinaryOperator NOT_EQUALS = new BinaryOperator("!=", 2);
            public static readonly BinaryOperator STRICTLY_EQUALS = new BinaryOperator("===", 3);
            public static readonly BinaryOperator STRICTLY_NOT_EQUALS = new BinaryOperator("!==", 4);

            public static readonly BinaryOperator LESS_THAN = new BinaryOperator("<", 5);
            public static readonly BinaryOperator LESS_THAN_OR_EQUAL = new BinaryOperator("<=", 6);
            public static readonly BinaryOperator GREATER_THAN = new BinaryOperator(">", 7);
            public static readonly BinaryOperator GERATER_THAN_OR_EQUAL = new BinaryOperator(">=", 8);

            public static readonly BinaryOperator LSHIFT = new BinaryOperator("<<", 9);
            public static readonly BinaryOperator RSHIFT = new BinaryOperator(">>", 10);
            public static readonly BinaryOperator ZERO_PADDING_RSHIFT = new BinaryOperator(">>>", 11);

            public static readonly BinaryOperator ADD = new BinaryOperator("+", 12);
            public static readonly BinaryOperator SUBTRACT = new BinaryOperator("-", 13);
            public static readonly BinaryOperator MULTIPLY = new BinaryOperator("*", 14);
            public static readonly BinaryOperator DIVIDE = new BinaryOperator("/", 15);
            public static readonly BinaryOperator REMAINDER = new BinaryOperator("%", 16);

            public static readonly BinaryOperator OR = new BinaryOperator("|", 17);
            public static readonly BinaryOperator XOR = new BinaryOperator("^", 18);
            public static readonly BinaryOperator AND = new BinaryOperator("&", 19);
            public static readonly BinaryOperator IN = new BinaryOperator("in", 20);

            public static readonly BinaryOperator INSTANCEOF = new BinaryOperator("instanceof", 21);
            public static readonly BinaryOperator SPREAD = new BinaryOperator("..", 22);


            private BinaryOperator(string name, int value)
            {
                this.name = name;
                this.value = value;
            }
            public override string ToString()
            {
                return name;
            }
        }
        public BinaryExpression ()
        {
        }
        public BinaryOperator @operator {
            get;
            set;
        }
        public IExpression left {
            get;
            set;
        }
        public IExpression right {
            get;
            set;
        }
    }
}

