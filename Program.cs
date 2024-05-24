using System;

class Program
{
    static void Main()
    {
        // Исходный массив строк
        string[] originalArray = { "Hello", "2", "world", ":-)" }; //объявляем и инициализируем массив строк originalArray.
       		
        // Этот блок кода проходит по каждой строке в originalArray 
		// и увеличивает newSize на 1, если длина строки меньше или равна 3.
		int newSize = 0;
		foreach (string s in originalArray)
        {
            if (s.Length <= 3)
            {
                newSize++;
            }
        }

        // Здесь создается новый массив строк newArray с размером newSize.
        string[] newArray = new string[newSize];

        // Этот блок кода снова проходит по каждой строке в originalArray и,
		// если длина строки меньше или равна 3, добавляет ее в newArray и увеличивает index на 1.
        int index = 0;
        foreach (string s in originalArray)
        {
            if (s.Length <= 3)
            {
                newArray[index] = s;
                index++;
            }
        }

        //Наконец, этот блок кода выводит каждую строку в newArray в консоль.
        foreach (string s in newArray)
        {
            Console.WriteLine(s);
        }
    }
}
/*
Этот код создает новый массив строк, в который добавляются только те строки из исходного массива,
длина которых меньше или равна 3. Затем он выводит элементы нового массива.
*/