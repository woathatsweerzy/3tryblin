//int choise;
//do
//{
//    Console.WriteLine("Выберите программу: ");
//    Console.WriteLine("1. Угадай число");
//    Console.WriteLine("2. Таблица умножения");
//    Console.WriteLine("3. Вывод делителей");
//    Console.WriteLine("Или введите 0 для выхода");
//    choise = Convert.ToInt32(Console.ReadLine());
//    if (choise == 1)
//    {
//        GuessNumber();

//    }
//    else if (choise == 2)
//    {
//        multiplication();

//    }
//    else if (choise == 3)
//    {
//        div();

//    }

//} while (choise != 0);


//void GuessNumber()
//{
//    //Игра "Угадай число":
//    //Рандомайзер(прямо внутри кода) выбирает какое-либо число от 0 до 100.
//    //Пользователь должен вводить числа до тех пор, пока введенное им число не будет равно рандомному.
//    //Как только введенное равно рандомному,
//    //говорим пользователю о победе и возвращаем его в меню выбора программы.
//    Random rnd = new Random();
//    int number = rnd.Next(0, 100);
//    Console.WriteLine("Игра \"Угадай число\"! Попбробуйте отгадать число от 0 до 100");
//    int users_number;
//    do
//    {
//        users_number = Convert.ToInt32(Console.ReadLine());
//        if (number < users_number)
//        {
//            Console.WriteLine("Меньше! Попробуй еще: ");
//        }
//        else if (number > users_number)
//        {
//            Console.WriteLine("Больше! Попробуй еще: ");
//        }
//        else if (number == users_number)
//        {
//            Console.WriteLine("Правильно! Красава!");
//        }
//    } while (users_number != number);

//}

//void multiplication()
//{
//    Console.WriteLine("А не сделал вот =(");
//}

//void div()
//{
//    //Вывод делителей числа
//    //Пользователь вводит число в консоль.
//    //Алгоритм должен найти _все_ числа, которые делят это число на цело, без остатка
//    //(например число 10 имеет делители 1, 2, 5, 10,
//    //так как все результаты при делении (10/1, 10/2, 10/5, 10/10) будут иметь целый результат.
//    //тот же 10/4 сюда не подходит, так как получится дробное значение).
//    //*(Не обязательно) Должна быть возможность после ввода одного числа ввести также
//    //и другое (как показано на видео). Однако если будет вводится число,
//    //а потом код будет перекидывать нас в менюшку, будет нормально
//    Console.WriteLine("Данная программа выводит все делители введенного вами числа");
//    Console.WriteLine("Введите 0 что бы закончить");
//    int number;
//    do
//    {
//        Console.WriteLine("Введите число: ");
//        number = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Делители данного числа: ");
//        for (int i = 1; i <= number; i++)
//        {
//            if (number % i == 0)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    } while (number != 0);
//}
