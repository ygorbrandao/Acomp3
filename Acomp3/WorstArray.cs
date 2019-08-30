namespace Acomp3
{
    public class WorstArray
    {
        public int[] Array;
        public WorstArray(int n)
        {
            Array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Array[i] = (n-i);
            }
        }
    }
}
