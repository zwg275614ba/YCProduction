using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace YCProduction.Common.Extend
{
    public static partial class ExtLinq
    {
        public static Expression<Func<T, bool>> ExpressionTrue<T>() where T : class
        {
            return hh => true;
        }
        public static Expression<Func<T, bool>> ExpressionFalse<T>() where T : class
        {
            return hh => false;
        }

        /// <summary>
        /// Expression And
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <param name="expression1"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expression, Expression<Func<T, bool>> expression1) where T : class
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "x");
            NewExpressionVisitor newExpressionVisitor = new NewExpressionVisitor(parameterExpression);
            Expression left = newExpressionVisitor.ProviderVisitor(expression.Body);
            Expression right = newExpressionVisitor.ProviderVisitor(expression1.Body);
            BinaryExpression binaryExpression = Expression.And(left, right);
            return Expression.Lambda<Func<T, bool>>(binaryExpression, parameterExpression);
        }

        /// <summary>
        /// Expression Or
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <param name="expression1"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expression, Expression<Func<T, bool>> expression1) where T : class
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "x");
            NewExpressionVisitor newExpressionVisitor = new NewExpressionVisitor(parameterExpression);
            Expression left = newExpressionVisitor.ProviderVisitor(expression.Body);
            Expression right = newExpressionVisitor.ProviderVisitor(expression1.Body);
            BinaryExpression binaryExpression = Expression.Or(left, right);
            return Expression.Lambda<Func<T, bool>>(binaryExpression, parameterExpression);
        }
    }
}
