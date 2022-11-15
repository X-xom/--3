// Найти сумму квадратов элементов, расположенных до первого отрицательного элемента массива размера 11.
using System;
class HelloWorld {
    static void Main() {
    int[] a = new int[11];
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (int i = 0; i < 11; i = i + 1)
    {
        a[i] = int.Parse(c[i]);
    }
    double m = 0;
    foreach (double x in a)
    {
        if (x >= 0){
            m = m + x*x;
    }
        else{
        break;
    }
    }
    Console.WriteLine(m);
    }
  }
