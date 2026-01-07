Console.WriteLine("Что бы продолжить введите пароль состоящий из 4 чисел: ");
if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Ошибка! Возможно вы ввели не числа!");
}
else
{
    password.Run();
}

