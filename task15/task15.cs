Console.WriteLine("введи число, обозначающее день недели");
int day=int.Parse(Console.ReadLine()??""); 
if (day==6 || day==7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}