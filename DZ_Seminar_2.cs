// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int second = (num /10) % 10;

// if (num > 100 && num < 1000)
// {
//     Console.WriteLine(second);
// }

// else
// {
//     Console.WriteLine("Некорректное значение");
// }




// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// находим кол-во разрядов
int count = 0;
int num2 = num;
while (num2 >= 1)
{
    num2 = num2 / 10;
    count++;
}

Console.WriteLine("количество разрядов " + count);

// отбрасываю разряды

// нахождение степени
int pow = 1;
for (int i=1; i<=count-3; i++) {
    pow = pow * 10;
}
int num3 = num / pow;
Console.WriteLine("степень " + pow);

Console.WriteLine("число без разрядов " +num3);

Console.WriteLine("Ответ: " +num3 % 10); 



// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("введите номер дня: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
// {
//     Console.Write("Некорректное значение");
// }

// else
// {
//     if (day == 1 || day == 2 || day == 3 || day == 4 || day ==5 )
//     {
//         Console.Write("Рабочий день");
   
//     }
//     else
//     {
//         Console.Write("Выходной день");
//     }
// }