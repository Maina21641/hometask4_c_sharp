// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Просто без цикла

// double A = Convert.ToInt32(Console.ReadLine());
// double B = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(A, B);
// Console.WriteLine(result);

// С циклом

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = A;

while (count < B)
{
    result *= A;
    count++;
}

System.Console.WriteLine($"{A} ^ {B} = {result}");
System.Console.WriteLine();