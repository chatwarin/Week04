using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        /* int a, b, c, d, e, f;
         a = 1;
         b = a + 6;
         c = b - 3;
         d = c * 2;
         e = d / 2;
         f = e % 2;
         Console.WriteLine("a = {0} b = {1} c ={2} d ={3} e ={4} f ={5} ", a, b, c, d, e, f);*/
        int a = 10, b = 20, x = 5, y = 2;
        Console.WriteLine("a = 10, b = 20, x = 5, y = 2 ");
        int ans1 = a + b;
        Console.WriteLine("a + b = {0} ", ans1);
        int ans2 = x - b;
        Console.WriteLine("x - b = {0} ", ans2);
        int ans3 = x * b;
        Console.WriteLine("x * b = {0} ", ans3);
        int ans4 = y / a;
        Console.WriteLine("y / a = {0} ", ans4);
        int ans5 = b % y;
        Console.WriteLine("b % y = {0} ", ans5);
        int ans6 = y + 10 % x;
        Console.WriteLine("y + 10 % x = {0} ", ans6);
        int ans7 = a / 3 * 5;
        Console.WriteLine("a / 3 * 5 = {0} ", ans7);
        int ans8 = 9 / 2 * a;
        Console.WriteLine("9 / 2 * a = {0} ", ans8);
        int ans9 = y % 8;
        Console.WriteLine("y % 8 = {0} ", ans9);
        int ans10 = 100 * x + y % 2 - a;
        Console.WriteLine("100 * x + y % 2 - a = {0} ", ans10);
    }
}

