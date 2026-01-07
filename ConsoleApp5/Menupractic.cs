class Menupractic
{
    public static void Run()
    {
        Console.WriteLine("Выберите цифру: ");
        while (true)
        {
            Console.WriteLine("1 - сказать люблю Машу");
            Console.WriteLine("2 - Показать время");
            Console.WriteLine("0 - Выход");
            Console.WriteLine("Выберите пункт: ");
            if (!int.TryParse(Console.ReadLine(), out int choise))
            {
                Console.WriteLine("Введите число!");
                continue;
            }
            if (choise == 1)
            {
                Console.WriteLine("ЛЮБЛЮ МАШУ");
            }
            else if (choise == 2)
            {

                Console.WriteLine("Текущее время: " + DateTime.Now);
            }
            else if(choise == 0) 
            {
                break;
               
            }
            else
            {
                Console.WriteLine("Такого нет в меню!");
                continue;
                
            }






        }
        
    }
}