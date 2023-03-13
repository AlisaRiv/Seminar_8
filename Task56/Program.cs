//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт
//номер строки с наименьшей суммой элементов: 1 
Console.Clear();
Console.WriteLine("Задача 56");

int rowSize = 3;
int colSize = 4;
int[,] a = new int[rowSize, colSize];
int[] sum = new int[rowSize];
System.Random random = new System.Random();
for (int i = 0; i < rowSize; i++) {
  sum[i] = 0;
  for (int j = 0; j < colSize; j++) {
      a[i, j] = random.Next(0, 100);
      sum[i] += a[i, j];
      Console.Write($"{a[i, j]} ");
  }
  Console.WriteLine($"sum: {sum[i]}");
}
int rowIndex = 0;
for (int i=1; i<rowSize; i++) {
  if (sum[rowIndex]>sum[i]) {
    rowIndex = i;
  }
}
Console.WriteLine("Номер строки с наименьшей суммой элементов: {0}", rowIndex+1);
