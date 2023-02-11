namespace DataStructures
{
    public class CharFinder
    {
        public string FindFirstNonRepatingChar(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (var item in str) {
                if (dict.ContainsKey(item)) {
                    dict[item] += 1;
                }
                else {
                    dict.Add(item, 1);
                }

            }

            return dict.Where(x => x.Value == 1).FirstOrDefault().Key.ToString();
        }

        public string FirstRepeatedCharacter(string str)
        {
            var hash = new HashSet<char>();

            foreach (var item in str) {
                if (hash.Contains(item)) {
                    return item.ToString();
                }
                else {
                    hash.Add(item);
                }
            }

            return "No repeated characters found";
        }
    }
}
