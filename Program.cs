// Console.Write("Введите число: ");// Задача № 3.
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = number;
// if (number >= 100)
// {
//    while (number > 999)
//    {
//        number /= 10; //убирает последнюю цифру с конца
//    } 
//    Console.WriteLine($"{temp} => {number % 10}");
//    //Console.WriteLine($"Число после очистки: {number}");
   
// }
// else
// {
//     Console.WriteLine("Число имеет меньше 3 цифр :)");
// }


// Console.Write("Введите число: ");// Задача № 4.
// int number = Convert.ToInt32(Console.ReadLine());

// string digits = string.Empty;
// // 45 / 10 -> 4 / 10 -> 0
// while (number > 0)
// {
//     //45 => "5" + " " + " " = "5   "
//     digits = (number % 10).ToString() + ", " + digits;
//     number /= 10; // number = number / 10
//     // 45/10=4
// }

// Console.WriteLine($"Итого: {digits}");