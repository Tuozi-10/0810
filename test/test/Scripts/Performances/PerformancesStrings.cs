using System.Diagnostics;
using System.Text;

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
        var sw1 = new Stopwatch();
        sw1.Start();
        
        string myString = "";

        for (int i = 0; i < 100; i++)
        {
            myString += i.ToString();
        }
        
        sw1.Stop();
        Console.WriteLine($"method 1 exe time = {sw1.Elapsed.TotalMilliseconds} seconds");
    }
    
    private void CheckPerfsStringBuilder()
    {
        var sw2 = new Stopwatch();
        sw2.Start();
        
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < 100; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
        
        sw2.Stop();
        Console.WriteLine($"method 2 exe time = {sw2.Elapsed.TotalMilliseconds} seconds");
    }

    private void CheckPerfsPrimeNumbersList()
    {
        // TODO ADD ALL PRIME NUMBERS IN A LIST, FROM 1 TO 153248
    }
    
}