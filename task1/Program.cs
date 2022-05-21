// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int PowCalc (int x, int y)
{
    return (int) Math.Pow(x,y);
}
for (int i = 0 ; i<5; i++){
    int a = new Random().Next(10);
    int b = new Random().Next(10);
    Console.WriteLine( $"{a},{b} -> {PowCalc(a,b)}");
} 