using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Profiling;
using Random = UnityEngine.Random;


public class PerfsManager : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(DoChecks());
        CheckPerfSort();
    }
    public void CheckPerfSort()
    {
        CheckStandardSort();
        CheckCustomSort();
        CheckLinqSort();
        CheckCustomSort();
        CheckCustomSort2();
    }
    private IEnumerator DoChecks()
    {
        yield return new WaitForSeconds(2f);
        CheckTrue();
        CheckTrue2();
        CheckTrue3();
        CheckTrue4();
    }

    private void CheckTrue()
    {
        Profiler.BeginSample("test 1");
        string t = "";
        for (int i = 0; i < 50000; i++)
        {
            t += i.ToString();
        }

        Profiler.EndSample();
    }

    private void CheckTrue2()
    {
        Profiler.BeginSample("test 2");
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < 50000; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
        Profiler.EndSample();
    }
    
    private void CheckTrue3()
    {
        Profiler.BeginSample("test 3");
        string t = "";
        for (int i = 0; i < 1; i++)
        {
            t += i.ToString();
        }

        Profiler.EndSample();
    }

    private void CheckTrue4()
    {
        Profiler.BeginSample("test 4");
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < 1; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
        Profiler.EndSample();
    }
    private List<int> GenerateRandomList(int count)
    {       
        var random = new Random();

        var randomList = new List<int>();
        
        for (int i = 0; i < count; i++)
        {
            int value = UnityEngine.Random.Range(0,int.MaxValue);
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
}
