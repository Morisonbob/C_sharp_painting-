using System;
class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        for(int i = 0; i <15; i++)
        {
            Console.WriteLine("                                                                             ");
        }
        Console.BackgroundColor = ConsoleColor.White;
        Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop - 8);
        Console.WriteLine("                             ");
        Console.SetCursorPosition(Console.CursorLeft + 5, Console.CursorTop - 2);
        Console.WriteLine("               ");
        Console.SetCursorPosition(Console.CursorLeft + 19, Console.CursorTop + 1);
        Console.WriteLine("               ");
        Console.SetCursorPosition(Console.CursorLeft + 54, Console.CursorTop - 1);
        Console.WriteLine("               ");
        Console.SetCursorPosition(Console.CursorLeft + 40, Console.CursorTop + 1);
        Console.WriteLine("               ");
        Console.SetCursorPosition(Console.CursorLeft + 40, Console.CursorTop - 2);
        Console.WriteLine("                             ");
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 2);
        Console.BackgroundColor = ConsoleColor.Green;
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("                                                                             ");
        }

        //Arvore
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop -6);
        Console.WriteLine(" ");
        Console.WriteLine("   ");
        Console.WriteLine("   ");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        for (int i =0; i<3; i++)
        {
            Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
            Console.WriteLine(" ");
        }

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.SetCursorPosition(Console.CursorLeft + 15, Console.CursorTop - 8);
        Console.WriteLine(" ");
        Console.SetCursorPosition(Console.CursorLeft+14, Console.CursorTop);
        Console.WriteLine("   ");
        Console.SetCursorPosition(Console.CursorLeft + 14, Console.CursorTop);
        Console.WriteLine("   ");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(Console.CursorLeft + 15, Console.CursorTop);
            Console.WriteLine(" ");
        }
        Console.ResetColor();
        Console.SetCursorPosition(Console.CursorLeft + 35, Console.CursorTop);
        Console.WriteLine("ME AJUDA!");
        Console.ReadKey();
    }
}
