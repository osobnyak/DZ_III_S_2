// задания 10. Принимаем 3-х значное число и показываем второю цифру этого числа. 

Console.WriteLine("Введите трёх значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result1 = n / 100;
Console.Write("количество сотен: ");
Console.WriteLine(result1);

result1 = result1 * 100;
Console.Write("соти: ");
Console.WriteLine(result1);

result1 = n - result1;
Console.Write("остаток без сотен: ");
Console.WriteLine(result1);

result1 = result1/10;
Console.Write("вторая цифра: ");
Console.WriteLine(result1);
