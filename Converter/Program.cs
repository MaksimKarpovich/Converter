using System;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            int dec;
            int bas;
            Console.WriteLine("Введите число для перевода:");
            bool NotPosibleToConvert = !Int32.TryParse(Console.ReadLine(), out dec);
            if (NotPosibleToConvert)
            {
                Console.WriteLine("Неверные входные данные");
            }
            else 
            {
                Console.WriteLine("Введите основание для перевода:");
                NotPosibleToConvert = !Int32.TryParse(Console.ReadLine(), out bas);
                if (NotPosibleToConvert | (bas < 2) | (bas > 20))
                {
                    Console.WriteLine("Неверное основание");
                }
                else 
                {
                    //Основная часть
                    while( dec >= bas)
                    {
                        res += char.ToString(ConvertOne(dec % bas));
                        dec = dec / bas;
                    }
                    res += char.ToString(ConvertOne(dec));
                    Console.WriteLine(Swap(res));
                }
                
                
            }
            
            char ConvertOne(int input)
            {
                if ((input >= 0) & (input <= 9))
                {
                    return (char)(input+'0');
                }
                else
                {
                    if ((input >= 10) & (input <= 19))
                    {
                        return (char)(input+'A'-10);
                    }
                    else { return '-'; }
                }
            }

            string Swap(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
        }
    }
}
