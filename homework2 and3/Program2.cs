// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
//1
int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] nums2 = new int[nums1.Length];
for (int i = 0; i < nums1.Length; i++)
{
    nums2[i] = nums1[i];
    Console.Write(nums2[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < nums1.Length; i++)
{
    Console.Write(nums1[i] + " ");
}

////2第二题



// 定义一个列表来存储用户的项目
List<string> itemList = new List<string>();

        while (true)
        {
            // 提示用户输入命令
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

            // 读取用户输入
            string input0 = Console.ReadLine();

            // 检查输入是否是清空列表的命令
            if (input0 == "--")
            {
                itemList.Clear();
                Console.WriteLine("List cleared.");
            }
            // 检查是否是添加项目的命令
            else if (input0.StartsWith("+"))
            {
                string itemToAdd = input0.Substring(1).Trim();  // 获取要添加的项目
                if (!string.IsNullOrEmpty(itemToAdd))
                {
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
            }
            // 检查是否是删除项目的命令
            else if (input0.StartsWith("-"))
            {
                string itemToRemove = input0.Substring(1).Trim();  // 获取要删除的项目
                if (itemList.Remove(itemToRemove))
                {
                    Console.WriteLine($"Removed: {itemToRemove}");
                }
                else
                {
                    Console.WriteLine($"Item '{itemToRemove}' not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Please use +, -, or --.");
            }

            // 显示当前列表内容
            Console.WriteLine("Current List:");
            if (itemList.Count > 0)
            {
                foreach (string item in itemList)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            else
            {
                Console.WriteLine("(The list is empty)");
            }
            Console.WriteLine();  // 添加一个空行，便于阅读
        }

//3第三题
static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primeList = new List<int>();  // Use a list to collect the prime numbers

    for (int num = startNum; num <= endNum; num++)
    {
        if (IsPrime(num))
        {
            primeList.Add(num);
        }
    }

    return primeList.ToArray();  // Convert the list to an array and return it
}

// Helper method to check if a number is prime
static bool IsPrime(int number)
{
    if (number < 2) return false;  // Numbers less than 2 are not prime

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) return false;  // If divisible by any number other than 1 and itself, not prime
    }

    return true;  // If no divisors found, it's prime
}


//4
// Reading the array of integers
Console.WriteLine("Enter the integers in the array (space-separated):");
string[] inputArray = Console.ReadLine().Split();
int[] arr = Array.ConvertAll(inputArray, int.Parse);

// Reading the number of rotations
Console.WriteLine("Enter the number of rotations:");
int k = int.Parse(Console.ReadLine());

// Initialize sum array
int[] sum = new int[arr.Length];

// Perform rotations and sum the arrays
for (int r = 1; r <= k; r++)
{
    int[] rotated = RotateRight(arr, r);
    for (int i = 0; i < arr.Length; i++)
    {
        sum[i] += rotated[i];
    }
}

// Output the final sum array
Console.WriteLine("Sum of arrays after rotations:");
Console.WriteLine(string.Join(" ", sum));
    

    // Method to rotate the array to the right r times
    static int[] RotateRight(int[] arr, int r)
{
    int n = arr.Length;
    int[] rotated = new int[n];
    for (int i = 0; i < n; i++)
    {
        rotated[(i + r) % n] = arr[i];
    }
    return rotated;
}



//5
int[] nums = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
int max = 1;
int count = 0;
int number = -1;
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] == nums[i - 1])
    {
        count++;
        if (count > max)
        {
            max = count;
            number = nums[i];
        }
    }
    else
    {
        count = 0;
    }
}
for (int i = 0; i < max + 1; i++)
{
    Console.Write(number + " ");
}


//6
int[] numbers = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };

// Dictionary to store frequency of each number
Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

// Find frequency of each number
foreach (int num in numbers)
{
    if (frequencyMap.ContainsKey(num))
    {
        frequencyMap[num]++;
    }
    else
    {
        frequencyMap[num] = 1;
    }
}

// Find the most frequent number (leftmost if multiple)
int maxFrequency = frequencyMap.Values.Max();
int mostFrequentNumber = numbers.First(num => frequencyMap[num] == maxFrequency);

// Output the result
Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times).");

//
//1
string input = Console.ReadLine();

// Convert the string to a character array
char[] charArray = input.ToCharArray();

// Reverse the character array
Array.Reverse(charArray);
String s = new String(charArray);
Console.WriteLine(s);



//2
string input1 = "C# is not C++, and PHP is not Delphi!";

// Regular expression to split words and separators
string pattern = @"([a-zA-Z0-9\+\#]+)|([.,:;=()&\[\]""'\\\/!? ])";

// Find all matches using Regex
MatchCollection matches = Regex.Matches(input1, pattern);

// Lists to hold words and separators
List<string> words = new List<string>();
List<string> result = new List<string>();

// Populate the word list while keeping track of separators
foreach (Match match in matches)
{
    if (!string.IsNullOrEmpty(match.Groups[1].Value)) // If it's a word
    {
        words.Add(match.Groups[1].Value);
    }
}

// Reverse the words list
words.Reverse();

// Rebuild the sentence with reversed words and original separators
int wordIndex = 0;
foreach (Match match in matches)
{
    if (!string.IsNullOrEmpty(match.Groups[1].Value)) // If it's a word
    {
        result.Add(words[wordIndex]); // Use the reversed word
        wordIndex++;
    }
    else
    {
        result.Add(match.Groups[2].Value); // Keep the original separator
    }
}

// Join the result and print
Console.WriteLine(string.Join("", result));


//3
string input3 = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

// Use regex to extract words
string[] wordss = Regex.Matches(input3, @"\w+")
                      .Cast<Match>()
                      .Select(m => m.Value)
                      .ToArray();

// HashSet to store unique palindromes
HashSet<string> palindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

// Check each word for palindrome
foreach (string word in wordss)
{
    if (IsPalindrome(word))
    {
        palindromes.Add(word);
    }
}

// Sort palindromes and print
var sortedPalindromes = palindromes.OrderBy(p => p, StringComparer.OrdinalIgnoreCase).ToList();
Console.WriteLine(string.Join(", ", sortedPalindromes));
    

    // Helper function to check if a word is a palindrome
    static bool IsPalindrome(string word)
{
    int len = word.Length;
    for (int i = 0; i < len / 2; i++)
    {
        if (char.ToLower(word[i]) != char.ToLower(word[len - i - 1]))
        {
            return false;
        }
    }
    return true;
}


//4
string url = "https://www.apple.com/iphone";
ParseUrl(url);


url = "ftp://example.com/";
ParseUrl(url);
    

    static void ParseUrl(string url)
{
    string protocol = string.Empty;
    string server = string.Empty;
    string resource = string.Empty;

    // Find the index of "://", if exists
    int protocolIndex = url.IndexOf("://");
    if (protocolIndex != -1)
    {
        protocol = url.Substring(0, protocolIndex);
        url = url.Substring(protocolIndex + 3); // Remove the protocol part
    }

    // Find the index of "/", if exists
    int resourceIndex = url.IndexOf('/');
    if (resourceIndex != -1)
    {
        server = url.Substring(0, resourceIndex);
        resource = url.Substring(resourceIndex + 1); // Remove the server part
    }
    else
    {
        server = url; // If no resource, the rest is the server
    }

    // Output the results
    Console.WriteLine($"[protocol] = \"{protocol}\"");
    Console.WriteLine($"[server] = \"{server}\"");
    Console.WriteLine($"[resource] = \"{resource}\"");
    Console.WriteLine();
}