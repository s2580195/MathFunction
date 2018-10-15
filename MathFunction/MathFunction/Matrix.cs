using System;
using System.Diagnostics;

namespace MathFunction
{
    public class Matrix
    {
        

        public int Row {
            get { return Data.Rank; }
        }

        public int Col {
            get { return Data.GetLength(0); }
        }

        public float[,] Data;
        public Matrix(float[,] data)
        {
            Debug.Assert(data!=null);
            Data = data;
        }
        
        public static Matrix Multiple(Matrix a, Matrix b)
        {
            if (a == null || b == null)
            {
                Util.Error("input matrics can NOT be null");
                return null;
            }
            else if(a.Col!=b.Row)
            {
                Util.Error("invalid input of Matrics Multiplication");
                return null;
            }
            else
            {
                var ret = new Matrix(new float[a.Row,a.Col]);
                for (int i = 0; i < a.Row; i++)
                {
                    for (int j = 0; j < b.Col; j++)
                    {
                        float sum = 0;
                        for (int k = 0; k < a.Col; k++)
                        {
                            sum += a.Data[i, k] * b.Data[k,j];
                        }
                        ret.Data[i, j] = sum;
                    }
                }
                return ret;
            }
        }

        public override string ToString()
        {
            var str = "";
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    str += Data[i, j] + '\t';
                }
                str += '\n';
            }
            return str;
        }
    }
    
    
}