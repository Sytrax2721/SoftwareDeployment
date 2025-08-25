namespace HelpersLib
{
    public static class FormatService
    {
        public static string FormatResult(string op, decimal a, decimal b, decimal result) =>
            $"{a} {op} {b} = {result}";
    }
}
