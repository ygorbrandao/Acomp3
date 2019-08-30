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

            [Params(100, 1000, 10000)]
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
            public void RandomTailQuickSortTest()
            {
                (new TailQuickSort()).Sort(new RandomArray(N).Array, N);
            }

            [Benchmark]
            public void WorstTailQuickSortTest()
            {
                (new TailQuickSort()).Sort(new WorstArray(N).Array, N);
            }

        }

        [Fact]
        public static void QuickSortTest()
        {
            int[] A = new RandomArray(10).Array;
            int[] B = (int[])A.Clone();
            new QuickSort().Sort(B, 10);
            Assert.True(A.OrderBy(i => i).ToArray().SequenceEqual(B));
        }

        [Fact]
        public static void TailQuickSortTest()
        {
            int[] A = new RandomArray(10).Array;
            int[] B = (int[])A.Clone();
            new TailQuickSort().Sort(B, 10);
            Assert.True(A.OrderBy(i => i).ToArray().SequenceEqual(B));
        }
        
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
            Console.Read();
        }
    }
}
