using System;
//Дана строка чисел ,нужно найти сколько в ней подстрок сожержащих комбинацию дающую 0
class Program
{
    public static int raz(int[] str)
    {
        int count = 0;
        int ch = -1;
        int sum = str[0];
        for (int i = 0; i < str.Length; i++)
        {
            if (i == str.Length - 1)
            {
                ch++;
                i = str.Length - (i - ch);
                sum = str[i];
                if (i == str.Length - 2)
                {
                    break;
                }
            }
            int j = i + 1;
            if (sum + str[j] == 0)
            {
                count += ((str.Length - 1) - i);
            }
            if (sum + str[j] != 0)
            {
                sum += str[j];
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] str = new int[n];
        if (n > 1 && n < 200)
        {
            Random random = new Random();
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = random.Next(-1, 2);
                Console.Write(Convert.ToString(str[i]) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(raz(str));
        }
    }
}