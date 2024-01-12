/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] SmallString(string[] array)
// Функция поиска слов меньше или равным 3 символов и ввод их в отдельный массив
{
    int smallStringCount = 0;
    int temp = 0;
// Определение количества коротких слов для инициализации второго массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            smallStringCount++;
        }
    }

    string[] smallArray = new string[smallStringCount];
// Внесение коротких слов во второй массив
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            smallArray[temp] = array[i];
            temp++;
        }
    }
    return smallArray;
}

void PrintArray(string[] array)
// Функция печати массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write("]");
}

string[] CreateArray()
{
    // Ввод строк с клавиатуры

    // Объявление переменных
    string[] AS; // ссылка на массив строк
    int count; // текущее количество строк в массиве
    string s;
    string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

    // Цикл ввода строк
    Console.WriteLine("Введите строку латиницей (для завершения ввода введите пустую строку):");

    count = 0;
    AS = new string[count];

    do
    {
        s = Console.ReadLine();

        if (s != "")
        {
            // если строка не пустая, то добавить строку в массив
            count++;

            // предварительно выделить память для нового массива
            // в котором на 1 элемент больше
            AS2 = new string[count];

            // скопировать старый массив в новый
            for (int i = 0; i < AS2.Length - 1; i++)
                AS2[i] = AS[i];

            // добавить последнюю введенную строку в массив AS2
            AS2[count - 1] = s;

            // перенаправить ссылку AS на AS2
            AS = AS2;
        }
    } while (s != "");
    return AS;
}

// Вызов функций
string[] array = CreateArray();
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine("\n");
Console.WriteLine("Обработанный массив: ");
PrintArray(SmallString(array));