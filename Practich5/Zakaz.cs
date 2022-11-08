using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practich5;
namespace Practich51
{
    public class Zakaz
    {
        private Podpunkt form = new Podpunkt();
        private Podpunkt taste = new Podpunkt();
        private Podpunkt size = new Podpunkt();
        private Podpunkt glazur = new Podpunkt();
        private Podpunkt decoration = new Podpunkt();
        public static List<Podpunkt> itog = new List<Podpunkt>();

        private int position;

        public static string[] c = new string[Zakaz.itog.Count];
        public static ConsoleKeyInfo key;
        public static int a;

        private void Strelka()
        {
            key = Console.ReadKey();
            if ((key.Key == ConsoleKey.UpArrow) && (position != 2))
            {
                position--;
            }

            if ((key.Key == ConsoleKey.DownArrow) && (position < 6))
            {
                position++;
            }
            if (position == 2)
            {
                Console.SetCursorPosition(0, 3);
            }
            if (position == 7)
            {
                Console.SetCursorPosition(0, 6);
            }
        }

        public void MainMenu()
        {
            position = 2;
            
            Console.Clear();
            Console.WriteLine("Нажмите стрелочку вниз, чтобы отобразить меню.");
            key = Console.ReadKey();
            while ((key.Key != ConsoleKey.Enter) && (key.Key != ConsoleKey.Escape))
            {
                Strelka();
                Console.Clear();
                Console.WriteLine("Главное меню для заказа.");
                Console.WriteLine("-------------------------");
                Console.WriteLine("  1. Форма");
                Console.WriteLine("  2. Размер");
                Console.WriteLine("  3. Вкус");
                Console.WriteLine("  4. Декор");
                Console.WriteLine("  5. Глазурь");
                Console.SetCursorPosition(0, position);
                Console.Write("->");


                Console.SetCursorPosition(0, 8);
                for (int i = 0; i < itog.Count; i++)
                {
                    Console.Write(itog[i].podp + " - ");
                    Console.Write(itog[i].Zena + "  ");
                }
            }

            if (key.Key == ConsoleKey.Enter)
            {
                AddMenu();
            }

            if (key.Key == ConsoleKey.Escape)
            {
                a = 0;
                Console.SetCursorPosition(0, 7);
                for (int i = 0; i < itog.Count; i++)
                {
                    a = a + itog[i].Zena;
                }
                
                for (int i = 0; i < Zakaz.itog.Count; i++)
                {
                    c.Append(Convert.ToString(Zakaz.itog[i]));
                }

                itog.Clear();
                Console.Write(a);
                return;
            }
        }   

        public void AddMenu()
        {
            Console.Clear();
            Console.WriteLine("Нажмите стрелочку вниз, чтобы отобразить подпункты меню.");
            
                if (position == 2)
                {
                    position = 2;
                    while (key.Key != ConsoleKey.A)
                    {
                        
                        Strelka();
                        Console.Clear();
                        Console.WriteLine("Подпункты меню: Форма");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("  1. Круг");
                        Console.WriteLine("  2. Квадрат");
                        Console.WriteLine("  3. Сердце");
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }
                    
                    if (position == 2)
                    {
                        form.podp = "Круг";
                        form.Zena = 40;
                    }

                    if (position == 3)
                    {
                        form.podp = "Квадрат";
                        form.Zena = 20;
                    }

                    if (position == 4)
                    {
                        form.podp = "Сердце";
                        form.Zena = 60;
                    }
                    itog.Add(form);
                    MainMenu();
                }

                if (position == 3)
                {
                    position = 2;
                    while (key.Key != ConsoleKey.A)
                    {
                        
                        Strelka();
                        Console.Clear();
                        Console.WriteLine("Подпункты меню: Размер");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("  1. Большой");
                        Console.WriteLine("  2. Средний");
                        Console.WriteLine("  3. Маленький");
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }

                    if (position == 2)
                    {
                        size.podp = "Большой";
                        size.Zena = 100;
                    }

                    if (position == 3)
                    {
                        size.podp = "Средний";
                        size.Zena = 60;
                    }

                    if (position == 4)
                    {
                        size.podp = "Маленький";
                        size.Zena = 30;
                    }
                    itog.Add(size);
                    MainMenu();
                }

                if (position == 4)
                {
                    position = 2;
                     while (key.Key != ConsoleKey.A)
                    {
                        
                        Strelka();
                        Console.Clear();
                        Console.WriteLine("Подпункты меню: Вкус");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("  1. Клубника");
                        Console.WriteLine("  2. Банан");
                        Console.WriteLine("  3. Манго");
                        Console.WriteLine("  4. Ежевика");
                        Console.WriteLine("  5. Шоколад");
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }

                    if (position == 2)
                    {
                        taste.podp = "Клубника";
                        taste.Zena = 30;
                    }

                    if (position == 3)
                    {
                        taste.podp = "Банан";
                        taste.Zena = 60;
                    }

                    if (position == 4)
                    {
                        taste.podp = "Манго";
                        taste.Zena = 150;
                    }

                    if (position == 5)
                    {
                        taste.podp = "Ежевика";
                        taste.Zena = 100;
                    }

                    if (position == 6)
                    {
                        taste.podp = "Шоколад";
                        taste.Zena = 30;
                    }
                    itog.Add(taste);
                    MainMenu();
                }

                if (position == 5)
                {
                    position = 2;
                    while (key.Key != ConsoleKey.A)
                    {
                       
                        Strelka();
                        Console.Clear();
                        Console.WriteLine("Подпункты меню: Декор(можно есть)");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("  1. Бабочки");
                        Console.WriteLine("  2. Деньги");
                        Console.WriteLine("  3. Ягоды");
                        Console.WriteLine("  4. Шоколадки");
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }

                    if (position == 2)
                    {
                        decoration.podp = "Бабочки";
                        decoration.Zena = 50;
                    }

                    if (position == 3)
                    {
                        decoration.podp = "Деньги";
                        decoration.Zena = 110;
                    }

                    if (position == 4)
                    {
                        decoration.podp = "Ягоды";
                        decoration.Zena = 100;
                    }

                    if (position == 5)
                    {
                        decoration.podp = "Шоколадки";
                        decoration.Zena = 50;
                    }
                    itog.Add(decoration);
                    MainMenu();
            }

                if (position == 6)
                {
                    position = 2;
                    while (key.Key != ConsoleKey.A)
                    {
                        Strelka();
                        Console.Clear();
                        Console.WriteLine("Подпункты меню: Глазурь");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("  1. Апельсиновая глазурь");
                        Console.WriteLine("  2. Кофейная глазурь");
                        Console.WriteLine("  3. Шоколадная глазурь");
                        Console.WriteLine("  4. Молочная глазурь");
                        Console.SetCursorPosition(0, position);
                        Console.Write("->");
                    }

                    if (position == 2)
                    {
                        glazur.podp = "Апельсиновая глазурь";
                        glazur.Zena = 70;

                    }

                    if (position == 3)
                    {
                        glazur.podp = "Кофейная глазурь";
                        glazur.Zena = 40;
                    }

                    if (position == 4)
                    {
                        glazur.podp = "Шоколадная глазурь";
                        glazur.Zena = 30;
                    }

                    if (position == 5)
                    {
                        glazur.podp = " Молочная глазурь";
                        glazur.Zena = 30;
                    }
                    itog.Add(glazur);
                     MainMenu();
            }
         
        }
    }
}
