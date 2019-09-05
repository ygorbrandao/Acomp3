namespace Acomp3
{
    interface IHeapSort : ISort
    {
        void Heap(int[] E, int n);
        void Heapify(int[] E, int n, int i);
    }
}
