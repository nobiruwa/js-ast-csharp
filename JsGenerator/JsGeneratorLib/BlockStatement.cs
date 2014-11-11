using System;
using System.Collections.Generic;

namespace JsGeneratorLib
{
    public class BlockStatement : Statement
    {
        private List<IStatement> __body = new List<IStatement>();
        public BlockStatement ()
        {
        }
        public List<IStatement> body
        {
            get
            {
                return this.__body;
            }
        }
    }
}

