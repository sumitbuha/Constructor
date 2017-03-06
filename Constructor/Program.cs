using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        int length;
        int width;
        public Program(int l)
        {
            Console.WriteLine("Hii i am here");
            length = l;
        }
        public void setlength(int l)
        {
            length = l;
        }
        public int getlength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Program line = new Program(5);

            line.setlength(78);



            Console.WriteLine("length is:{0}",line.getlength());
            Console.ReadLine();



        }
    }
}
