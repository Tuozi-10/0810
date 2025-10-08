using System.Text;
using System.Diagnostics;

namespace test.Scripts;

// TODO ADD WATCH

public class PerformancesStrings
{
    public void CheckPerfStrings()
    {
        CheckPerfsLotOfStrings();
        CheckPerfsStringBuilder();
    }

    private void CheckPerfsLotOfStrings()
    {
        var sw = new Stopwatch();
        sw.Start();
        string myString = "";

        for (int i = 0; i < 10000; i++)
        {
            myString += i.ToString();
        }
        
        sw.Stop();
        Console.WriteLine("Check perf lot of strings = {0}",sw.Elapsed);
    }
    
    private void CheckPerfsStringBuilder()
    {
        var sw = new Stopwatch();
        sw.Start();
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < 10000; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
        
        sw.Stop();
        Console.WriteLine("Check perf string builder  = {0}",sw.Elapsed);
    }

    private void CheckPerfsPrimeNumbersList()
    {
        // TODO ADD ALL PRIME NUMBERS IN A LIST, FROM 1 TO 153248
    }
    
}