using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.NasyrovaVR.Sprint6.TaskReview.V26.Lib
{
    public class DataService
    {
        public int GetMatrix(int [,] array , int c, int k, int l)
        {
            
            int p = 1;

            for (int j = k; j <= l; j++)
            {
                if (array[c,j] % 2 != 0)
                {
                    p = array[c,j] * p;
                }
                
            }


            return p;
        }
    }
}
