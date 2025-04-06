using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1: Missing Numbers in Array");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1,1,4 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:Sort Array by Parity");
            int[] nums2 = { 4,3,2,1};
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:Two Sum");
            int[] nums3 = { 2, 7,11, 15, 4};
            int target = 6;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4: Maximum Product of Three Numbers");
            int[] nums4 = { 9,1, 2, 3, 4 ,8};
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:Decimal to Binary Conversion");
            int decimalNumber = 24;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6: Minimum in Rotated Sorted Array");
            int[] nums5 = { 3, 4, 5,2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:Palindrome Number");
            int palindromeNumber = 1212;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:Fibonacci Number");
            int n = 13;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array

        // Copilot: Generate function to find missing numbers from array where numbers range from 1 to n
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                
                foreach (var num in nums)
                    nums[Math.Abs(num) - 1] = -Math.Abs(nums[Math.Abs(num) - 1]);

                List<int> result = new();
                for (int i = 0; i < nums.Length; i++)
                    if (nums[i] > 0) result.Add(i + 1);

                return result;

            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        // Copilot: Write a function to sort an array by moving even numbers to the front and odd numbers to the back
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                
                    // Initialize a list to store the result
                    List<int> result = new();
                    foreach (int n in nums)
                        if (n % 2 == 0) result.Insert(0, n); else result.Add(n);
                // Convert the list to an array and return it
                return result.ToArray();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        // Copilot: Find two indices in an array whose values sum up to a given target
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                // Dictionary to store number and its index
                Dictionary<int, int> map = new();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];

                    // Check if the complement is already in the map
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }

                    // Add current number and index to the map
                    if (!map.ContainsKey(nums[i]))
                        map[nums[i]] = i;
                }
                  return new int[0];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        // Copilot: Find the maximum product of any three numbers in an array
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                {
                    Array.Sort(nums);
                // Max product can be either from the three largest or two smallest (negatives) and the largest
                    return Math.Max(nums[^1] * nums[^2] * nums[^3], nums[0] * nums[1] * nums[^1]);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        // Copilot: Convert a given decimal number to binary string representation
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                // Convert decimal to binary using base 2
                return Convert.ToString(decimalNumber, 2); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        // Copilot: Find the minimum element in a rotated sorted array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                int left = 0, right = nums.Length - 1;

                // Binary search to find the minimum element in the rotated sorted array
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }

                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        // Copilot: Check if a given integer is a palindrome number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                // Negative numbers are not palindromes
                if (x < 0) return false;

                // Convert the number to string, reverse it, and compare
                 return x.ToString() == new string(x.ToString().Reverse().ToArray());   
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        // Copilot: Write a function to return the nth Fibonacci number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here

                if (n <= 1) 
                    return n; 

                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b; // Next Fibonacci number
                    a = b;            // Shift a to b
                    b = temp;         // Update b to the new value
                }
                return b; // b holds the nth Fibonacci number
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
