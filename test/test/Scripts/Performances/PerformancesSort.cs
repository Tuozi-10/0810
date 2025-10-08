namespace test.Scripts;

using System.Diagnostics;

public class PerformancesSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
        CheckLinqSort();
        CheckCustomSort();
        CheckCustomSort2();
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
<<<<<<< Updated upstream
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
        
        
        
=======
        
        for (int i = 0; i < list.Count-1; i++)
        {
            int x = list[i];
            int j = i;
            while (j > 0 && list[j - 1] > x)
            {
                list[j] = list[j - 1];
                j = j - 1;
            }

            list[j] = x;
        }
>>>>>>> Stashed changes
        // todo sort
        
        sw.Stop();
        
        Console.WriteLine("Custom sort ={0}",sw.Elapsed);
    }
    
    private void CheckCustomSort2()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);
        var array = list.ToArray();
        for (int i = 0; i < array.Length-1; i++)
        {
            int x = array[i];
            int j = i;
            while (j > 0 && array[j - 1] > x)
            {
                array[j] = array[j - 1];
                j = j - 1;
            }

            array[j] = x;
        }
        // todo sort
        
        sw.Stop();
        
        Console.WriteLine("Custom sort with array ={0}",sw.Elapsed);
    }
    
    private void CheckLinqSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);

        //  list.OrderBy()
        // todo sort
        var sortedList = list.OrderBy(n => n);
        sw.Stop();
        Console.WriteLine("Sort Linq={0}",sw.Elapsed);
    }
    
    // TODO CHECK WITH ARRAYS ALL THE SAME METHODS 
    
}