using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace Space4XCoreConcepts
{
    public static class EnumerableExtensions
    {
        public static TResult MaxOrDefault<TSource, TResult>(
            this IEnumerable<TSource> enumerable,
            Func<TSource, TResult> expression,
            TResult defaultValue = default(TResult)
        )
        {
            if (!enumerable.Any())
            {
                return defaultValue;
            }

            return enumerable.Max(expression);
        }

        public static float SumOrDefault<TSource>(
            this IEnumerable<TSource> enumerable,
            Func<TSource, float> expression, 
            float defaultValue = default(float))
        {
            if (!enumerable.Any())
            {
                return defaultValue;
            }

            return enumerable.Sum(expression);
        }
    }
}