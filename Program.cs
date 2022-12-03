// Задача итоговой проверочной работы
// по вводному курсу

// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры 
// либо задать на старте выполнения алгоритма.
// При решениее не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Пример:
//["hello","2","world",":-)"] -> ["2", ":-)"]
//["1234","1567","-2","computer science"] -> ["-2"]
//["Russia", "Denmark","Kazan"]` -> []


string[] CreateArrayUserString(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    { 
       Console.WriteLine("Введите элемент массива:");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

string[] SelectArrayString(string[] arrStr, int Len)
{
    int size = 0;
    
    for (int i = 0; i < arrStr.Length; i++)
    {
       if (arrStr[i].Length <= Len)
        {
            size++;
        }            
    }  
    string[] selArrStr = new string[size];
     int count = 0; 
     for (int i = 0; i < arrStr.Length; i++)
    {
        if (arrStr[i].Length <= Len)
        {
            selArrStr[count] = arrStr[i];
            count++;
        }
    }
    return selArrStr;
}
    
    
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m <= 0)
{
    Console.WriteLine($"Число {m} некорректно, нужно ввести целое положительное число.");
}
else
{
     string[] createArrayUserString = CreateArrayUserString(m);
     PrintArray(createArrayUserString);
     string[] selectArrayString = SelectArrayString(createArrayUserString, 3);
     Console.Write(" => ");
     PrintArray(selectArrayString);
}

