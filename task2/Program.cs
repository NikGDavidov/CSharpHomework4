// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
// 82 -> 10
// 9012 -> 12
int SumDigits (int num)
{
    int result=0;
   while (num>0){
       result +=  num%10;
       num = num/10;
   }
   return result;
}
Console.WriteLine($"452 -> {SumDigits(452)}");
Console.WriteLine($"82 -> {SumDigits(82)}");
Console.WriteLine($"9012 -> {SumDigits(9012)}");