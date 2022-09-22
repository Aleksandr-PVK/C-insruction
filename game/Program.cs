Console.WriteLine("Начинаем игру УГАДАЙ ЧИСЛО");
int secret_number = new Random().Next(1,11);
int attempt = 5;
bool Win = false;
while (attempt > 0)
{
    Console.WriteLine("Введиете число от 1 до 10");
    int user_number = int.Parse(Console.ReadLine());
    Console.WriteLine(user_number);
    if(user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if(user_number < secret_number)
    {
        Console.WriteLine("Сектетное число больше");
        attempt--;
    }
    else if(user_number == secret_number)// = присвоить == сравнить
    {
        Console.WriteLine("УГАДАЛ!!!");
        Win = true;
        break;
    }
    Console.WriteLine("Попробуй ещё раз, осталось " + attempt + " попыток");
}
if (Win)
{
    Console.WriteLine("Победа!!! Поиграй ещё!");
    Console.WriteLine("Осталось " + (attempt - 1) + " попыток");
}else
{
    Console.WriteLine("Вы проиграли, секретное число было " + secret_number);
    Console.WriteLine("Попробуй ещё раз.");
}