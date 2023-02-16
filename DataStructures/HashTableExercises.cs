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

        public int CountPairsWithDiff(int[] items, int k)
        {
            //O(N^2)
            /* var sItems = items.OrderBy(x => x).ToArray();
             var count = 0;

             for (int i = 0; i < sItems.Length - 1; i++) {
                 for (int j = i + 1; j < sItems.Length; j++) {
                     if (Math.Abs(sItems[i] - sItems[j]) > k) {
                         break;
                     }
                     else if (Math.Abs(sItems[i] - sItems[j]) == k) {
                         count++;
                     }
                 }
             }

             return count;*/

            //O(N)
            var dict = new Dictionary<int, bool>();
            int count = 0;

            foreach (var item in items) {
                dict.Add(item, true);
            }
            foreach (var item in items) {
                if (dict.ContainsKey(item + k) && dict[item + k]) {
                    count++;
                }
                if (dict.ContainsKey(item - k) && dict[item - k]) {
                    count++;
                }
                dict[item] = false;
            }

            return count;
        }

        public int[] TwoSum(int[] items, int target)
        {
            var result = new HashSet<int>();

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < items.Length; i++) {

                dict.Add(items[i], i);
            }

            foreach (var item in items) {
                if (dict.ContainsKey(target - item) && dict[target - item] != -1) {
                    result.Add(dict[item]);
                    result.Add(dict[target - item]);
                    dict[target - item] = -1;
                    break;
                }
                dict[item] = -1;
            }

            return result.ToArray();
        }
    }
}
