using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRiceCooker
{
    public class MessageBox
    {
        int x;
        int y;
        string Message;
        int height = 3;

        public MessageBox(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Message = "안녕하십니까용!";
        } 

        public void showBox(string message)
        {
            this.Message = message;

            Console.SetCursorPosition(x, y);
            Console.Write("┌─────────────────────────────────────────────┐");
            for(int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                                             │");
            }

            Console.SetCursorPosition(x, y + height);
            Console.Write("└─────────────────────────────────────────────┘");
            Console.SetCursorPosition(x + 2, y + 1);
            Console.Write(this.Message);
        }
    }
}
