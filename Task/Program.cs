// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



string[] GetArray( int n)
{


string[] array = new string[n];


 for(int i = 0; i < n; i++)
 {
  Console.WriteLine("Введите элемент массива");
  
    array[i] = Console.ReadLine() ?? "";

 }


Console.WriteLine("[{0}]", string.Join(", ", array));

  return array;
}


void GetNewArray(string[] arr)
{
int count = 0;
for(int i = 0; i < arr.Length; i++)
{
  if(arr[i].Length < 4 && 0 < arr[i].Length)
  {
    count++;


  }
}
string[] NewArray = new string[count];
int CountNew = 0;
for(int i = 0; i < arr.Length; i++)
{
 if(arr[i].Length < 4 && 0 < arr[i].Length)
 {
   NewArray[CountNew] = arr[i];
   CountNew++;
 }

}


Console.WriteLine("[{0}]", string.Join(", ", NewArray));

}



int n = ReadNumber("Введите количество элементов в массиве");
if(n > 50)
{
  Console.WriteLine("Слишком много элементов в изначальном массиве.");
  return;
}

string[] arr = GetArray(n);
GetNewArray(arr);


