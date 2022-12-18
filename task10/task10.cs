Console.WriteLine("введи трехзначное число");
int num=int.Parse(Console.ReadLine()??""); 
int b = (num/10)%10;
Console.WriteLine(b);