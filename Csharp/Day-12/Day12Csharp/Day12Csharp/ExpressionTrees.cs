using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day12Csharp
{
    class ExpressionTrees
    {
        static void Main() 
        { 
            Func<string, string, string> stringJoin = (s1, s2) => String.Concat(s1, s2);
            Expression<Func<string, string, string>> stringJoinExpr = (s1, s2) => String.Concat(s1,s2);
            var result = stringJoinExpr.Compile()("Dinesh", "Kapu");
            Console.WriteLine(result);
            //create an expression tree that takes 2 int and returns the sum of the 2

            //Creating Expression trees using API
            //1.Create Parameter
            ParameterExpression n1 = Expression.Parameter(typeof(int),"n1");
            ParameterExpression n2 = Expression.Parameter(typeof(int), "n2");

            //2.Create Expression Parameters
            ParameterExpression[] parameters =new ParameterExpression[] { n1,n2};

            //3.create expression body
            BinaryExpression exprbody = Expression.Add(n1, n2);

            //4.Create The Expression
            Expression<Func<int, int, int>> expr = Expression.Lambda<Func<int, int, int>>(exprbody, parameters);

            //5.Compile The Expression
            Func<int, int, int> compiledexpr = expr.Compile();

            //6.Execute the Expression
            int res = compiledexpr(10, 20);
            Console.WriteLine("Expression using API resulted in :{0}", res);

            Console.Read();
        }
    }
}
