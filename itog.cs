Console.Clear();

string[] array = new string[] { "hello", "2", "world", ":-)" };

int getArray(string[] array) // функция по подсчету элементов, удовлетворяющих условию в заданном массиве.
{
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      count += 1;
    }
  }
  return count;
}

//Console.WriteLine(getArray(array));


void resultArray(int count) // в функци resultArray создается новый массив, который заполняется значениями, удовлетворяющими условия задачи.
{
  string[] newArray = new string[count];
  int j = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      newArray[j] = array[i];
      j += 1;
    }
  }

  var str = string.Join(" ", newArray);
  Console.Write(str);

}

resultArray(getArray(array));