using System;
 
class Program
{
    // int.Max  : 2147483647 : 10^10

    static void Main(string[] args)
    {

        Console.WriteLine($"");
    }

    static string ReadStr() => Console.ReadLine();
    static string[] ReadStrArray() => Console.ReadLine().Split(' ');

    static int ReadInt() => int.Parse(ReadStr());
    static int[] ReadIntArray() => Array.ConvertAll(ReadStrArray(), int.Parse);

    static T Max<T>(T x, params T[] a)
        where T : IComparable
    {
        T ret = x;
        foreach(T i in a)
        {
            ret = 0 < ret.CompareTo(i) ? ret : i;
        }
        return ret;
    }

    static T Min<T>(T x, params T[] a)
        where T : IComparable
    {
        T ret = x;
        foreach(T i in a)
        {
            ret = ret.CompareTo(i) < 0 ? ret : i;
        }
        return ret;
    }

    static void Swap<T>(ref T[] array, int i, int j)
    {
        T t = array[i];
        array[i] = array[j];
        array[j] = t;
    }
}
