// Задан массив х размера 10. Вычислить значения функции у = 0,5lnx при значениях аргумента, заданных в массиве х. Вычисленные значения поместить в массив y.
// Вывести массивы х и y в виде двух столбцов.
using System;
class HelloWorld {
  static void Main() {
    double[] a = new double[10];
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (int i = 0; i < 10; i++){
        a[i] = double.Parse(c[i]);
    }
    
    double[] b = new double[10];
    int k = 0;
    foreach (double x in a){
        b[k] = 0.5*Math.Log(x);
        k += 1;
    }
    for (int i = 0; i < 10; i++){
        Console.Write(a[i] + " " + b[i] + "\r\n");
    }
  }
}
