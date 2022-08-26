//  Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

//Console.Write("Введите числа(через пробел): ");
//int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
double[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToDouble(e)).ToArray();

double count = 0;
 
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
