namespace DataStructures
{
    public static class Expression
    {
        public static bool IsBalancedBracket(string exp)
        {
            Stack<string> stk = new Stack<string>();
            foreach (var chr in exp) {
                var bracket = chr.ToString();
                if (IsOpeningBracket(bracket)) {
                    stk.Push(bracket);
                }
                else if (IsClosingBracket(bracket)) {
                    if (!stk.Any()) {
                        return false;
                    }
                    var lastBracket = stk.Pop();
                    if (bracket != MatchingBracket(lastBracket)) {
                        return false;
                    }
                }
            }

            return !stk.Any();
        }

        private static bool IsOpeningBracket(string bracket)
        {
            return bracket switch {
                "(" => true,
                "[" => true,
                "{" => true,
                _ => false
            };
        }

        private static bool IsClosingBracket(string bracket)
        {
            return bracket switch {
                ")" => true,
                "]" => true,
                "}" => true,
                _ => false
            };
        }

        private static string MatchingBracket(string bracket)
        {
            return bracket switch {
                "(" => ")",
                "[" => "]",
                "{" => "}",
                _ => ""
            };
        }
    }
}
