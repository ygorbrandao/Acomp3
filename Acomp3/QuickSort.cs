using System;

namespace Acomp3
{
    class QuickSort : IQuickSort
    {
        public int Part(int[] E, int left, int right)
        {
            //int separa(int v[], int p, int r)
            //{
            int c = E[right]; // pivô
            int t, j = left;
            for (int k = left; k < right; ++k)
            {
                if (E[k] <= c)
                {
                    t = E[j];
                    E[j] = E[k];
                    E[k] = t;
                    ++j;
                }
            }
            t = E[j];
            E[j] = E[right];
            E[right] = t;

            return j;

        }

        public void Sort(int[] E, int left, int right)
        {
            // void quicksort(int v[], int p, int r)

            if (left < right)
            {                   // 1
                int j = Part(E, left, right);   // 2
                Sort(E, left, j - 1);      // 3
                Sort(E, j + 1, right);      // 4
            }

        }

        public void Sort(int[] E, int n)
        {
            Sort(E, 0, n - 1);
        }
    }
}
