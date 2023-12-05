Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string digits = string.Empty;
// 45 / 10 -> 4 / 10 -> 0
while (number > 0)
{
    //45 => "5" + " " + " " = "5   "
    digits = (number % 10).ToString() + "\t" + digits;
    number /= 10; // number = number / 10
    // 45/10=4
}

Console.WriteLine($"Итого: {digits}");