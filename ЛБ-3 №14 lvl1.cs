using System;
class HelloWorld {
    static void Main() {
    double[] a = new double[11];
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (int i = 0; i < 11; i = i + 1)
    {
        a[i] = double.Parse(c[i]);
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
