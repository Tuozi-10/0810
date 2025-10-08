namespace test.Scripts;

using System.Diagnostics;

public class PerformancesSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
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

        //EXEMPLE INVERSION, CA SORT PAS TOUT
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > list[i + 1])
            {
                temp = list[i + 1];
                list[i + 1] = list[i];
                list[i] = temp;
            }
        }
        
        
        
        // todo sort
        
        sw.Stop();
        Console.WriteLine($"Sort Linq");
    }
    
    private void CheckLinqSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);

        //  list.OrderBy()
        
        // todo sort
        
        sw.Stop();
        Console.WriteLine($"Sort Linq");
    }
    
    // TODO CHECK WITH ARRAYS ALL THE SAME METHODS 
    
}