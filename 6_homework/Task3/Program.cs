//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = Console.ReadLine()!;
string str2 ="";
for  (int i=0; i<str.Length; i++)
{
    str2=str2+ str[str.Length-1-i];
}
Console.WriteLine(str2);
