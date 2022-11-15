using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    public class GenericOperation
    {
        public void ToPrintArray<T>(T[] intArr)// we are using single method for multiple datatypes using Generic
        {
            foreach (var data in intArr)
            {
                Console.WriteLine(data);
            }

            /*public void ToPrintArray(int[] intArr)
            {
                foreach (var data in intArr)
                {
                    Console.WriteLine(data);
                }
            }
            public void ToPrintArray(double[] intArr)
            {
                foreach (var data in intArr)
                {
                    Console.WriteLine(data);
                }
            }
            public void ToPrintArray(char[] intArr)
            {
                foreach (var data in intArr)
                {
                    Console.WriteLine(data);
                }
            }*/
        }
    }
}