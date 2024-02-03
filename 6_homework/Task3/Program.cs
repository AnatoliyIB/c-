//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

string CreateReplaceStr(string str)
{
string str2 ="";
for  (int i=0; i<str.Length; i++)
{
    str2=str2+ str[str.Length-1-i];
}
return str2;
}

void IfPolindrom (string str, string str2)
{if (str == str2)
{
    Console.WriteLine("Polindrom");
}
else Console.WriteLine("Not Polindrom");
}

string str=Console.ReadLine();
string str2=CreateReplaceStr(str);
IfPolindrom(str, str2);
