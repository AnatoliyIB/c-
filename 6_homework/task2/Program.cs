﻿// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.



string str = Console.ReadLine();
char [] CapitalLeters = {'Q','W','E','R','T','Y','U','I','O','P','A','S','D','F','G','H','J','K','L','Z','X','C','V','B','N','M'};
char [] LowerLeters = {'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
string LowerStr="";
for (int i=0; i<str.Length; i++)
{for (int j=0; j<CapitalLeters.Length; j++)
{
  if (str[i]==CapitalLeters[j])
{
  LowerStr=LowerStr+LowerLeters[j];
}

}
}
Console.WriteLine(LowerStr);
