Console.WriteLine("Начинаем игру УГАДАЙ ЧИСЛО");
int secret_number = new Random().Next(1,11);
while (true)
{
    Console.WriteLine("Введиете число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine());
    Console.WriteLine(user_number);
    if(user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
    }
    else if(user_number < secret_number)
    {
        Console.WriteLine("Сектетное число больше");
    }
    else if(user_number == secret_number)// = присвоить == сравнить
    {
        Console.WriteLine("УГАДАЛ!!!");
    }
}