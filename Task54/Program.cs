//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
Console.Clear();
Console.WriteLine("Задача 54");
void sortRow(int[,] a, int row) {
  int size = a.GetUpperBound(0) + 1;
  for (int currentIndex = 0; currentIndex < size-1; currentIndex++) {
    for (int nextIndex = currentIndex+1; nextIndex < size; nextIndex++) {
      if (a[row, currentIndex] < a[row, nextIndex]) {
        int value = a[row, currentIndex];
        a[row, currentIndex] = a[row, nextIndex];
        a[row, nextIndex] = value;
      }
    }
    Console.Write($"{a[row, currentIndex]} ");
  }
  Console.WriteLine($"{a[row, size-1]} ");
}
int size = 3;
int[,] a = new int[size, size];
System.Random random = new System.Random();
for (int i = 0; i < size; i++) {
  for (int j = 0; j < size; j++) {
      a[i, j] = random.Next(0, 100);
      Console.Write($"{a[i, j]} ");
  }
  Console.WriteLine();
}
Console.WriteLine("----------");
for (int i = 0; i < size; i++) {
  sortRow(a,i);
}
