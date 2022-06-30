using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace YCProduction.Common.Extend
{
    public class NewExpressionVisitor : ExpressionVisitor
    {
        public ParameterExpression Parameter { get; private set; }

        public NewExpressionVisitor(ParameterExpression parameterExpression)
        {
            this.Parameter = parameterExpression;
        }
        public virtual Expression ProviderVisitor(Expression expression)
        {
            return this.Visit(expression);
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return this.Parameter;
        }
    }
}
