public static class Library 
{
    public static void UserInput (string[] arrayStr)
    {
        Console.Write($"Введите элементы массива с клавиатры. Например: пример, вертеброгенная, 1234556, 345, ??ЭЭЖ/");
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < arrayStr.Length; i++)
        {
            Console.Write($"Введите элемент в массива с индексом {i}: ");
            arrayStr[i] = Console.ReadLine();
        }
    }


    /// <summary>
    /// Метод печати массива
    /// </summary>
    /// <param name="arrayString">Имя массива для печати</param>
    public static void PrintArray(string[] arrayString)
    {
        Console.Write($"Ваш массив:  ");
        Console.WriteLine();
        
        for (int i = 0; i < arrayString.Length; i++)
        {
            Console.Write(arrayString[i]+"   ");
        }
        
    }
}