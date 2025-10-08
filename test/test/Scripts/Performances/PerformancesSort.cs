namespace test.Scripts;

using System.Diagnostics;

public class PerformancesSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
        CheckLinqSort();
        CheckCustomSortArray();
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
    
    private void CheckCustomSortArray()
    {
        var sw = new Stopwatch();
        var sw2 = new Stopwatch();

        var list = GenerateRandomList(1000);
        int[] intArray = new int[list.Count];
        
        for (int i = 0; i < list.Count; i++)
        {
            intArray[i] = list[i];
        }
        
        sw.Start();
        for (int i = 0; i < list.Count-1; i++)
        {
            if (list[i] > list[i + 1])
            {
                (list[i], list[i+1]) = (list[i+1], list[i]);
                i = -1;
            }
        }
        sw.Stop();
        
        sw2.Start();
        for (int i = 0; i < intArray.Length-1; i++)
        {
            if (intArray[i] > intArray[i + 1])
            {
                (intArray[i], intArray[i+1]) = (intArray[i+1], intArray[i]);
                i = -1;
            }
        }
        sw2.Stop();
        
        Console.WriteLine("Sort Custom Elapsed for list = {0}",sw.Elapsed);
        Console.WriteLine("Sort Custom Elapsed for array = {0}",sw2.Elapsed);
    }
    
    private void CheckCustomSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(100);
        var list2 = new List<int>(list);
        
        for (int i = 0; i < list.Count-1; i++)
        {
            if (list[i] > list[i + 1])
            {
                (list[i], list[i+1]) = (list[i+1], list[i]);
                i = -1;
            }
        }
        
        // todo sort
        
        sw.Stop();
        list2.Sort();
        for (int i = 0; i < list2.Count; i++)
        {
            if (list[i] != list2[i])
            {
                Console.WriteLine("Ca marche pas");
                return;
            }
        }
        Console.WriteLine("Sort Custom Elapsed = {0}",sw.Elapsed);
    }
    
    private void CheckLinqSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);
        var list2 = list.OrderBy(x => x);
        // todo sort
        
        sw.Stop();
        Console.WriteLine("Sort Linq Elapsed = {0}",sw.Elapsed);
    }
    
    // TODO CHECK WITH ARRAYS ALL THE SAME METHODS 
    
}