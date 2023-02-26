public static class Library 
{
    /// <summary>
    /// Метод ввода пользователем массива строк с клавитуры
    /// </summary>
    /// <param name="arrayStr">!Заданный! массив строк</param>
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
            Console.Write($"{arrayString[i]} ");
        }
        
    }

    /// <summary>
    /// Метод поиска элемента массива определнной длины
    /// </summary>
    /// <param name="arrayString">массив для поиска</param>
    /// <param name="arrayStringNew">массив, для вывода подходящих под критерии элементов</param>
    /// <param name="elementLength">необходимая длина элемента массива</param>
    public static void FindStringArrayElementsSpecificLength (string[] arrayString, string[] arrayStringNew, int elementLength)
    {
        int count = 0;
        for (int i = 0; i < arrayString.Length; i++)
        {
            if (arrayString[i].Length <= elementLength)
            {
                arrayStringNew[count] = arrayString[i];
                count++;
            } 
        }
    }
}