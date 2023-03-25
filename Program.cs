string[] array = new string[] { "hello", "2", "World", ":-)" };

/// <summary>
/// Метод отбора значенией массива с элементами содержаищими менее или равным 3 знака
/// </summary>
/// <param name="arr">на вход - массив из строк</param>
/// <returns>на выходе - массив из элементов с количеством символов менее или равным 3</returns>
string[] GetThreeSumbolArray(string[] arr)
{
  string[] newArray = new string[arr.Length];
  for (int j = 0; j < arr.Length; j++)
  {
    if (arr[j].Length <= 3)
      newArray[j] = arr[j];
  }
  return newArray;
}

void PrintArray(string[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] != null)
      Console.Write(arr[i] + "\t");
  }
  Console.WriteLine();
}

PrintArray(array);
PrintArray(GetThreeSumbolArray(array));