using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace xllPane_2
{
    public static class ArrMearge : object
    {
        public static TResult To<T, TResult>(this T source)
            => (source != null) ? (TResult)Convert.ChangeType(source, typeof(TResult)) : default;

        public static T[] ToParse<T>(T[,] source)
            => source.Cast<T>().ToArray();

        public static T[] ToParse<T>(T[,] source, int take)
            => source.Cast<T>().Take(take).ToArray();

        public static TResult[] ToParse<T, TResult>(T[,] source)
            => Array.ConvertAll(source.Cast<T>().ToArray(),
                               a => To<T, TResult>(a));

        public static TResult[] ToParse<T, TResult>(T[,] source, int take)
            => Array.ConvertAll(source.Cast<T>().Take(take).ToArray(),
                                a => To<T, TResult>(a));

        public static TResult[] ToParse<T, TResult>(this T[] source)
            => source.AsParallel().Select(a => To<T, TResult>(a)).ToArray();

        public static TResult[,] ToParse<T, TResult>(T[,] source, Func<T, TResult> func)
        {
            TResult[,] result = new TResult[source.GetLength(0), source.GetLength(1)];
            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                {
                    result[i - 1, j - 1] = func(source[i, j]);
                }
            }
            return result;
        }

        public static bool IsNumber<T>(this T source)
            => double.TryParse(To<T, string>(source),
                               NumberStyles.Any,
                               CultureInfo.InvariantCulture,
                               out _);

        public static bool IsDate<T>(this T source)
            => DateTime.TryParse(To<T, string>(source), out _);

        public static double ParseToDouble<T>(this T source)
        {
            if (!double.TryParse(source.To<T, string>().Trim(),
                                 NumberStyles.Any,
                                 CultureInfo.GetCultureInfo("ru-RU"),
                                 out double result))
            {
                if (!double.TryParse(source.To<T, string>().Trim(),
                                     NumberStyles.Any,
                                     CultureInfo.GetCultureInfo("en-US"),
                                     out result))
                {
                    return double.NaN;
                };
            };
            return result;
        }

        public static ParallelQuery<string> UniqVal<T>(T[,] source)
            => ToParse<T, string>(source)
                                  .OrderBy(a => a)
                                  .Distinct()
                                  .AsParallel();

        public static ParallelQuery<KeyValuePair<string, double>> AgrVal<T>(T[,] source, int bound = 0)
        {
            IDictionary<string, double> result = new Dictionary<string, double>();

            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                if (source[i, bound] != null & source[i, bound + 1].IsNumber())
                {
                    if (!result.ContainsKey(source[i, bound].To<T, string>()))
                    {
                        result.Add(source[i, bound].To<T, string>(), source[i, bound + 1].ParseToDouble());
                    }
                    else
                    {
                        result[source[i, bound].To<T, string>()] += source[i, bound + 1].ParseToDouble();
                    }
                }
                else
                {
                    continue;
                }
            }

            return from KeyValuePair<string, double> value in result.AsParallel()
                   orderby value.Value descending, value.Key ascending
                   select value;
        }
    }
}