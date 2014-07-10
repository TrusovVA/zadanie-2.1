using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace ConsoleApplication5
    {
    class Number
        {
        string n;
        string nums = "0123456789";
        public double cel, drob, num;
        public int countNums;
        
        public Number(string _n)
            {
            n = _n;
            cel = Convert.ToDouble(n.Split(',')[0]);
            drob = Convert.ToDouble(n) - cel;
            countNums = 0;
            for (int i = 0; i < n.Length; i++) 
                if (nums.Contains(n[i])) countNums++;
                num = Convert.ToDouble(n);
            }
public string convertToBin()
    {
    string ret = "";
    int c = Math.Abs(Convert.ToInt32(cel));
    while (c != 0)
        {
            if (c % 2 == 1) ret = "1" + ret;
            else ret = "0" + ret;
            c /= 2;
        }
    if (num < 0) ret = "-" + ret;
    double d = Math.Abs(drob);
    for (int i = 0; i < 15 && d != 0; i++)
    {
        if (i == 0) ret += ",";
        d *= 2;
        if (d >= 1)
            {
                ret += "1";
                d -= 1;
            }
        else ret += "0";
    }
    return ret;
    }
public void movePoint(int c)
    {
        num *= Math.Pow(10, c);
        n = Convert.ToString(num);
        cel = Convert.ToDouble(n.Split(',')[0]);
        drob = Convert.ToDouble(n) - cel;
        countNums = 0;
        for (int i = 0; i < n.Length; i++) 
            if (nums.Contains(n[i])) countNums++;
    }
    }

class Program
    {
    static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Number a = new Number(Console.ReadLine());
            Console.Write("На сколько символов сдвинуть запятую? ");
            a.movePoint(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Получишееся число: {0}", a.num);
            Console.WriteLine("Количество цифр в числе: {0}", a.countNums);
            Console.WriteLine("Целая часть числа: {0}", a.cel);
            Console.WriteLine("Дробная часть числа: {0}", a.drob);
            Console.WriteLine("Число в двоичной системе: {0}", a.convertToBin());
            Console.ReadKey();
        }
    }
}