namespace Acomp3
{
    class TailQuickSort : QuickSort
    {
        public new void Sort(int[] E, int left, int right)
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
    }
}
