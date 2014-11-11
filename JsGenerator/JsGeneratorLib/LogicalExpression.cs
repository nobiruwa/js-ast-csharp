using System;

namespace JsGeneratorLib
{
    public class LogicalExpression
    {
        public class LogicalOperator
        {
            private readonly string name;
            private readonly int value;

            private readonly static LogicalOperator OR = new LogicalOperator("||", 1);
            private readonly static LogicalOperator AND = new LogicalOperator("&&", 2);


            private LogicalOperator(string name, int value)
            {
                this.name = name;
                this.value = value;
            }

            public override string ToString()
            {
                return name;
            }
        }
        public LogicalExpression ()
        {
        }

        public LogicalOperator @operator {
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

