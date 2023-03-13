//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
Console.Clear();
Console.WriteLine("Задача 60");

void init3DArray(int[,,] a) {
  int length = a.Length;
  int rank = a.Rank;
  int rowSize = a.GetUpperBound(0) + 1;
  int colYSize = a.GetUpperBound(1) + 1;
  int colZSize = a.GetUpperBound(1) + 1;
  HashSet<int> elements = new HashSet<int>();
  System.Random random = new System.Random();
  int newElement;
  for (int x = 0; x < rowSize; x++) {
    for (int y = 0; y < colYSize; y++) {
      for (int z = 0; z < colYSize; z++) {
        do {
          newElement = random.Next(0, 100);
        } while(elements.Contains(newElement));
        a[x, y, z] = newElement;
        elements.Add(a[x, y, z]);
      }
    }
  }
}
void print3DArray(int[,,]  a) {
  int rank = a.Rank;
  int rowSize = a.GetUpperBound(0) + 1;
  int colYSize = a.GetUpperBound(1) + 1;
  int colZSize = a.GetUpperBound(1) + 1;
  for (int x = 0; x < rowSize; x++) {
    for (int y = 0; y < colYSize; y++) {
      for (int z = 0; z < colYSize; z++) {
        Console.Write($"{a[x, y, z]}({x},{y},{z}) ");
      }
      Console.WriteLine();
    }
  }
}
int rowSize = 3;
int colYSize = 3;
int colZSize = 3;
int[,,] a = new int[rowSize, colYSize, colZSize];

init3DArray(a);
print3DArray(a);
