using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
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
                var result = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                    {
                        nums[index] = -nums[index];
                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                        result.Add(i + 1);
                }

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
                int left = 0, right = nums.Length - 1;

                while (left < right)
                {
                    if (nums[left] % 2 > nums[right] % 2)
                    {
                        int temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                    }

                    if (nums[left] % 2 == 0) left++;
                    if (nums[right] % 2 == 1) right--;
                }

                return nums;
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
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }
                    if (!map.ContainsKey(nums[i]))
                    {
                        map[nums[i]] = i;
                    }
                }

                return new int[] { };
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
                Array.Sort(nums);
                int n = nums.Length;

                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3],
                                nums[0] * nums[1] * nums[n - 1]);
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
                if (decimalNumber == 0)
                    return "0";

                string binary = "";
                while (decimalNumber > 0)
                {
                    binary = (decimalNumber % 2) + binary;
                    decimalNumber /= 2;
                }

                return binary;
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
                if (x < 0 || (x % 10 == 0 && x != 0))
                    return false;

                int reversed = 0;
                while (x > reversed)
                {
                    reversed = reversed * 10 + x % 10;
                    x /= 10;
                }

                return x == reversed || x == reversed / 10;
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

                if (n == 0)
                    return 0;
                if (n == 1)
                    return 1;

                int a = 0, b = 1, c = 0;
                for (int i = 2; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                return c;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
