// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

if (args.Length == 0)
{
    Console.WriteLine("No arguments were provided");
}

for (int i = 0; i < args.Length; i++)
{
    string str = args[i];
    if (string.IsNullOrWhiteSpace(str))
    {
        Console.WriteLine("<empty string>");
        return;
    }

    HashSet<char> set = new HashSet<char>();
    int longest = 0;
    int left = 0;

    for (int right = 0; right < str.Length; right++)
    {
        while (set.Contains(str[right]))
        {
            set.Remove(str[left]);
            left++;
        }

        set.Add(str[right]);
        longest = Math.Max(longest, right - left + 1);
    }

    Console.WriteLine($"{str}: {longest}");
}


