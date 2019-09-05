namespace Acomp3
{
    class QuickSort : IQuickSort
    {
        public int Part(int[] E, int left, int right)
        {
            int c = E[right];
            int t, j = left;
            for (int i = left; i < right; i++)
            {
                if (E[i] <= c)
                {
                    t = E[j]; E[j] = E[i]; E[i] = t; ++j;
                }
            }
            t = E[j]; E[j] = E[right]; E[right] = t;
            return j;
        }

        public void Sort(int[] E, int left, int right)
        {
            if (left < right)
            {
                int q = Part(E, left, right);
                Sort(E, left, q - 1);
                Sort(E, q + 1, right);
            }
        }

        public void Sort(int[] E, int n)
        {
            Sort(E, 0, n-1);
        }
    }
}
