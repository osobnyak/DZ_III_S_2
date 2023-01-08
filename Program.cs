// принимаем на вход цифру, обозначающую день недели и проверяем, является ли это день выходным.

Console.WriteLine("Введите число обозначающую день недели: ");
Console.WriteLine("1 - ПН. ");
Console.WriteLine("2 - ВТ. ");
Console.WriteLine("3 - СР. ");
Console.WriteLine("4 - ЧТ. ");
Console.WriteLine("5 - ПТ. ");
Console.WriteLine("6 - СБ. ");
Console.WriteLine("7 - ВС. ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    Console.WriteLine("YES!");
}
else
{
    Console.WriteLine("NO...");
}