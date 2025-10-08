namespace test.Scripts;

using System.Diagnostics;

public class PerformancesSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
        CheckCustomArraySort();
        CheckLinqSort();
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

        var list = GenerateRandomList(10000);
        list.Sort();

        
        // TODO SORT
        
        sw.Stop();
        Console.WriteLine("Sort Standard Elapsed={0}",sw.Elapsed);
    }

    
    private void CheckCustomSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);
        int temp;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                i--;
            }
        }


        

        
        // todo sort
        
        sw.Stop();
        Console.WriteLine("Sort custom Elapsed={0}",sw.Elapsed);
    }

    private void CheckCustomArraySort()
    {
        var sw = new Stopwatch();
        sw.Start();
        
        var list = GenerateRandomList(10000);
        var array = list.ToArray();

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i + 1])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                i--;
            }
        }
        
        sw.Stop();
        Console.WriteLine("Sort custom array Elapsed={0}",sw.Elapsed);
        
    }
    
    
    private void CheckLinqSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);

        var sortedList = list.OrderBy(i => i);
        
        // todo sort
        
        sw.Stop();
        Console.WriteLine("Sort Linq Elapsed={0}",sw.Elapsed);
    }
    
    // TODO CHECK WITH ARRAYS ALL THE SAME METHODS 
    
}