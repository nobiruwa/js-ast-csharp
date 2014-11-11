using System;

namespace JsGeneratorLib
{
    public class AssignmentExpression : Expression
    {
        public class AssignmentOperator
        {
            private readonly string name;
            private readonly int value;

            private readonly static AssignmentOperator ASSIGNMENT = new AssignmentOperator("=", 1);
            private readonly static AssignmentOperator ADDITION_ASSIGNMENT = new AssignmentOperator("+=", 2);
            private readonly static AssignmentOperator SUBTRACTION_ASSIGNMENT = new AssignmentOperator("-=", 3);
            private readonly static AssignmentOperator MULTIPLICATION_ASSIGNMENT = new AssignmentOperator("*=", 4);
            private readonly static AssignmentOperator DIVISION_ASSIGNMENT = new AssignmentOperator("/=", 5);
            private readonly static AssignmentOperator REMAINDER_ASSIGNMENT = new AssignmentOperator("%=", 6);

            private readonly static AssignmentOperator LSHIFT_ASSIGNMENT = new AssignmentOperator("<<=", 7);
            private readonly static AssignmentOperator RSHIFT_ASSIGNMENT = new AssignmentOperator(">>=", 8);
            private readonly static AssignmentOperator UNSIGNED_RSHIFT_ASSIGNMENT = new AssignmentOperator(">>>=", 9);

            private readonly static AssignmentOperator BITWISE_OR_ASSIGNMENT = new AssignmentOperator("|=", 10);
            private readonly static AssignmentOperator BITWISE_XOR_ASSIGNMENT = new AssignmentOperator("^=", 11);
            private readonly static AssignmentOperator BITWISE_AND_ASSIGNMENT = new AssignmentOperator("&=", 12);

            private AssignmentOperator(string name, int value)
            {
                this.name = name;
                this.value = value;
            }

            public override string ToString()
            {
                return name;
            }
        }
        public AssignmentExpression ()
        {
        }
        public AssignmentOperator @operator {
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

