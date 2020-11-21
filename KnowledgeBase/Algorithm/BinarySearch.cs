using System;
namespace KnowledgeBase.Algorithm
{
    public class BinarySearch : ICode
    {
        private const int NotFound = -1;
        private int[] _arrayToSearch = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int _startIndex = 0;
        private int _endIndex = 0;

        public string GetDecription()
        {
            return "Algorithm - Binary search";
        }

        public void Run()
        {
            var searchinput = GetSearchInput();
            // Sort the array
            Array.Sort(_arrayToSearch);
            var result = BinaraySearch(searchinput, _arrayToSearch);
            Console.WriteLine("Search result");
            Console.WriteLine("value : {0}", result != NotFound ? $"found at index {result}" : "Not foud!");

        }

        private int BinaraySearch(int searchInput, int[] arrayToSearch)
        {
            _endIndex = arrayToSearch.Length - 1;

            while (_startIndex < _endIndex)
            {
                var mid = (int)Math.Floor((_startIndex + _endIndex) / 2.0);

                if (searchInput == arrayToSearch[mid])
                    return mid;
                if (mid > arrayToSearch[mid])
                    _startIndex = mid + 1;
                else if (mid < arrayToSearch[mid])
                    _endIndex = mid - 1;
            }
            return -1;
        }

        private int GetSearchInput()
        {
            Console.WriteLine("Binary search");
            Console.WriteLine("[{0}]", string.Join(", ", _arrayToSearch));
            Console.WriteLine("Enter a number to search from above array");
            int searchInput;
            while (!int.TryParse(Console.ReadLine(), out searchInput))
            {
                Console.WriteLine("you entered an invalid number");
                Console.WriteLine("Please enter a number to search");
            }
            return searchInput;
        }
    }
}