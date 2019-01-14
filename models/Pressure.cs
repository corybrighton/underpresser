using System;

namespace underpressure
{
  class Pressure
  {
    public Pressure()
    {
      Console.WriteLine(DoubleInteger(12));
      Console.WriteLine(DoubleInteger(4));
      Console.WriteLine(IsNumberEven(12));
      Console.WriteLine(IsNumberEven(11));
      Console.WriteLine(getFileExtension("ceir.12.exe"));
      Console.WriteLine(getFileExtension("ceir12.exe"));
      Console.WriteLine(getFileExtension("ceir12exe"));
      string[] arr = { "coe.12.exe", "et" };
      string[] arr1 = { "coe.12.exe", "et", "longer text long" };
      string[] arr2 = { "coe.12.exe", "et", "Crazy long text to come back", "longer text long" };
      Console.WriteLine(longestString(arr));
      Console.WriteLine(longestString(arr1));
      Console.WriteLine(longestString(arr2));
      int[] intarr = { 1, 3, 6 };
      int[] intarr1 = { 1, 3, 6, 10 };
      Console.WriteLine(arraySum(intarr));
    }

    // num will be an integer. Double it and return it. (ex 12 => 24)
    public int DoubleInteger(int num)
    {
      return num * 2;
    }

    //num will be an integer. Return true if it’s even, and false if it isn’t.
    public bool IsNumberEven(int num)
    {
      return num % 2 == 0;
    }

    public string getFileExtension(string str)
    {
      // str will be a string, but it may not have a file extension.
      // return the file extension (with no period) if it has one, otherwise false
      string[] file = str.Split('.');
      int n = file.Length - 1;
      return (n >= 1) ? file[n] : null;
    }

    public string longestString(string[] arr)
    {
      // arr will be an array. Return the longest string in the array
      string longest = arr[0];
      for (int i = 1; i < arr.Length; i++)
      {
        string str = arr[i];
        longest = (longest.Length < str.Length) ? str : longest;
      }
      return longest;
    }

    public int arraySum(int[] arr)
    {
      int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        sum += arr[i];
      }
      return sum;
    }
  }
}