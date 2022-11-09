using System;
class HelloWorld {
  static void Main() {
        double[] a = new double[5] {4.0, 3.0, 4.0, -5.0, -7.0};
        double s = 0;
        foreach (double x in a)
        {
            if (x > 0){
                s = s + x*x;
        }
        else
        {
            break;
        }
        }
        Console.WriteLine(s);
  }
}


using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите размер массива");
    int n = int.Parse(Console.ReadLine());
    double[] a = new double[n];
    Console.WriteLine("Введите массив");
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (double i = 0; i < n; i = i + 1)
    {
        a[i] = double.Parse(c[i]);
    }
    for (int i = 0; i < n; i++)
        Console.Write("{0:d} ", a[i]);
  }
}
