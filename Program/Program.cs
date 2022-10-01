// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиотуры, либо задать на старте 
//выполнения алгоритма.  


string[] SortArrayByChar(string[] inputArray, int limitChar)
{   
    int sizeArray = inputArray.Length;
    string[] tmpArray = new string[sizeArray];
    int counter = 0;
    for (int i = 0; i < sizeArray; i++)
    {   
        int sizeRow = inputArray[i].Length;
        if (sizeRow <= limitChar)
        {
            tmpArray[counter] = inputArray[i];
            counter++;
        }   
    }

    string[] outputArray = new string[counter];

    for (int i = 0; i < counter; i++)
    {   
        outputArray[i] = tmpArray[i];
    }

    return outputArray;
}

void PrintArray(string[] array)
{   
    int size = array.Length;
    Console.Write("[ ");  
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]+ " ");  
    }
    Console.WriteLine("]");  
}

string[] inputArray = new string[] {"hello", "три", "2", "world", ":-)"};
Console.WriteLine("Первоначальный массив :");
PrintArray(inputArray);
string[] outputArray = SortArrayByChar(inputArray, 3);
Console.WriteLine("Итоговый массив :");
PrintArray(outputArray);
