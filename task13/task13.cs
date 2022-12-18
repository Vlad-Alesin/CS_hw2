Console.WriteLine("введи число");
string number= (Console.ReadLine()??"");
int num=int.Parse(number); 
int del = Convert.ToInt32(Math.Pow(10,number.Length-3));
if (num>999)
{ 
    Console.WriteLine((num/del)%10);
}
else if (num>99)
    {
        Console.WriteLine(num%10); 
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }