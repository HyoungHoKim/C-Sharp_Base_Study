using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRiceCooker
{
    public class Menu
    {
        int x;
        int y;
        string[] MenuItem;
        public int MainMenuIndex = 0;

        public Menu(int x, int y, string[] menuItem)
        {
            this.x = x;
            this.y = y;
            this.MenuItem = menuItem;
        }

        public void showMenu()
        {
            ConsoleKeyInfo inputKey;

            while (true)
            {
                for (int i = 0; i < this.MenuItem.Length; i++)
                {
                    if (MainMenuIndex == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(MenuItem[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(MenuItem[i]);
                    }
                }

                inputKey = Console.ReadKey(true);

                if (inputKey.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (inputKey.Key == ConsoleKey.UpArrow)
                {
                    MainMenuIndex--;
                    if (MainMenuIndex < 0)
                        MainMenuIndex = 0;
                }
                else if (inputKey.Key == ConsoleKey.DownArrow)
                {
                    MainMenuIndex++;
                    if (MainMenuIndex == this.MenuItem.Length)
                        MainMenuIndex = this.MenuItem.Length - 1;
                }
            }

        }
    }
}
