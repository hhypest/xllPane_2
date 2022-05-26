using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace xllPane_2
{
    public class TextPaste : object, ITextCast
    {
        public string CastPasteText(byte state, string source, string paste)
        {
            switch (state)
            {
                case 0: return $"{paste}{source}";

                case 1: return $"{source}{paste}";

                case 2: return $"{paste}{source}{paste}";
            }

            return source;
        }

        public string CastProp(byte state, string source)
        {
            switch (state)
            {
                case 0: return source.ToUpperInvariant();

                case 1: return source.ToLowerInvariant();

                case 2: return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(source.ToLowerInvariant());
            }

            return source;
        }

        public string[,] GetPasteText(string[,] source, Func<byte, string, string, string> cast, string paste, byte state = 0)
        {
            string[,] result = new string[source.GetLength(0), source.GetLength(1)];

            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                {
                    result[i, j] = cast(state, source[i, j], paste);
                }
            }
            return result;
        }

        public string[,] GetPasteText(string[,] source, Func<byte, string, string> cast, byte state = 0)
        {
            string[,] result = new string[source.GetLength(0), source.GetLength(1)];

            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                {
                    result[i, j] = cast(state, source[i, j]);
                }
            }
            return result;
        }

        public string[,] ToReplace(string[,] source, string pattern, string replacer)
        {
            Regex reg = new Regex(pattern);

            string[,] result = new string[source.GetLength(0), source.GetLength(1)];

            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                {
                    result[i, j] = reg.Replace(source[i, j], replacer);
                }
            }
            return result;
        }

        public string[,] ToTrim(string[,] source)
        {
            Regex reg = new Regex(@"[\s]+", RegexOptions.Compiled);

            string[,] result = new string[source.GetLength(0), source.GetLength(1)];

            for (int i = source.GetLowerBound(0); i <= source.GetUpperBound(0); i++)
            {
                for (int j = source.GetLowerBound(1); j <= source.GetUpperBound(1); j++)
                {
                    result[i, j] = reg.Replace(source[i, j], " ").Trim();
                }
            }
            return result;
        }
    }
}