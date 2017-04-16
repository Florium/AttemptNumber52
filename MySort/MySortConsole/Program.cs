using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            int len = 9;                                    //length of array
            int[] Mas = new int[len];
            Mas[0] = 3;                                     //array
            Mas[1] = 2;
            Mas[2] = 4;
            Mas[3] = 1;
            Mas[4] = 7;
            Mas[5] = 9;
            Mas[6] = 8;
            Mas[7] = 6;
            Mas[8] = 5; 
            MySortConsole.Program j = new MySortConsole.Program();
            Mas = j.Magic(Mas, len);
            for (i = 0; i < len; i++)                       //output array to console
            {
                Console.Write(Mas[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public int[] Magic(int[] mas, int len)              //sorting method
        {
            int i; int p; int n1; int n2; int n3; int n4; int j; int s; int d; int k;
            int[] mas2 = new int[len];
            for (p = 0; p < len-1; p++)
            {
                for (i = 0; i < len-1; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        n1 = i + 1;                         //setting labels n1, n2, n3, n4 in an array
                        n2 = i + 1;
                        for (j = n1+1; j < len; j++)
                        {
                            if (mas[i] > mas[j])
                            {
                                n2++;
                            }
                            else j = len;
                        }
                        n3 = i;
                        n4 = i;
                        for (j = n4 - 1; j > - 1; j--)
                        {
                            s = 0;
                            for (k = n1; k <n2+1; k++)
                            {
                                if (mas[k] <= mas[j])
                                {
                                    s++;
                                }
                                else k = len;
                            }
                            if (s == n2 - n1 + 1)
                            {
                                n3--;
                            }
                            else j = -1;
                        }
                        for (d = 0; d < n3; d++)            //sorting
                        {
                            mas2[d] = mas[d];
                        }
                        s = 0;
                        for (d = n3; d < n3+n2-n1+1; d++)
                        {
                            mas2[d] = mas[n1+s];
                            s++;
                        }
                        s = 0;
                        for (d = n3 + n2 - n1+1; d < n2+1; d++)
                        {
                            mas2[d] = mas[n3 + s];
                            s++;
                        }
                        s = 0;
                        for (d = n2+1; d < len; d++)
                        {
                            mas2[d] = mas[d];
                            s++;
                        }
                        for (d = 0; d < len; d++)
                        {
                            mas[d] = mas2[d];
                        }
                    }
                }
            }
            return mas;                                     //result
            throw new NotImplementedException();
        }
    }
}
