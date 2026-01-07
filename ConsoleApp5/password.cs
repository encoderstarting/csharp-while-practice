class password
{
    public static void Run()
    {
        Console.WriteLine("Нужно ввести пароль, ниже вам предоставиться ввеси его");
        int count = 0;
        int password = 0;

        while (password != 1234)
        {
            Console.WriteLine("Введите пароль: ");
            bool number = int.TryParse(Console.ReadLine(), out password);
            if (!number)
            {
                Console.WriteLine("Повторите попытку, введите числа");
                continue;

            }
            else
            {
                count++;
            }


        }
        Console.WriteLine("Пароль верный! ");
        Console.WriteLine("Пароль неверный! Количество попыток: " + count);



    }
}