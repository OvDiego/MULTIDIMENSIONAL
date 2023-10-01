using System;


namespace FormMultidimensional
{
    internal class Matriz
    {
        private int m;
        private int n;

        public int M
        {
            get => m;
            set
            {
                if (value < 0)
                {
                    m = 2;
                }
                else
                {
                    m = value;
                }
            }
        }
        public int N 
        { 
            get => n;
            set
            {
                if (value < 0)
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
            }
        }
    }
}
