using System;

namespace Multidimensionales_G2_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,,] miArregloCaracteres = {{{ 'a', 'b','c' }, {'d', 'e', 'f'} }, { { 'g', 'h','i' }, { 'j', 'k', 'l' }}};
            Console.WriteLine(miArregloCaracteres[1,1,2]);
            Console.ReadLine();
        }
    }
}
