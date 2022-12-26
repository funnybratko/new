namespace ConsoleApp6
{
    internal class Program
    {
        static int summ(int s, int n) //Объявление рекурсивной функции
        {
            if (s == n) //если номер студента и число совпадут
                return n; //вернуть число уже равное номеру студента
            return n + summ(s, n - 1); //а до тех пор возвращать функцию уменьшая текущее число на 1
        }
        static void Main(string[] args)
        {
            int s = 4; //номер студента
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine()); //ввод числа
            Console.WriteLine($"Сумма чисел: {summ(s, n)}"); //вывод суммы чисел
        }
    }
}