/* Задача: Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */



Console.Clear();

Console.WriteLine("Введите любое количество строковых элементов через пробел:");
string str = Console.ReadLine()!;

if (str.Length != 0)
{
    string[] arrayString = str.Split(" ").ToArray();
    PrintStrArray(arrayString, "\nМассив из этих элементов:\n");

    string[] newArray = ToArrayWithElementsLess(arrayString, 3);
    PrintStrArray(newArray, "\n\nЭтот массив из элементов длиной меньше или равной 3:\n");
}

else Console.WriteLine($"Вы ничего не ввели! Запустите программу заново.");

Console.WriteLine("");


void PrintStrArray(string[] array, string message)
{
    Console.WriteLine(message);

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }

    Console.Write("]");
}

string[] ToArrayWithElementsLess(string[] array, int elementLength)
{
    int newArrayLength = 0;
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementLength) newArrayLength++;
    }

    string[] arrayTruncated = new string[newArrayLength];

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= elementLength)
        {
            arrayTruncated[count] = array[j];
            count++;
        }
    }

    return arrayTruncated;
}