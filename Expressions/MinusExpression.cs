﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    public class MinusExpression : BinaryExpression
    {
        public MinusExpression(Expression left, Expression right) : base(left, right) { }

        protected override string OperatorSymbol
        {
            get
            {
                return "-";
            }
        }

        public override double Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }
    }
}
