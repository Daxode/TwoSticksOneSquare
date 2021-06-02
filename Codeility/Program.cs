using BenchmarkDotNet.Running;

namespace Codeility {
    internal class Program {
        public static void Main(string[] args) {
            BenchmarkRunner.Run<Benchmarker>();
        }
    }
}