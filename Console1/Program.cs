using System;
class MyClass
{
    public unsafe void Method()
    {
        int x = 10;
        int y = 20;
        int* ptr1 = &x;
        int* ptr2 = &y;
        Console.WriteLine((int)ptr1);
        Console.WriteLine((int)ptr2);
        Console.WriteLine(*ptr1);
        Console.WriteLine(*ptr2);
    }
}
class CaesarCipher
{
    
    static void Main()
    {
        while (true)
        {

        
        Console.WriteLine("Методы:\n1.Система шифрования Цезаря (смещением)\r\n2.Афинная система подстановок Цезаря\r\n3.Система Цезаря с ключевым словом\r\n4.Шифрующие таблицы Трисемуса\r\n5.Биограммный шифр Плейфейра\r\n6.Криптосистема Хилла");
        Console.WriteLine("Выберите метод шифрования: ");
        int vibor = Convert.ToInt32(Console.ReadLine());

        if (vibor == 1)     
        {
            // Ввод сообщения для шифрования
            Console.WriteLine("Введите сообщение для шифрования:");
            string message = Console.ReadLine();

            // Ввод смещения для шифрования
            Console.WriteLine("Введите смещение (целое число):");
            int shift = int.Parse(Console.ReadLine());

            // Вызов метода для шифрования сообщения
            string encryptedMessage = EncryptMessage(message, shift);

            // Вывод зашифрованного сообщения
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);
        }
       else if (vibor == 2)
       {
            // Ввод сообщения для шифрования
            Console.WriteLine("Введите сообщение для шифрования:");
            string message = Console.ReadLine();

            // Ввод ключа a для шифрования (взаимно простое с 32)
            Console.WriteLine("Введите ключ a (взаимно простое с 32):");
            int a = int.Parse(Console.ReadLine());

            // Ввод ключа b для шифрования
            Console.WriteLine("Введите ключ b (целое число):");
            int b = int.Parse(Console.ReadLine());

            // Вызов метода для шифрования сообщения
            string encryptedMessage = EncryptMessage1(message, a, b);

            // Вывод зашифрованного сообщения
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);
       }
        else if  (vibor == 3)
        {
            // Ввод сообщения для шифрования
            Console.WriteLine("Введите сообщение для шифрования:");
            string message = Console.ReadLine();

            // Ввод ключевого слова
            Console.WriteLine("Введите ключевое слово:");
            string keyword = Console.ReadLine();

            // Вызов метода для шифрования сообщения
            string encryptedMessage = EncryptMessage2(message, keyword);

            // Вывод зашифрованного сообщения
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);
        }
        else if (vibor == 4)
        {
            // Ввод сообщения для шифрования
            Console.WriteLine("Введите сообщение для шифрования:");
            string message = Console.ReadLine();

            // Ввод ключевого слова
            Console.WriteLine("Введите ключевое слово:");
            string keyword = Console.ReadLine();

            // Вызов метода для шифрования сообщения
            string encryptedMessage = EncryptMessage3(message, keyword);

            // Вывод зашифрованного сообщения
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);
        }
        else if (vibor == 5)
        {
            // Ввод сообщения для шифрования
            Console.WriteLine("Введите сообщение для шифрования:");
            string message = Console.ReadLine();

            // Ввод ключевого слова
            Console.WriteLine("Введите ключевое слово:");
            string keyword = Console.ReadLine();

            // Вызов метода для шифрования сообщения
            string encryptedMessage = EncryptMessage4(message, keyword);

            // Вывод зашифрованного сообщения
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);
        }
        else if(vibor == 6)
        {
            // Ввод сообщения для шифрования
            Console.WriteLine("Введите сообщение для шифрования:");
            string message = Console.ReadLine();

            // Ввод ключа (матрицы 2x2)
            Console.WriteLine("Введите ключ (матрица 2x2 в формате 1 2 3 4):");
            string keyInput = Console.ReadLine();
            string[] keyValues = keyInput.Split(' ');
            int[,] key = new int[2, 2] { { int.Parse(keyValues[0]), int.Parse(keyValues[1]) }, { int.Parse(keyValues[2]), int.Parse(keyValues[3]) } };

            // Вызов метода для шифрования сообщения
            string encryptedMessage = EncryptMessage5(message, key);

            // Вывод зашифрованного сообщения
            Console.WriteLine("Зашифрованное сообщение: " + encryptedMessage);
        }


       
    }
    }

    static string EncryptMessage(string message, int shift)// шифрования сообщения методом Афинная система подстановок Цезаря
    {
        // Преобразование строки в массив символов
        char[] chars = message.ToCharArray();

        // Цикл по каждому символу в массиве
        for (int i = 0; i < chars.Length; i++)
        {
            // Проверка, является ли символ буквой русского алфавита
            if (char.IsLetter(chars[i]))
            {
                // Определение нового символа с учетом смещения
                char offset = char.IsUpper(chars[i]) ? 'А' : 'а';
                chars[i] = (char)(((chars[i] + shift - offset + 32) % 32) + offset);
            }
        }

        // Преобразование массива символов обратно в строку
        return new string(chars);
    }

   
    static string EncryptMessage1(string message, int a, int b)  //  шифрования сообщения методом Цезаря
    {
        // Преобразование строки в массив символов
        char[] chars = message.ToCharArray();

        // Цикл по каждому символу в массиве
        for (int i = 0; i < chars.Length; i++)
        {
            // Проверка, является ли символ буквой русского алфавита
            if (char.IsLetter(chars[i]))
            {
                // Определение нового символа с учетом ключей a и b
                char offset = char.IsUpper(chars[i]) ? 'А' : 'а';
                chars[i] = (char)((((a * (chars[i] - offset) + b) % 32) + 32) % 32 + offset);
            }
        }

        // Преобразование массива символов обратно в строку
        return new string(chars);
    }

    static string EncryptMessage2(string message, string keyword) // Система Цезаря с ключевым словом
    {
        // Преобразование ключевого слова в числовой ключ
        int key = 0;
        foreach (char letter in keyword)
        {
            key += (int)char.ToUpper(letter) - 64; // Преобразование буквы в число (A=1, B=2, и т.д.)
        }

        // Преобразование строки в массив символов
        char[] chars = message.ToCharArray();

        // Цикл по каждому символу в массиве
        for (int i = 0; i < chars.Length; i++)
        {
            // Проверка, является ли символ буквой русского алфавита
            if (char.IsLetter(chars[i]))
            {
                // Определение смещения в алфавите с учетом ключа
                char offset = char.IsUpper(chars[i]) ? 'А' : 'а';
                chars[i] = (char)((((chars[i] - offset + key) % 32) + 32) % 32 + offset);
            }
        }

        // Преобразование массива символов обратно в строку
        return new string(chars);
    }

    
    static string EncryptMessage3(string message, string keyword) // Метод для шифрования сообщения с использованием таблицы Трисемуса
    {
        // Создание таблицы Трисемуса
        char[,] trisemusTable = new char[6, 6]
        {
            {'А', 'Б', 'В', 'Г', 'Д', 'Е'},
            {'Ё', 'Ж', 'З', 'И', 'Й', 'К'},
            {'Л', 'М', 'Н', 'О', 'П', 'Р'},
            {'С', 'Т', 'У', 'Ф', 'Х', 'Ц'},
            {'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь'},
            {'Э', 'Ю', 'Я', ' ', ' ', ' '}
        };

        // Преобразование ключевого слова в числовой ключ
        int key = 0;
        foreach (char letter in keyword)
        {
            key += (int)char.ToUpper(letter) - 1040; // Преобразование буквы в число (А=1040, Б=1041, и т.д.)
        }

        // Преобразование строки в массив символов
        char[] chars = message.ToCharArray();

        // Цикл по каждому символу в массиве
        for (int i = 0; i < chars.Length; i++)
        {
            // Поиск символа в таблице Трисемуса
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (chars[i] == trisemusTable[row, col])
                    {
                        // Определение новых координат символа с учетом ключа
                        int newRow = (row + key / 6) % 6;
                        int newCol = (col + key % 6) % 6;
                        chars[i] = trisemusTable[newRow, newCol];
                    }
                }
            }
        }

        // Преобразование массива символов обратно в строку
        return new string(chars);
    }

    
    static string EncryptMessage4(string message, string keyword)// Метод для шифрования сообщения с использованием биграммного шифра Плейфейра
    {
        // Создание матрицы 5x5 для шифра Плейфейра
        char[,] playfairMatrix = new char[5, 5];

        // Заполнение матрицы уникальными буквами из ключевого слова
        string key = keyword + "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        key = new string(key.Distinct().ToArray()).Replace(" ", ""); // Удаление повторяющихся символов и пробелов
        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                playfairMatrix[i, j] = key[index];
                index++;
            }
        }

        // Преобразование строки в массив биграмм (пар символов)
        string[] bigrams = new string[message.Length / 2];
        int count = 0;
        for (int i = 0; i < message.Length; i += 2)
        {
            bigrams[count] = message.Substring(i, 2);
            count++;
        }

        // Шифрование каждой биграммы
        for (int k = 0; k < bigrams.Length; k++)
        {
            char first = bigrams[k][0];
            char second = bigrams[k][1];

            int row1 = 0, col1 = 0, row2 = 0, col2 = 0;

            // Нахождение координат символов в матрице
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (playfairMatrix[i, j] == first)
                    {
                        row1 = i;
                        col1 = j;
                    }
                    if (playfairMatrix[i, j] == second)
                    {
                        row2 = i;
                        col2 = j;
                    }
                }
            }

            // Шифрование биграммы
            if (row1 == row2)
            {
                bigrams[k] = playfairMatrix[row1, (col1 + 1) % 5].ToString() + playfairMatrix[row2, (col2 + 1) % 5].ToString();
            }
            else if (col1 == col2)
            {
                bigrams[k] = playfairMatrix[(row1 + 1) % 5, col1].ToString() + playfairMatrix[(row2 + 1) % 5, col2].ToString();
            }
            else
            {
                bigrams[k] = playfairMatrix[row1, col2].ToString() + playfairMatrix[row2, col1].ToString();
            }
        }

        // Объединение зашифрованных биграмм в строку
        return string.Join("", bigrams);
    }

    
    static string EncryptMessage5(string message, int[,] key) // Метод для шифрования сообщения с использованием криптосистемы Хилла
    {
        // Преобразование строки в массив чисел (по номерам букв в алфавите)
        int[] messageNumbers = new int[message.Length];
        for (int i = 0; i < message.Length; i++)
        {
            messageNumbers[i] = (int)message[i] - 1072; // Получение номера буквы в алфавите (для русского алфавита)
        }

        // Шифрование
        string encryptedMessage = "";
        for (int i = 0; i < messageNumbers.Length; i += 2)
        {
            int char1 = messageNumbers[i];
            int char2 = (i + 1 < messageNumbers.Length) ? messageNumbers[i + 1] : 32; // Если последний символ один, то добавляем пробел
            int encChar1 = (key[0, 0] * char1 + key[0, 1] * char2) % 32; // Модуль по размеру алфавита
            int encChar2 = (key[1, 0] * char1 + key[1, 1] * char2) % 32; // Модуль по размеру алфавита
            encryptedMessage += (char)(encChar1 + 1072); // Получение символа по номеру в алфавите (для русского алфавита)
            encryptedMessage += (char)(encChar2 + 1072); // Получение символа по номеру в алфавите (для русского алфавита)
        }

        return encryptedMessage;
    }
}
