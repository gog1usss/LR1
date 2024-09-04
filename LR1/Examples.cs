class Examples
{
    static void Main1(string[] args)
    {
        Console.WriteLine("Приклад 1:");
        string s1 = "Dfg + t5 - r7y; asd* s34; rt";
        int t = s1.IndexOf(";");
        int i, k = 0;
        for (i = 0; i <= t; i++)
        {
            if (char.IsLetter(s1[i])) k++;
        }
        Console.WriteLine(k);

        Console.WriteLine();

        Console.WriteLine("Приклад 3:");
        string s2 = "АУАУАПАУК";
        i = 0;
        do
        {
            string ss = s2.Substring(i, 2);
            if (ss == "АУ")
            {
                s2 = s2.Insert(i, "О");
                i = i + 3;
            }
            else
            {
                i++;
            }
        } while (i < s2.Length - 1);
        Console.WriteLine(s2);

        Console.WriteLine();


        Console.WriteLine("Приклад 3:");
        string s3 = "бiологiя алгебра iсторiя географiя геометрiя";
        string c = "i";
        string[] a;
        a = s3.Split(' ');
        for (i = 0; i < a.Length; i++)
        {
            t = a[i].IndexOf(c);
            if (t != -1) Console.WriteLine(a[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Приклад 4:");
        string s4 = "бiологiя алгебра iсторiя географiя геометрiя";
        a = s4.Split(' ');
        Array.Reverse(a);
        string s2_reversed = string.Join(" ", a);
        Console.WriteLine(s2_reversed);

        Console.ReadKey();
    }
}