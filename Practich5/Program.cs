using Practich51;
using Practich5;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using System.Data;

Zakaz.key = Console.ReadKey();

while (Zakaz.key.Key != ConsoleKey.Enter)
{
    Zakaz zakas = new Zakaz();
    zakas.MainMenu();
    Console.Clear();
    DateTime date = new DateTime();
    date = DateTime.Now;
    string a = Convert.ToString(Zakaz.a);
    File.AppendAllText("C:\\Users\\Anna\\Documents\\ОАИП Скорогудаева\\Заказ.txt", date.ToString());
    File.AppendAllText("C:\\Users\\Anna\\Documents\\ОАИП Скорогудаева\\Заказ.txt", a);
    File.AppendAllText("C:\\Users\\Anna\\Documents\\ОАИП Скорогудаева\\Заказ.txt", Convert.ToString(Zakaz.c));
    Console.WriteLine("Сумма заказа " + Zakaz.a);
    Console.WriteLine("Чтобы выйти из программы нажмите Enter, если хотите сделать новый заказ, нажмите любую клавишу.");
    Array.Clear(Zakaz.c);
    Zakaz.key = Console.ReadKey();
}



