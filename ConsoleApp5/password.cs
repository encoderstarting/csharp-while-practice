class password
{
    public static void Run()
    {

        int correctPassword = 1234;
        int password;
        int count = 0;

        while (true)
        {
            Console.WriteLine("Введите пароль: ");
            bool number = int.TryParse(Console.ReadLine(), out password);
            if (!number)
            {
                Console.WriteLine("Повторите попытку, введите числа");
                continue;

            }
            if (password == correctPassword)
            {
                Console.WriteLine("Доступ разрешен!");
                break;
            }
            else if (password != correctPassword) 
            {
                count++;
                Console.WriteLine("Не верный пароль! Повторите попытку. Кол во попыток: " + count);
                continue;
            }
        

           
            

        }
     
    }
}