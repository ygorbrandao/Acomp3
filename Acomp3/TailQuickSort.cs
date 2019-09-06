using System;

namespace Acomp3
{
    class TailQuickSort : IQuickSort
    {
        public int Part(int[] E, int left, int right)
        {
            int c = E[right]; //pivô
            int t, j = left;
            for (int k = left; k < right; k++)
            {
                if (E[k] <= c)
                {
                    t = E[j];
                    E[j] = E[k];
                    E[k] = t;
                    j++;
                }
            }
            t = E[j];
            E[j] = E[right];
            E[right] = t;
            return j;
        }

        public void Sort(int[] E, int left, int right)
        {
            while (left < right)
            {
                int j = Part(E, left, right);
                if (j - left < right - j)
                {
                    Sort(E, left, j - 1);
                    left = j + 1;
                }
                else
                {
                    Sort(E, j + 1, right);
                    right = j - 1;
                }
            }
        }

        public void Sort(int[] E, int n)
        {
            Sort(E, 0, n - 1);
        }
    }
}