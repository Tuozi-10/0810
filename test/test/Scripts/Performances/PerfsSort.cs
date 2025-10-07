namespace test.Scripts;

using System.Diagnostics;

public class PerfsSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckLinqSort();
    }

    private void CheckStandardSort()
    {
        Random random = new Random();
        Stopwatch sw = new Stopwatch();
        sw.Start();

        List<int> sortingList = new List<int>();
        
        for (int i = 0; i < 100; i++)
        {
            int value = random.Next();
            sortingList.Add(value);
        }
        
        // TODO SORT
        
        sw.Stop();
        Console.WriteLine("Sort Standard Elapsed={0}",sw.Elapsed);
    }

    private void CheckLinqSort()
    {
        Console.WriteLine($"Sort Linq");
    }
    
}