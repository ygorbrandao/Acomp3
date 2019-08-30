namespace Acomp3
{
    interface IQuickSort : ISort
    {
        int Part(int[] E, int left, int right);
        void Sort(int[] E, int left, int right);
    }
}
