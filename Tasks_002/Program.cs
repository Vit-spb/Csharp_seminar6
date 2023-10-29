// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите значения b1, k1, b2 и k2 через пробел: ");
int[] myMrray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
if(myMrray.Length != 4){
    System.Console.WriteLine("Должно быть четыре знвчения!");
    return;
}
 var b1 = Convert.ToDouble(myMrray[0]);
 var k1 = Convert.ToDouble(myMrray[1]);
 var b2 = Convert.ToDouble(myMrray[2]);
 var k2 = Convert.ToDouble(myMrray[3]);
 
var x = Math.Round((-(b1 - b2) / (k1 - k2)), 3);
var y = Math.Round((k1 * x + b1), 3);
  
Console.WriteLine($"Пересечение в точке: ({x};{y})");