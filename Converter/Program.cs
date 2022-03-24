using System;

namespace Converter
{
    internal class Program
    {
        /// <summary>
        /// Преобразует вводимое десятичное число в число с разрядностью от 2 до 20
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string res = "";
            int dec;
            int bas;
            bool IsNotPosibleToConvert = true;

            Console.WriteLine("Введите число для перевода:");
            IsNotPosibleToConvert = !Int32.TryParse(Console.ReadLine(), out dec);

            if (IsNotPosibleToConvert)
            {
                Console.WriteLine("Неверные входные данные");
            }
            else 
            {
                Console.WriteLine("Введите основание для перевода:");
                IsNotPosibleToConvert = !Int32.TryParse(Console.ReadLine(), out bas);

                if (IsNotPosibleToConvert | (bas < 2) | (bas > 20))
                {
                    Console.WriteLine("Неверное основание");
                }
                else 
                {
                    //Основная часть
                    while (dec >= bas)
                    {
                        res += char.ToString(ConvertOne(dec % bas));
                        dec = dec / bas;
                    }
                    res += char.ToString(ConvertOne(dec));
                    Console.WriteLine(Swap(res));
                }
                
                
            }

            /// <summary>
            /// Конвертирует число из десятичной системы исчисления
            /// в двадцатиричную систему исчисления
            /// </summary>
            char ConvertOne(int input)
            {
                if ((input >= 0) & (input <= 9))
                {
                    return (char)(input + '0');
                }
                else
                {
                    if ((input >= 10) & (input <= 19))
                    {
                        return (char)(input + 'A' - 10);
                    }
                    else {return '-';}
                }
            }

            /// <summary>
            /// "Отзеркаливает" строку, меняя первый элемент с последним и так далее
            /// </summary>
            string Swap(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
        }
    }
}
