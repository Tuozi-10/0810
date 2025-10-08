using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Profiling;

public class PrefsManager : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DoChecks());
    }

    private IEnumerator DoChecks()
    {
        yield return new WaitForSeconds(2f);
        /*CheckTruc();
        CheckTruc2();
        CheckTruc3();
        CheckTruc4();*/
        CheckTruc5();
        CheckTruc6();
        CheckTruc7();
    }

    private void CheckTruc()
    {
        Profiler.BeginSample("test 1");
        string t = "";
        for (int i = 0; i < 10000; i++)
        {
            t += i.ToString();
        }

        Profiler.EndSample();
    }

    private void CheckTruc2()
    {
        Profiler.BeginSample("test 2");
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < 100000; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
        Profiler.EndSample();
    }

    private void CheckTruc3()
    {
        Profiler.BeginSample("test 3");
        string t = "";
        for (int i = 0; i < 1; i++)
        {
            t += i.ToString();
        }

        Profiler.EndSample();
    }

    private void CheckTruc4()
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
        var randomList = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int value = Random.Range(0, int.MaxValue);
            randomList.Add(value);
        }

        return randomList;
    }

    private void CheckTruc5()
    {
        Profiler.BeginSample("test 5");
        var list = GenerateRandomList(100000);
        list.Sort();
        Profiler.EndSample();
    }

    private void CheckTruc6()
    {
        Profiler.BeginSample("test 6");

        var list = GenerateRandomList(100000);
        var list2 = list.OrderBy(x => x);

        Profiler.EndSample();
    }

    private void CheckTruc7()
    {
        Profiler.BeginSample("test 7");
        var list = GenerateRandomList(100000);

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
            Profiler.EndSample();
        }
    }
}
