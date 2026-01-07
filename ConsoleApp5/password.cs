class password
{
    public static void Run()
    {

        int correctPassword = 1234;
        int password;

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