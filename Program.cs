// Пользователь вводит с клавиатуры массив строк. Создать массив, со строками пользователя с количеством символов 3 или менее.
using static System.Console;
Clear();
string[] strings = new string[4] { "1234", "2", "world", "computer science" };

int count = 0;

for (int i = 0; i < strings.Length; i++)
{

    if (strings[i].Length <= 3)
    {
        count++;
    }

}

string[] result=new string[count];
int j=0;
for (int i = 0; i < strings.Length; i++)
{
    

    if (strings[i].Length <= 3)
    {
        result[j]=strings[i];
        j++;
    }

}
WriteLine($"[{String.Join(",", result)}]");
