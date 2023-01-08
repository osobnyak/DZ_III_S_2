// задание 13. выводить 3-ю цифру заданного числа или сообщаем, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100)
{
    Console.WriteLine("третьей цифры нет");    
}

else 
{while (n>999)
    n = n - 1000;
    Console.WriteLine(n);   


    int result1 = n / 100;

    Console.Write("3-я цифра: ");
    Console.WriteLine(result1); 
}
