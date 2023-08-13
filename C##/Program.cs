// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string meaning1 = ReadString("Введите первое значение массива: ");
string meaning2 = ReadString("Введите первое значение массива: ");
string meaning3 = ReadString("Введите третье значение массива: ");
string meaning4 = ReadString("Введите четвертое значение массива: ");

string[] Array = { meaning1, meaning2, meaning3, meaning4 };
int count = 0;
int j = 0;

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3) count++;
}

string[] newArray = new string[count];

for (int i = 0; i < Array.Length; i++)
{
    if(Array[i].Length <= 3)
    {
        newArray[j]=Array[i];
        j++;
    }
}
PrintArray(Array);
Console.WriteLine();
PrintArray(newArray);

string ReadString(string message)
{
    Console.WriteLine(message);
    return Convert.ToString(Console.ReadLine());
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}