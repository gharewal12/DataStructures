using System.Text;

namespace DataStructures
{
    public static class StringReverser
    {
        public static String Reverse(String input)
        {
            if (input == null) {
                throw new Exception("Input is null.");
            }

            Stack<string> stk = new Stack<string>();

            foreach (var chr in input) {
                stk.Push(chr.ToString());
            }

            var reverseString = new StringBuilder(); ;
            while (stk.Any()) {
                reverseString.Append(stk.Pop());
            }

            return reverseString.ToString();
        }
    }
}
