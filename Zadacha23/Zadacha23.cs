// задача23. на вход число N. Вывести в строку таблицу кубов чисел от 1 до N.
// Внимание! Задача истолкована так, что вывести требуется кубы всех целых чисел,
// принадлежащих ОТРЕЗКУ от 1 до N. Т.о. для нуля и отрицательных N
// в таблицу включены кубы 1 и 0.
System.Console.WriteLine("Enter N");
int N=int.Parse(Console.ReadLine());
if (N>0)
  {
   int [] Array1toN=new int [N];
   int index=0;
   int CurrentNumber=1;
   while (index<N) 
     {
      Array1toN[index]=CurrentNumber*CurrentNumber*CurrentNumber;
      CurrentNumber++;
      index++;
     }
    var str = string.Join(" , ", Array1toN);
    Console.WriteLine(str);
  }
else 
  {
   int [] Array1toN=new int [Math.Abs(N)+1];
   int index=1;
   int CurrentNumber=-1;
   while (index<Math.Abs(N)+1) 
     {
      Array1toN[index]=CurrentNumber*CurrentNumber*CurrentNumber;
      CurrentNumber=CurrentNumber-1;
      index++;
     }
    var str = string.Join(" , ", Array1toN);
    Console.WriteLine(str);
  }