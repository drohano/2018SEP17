using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortlek21
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 1;
            do
            {




                char ch;
                Console.WriteLine("Select a Program \n A , B , C \n Press Q then enter to exit");
                ch = Convert.ToChar(Console.ReadLine());

                switch (char.ToLower(ch))
                {
                    case 'a':


                        start = 1;
                        break;

                    case 'b':

                        start = 1;
                        break;

                    case 'c':


                        start = 1;
                        break;

                    case 'q':
                        start = 0;
                        break;

                    default:

                        start = 1;
                        break;

                }

            }
            while (start != 0);

        }
    }
}
