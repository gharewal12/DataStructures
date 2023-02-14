namespace DataStructures
{
    public class HashTableExercises
    {
        public int MostFrequent(int[] items)
        {
            var dict = new Dictionary<int, int>();
            var max = -1;
            var result = 0;

            foreach (var item in items) {
                if (dict.ContainsKey(item)) {
                    dict[item] += 1;
                }
                else {
                    dict.Add(item, 1);
                }

                if (result < dict[item]) {
                    result = dict[item];
                    max = item;
                }
            }

            return max;
        }
    }
}
