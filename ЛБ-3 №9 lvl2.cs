//Найти среднее арифметическое значение элементов массива, расположенных между минимальным и максимальным элементами массива.

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите массив");
    double[] a = new double[size];
    string s = Console.ReadLine();
    string[] c = s.Split(' ');
    for (int i = 0; i < size; i = i + 1)
    {
        a[i] = double.Parse(c[i]);
    }
    double amax = a[0];
    int imax = 0;
    for (int i = 1; i < size; i++){
        if (a[i] >= amax){
            amax = a[i];
            imax = i;
        }
    }
    double amin = Math.Pow(10, 10);
    int imin = 0;
    for (int i = 1; i < size; i++){
        if (a[i] <= amin){
            amin = a[i];
            imin = i;
        }
    }
    double num = 0;
    int amount = 0;
    for ( int i = Array.IndexOf(a, Math.Min(a[imin], a[imax])) + 1; i< Array.IndexOf(a, Math.Max(a[imin],a[imax])); i++){
        num += a[i];
        amount += 1;
    }
    Console.WriteLine(num/amount);
  }
}
