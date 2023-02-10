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
    }
}
