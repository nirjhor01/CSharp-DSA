using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder();
        int t = 1; 
        for (int _CASE = 0; _CASE < t; _CASE++)
            Solve(sb);
        Console.Write(sb);
    }

    static void Solve(StringBuilder sb)
    {
        int n = ReadInt();
        int[] arr = ReadIntArray();

    }

    // ===== Input helpers =====
    static string Read() => Console.ReadLine();
    static int ReadInt() => int.Parse(Console.ReadLine());
    static long ReadLong() => long.Parse(Console.ReadLine());
    static int[] ReadIntArray() => Console.ReadLine().Split().Select(int.Parse).ToArray();
    static long[] ReadLongArray() => Console.ReadLine().Split().Select(long.Parse).ToArray();

    // ===== Output helpers =====
    static void Print<T>(T value) => Console.WriteLine(value);
    static void PrintArray<T>(T[] arr) => Console.WriteLine(string.Join(" ", arr));
    
    // ===== Debug helpers =====
    static void Debug<T>(string name, T value) => Console.WriteLine($"{name}: {value}");
    static void DebugArray<T>(string name, T[] arr) => Console.WriteLine($"{name}: {string.Join(" ", arr)}");


    // ===== Utilities =====
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
    static long LCM(long a, long b) => a / GCD((int)a, (int)b) * b;

    
}
