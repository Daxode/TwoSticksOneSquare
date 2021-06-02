using BenchmarkDotNet.Attributes;
using Xunit;

namespace Codeility {
    public class Benchmarker {
        private static readonly int[,] Data = {
            {10,21,7},
            {13,11,5},
            {2,1,0},
            {1,8,2},
            {100,30,30},
            {10000,3000,3000},
            {1000000,300000,300000},
            {2000000,600000,600000},
            {int.MaxValue, 1, 536870911}
        };
        
        [Benchmark(Baseline = true)]
        [Fact]
        public void SolutionRunnerNaive() {
            var res = 0;

            for (var i = 0; i < Data.GetLength(0); i++) {
                res += TwoSticksOneSquare.Naive(Data[i,0],Data[i,1])-Data[i,2];
            }
            
            Assert.Equal(0,res);
        }
        
        [Benchmark]
        [Fact]
        public void SolutionRunnerBetterRange() {
            var res = 0;

            for (var i = 0; i < Data.GetLength(0); i++) {
                res += TwoSticksOneSquare.BetterRange(Data[i,0],Data[i,1])-Data[i,2];
            }
            
            Assert.Equal(0,res);
        }
        
        [Benchmark]
        [Fact]
        public void SolutionRunnerBetterSearch() {
            var res = 0;

            for (var i = 0; i < Data.GetLength(0); i++) {
                res += TwoSticksOneSquare.BetterSearch(Data[i,0],Data[i,1])-Data[i,2];
            }
            
            Assert.Equal(0,res);
        }
        
        
        [Benchmark]
        [Fact]
        public void SolutionRunnerBetterSearchAndRange() {
            var res = 0;

            for (var i = 0; i < Data.GetLength(0); i++) {
                res += TwoSticksOneSquare.BetterSearchAndRange(Data[i,0],Data[i,1])-Data[i,2];
            }
            
            Assert.Equal(0,res);
        }
    }
}