//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.



string [] SplitstrToArray(string str)
{
char [] delimiter = {' '};
string [] strArray = str.Split(delimiter,StringSplitOptions.None);
return strArray;
}

string [] ReplacestrArray (string [] strArray)
{
for (int i=0; i<strArray.Length/2; i++)
{
    string temp=strArray[i];
    strArray[i]=strArray[strArray.Length-1-i];
    strArray[strArray.Length-1-i]=temp;
}
return strArray;
}

string ConvertArrayToStr (string [] strArray)
{
string str2="";
for (int j=0; j<strArray.Length; j++)
{
    str2=str2+strArray[j]+" ";
}
return str2;
}
Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами");
string str = Console.ReadLine()!;
string [] strArray=SplitstrToArray(str);
ReplacestrArray (strArray);
string res=ConvertArrayToStr (strArray);
Console.WriteLine(res);
