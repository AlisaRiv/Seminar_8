//Задача 58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
Console.Clear();
Console.WriteLine("Задача 58");

void initArray(int[,] a) {
  int rank = a.Rank;
  int rowSize = a.GetUpperBound(0) + 1;
  int colSize = a.GetUpperBound(1) + 1;
  System.Random random = new System.Random();
  for (int i = 0; i < rowSize; i++) {
    for (int j = 0; j < colSize; j++) {
      a[i, j] = random.Next(0, 100);
    }
  }
}
void printArray(int[,]  a, int[,]  b = null) {
  bool isOnlyOne = b==null;
  int rank = a.Rank;
  int rowSize = a.GetUpperBound(0) + 1;
  int colSize = a.GetUpperBound(1) + 1;
  for (int i = 0; i < rowSize; i++) {
    for (int j = 0; j < colSize; j++) {
      Console.Write($"{a[i, j]} ");
    }
    if (!isOnlyOne) {
      Console.Write("| ");
      for (int j = 0; j < colSize; j++) {
        Console.Write($"{b[i, j]} ");
      }
    }
    Console.WriteLine();
  }
}

int rowSize = 3;
int colSize = 3;
int[,] a = new int[rowSize, colSize];
int[,] b = new int[rowSize, colSize];
initArray(a);
initArray(b);
printArray(a, b);
int[,] c = new int[rowSize, colSize];
for (int i = 0; i < rowSize; i++) {
  for (int j = 0; j < colSize; j++) {
    c[i, j] = 0;
    for (int n = 0; n < colSize; n++)
    {
      c[i, j] += a[i, n] * b[n, j];
    }
  }
}
printArray(c);

