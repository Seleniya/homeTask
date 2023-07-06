/*
Написать программу, которая из имеющегося массива
 строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

*/




Console.WriteLine("Введите какие-нибудь символы, в строку, 0 - 5 штук.");
string a = Console.ReadLine()!;
Console.WriteLine("Введите снова какие-нибудь символы, в строку, 0 - 5 штук.");
string b = Console.ReadLine()!;
Console.WriteLine("Опять введите какие-нибудь символы, в строку.");
string c = Console.ReadLine()!;
﻿string[] array1 = new string[] {a, b, c};
string[] array2 = new string[array1.Length];


void countLengthOfStrings(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if( array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    
    }
    
}
countLengthOfStrings(array1, array2);

void PrintArray(string[] array)
{
    
        var s = "";
        for (int i = 0; i < array.Length; i++)
        {
        
        s = string.Join(", ", array); 
        }
       
        Console.WriteLine($"Я создам массив из строк, длиной до 3 символов.\n Искомый массив это: {s} ");
            
        
    
}

  

PrintArray(array2);



