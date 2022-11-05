// Pointers, Queue only head, Bubble sort
using System;

using BSBO_0910_2021_lab1;
class Program
{
    static void Main(string[] args)
    {
        Queue queue1 = new Queue();
        Random random = new Random();
        int N = 100;
        for (int i = 0; i < N; i++)
        {
            queue1.Push(new Item(random.Next(1, 100)));
        }
        queue1.Print();
        

        for (int i = 0; i < N; i++)
        {
            bool flag = false;
            for (int j = 0; j < N-1-i; j++)
            {
                int a = queue1.Get(j);
                int b = queue1.Get(j+1);
                if (a > b)
                {
                    flag = true;
                    queue1.Set(j, b);
                    queue1.Set(j + 1, a);
                }
            }
            if (!flag) break;
        }

        queue1.Print();
    }
}