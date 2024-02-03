//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами");
string str = Console.ReadLine()!;
char [] delimiter = {' '};
string [] strArray = str.Split(delimiter,StringSplitOptions.None);
foreach (string s in strArray) 
{
    Console.WriteLine(s);
}

for (int i=0; i<strArray.Length/2; i++)
{
    string temp=strArray[i];
    strArray[i]=strArray[strArray.Length-1-i];
    strArray[strArray.Length-1-i]=temp;
}
foreach (string s in strArray) 
{
    Console.WriteLine(s);
}