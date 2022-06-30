// Задача 15
Console.Write("Введи цифру обозначающую день недели ");
int day = Convert.ToInt32(Console.ReadLine());

string daynew (int daynumber)
{
if (daynumber >= 1 && daynumber <= 5)
{
    return "Введённый день не явялется выходным";

}
 else if (daynumber >= 6 && daynumber <= 7)
 {
    return "Введённый день ВЫХОДНОЙ";

 }
 else
 return "Введёное число не является днём недели"; 
}
 Console.WriteLine(daynew(day));
