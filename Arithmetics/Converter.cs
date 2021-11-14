using System;

namespace Arithmetics
{
    internal static class Converter
    {

        private static readonly Tuple<string, string>[] MathFunctions =
        {
            new Tuple<string, string>("abs(", "[Math]::Abs("),
            new Tuple<string, string>("atan2(", "[Math]::Atan2("),
            new Tuple<string, string>("bigmul(", "[Math]::BigMul("),
            new Tuple<string, string>("ceiling(", "[Math]::Ceiling("),
            new Tuple<string, string>("cos(", "[Math]::Cos("),
            new Tuple<string, string>("cosh(", "[Math]::Cosh("),
            new Tuple<string, string>("divrem(", "[Math]::DivRem("),
            new Tuple<string, string>("exp(", "[Math]::Exp("),
            new Tuple<string, string>("floor(", "[Math]::Floor("),
            new Tuple<string, string>("ieeeremainder(", "[Math]::IEEERemainder("),
            new Tuple<string, string>("log(", "[Math]::Log("),
            new Tuple<string, string>("log10(", "[Math]::Log10("),
            new Tuple<string, string>("max(", "[Math]::Max("),
            new Tuple<string, string>("min(", "[Math]::Min("),
            new Tuple<string, string>("pow(", "[Math]::Pow("),
            new Tuple<string, string>("round(", "[Math]::Round("),
            new Tuple<string, string>("sign(", "[Math]::Sign("),
            new Tuple<string, string>("sin(", "[Math]::Sin("),
            new Tuple<string, string>("sinh(", "[Math]::Sinh("),
            new Tuple<string, string>("sqrt(", "[Math]::Sqrt("),
            new Tuple<string, string>("tan(", "[Math]::Tan("),
            new Tuple<string, string>("tanh(", "[Math]::Tanh("),
            new Tuple<string, string>("truncate(", "[Math]::Truncate("),
        };

        public static string Convert(string expression)
        {
            string converted = expression.ToLower().Replace(" ", "");

            foreach (Tuple<string, string> tuple in MathFunctions)
            {
                converted = converted.Replace(tuple.Item1, tuple.Item2);
            }

            // ２重で変換してしまったとき用
            converted = converted.Replace("a[Math]::Cos(", "[Math]::Acos");
            converted = converted.Replace("a[Math]::Sin(", "[Math]::Asin");
            converted = converted.Replace("a[Math]::Tan(", "[Math]::Atan");
            converted = converted.Replace("[math]::[Math]::", "[Math]::");

            return converted;
        }

    }
}