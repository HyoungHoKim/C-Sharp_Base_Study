using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRiceCooker
{
    public class RiceCookerBox
    {
        int x;
        int y;
        int height = 20;

        public RiceCookerBox(int x, int y)
        {
            this.x = x;
            this.y = y;
        } 

        public void showBox()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("┌─────────────────────────────────────────────┐");
            for(int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                                             │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└─────────────────────────────────────────────┘");
        }
    }
}
