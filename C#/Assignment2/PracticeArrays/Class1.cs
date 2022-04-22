using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeArrays
{
    internal class Class1
    {
        public void CopyAnArray(int[] array)
        {
            int[] newArr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
                Console.WriteLine($"The {i}th element of array is {array[i]}");
                Console.WriteLine($"The {i}th element of copied array is {newArr[i]}");
                Console.WriteLine();
            }
        }

        public void ManageElements()
        {
            List<string> list = new List<string>();
            Console.Write("Enter command (+ item, - item or -- to clear): ");
            string operation = Console.ReadLine();
            while (operation != null)
            {
                switch (operation)
                {
                    case "+":
                        Console.Write("Please enter the element which you want to add: ");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("The current list is: ");
                        foreach (var item in list)
                        {
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case "-":
                        list.RemoveAt(list.Count - 1);
                        Console.WriteLine($"The current list is: {list}");
                        Console.WriteLine($"The current list is: ");
                        foreach (var item in list)
                        {
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case "--":
                        list.Clear();
                        Console.WriteLine("You have removed all the elements");
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Insert another input to Continue: ");
                operation = Console.ReadLine();
            }
        }

        public bool CheckPrime(int a)
        {
            int n = a / 2;
            for (int i = 2; i <= n; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            if (startNum <= 0 || endNum <= 0 || startNum > endNum) return null;
            List<int> vs = new List<int>();
            for(int i = startNum; i <= endNum; i++)
            {
                if (CheckPrime(i)) vs.Add(i);
                else continue;
            }
            return vs.ToArray();
            Console.WriteLine(vs.ToArray());
            Console.WriteLine();
        }

        public int[] SumAfterRotation(int[] arr, int k)
        {
            int times = k / arr.Length;
            int move = k % arr.Length;
            int sum = 0;
            int[] vs = new int[arr.Length];
            foreach (var item in arr)
            {
                sum = sum + item;
            }
            sum = sum * times;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= move; j++)
                {
                    if (i - j >= 0)
                    {
                        vs[i] = vs[i] + arr[i - j];
                    }
                    else
                    {
                        vs[i] = vs[i] + arr[i - j + arr.Length];
                    }
                }
                vs[i] = sum + vs[i];
            }
            return vs;
            
        }


        public int[] LongestSequence(int[] arr)
        {
            int num = arr[0];
            int maxCount = 1;
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            int[] res = new int[maxCount];
            Array.Fill(res, num);
            return res;
        }

        public void MostFrequentNumber(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int leftmost = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!freq.ContainsKey(arr[i]))
                {
                    freq.Add(arr[i], 1);
                    firstOccurrence.Add(arr[i], i);
                }
                else
                {
                    freq[arr[i]]++;
                }
            }
            int mostFreq = freq.Values.Max();
            int num = -1;
            foreach (var key in freq.Keys)
            {
                if (freq[key] == mostFreq && firstOccurrence[key] < leftmost)
                {
                    leftmost = firstOccurrence[key];
                    num = arr[leftmost];
                }
            }
            Console.WriteLine($"The number {num} is the most frequent (occurs {mostFreq} times)");
        }

        public string ReverseStringOne(string s)
        {
            if (s == null)
            {
                return string.Empty;
            }
            char[] chars = s.ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            string res = new string(chars);
            return res;
        }

        public string ReverseWords(string s)
        {
            if (s == null)
            {
                return string.Empty;
            }
            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ' };
            char[] chars = s.ToCharArray();
            int n = chars.Length;
            bool isWord = true;
            StringBuilder sb = new StringBuilder();
            List<string> wordsList = new List<string>();
            List<string> separatorList = new List<string>();
            foreach (var c in chars)
            {
                if (isWord)
                {
                    if (separators.Contains(c))
                    {
                        wordsList.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;
                    }
                }
                else
                {
                    if (!separators.Contains(c))
                    {
                        separatorList.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;
                    }
                }
                sb.Append(c);
            }
            separatorList.Add(sb.ToString());
            sb.Clear();
            int m = wordsList.Count();
            for (int i = 0; i < m; i++)
            {
                sb.Append(wordsList[m - 1 - i]);
                sb.Append(separatorList[i]);
            }
            return sb.ToString();
        }
        public string[] FindPalindrome(string s)
        {
            if (s == null)
            {
                return null;
            }
            HashSet<string> wordsSet = new HashSet<string>();
            bool isWord = true;
            StringBuilder sb = new StringBuilder();
            char[] chars = s.ToCharArray();
            foreach (var c in chars)
            {
                if (isWord)
                {
                    if (!char.IsLetter(c))
                    {
                        wordsSet.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if (char.IsLetter(c))
                    {
                        sb.Append(c);
                        isWord = !isWord;
                    }
                }
            }
            foreach (var word in wordsSet)
            {
                if (!IsPalindrome(word))
                {
                    wordsSet.Remove(word);
                }
            }
            return wordsSet.ToArray();
        }
        public bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }

        public void ParseUrl(string url)
        {
            char[] seperator = new char[] { ':', '/', '/' };
            int i = url.IndexOfAny(seperator);
            string protocal, secondHalf;
            if (i != -1)
            {
                protocal = url.Substring(0, i);
                secondHalf = url.Substring(i + 3);
            }
            else
            {
                protocal = " ";
                secondHalf = url;
            }
            string[] temp = secondHalf.Split('/');
            string server = temp[0];
            string resource;
            if (temp.Length > 1)
            {
                resource = temp[1];
            }
            else
            {
                resource = " ";
            }
            Console.WriteLine($"[protocal] = {protocal}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
        }


    }
}
