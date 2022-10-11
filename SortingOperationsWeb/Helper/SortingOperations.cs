namespace SortingOperationsWeb.Helper
{
    public class SortingOperations
    {
        public static string Sorting(string text)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var item in text)
            {
                if (!dictionary.ContainsKey(item))
                {
                    var totalRepeat = text.Count(x => x == item);
                    dictionary.Add(item, totalRepeat);
                }
            }

            var aux = dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var restulString = "";
            foreach (var item in aux)
            {
                var repeat = new string(item.Key, item.Value);
                restulString += repeat;
            }

            return restulString;
        }
    }
}
