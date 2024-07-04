using System;
using System.Diagnostics;
using LD;
using LD.Numeric;

public static class Program
{
    public static void Main()
    {
        BigDouble a = new BigDouble(123.331f);
        Console.WriteLine(a.ToString());
       // Console.WriteLine(AlphabetConverter.ConvertToAlphabetUnit(1234));
    }
}