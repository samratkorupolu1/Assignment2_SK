using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_SK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes, the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 2;
            if (HappyNumber(n8) == true)
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                int x = 0; //this var holds the index
                int[] xyz = new int[nums.Length]; // initialized output array 'xyz' with the length of input array

                for (int i = 0; i < n; i++) //looping through the array
                {
                    xyz[x] = nums[i];           // first run,  x = 0, i =0, first element of xyz is nums[0] 
                    x++;                        // x =1   
                    xyz[x] = nums[(i + (n))];   // x =1, second element of xyz is nums[0+n]  i.e n =3 in this case 
                    x++;                        // x =2, i =
                }
                Console.WriteLine("[{0}]", string.Join(", ", xyz));

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int x = 0;
                int[] xyz = new int[ar2.Length]; // initialized output array 'xyz' with the length of input array
                for (int i = 0; i < ar2.Length; i++) //iterating through the array 'xyz'
                {
                    if (ar2[i] != 0) // checking if the element is non-zero
                    {
                        xyz[x] = ar2[i]; // assigning non-zero values to output array 'xyz'
                        x++;
                    }
                }
                Console.WriteLine("[{0}]", string.Join(", ", xyz)); //assigning 0 as default int

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                int xyz = 0; //this var gonna hold the count
                for (int i = 0; i < nums.Length; i++) //iterating over the array
                    for (int j = i + 1; j < nums.Length; j++) // O(n)2
                    {
                        if (nums[i] == nums[j])
                            xyz++;
                    }
                Console.WriteLine(xyz);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                int xyz = 0;   // initialized the xyz as 0 (this is the sum holding var)
                for (int i = 0; i < nums.Length; i++) //iterating 
                    for (int j = i + 1; j < nums.Length; j++) // O(n)2
                    {
                        xyz = nums[i] + nums[j];
                        if (xyz == target)  // when our condition satisfied, just print it out
                            Console.WriteLine("[{0}]", string.Join(", ", i, j));
                    }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                // storing the index values in char array 'xyz' and the corresponding characters in the string s
                {
                    char[] xyz = new char[indices.Length];
                    int len = indices.Length;

                    for (int i = 0; i < len; i++) //iterating over array xyz
                    {
                        xyz[indices[i]] = s[i]; //assigning, pretty basic
                    }
                    Console.WriteLine(xyz);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                if (s1.Length != s2.Length) // length mismatch = non isomorphic strings
                {
                    return false;           // false = non isomorphic 
                }
                Dictionary<char, char> dict = new Dictionary<char, char>(); // dict comparing matching characters in input strings

                for (int e = 0; e < s1.Length; e++) // looping through both strings to compare the match
                {                    
                    char c1 = s1[e]; // Copying characters from s1 to temp var c1
                    char c2 = s2[e]; // Copying characters from s2 to temp var c2
                    // If dict got the key, we compare to corresponding value char at same index from 2nd string
                    if (dict.ContainsKey(c1))
                    {
                        // dict value from 1st string doesn't match with 2nd string's character, then retrun false 
                        if (dict[c1] != c2)
                        {
                            return false;
                        }
                    }
                    // dict has no 1st string char at that position, add it to the dict
                    else
                    {
                        dict.Add(c1, c2);
                    }
                }
                // hash set to store all the dict values/freq of key's in it 
                HashSet<char> set = new HashSet<char>(dict.Values);
                // total values count in hash set = the dictionary values, then isomorphic, return true
                if (set.Count == dict.Values.Count)
                {
                    return true;  // true = isomorphic
                }
                // In all other cases we return false
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                int[] key = new int[items.GetLength(0)]; // new array for saving student id's

                int[] val1 = new int[items.GetLength(0)]; // two arrays to save corresponding students values
                int[] val2 = new int[items.GetLength(0)];
                 
                int sum1 = 0; // sum1 and sum2 to calculate the top 5 scores and average it
                int sum2 = 0;
               
                int count1 = 0;// count1 and count2 to limit scores for each student to 5
                int count2 = 0;

                int counter = 0; // counter to ensure equal num of positive and negative values

                for (int f = 0; f < items.GetLength(0); f++) //looping 
                {
                    key[f] = items[f, 0]; // assigning student id's to array 'key'
                }

                int[] unique = key.Distinct<int>().ToArray(); // unique keys saved in the 'unique' array 

                int keyValue1 = unique[0];
                int keyValue2 = unique[1];
                
                for (int g = 0; g < items.GetLength(0); g++) //looping through
                {
                    if (items[g, 0] == keyValue1)// If studentid matches with unique values, add the respective score values
                    {
                        val1[count1] = items[g, 1];
                        count1++;
                    }
                    else if (items[g, 0] == keyValue2)
                    {
                        val2[count2] = items[g, 1];
                        count2++;
                    }
                }
                
                Array.Sort(val1); // sort the array val1
                Array.Reverse(val1); //descend the array val1
                Array.Sort(val2); // sort the array val2
                Array.Reverse(val2); //descend the array val2

                for (int h = 0; h < items.GetLength(0); h++)

                {
                    if (val1[h] >= 0 && val1[h] <= 100 && val2[h] >= 0 && val2[h] <= 100 && counter < 5)
                    {
                        sum1 += val1[h];
                        sum2 += val2[h];
                        counter++;
                    }
                }
                Console.WriteLine("[[" + unique[0] + "," + (sum1 / 5) + "],[" + unique[1] + "," + (sum2 / 5) + "]]");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                List<int> list = new List<int>(); // list to store the numbers with the sum of squared 1
                while (n > 0) //loop till n is positive
                {
                    int sum = 0;                  // sum = sum of squares of digits
                    string num = n.ToString();    // string convertion

                    for (int i = 0; i < num.Length; i++) // loop through the string, cut off number at each index
                    {
                        int temp = int.Parse(new string(num[i], 1)); //convert to int
                        sum += (temp * temp); //square it and add it to sum
                    }
                    n = sum;

                    if (sum == 1) // sum of squares = 1, return true = 'happy number'
                    {
                        return true;
                    }
                    
                    foreach (int val in list) //if already there in list,return false = 'not a happy number'
                    {
                        if (val == n)
                        {
                            return false;
                        }
                    }

                    list.Add(n); // if not, add number to list, continue to loop until the sum = 1
                }
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                int min = 100;
                int max = 0;
                int pos = 0;    // stores position of min/max variable
                int profit = 0; // profit = max - min
                // loop through array to fin the min, max, pos values
                for (int j = 0; j < prices.Length; j++)
                {
                    if (prices[j] >= 0)
                    {
                        if (prices[j] < min)
                        {
                            min = prices[j];
                            pos = j;
                        }
                        if (prices[j] > max && j > pos) // max always > pos, bcuz we can sell only after a buy
                        {
                            max = prices[j];
                        }
                    }
                }
                profit = max - min;
                if (profit > 0)      // profit > 0, return profit
                {
                    return profit;
                }
                return 0;                 // Else return 0
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                // Create an array result with the length of 'steps + 1' when the number of steps is given to the function as input
                int[] result = new int[steps + 1];
                // The possibilities of climbing no steps is in 1 way and 1 step is 1 way and 2 steps is in 2 ways. So we store them in the first three index places of the array
                result[0] = 1;
                result[1] = 1;
                result[2] = 2;
                // Traverse through the loop until the number of steps given as input to the function
                for (int k = 3; k <= steps; k++)
                {
                    // Initialize the value of the array with 0
                    result[k] = 0;
                    // Create another loop to make sure that the only number of steps are just 1 or 2
                    for (int l = 1; l <= 2 && (k - l) >= 0; l++)
                    {
                        // add number of ways by calculating the corresponding 'k-l' value to current position/ current step value
                        result[k] += result[k - l];
                    }
                }
                Console.WriteLine(result[steps]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}