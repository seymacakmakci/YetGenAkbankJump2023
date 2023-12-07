using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Extension Methods Example");

            #region Example

            int[] numberArray = { 8, 1, 3, 2, 3, 5, 5, 5 };

            int maxNumberOfArray = numberArray.Max();

            int uniqueMembersCount = numberArray.Distinct().Count();

            int secondNumberOfArray = numberArray.GetSecondNumber();

            string rawName = "Şeyma_Çakmakçı";

            string lastName = rawName.GetLastName();

            Console.WriteLine($"Max Number of Array: {maxNumberOfArray}");
            Console.WriteLine($"Unique Members Count: {uniqueMembersCount}");
            Console.WriteLine($"Second Number of Array: {secondNumberOfArray}");
            Console.WriteLine($"Last Name: {lastName}");

            Console.WriteLine();
            #endregion
        }
    }

    public static class MyExtensions
    {
        public static string GetLastName(this string fullName)
        {
            // Custom logic to extract last name
            string[] nameParts = fullName.Split('_');
            if (nameParts.Length >= 2)
            {
                return nameParts[1];
            }

            throw new ArgumentException("Invalid full name format");
        }

        public static int GetSecondNumber(this int[] arr)
        {
            if (arr.Length >= 2)
            {
                return arr[1];
            }

            throw new ArgumentException("Array must have at least two elements");
        }
    }
}