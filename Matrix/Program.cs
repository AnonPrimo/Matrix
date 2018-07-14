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
            int wsWidth = 100, wsHeigth=10;
            Console.SetWindowSize(wsWidth, wsHeigth);
            Matrix m = new Matrix(wsWidth, wsHeigth);
            m.Move();
            for (int i = 0; i < 5; ++i)
            {

                
               // new Thread(m.Move).Start();
            }
            //Console.SetWindowSize(80, 40);

            //Matrix2_0 mat;

            //for(int i = 0; i < 30; ++i)
            //{
            //    mat = new Matrix2_0(i * 2);
            //    new Thread(mat.Move).Start();
            //}


            Console.ReadLine();
        }
    }
}
