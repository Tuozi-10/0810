namespace test.Scripts;

using System.Diagnostics;

public class PerformancesSort
{
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
        CheckLinqSort();
        CheckCustomArraySort();
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
        var list2 = new List<int>(list);
        var list3 = new List<int>(list);
        
        list2.Sort();
        
        //sort list3

        bool swapped;
        do {
            swapped = false;
            for (int i = 1; i < list3.Count; i++) {
                if (list3[i - 1] > list3[i]) {
                    int temp = list3[i - 1];
                    list3[i - 1] = list3[i];
                    list3[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);

        //verif du customsort
        
        sw.Stop();
        Console.WriteLine("Sort Custom Elapsed={0}",sw.Elapsed);
    }
    
    private void CheckLinqSort()
    {
        var sw = new Stopwatch();
        sw.Start();

        var list = GenerateRandomList(10000);

        list.OrderBy(i => i );
        
        // todo sort
        
        sw.Stop();
        Console.WriteLine("Sort Linq={0}",sw.Elapsed);
    }
    
    // TODO CHECK WITH ARRAYS ALL THE SAME METHODS 
    private void CheckCustomArraySort()
    {
        var sw = new Stopwatch();
        sw.Start();

        int[] test = new int[10000];
        Random randNum = new Random();
        for (int i = 0; i < test.Length; i++)
        {
            test[i] = randNum.Next();
        }

        // todo sort
        
        //sort list3

        bool swapped;
        do {
            swapped = false;
            for (int i = 1; i < test.Length; i++) {
                if (test[i - 1] > test[i]) {
                    int temp = test[i - 1];
                    test[i - 1] = test[i];
                    test[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);

        //verif du customsort
        
        sw.Stop();
        Console.WriteLine("Sort Custom Array Elapsed={0}",sw.Elapsed);
    }
    
}