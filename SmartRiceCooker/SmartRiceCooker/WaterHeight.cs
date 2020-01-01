using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRiceCooker
{
    public class WaterHeight
    {
        int x;
        int y;
        float height;

        public WaterHeight(int x, int y, int Amount)
        {
            this.x = x;
            this.y = y;
            this.height = Amount / 1000;
        } 

        public void showBox(int height)
        {
            this.height = height/ 1000.0f;

            Console.BackgroundColor = ConsoleColor.Black;
            for(int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(x, 2 + i);
                Console.Write("                    ");
            }

            for(int i = 0; i < this.height; i++)
            {
                Console.SetCursorPosition(x, 19 - i);
                Console.Write("                    ");

            }
        }
    }
}
