using ExcelDna.Integration;
using System.Text.RegularExpressions;

namespace xllPane_2
{
    public abstract class UsFuncEx
    {
        [ExcelFunction(Description = "Анализ текста регулярными выражениями", Category = "Общие функции", Name = "РЕГУЛТЕКСТ")]
        public static string RegExF([ExcelArgument(Description = "Источник текста", Name = "Текст")] string source,
                                    [ExcelArgument(Description = "Регулярное выражение", Name = "Паттерн")] string pattern,
                                    [ExcelArgument(Description = "Номер вхождения", Name = "Вхождение")] int count = 0)
        {
            if (string.IsNullOrEmpty(source))
            {
                return $"{nameof(source)} не может быть неопределенным или пустым.";
            }

            if (string.IsNullOrEmpty(pattern) && string.IsNullOrWhiteSpace(pattern))
            {
                return $"{nameof(pattern)} не может быть неопределенным или пустым."; ;
            }

            if (count < 0)
            {
                return $"{nameof(count)} не может быть меньше нуля.";
            }

            Regex reg = new Regex(pattern);
            if (!reg.IsMatch(source))
            {
                return "Значений не найдено!";
            };
            MatchCollection matches = reg.Matches(source);
            return matches[count].Value;
        }

        [ExcelFunction(Description = "Разделение строки", Category = "Общие функции", Name = "РАЗДЕЛТЕКСТ")]
        public static string SplitTex([ExcelArgument(Description = "Источник текста", Name = "Текст")] string source,
                                      [ExcelArgument(Description = "Разделитель строки", Name = "Разделитель")] string separator,
                                      [ExcelArgument(Description = "Номер вхождения", Name = "Вхождение")] int count = 0)
        {
            if (string.IsNullOrEmpty(source))
            {
                return $"{nameof(source)} не может быть неопределенным или пустым.";
            }

            if (string.IsNullOrEmpty(source))
            {
                return $"{nameof(separator)} не может быть неопределенным или пустым.";
            }

            if (count < 0)
            {
                return $"{nameof(count)} не может быть меньше нуля.";
            }

            string[] result = source.Split(separator.ToCharArray());
            if (result.Length < count + 1)
            {
                return source;
            }
            return result[count];
        }
    }
}