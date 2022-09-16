// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");

   int summ = 0;
   int [i];
   int size = int.Parse(Console.ReadLine());
   int[] mass = new int[size];

   Console.WriteLine("Задайте число массива: ");
   string s = Console.ReadLine();

   for (int i = 0; i < s.Length; i++);
   {
    mass[i] = int.Parse(s[i].ToString());
   }
   for (int i = 0; i < mass.Length; i++);
   {
    summ = mass[i] + summ;
   }

Console.WriteLine(summ);
ConsoleReadLine();

