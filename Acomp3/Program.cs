using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Linq;
using Xunit;

namespace Acomp3
{
    public class Program
    {

        public class Tests
        {

            [Params(1000, 10000)]
            public int N { get; set; }

            [Benchmark]
            public void RandomQuickSortTest()
            {
                (new QuickSort()).Sort(new RandomArray(N).Array, N);
            }

            [Benchmark]
            public void WorstQuickSortTest()
            {
                (new QuickSort()).Sort(new WorstArray(N).Array, N);
            }

            [Benchmark]
            public void RandomHeapSortTest()
            {
                (new HeapSort()).Sort(new RandomArray(N).Array, N);
            }

            [Benchmark]
            public void WorstHeapSortTest()
            {
                (new HeapSort()).Sort(new WorstArray(N).Array, N);
            }

        }

        [Fact]
        public static void HeapSortTest()
        {
            int[] A = new RandomArray(10).Array;
            int[] B = (int[])A.Clone();
            new HeapSort().Sort(B, 10);
            Assert.True(A.OrderBy(i => i).ToArray().SequenceEqual(B));
        }
        
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
            Console.Read();
        }
    }
}
