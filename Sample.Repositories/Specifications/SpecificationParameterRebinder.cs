namespace Sample.Repositories.Specifications
{
    using System.Linq.Expressions;

    internal class SpecificationParameterRebinder : ExpressionVisitor
    {
        private readonly ParameterExpression specificationParameter;

        private SpecificationParameterRebinder(ParameterExpression specificationParameter)
        {
            this.specificationParameter = specificationParameter;
        }

        public static Expression ReplaceParameter(Expression expression, ParameterExpression parameter)
        {
            return new SpecificationParameterRebinder(parameter).Visit(expression);
        }

        protected override Expression VisitParameter(ParameterExpression p)
        {
            return base.VisitParameter(specificationParameter);
        }
    }
}