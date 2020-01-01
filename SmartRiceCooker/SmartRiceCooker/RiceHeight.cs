using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRiceCooker
{
    public class RiceHeight
    {
        int x;
        int y;
        float height;

        public RiceHeight(int x, int y, int Amount)
        {
            this.x = x;
            this.y = y;
            this.height = Amount / 1000;
        } 

        public void showBox()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for(int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(x, 2 + i);
                Console.Write("                    ");
            }

            for(int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, 19 - i);
                Console.Write("⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");

            }
        }
    }
}
