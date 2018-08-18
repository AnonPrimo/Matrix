using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Matrix
{
    class Matrix
    {
        object locker = new object();

        string s = "AQWSEDRFGTYHJUIKLOPMNBVCXZ123654789";

        Random r = new Random();

        int wsWidth, wsHeigth, shift;

        public Matrix(int w, int h)
        {
            this.wsWidth = w;
            this.wsHeigth = h;
            shift = r.Next(this.wsWidth);
        }


        public char GetSymb()
        {
            return s[r.Next(s.Length)];
        }

        public void Move()
        {
            int lt = 0;
            int count = 4;
            for (int i = 1; i < this.wsHeigth+2; i++)
            {
               
                    Console.CursorLeft = shift;
                    Console.CursorTop = i;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(GetSymb());

                    if (lt < count) 
                        lt++;

                    for (int j = 1; j < lt; ++j)
                    {
                        Console.CursorLeft = shift;
                        Console.CursorTop = i-j;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(GetSymb());
                    }

                      Console.CursorLeft = shift;
                     Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorTop = i - lt;
                    Console.WriteLine("█");
                    Console.ForegroundColor = ConsoleColor.White;
                
                
                
                
                    if (i >= this.wsHeigth - 1)
                    {
                        
                        Console.CursorLeft = shift;
                        Console.CursorTop = this.wsHeigth - 1;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("█");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }

                    /*
                    while (lt > 0 && i == this.wsHeigth - 1)
                    {
                    Console.CursorLeft = shift;
                    Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("█");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }*/

                    Thread.Sleep(400);
                
            }      
        }      
    }
}
