using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Matrix
    {
        
        public Matrix(int rows, int cols)
        {
            
                MRows = rows;
                MCols = cols;
                MArray = new int[MRows, MCols];
           
        }
    
        public static void PopulateRandom(Matrix m)
        {
            if(m.MArray == null) throw new ApplicationException("ERROR: Matrix doesn't exist");
            Random rnd = new Random();
            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    int temp = rnd.Next(0, 1000);
                    m.MArray[i, j] = temp;
                }
            }
        }

        
        
        public static void DebugPrint(Matrix m)
        {
            StringBuilder sb = new StringBuilder();
            if(m.MArray == null) throw new ApplicationException("ERROR: Matrix doesn't exist");
            Random rnd = new Random();
            for (int i = 0; i < m.MRows; i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < m.MCols; j++)
                {
                    sb.Append(m.MArray[i,j] + " ");
                }
                sb.Append("] \n");
            }

            MessageBox.Show(sb.ToString());
        }
    
        //overriden operators 
        public static Matrix operator +(Matrix m, Matrix z)
        {
            
            
        
            Matrix result = new Matrix(m.MRows, m.MCols);

            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    result.MArray[i, j] = m.MArray[i, j] + z.MArray[i, j];
                }
            }

            return result;
        }
    
        public static Matrix operator -(Matrix m, Matrix z)
        {
        
            Matrix result = new Matrix(m.MRows, m.MCols);

            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    result.MArray[i, j] = m.MArray[i, j] - z.MArray[i, j];
                }
            }

            return result;
        }
    
        public static Matrix operator *(Matrix m, int n)
        {
           
        
            Matrix result = new Matrix(m.MRows, m.MCols);

            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    result.MArray[i, j] = m.MArray[i, j] * n;
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m, Matrix z)
        {
            
            Matrix result = new Matrix(m.MRows, z.MCols);
        
            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < z.MCols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m.MCols; k++)
                    {
                        sum += m.MArray[i, k] * z.MArray[k, j];
                    }
                    result.MArray[i, j] = sum;
                }
            }
        
            return result;
        }

        public static bool operator ==(Matrix m, Matrix z)
        {
            if (!(m.MRows == z.MRows && m.MCols == z.MCols)) return false;
       
            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    if (m.MArray[i, j] != z.MArray[i, j]) return false;
                }
            }
        
            return true;
        }

        public static bool operator !=(Matrix m, Matrix z)
        {
            return !(m == z);
        }
    
    

        /*public static void DebugPopulate(Matrix m, int n)
        {
            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    m.MArray[i, j] = n;
                }
            }
        }*/
    
        public static void Zero(Matrix m)
        {
            for (int i = 0; i < m.MRows; i++)
            {
                for (int j = 0; j < m.MCols; j++)
                {
                    m.MArray[i, j] = 0;
                }
            }
        }

        public int MRows;
        public int MCols;
        public int[,] MArray;
    }
}