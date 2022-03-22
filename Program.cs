Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

void Palindrom(int current_number)
{
    if(current_number > 9999 & current_number < 100000)
    {
        int digit_1 = current_number/10000;
        int digit_2 = current_number/1000 % 10;
        int digit_3 = current_number/100 % 10;
        int digit_4 = current_number/10 % 10;
        int digit_5 = current_number % 10;
        if (digit_1 == digit_5 & digit_2 == digit_4) Console.WriteLine(current_number + " >> число является палиндромом");
        else Console.WriteLine(current_number + " >> число не является палиндромом");
    }
    else Console.WriteLine("Вы ввели неверное число");
}