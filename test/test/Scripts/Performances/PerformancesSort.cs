namespace test.Scripts;

using System.Diagnostics;

public class PerformancesSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
        CheckLinqSort();
        CheckCustomeSort();
    }

    private List<int> GenerateRandomList(int count)
    {
        var random = new Random();

        var randomList = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int value = random.Next();
            randomList.Add(value);
        }

        return randomList;
    }

    private void CheckStandardSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(150000);

        // TODO SORT
        list.Sort();



        sw.Stop();
        Console.WriteLine("Sort Standard Elapsed={0}", sw.Elapsed);

    }

    private void CheckCustomSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(150000);


        // todo sort

        /*var length = list.Count;
        for (var i = 1; i <= list.Count; i++)
        {
            for (var j = 0; j <= length - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }*/
        static List<int> quicksort(List<int> list)
        {
            if (list.Count <= 1) return list;
            int pivotPosition = list.Count / 2;
            int pivotValue = list[pivotPosition];
            list.RemoveAt(pivotPosition);
            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            foreach (int item in list)
            {
                if (item < pivotValue)
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }

            List<int> sorted = quicksort(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(quicksort(greater));
            return sorted;
        }

        sw.Stop();
        Console.WriteLine($"Sort Custom={{0}}", sw.Elapsed);
        //list.ForEach(Console.WriteLine);
    }

    private void CheckLinqSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(100);

        //  list.OrderBy()

        // todo sort

        IEnumerable<int> liste = list.OrderBy(x => x);

        sw.Stop();
        Console.WriteLine($"Sort Linq{{0}}", sw.Elapsed);
        
    }

    // TODO CHECK WITH ARRAYS ALL THE SAME METHODS 
    private void CheckCustomeSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(150000);
        var array = list.ToArray();


        // todo sort

        var length = array.Length;
        for (var i = 1; i <= array.Length; i++)
        {
            for (var j = 0; j <= length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
    
}


