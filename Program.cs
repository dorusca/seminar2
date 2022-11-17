// Напишите программу, которая получает на вход двузначное число и выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*int Digits(int number) //объявление метода
{
int ed = number%10;
int dec = number /10;
int result;
if (ed>dec){
    return = ed;
}
else return dec;
}
Console.Write("Imput your 2digit number:  ");
int user_num =Convert.ToInt32 (Console.ReadLine());
int res = Digits(user_num );

Console.Write($"The biggest digit is{res}");




Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.


int Digits() //объявление метода
{
    int randomNum = new Random().Next(10,100);//генерация двухначного числа
Console.WriteLine("Your number is" + randomNum);
int ed = randomNum % 10;
int dec = randomNum /10;

if (ed>dec){
    return ed;  // завершение метода, возвращение в программу единиц
}
else return dec; //завершение метода, возвращение в программу десяток
}
Console.WriteLine("The biggest digit is" + Digits());



//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
void Cratnost (int num, int a, int b)
{
    if (num % a==0 && num % b ==0 )
    {
        Console.WriteLine ( $" Ваше число {num} кратно {a} и {b}");
    }
    else Console.WriteLine ( $" Ваше число {num}  не кратно {a} и {b}");
}
Console.WriteLine ( " Введите число:  ");
int num_user = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ( " Введите первое число:  ");
int dev1 = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ( " Введите второе число:  ");
int dev2 = Convert.ToInt32(Console.ReadLine ());

Cratnost( num_user, dev1, dev2);



напишите программу, которая выводит случайное 3-х значное число и удаляет вторую цифрую
int DeletDec ()
{
    int randomNum = new Random().Next(100, 1000);
    Console.WriteLine ("Ваше число:"  + randomNum);
    int fut_dec =randomNum/100;
    int fut_ed = randomNum %10;

    int new_num = fut_dec *10 + fut_ed;
    return new_num;
}
Console.WriteLine ( $"Ваше новое число {DeletDec()}");

Задача  10: Напишите программу, (без метода)которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

Console.WriteLine ( " Введите трехначное число:  ");
int num = Convert.ToInt32(Console.ReadLine ());

if (num > 99 &&  num < 1000)
{
int current = num /10;
int current1 = current % 10;
Console.WriteLine ( $"Новое число {current1}");
}
else 
{
Console.WriteLine ( $" Число {num } не трехначное !");
}

Задача 13: Напишите программу,(без метода) которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
*/
Console.WriteLine ( " Введите N:  ");
int num = Convert.ToInt32(Console.ReadLine ());

while (num >=1000 ) num = (num /10 );

if (num > 99 &&  num < 1000)
{
int current = num % 10;
Console.WriteLine ( $"Новое число {current}");
}
else  Console.WriteLine ( $" Число {num } не трехначное !Введите другое число:  ");






