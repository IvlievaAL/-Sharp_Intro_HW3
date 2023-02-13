// задача21. на вход - декартовы координаты двух точек в объеме (по трем осям то есть).
// Рассчитать расстояние между точками в объеме. 
System.Console.WriteLine("Enter number x1");
int x1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number y1");
int y1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number z1");
int z1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number x2");
int x2=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number y2");
int y2=int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number z2");
int z2=int.Parse(Console.ReadLine());
int Zdiff=Math.Abs((z1-z2));
int Ydiff=Math.Abs((y1-y2));
int Xdiff=Math.Abs((x1-x2));
double distance=Math.Sqrt(Zdiff*Zdiff+Ydiff*Ydiff+Xdiff*Xdiff);
System.Console.WriteLine(distance); //Это та же теорема Пифагора, только к сумме квадратов катетов прибавляется третье слагаемое.