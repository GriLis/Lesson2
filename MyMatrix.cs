using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2809
{
    class MyMatrix
    {
        public int[,] matrix;

        public MyMatrix(int strok, int stolb)
        {
            matrix = new int[strok, stolb];
        }

        public static MyMatrix operator+(MyMatrix m1, MyMatrix m2)
        {
            MyMatrix m3 = new MyMatrix(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m1.matrix.GetLength(1); j++)
                {
                    m3.matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
                }
            }

            return m3;
        }
        public static MyMatrix operator*(MyMatrix m1, MyMatrix m2)
        {
            MyMatrix m3 = new MyMatrix(m1.matrix.GetLength(0), m2.matrix.GetLength(1));

            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m2.matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < m1.matrix.GetLength(1); k++)
                        m3.matrix[i, j] += m1.matrix[i, k] * m2.matrix[k, j];
                }
            }

            return m3;
        }

        public static MyMatrix operator! (MyMatrix m)
        {
            MyMatrix m3 = new MyMatrix(m.matrix.GetLength(1), m.matrix.GetLength(0));

            for (int i = 0; i < m.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m.matrix.GetLength(1); j++)
                {
                    m3.matrix[j, i] = m.matrix[i, j];
                }
            }

            return m3;
        }
    }
}
