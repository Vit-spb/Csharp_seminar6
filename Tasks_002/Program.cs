// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string CheckTriangle(int b1, int k1, int b2, int k2)
{
if (a < b + c && b < a + c && c < a + b) return "Треугольник существует со сторонами такой длинны";
return "Треугольник не существует со сторонами такой длинны";

}

Console.WriteLine("Введите значения b1, k1, b2 и k2: ");
int[] myMrray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
if (myMrray.Length!=4)
{
myMrray = (2,5,4,9)
return;
}

Console.WriteLine(CheckTriangle(myMrray[0],myMrray[1],myMrray[2], myMrray[3]));