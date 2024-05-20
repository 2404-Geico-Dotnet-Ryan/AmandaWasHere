class Completed
{
    // ***********1. Calculate the average of all elements in an array.****************
    // Basic formula for average is <sum of all elements> / <number of elements>
    // public static double ArrayAverage(double[] arr)
    // {
    //     double sum = 0;
    //     foreach (double num in arr)
    //     {
    //         sum += num;
    //     }
    //     double average = sum / arr.Length;
    //     return average;
    // }


    // // 3. Return true if the given number is a perfect square, otherwise false.
    // // A Perfect Square means that the number is the product of squaring a Whole Number.
    // // Example: 25 is a Perfect Square -> 5 * 5 = 25.
    // public static bool IsPerfectSquare(int num)
    // {
    //     int a = 0;
    //     int b = 0;
    //     if (num < 0)
    //     {
    //         return false;
    //     }
    //     if (num % 2 == 0)
    //         num = a * b;
    //     return true;

    // }


    // ***************7. Return true if the given string is an anagram of another string, otherwise false.
    // An anagram of a string -> contains all the same characters, just in a different order.
    // public static bool IsAnagram(string str1, string str2)
    // {
    //     //Check if number of characters is equal or not
    //     if (str1.Length != str2.Length)
    //     {
    //         return false; //upfront, not an anagram
    //     }
    //     //where there are characters left, we enter loop
    //     while (str1.Length > 0)
    //     {
    //         //inside the loop, this means the string has latters
    //         //therefore, if str2 is empty at this point - not an anagram
    //         char c = str1[0];
    //         int index = 0;
    //         if ((index = str2.IndexOf(c)) != -1)
    //         {
    //             //If it contains, remove from both strings, potential anagram
    //             str1 = str1.Remove(0, 1); //removes 1st character 
    //             str2 = str2.Remove(index, 1);
    //         }
    //         else
    //         {
    //             //mismatch, not anagram
    //             return false;
    //         }
    //     }
    //     return true;
    // }
    //when str1 is empty, loop is done but does str2 have letters still? We can solve this
    //by comparing string length upfront.


    // // **********************14. All Cars are now Black!**************************
    // // Add a constructor below such that all cars are now Black.
    // // (Is already so, but) ensure that you cannot change the color away from Black.
    // public class Car
    // {
    //     public string? Color { get; set; } = "Black";
    // }




}