using System;
using System.Runtime.Remoting.Messaging;

namespace FormMultidimensional
{
    //Hay que heredar.
    internal class Multidimensional : Matriz
    {
        float[,] A;

        public Multidimensional(int M, int N)
        {
            //this pq vienen de matriz
            this.N = N;
            this.M = M;
            A = new float[this.M, this.N];

        }
        //static para no alterar valores
        public static Multidimensional Leer(string A)
        {
            //Matriz A ingresada
            //1,2;3,4 Matriz ingresada Ejemplo

            string[] renglones = A.Split(';');

            //renglones [0] = 1,2
            //renglones [1] = 3,4

            string[] columnas = renglones[0].Split(',');

            Multidimensional m1 = new Multidimensional(renglones.Length, columnas.Length);

            for (int i = 0; i < m1.M; i++)
            {
                columnas = renglones[i].Split(',');
                for (int j = 0; j < m1.N; j++)
                {
                    m1.A[i, j] = float.Parse(columnas[j]);
                }
            }

            return m1;

        }

        public static Multidimensional operator +(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);

            for(int i = 0; i< m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }
            return m3;
        }
        #region Resta
        public static Multidimensional operator -(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);

            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] - m2.A[i, j];
                }
            }
            return m3;
        }
        #endregion

        #region MULTIPLICACIÓN
        public static Multidimensional operator *(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);

            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m2.N; j++)
                {
                    for (int k = 0; k < m1.N; k++)
                    {
                        m3.A[i, j] += m1.A[i, k] * m2.A[k, j];
                    }
                }
            }
            return m3;
        }
        #endregion

        #region SENO
        public static Multidimensional operator ~(Multidimensional m3)
        {
            Multidimensional m4 = new Multidimensional(m3.M, m3.N);

            for (int i = 0; i < m3.M; i++)
            {
                for (int j = 0; j < m3.N; j++)
                {
                    m4.A[i, j] = (float)Math.Sin(m3.A[i, j]);
                }
            }

            return m4;
        }
        #endregion


        public override string ToString()
        {
            // 1 2
            // 3 4

            string A = "";

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A = A + " " + this.A[i, j].ToString();
                }
                A += "\n";
            }

            return A;
        }


    }
}
