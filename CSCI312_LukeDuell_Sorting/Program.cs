using System;

class GivenBubbleSort
{
    public GivenBubbleSort(int[] list)
    {
        bool swapped = false;
        int temp = 0;
        do
        {
            for(int i = 1; i < list.Length; i++)
            {
                if (list[i-1] > list[i])
                {
                    temp = list[i - 1];
                    list[i-1] = list[i];
                    list[i] = temp;
                    swapped = true;
                }
            }
        }
        while(swapped == false);
    }
}

class WritetoConsole
{
    static void Main()
    {
        //Time calculation portion
        DateTime start = DateTime.Now;
        DateTime end;

        double[] timecount_bubble = new double[10];
        double[] timecount_program = new double[10];
        int t = 0;
        int[] listsize = {100, 1000, 10000, 25000, 50000, 100000, 250000, 500000, 750000, 1000000};

        
        for(t = 0; t< listsize.Length; t++)
        {
            start = DateTime.Now;
            //using the sorting method as defined in the assignment document for elements
            int[] list_100 = new int[listsize[t]];
            Random rnd_100 = new Random();
            for (int i = 0; i < list_100.Length; i++)
            {
                list_100[i] = rnd_100.Next(1, listsize[t]);
            }
            for (int i = 0; i < list_100.Length; i++)
            {
                list_100[i] = rnd_100.Next(1, listsize[t]);
            }
            GivenBubbleSort bubblesort = new GivenBubbleSort(list_100);

            end = DateTime.Now;
            TimeSpan ts = end.Subtract(start);
            timecount_bubble[t] = ts.TotalMilliseconds;



            start = DateTime.Now;
            //now using the program sort method for elements
            int[] list_new_100 = new int[listsize[t]];
            for (int j = 0; j < list_new_100.Length; j++)
            {
                list_new_100[j] = rnd_100.Next(1, listsize[t]);
            }

            for (int i = 0; i < list_new_100.Length; i++)
            {
                list_new_100[i] = rnd_100.Next(1, listsize[t]);
            }
            Array.Sort(list_new_100);

            end = DateTime.Now;
            ts = end.Subtract(start);
            timecount_program[t] = ts.TotalMilliseconds;
        }

        Console.WriteLine("Time for bubble sort:\n");
        for (int i = 0;i< timecount_program.Length;i++)
        {
            Console.WriteLine($"{timecount_bubble[i]}\n");
        }

        Console.WriteLine("Time for program sort:\n");
        for (int i = 0; i < timecount_program.Length; i++)
        {
            Console.WriteLine($"{timecount_program[i]}\n");
        }
    }
}