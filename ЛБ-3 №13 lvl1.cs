// Дан массив размера 10. Сформировать два массива размера 5, включая в первый
// массив элементы исходного массива с четными индексами, во второй – с нечетными.

using System;
class HelloWorld {
  static void Main() {
    double[] a = new double[10];
    double[] m1 = new double[5];
    double[] m2 = new double[5];
    string s;
    int k1 = 0;
    int k2 = 0;
    for (int i = 0; i<10; i++){
        s = Console.ReadLine();
        a[i] = double.Parse(s);
    }
    for (int i = 0; i<10; i++){
        if (i%2 == 0){
            m1[k1] = a[i];
            k1 = k1 + 1;
        }
        if (i%2 != 0){
            m2[k2] = a[i];
            k2 = k2 + 1;
        }
    }
    Console.WriteLine("Массив с чётными индексами:");
    Console.WriteLine("[{0}]", string.Join(", ", m1));
    Console.WriteLine("Массив с нечётными индексами:");
    Console.WriteLine("[{0}]", string.Join(", ", m2));
  }
}
