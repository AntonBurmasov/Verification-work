
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



string[] GetMatrix( int n)
{


string[] matrix = new string[n];


 for(int i = 0; i < n; i++)
 {
  Console.WriteLine("Введите элемент массива");
  
    matrix[i] = Console.ReadLine();

 }

 for(int i = 0; i < n; i++)
 {
  Console.Write($"{matrix[i]}, ");

 }

  return matrix;
}












int n = ReadNumber("Введите количество элементов в массиве");
string[] matr = GetMatrix(n);


