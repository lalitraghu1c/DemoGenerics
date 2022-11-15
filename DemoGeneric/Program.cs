using System;
namespace DemoGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
            GenericOperation genericOperation = new GenericOperation();
            /*genericOperation.ToPrintArray(intArr);
            genericOperation.ToPrintArray(doubleArr);
            genericOperation.ToPrintArray(charArr);*/
            genericOperation.ToPrintArray<int>(intArr);
            genericOperation.ToPrintArray<double>(doubleArr);
            genericOperation.ToPrintArray<char>(charArr);

        }
    }
}