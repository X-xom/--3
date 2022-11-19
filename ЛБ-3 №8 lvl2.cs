//Поменять местами максимальный элемент массива и минимальный элемент части массива, расположенной после максимального.

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
    double amin = a[imax];
    for (int i = imax; i < size; i++){
        if (a[i] <= amin){
            amin = a[i];
        }
    }
    Console.WriteLine(amax + " " + amin);
  }
}
