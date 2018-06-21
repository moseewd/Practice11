using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_задача_3
{

    class Program
    {
        public static int Readint()
        //ввод числа для красивых лаб
        {
            bool check = false;
            int intNum;
            do
            {
                // Попытка перевести строку в число
                check = Int32.TryParse(Console.ReadLine(), out intNum);
                // Если попытка неудачная:
                if (!check)
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!check);
            // Если попытка удачная:
            return intNum;
        }
        static bool ok = false;
        static void Main(string[] args)
        {
            //char[] nums2 = new char[33] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
            char[] a;
            do
            {
                Console.WriteLine("Введите слово, которое вы хотите зашифровать");
                string s = Console.ReadLine();
                a = s.ToCharArray();
                for (int i = 0; i < a.Length; i++)
                {
                    if (((Convert.ToInt32(a[i]) >= 65) && (Convert.ToInt32(a[i]) <= 90)) || ((Convert.ToInt32(a[i]) >= 97) && (Convert.ToInt32(a[i]) <= 122)) || ((Convert.ToInt32(a[i]) >= 1040) && (Convert.ToInt32(a[i]) <= 1103)))
                    {
                        ok = true;
                    }
                    else
                        Console.WriteLine("Введите символы русского или английского алфавита");
                   
                }
            } while (!ok);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToChar((int)a[i] - 2);
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("Введите слово для дешифрации");
            string f = Console.ReadLine();
            char[] b = f.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToChar((int)b[i] + 2);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
        }
    }
}