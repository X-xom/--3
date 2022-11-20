// Удалить минимальный среди положительных элементов массива.

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
    double num = a[0];
    int index = 0;
    for (int i = 1; i < size; i++){
        if (a[i] > 0 && a[i] < num){
            num = a[i];
            index = i;
        }
    }
    int index2 = 0;
    double[] b = new double[size-1];    
    for ( int i = 0; i < size-1; i++){
        if (a[i] != a[index]){
            b[i] = a[index2];
            index2 += 1;
        }
        else{
            b[i] = a[i+1];
            index2 += 2;
        }
    }
    Console.WriteLine("[{0}]", string.Join(", ", b));
  }
}
