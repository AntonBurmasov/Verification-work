
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

 for(int i = 0; i < n; i++)
 {
  Console.Write($"{array[i]}, ");

 }

  return array;
}


void GetNewArray(string[] arr)
{
int count = 0;
for(int i = 0; i < arr.Length; i++)
{
  if(arr[i].Length < 4 )
  {
    count++;


  }
}
string[] NewArray = new string[count];
int CountNew = 0;
for(int i = 0; i < arr.Length; i++)
{
 if(arr[i].Length < 4 )
 {
   NewArray[CountNew] = arr[i];
   CountNew++;
 }

}

Console.WriteLine();
 for(int i = 0; i < NewArray.Length; i++)
 {
  Console.Write($"{NewArray[i]}, ");

 }


}











int n = ReadNumber("Введите количество элементов в массиве");
string[] arr = GetArray(n);
GetNewArray(arr);


