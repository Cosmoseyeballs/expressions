﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    public abstract class UnaryExpression : Expression
    {
        protected Expression expr;

        public override double Evaluate()
        {
            return expr.Evaluate();
        }
    }
}
