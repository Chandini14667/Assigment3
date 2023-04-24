using System.Globalization;
using System.Net.Http.Headers;

Console.WriteLine("Enter the number of words: ");
int n = Convert.ToInt16(Console.ReadLine());
string[] s = new string[n];
Console.WriteLine("Enter the words");
for (int i = 0; i < n; i++)
{
    s[i] = Console.ReadLine();
}
 

//a
string shortestWord = s[0];
for(int i = 0; i < n; i++)
{
    if (s[i].Length < shortestWord .Length)
    {
        shortestWord = s[i];
    }
}
Console.WriteLine($"The shortest word is: {shortestWord} ");


//b
Array.Sort(s);
Console.WriteLine( "Enter a word to search: ");
string word = Console.ReadLine();
bool isPresent = s.Contains(word);
if(isPresent)
{
    Console.WriteLine( "The word is present in the list. ");
}
else
{
    Console.WriteLine( "The word is not present in the list. ");
}


//c
Array.Sort(s);
Console.WriteLine("The sorted array is: ");
Console.WriteLine(string.Join(",",s));

//d
int count = 0;
foreach(string i in s)
{
    bool isPalindrome = true;
    for(int j = 0; j < i.Length / 2; j++)
    {
        if (i[j] != i[i.Length - 1])
        {
            isPalindrome = false;
            break;
        }
    }
    if(isPalindrome)
    {
        Console.WriteLine( "{0} is a palindrome!",i);
        count++;
    }
}
Console.WriteLine("The number of palindromes in the list: {0}",count);
Console.WriteLine( );