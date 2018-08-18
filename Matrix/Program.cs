using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int wsWidth = 100, wsHeigth = 45;

            Console.SetWindowSize(wsWidth, wsHeigth);

            Matrix2_0 []m = new Matrix2_0[30];

            

            for (int i = 0; i < m.Length; ++i)
            {
                m[i] = new Matrix2_0(100);
                new Thread(m[i].Move).Start();
            }
      
            
            Console.ReadLine();
        }
    }
}
