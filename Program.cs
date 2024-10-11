using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(@" The function accepts a binary string as input and remove spaces between Binary string and Check if the binary string is 'good' based on these conditions:
 1. Equal number of 0's and 1's.
 2. For every prefix, the number of 1's is not less than the number of 0's");
        Console.WriteLine("Enter Binary String like 110011");
        bool result = IsGoodBinaryString(Console.ReadLine());
        Console.WriteLine(result?"It is a Good Binary String":"It is not a Good Binary String"); 
    }

    static bool IsGoodBinaryString(string binaryString)
    {
        binaryString = binaryString.Replace(" ", "");
        int count0 = 0;
        int count1 = 0;

        foreach (char c in binaryString)
        {
            if (c == '0')
            {
                count0++;
            }
            else if (c == '1')
            {
                count1++;
            }

            // Check the prefix condition
            if (count1 < count0)
            {
                return false;
            }
        }

        // Check if the counts of 0's and 1's are equal
        return count0 == count1;
    }

 
}
