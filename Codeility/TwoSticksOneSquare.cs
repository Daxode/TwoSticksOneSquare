using System;
using BenchmarkDotNet.Attributes;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Codeility {
    public static class TwoSticksOneSquare {
        public static int Naive(in int A, in int B) {
            var max = Math.Max(A, B);

            for (var i = max; i > 0; i--) {
                var stickCount = (A/i)+(B/i);
                //Console.WriteLine($"A{A} A4{A/4} B{B} B4{B/4} I{i} S{stickCount}");
                if (stickCount > 3) return i;
            }
            
            return 0;
        }
        
        public static int BetterRange(in int A, in int B) {
            var max = (A/4)+(B/4);
            var min = Math.Min(A/4, B/4);

            for (var i = max; i > min; i--) {
                var stickCount = (A/i)+(B/i);
                if (stickCount > 3) return i;
            }
            
            return 0;
        }
        
        public static int BetterSearch(in int A, in int B) {
            if ((long)A + (long)B < 4) return 0;
            var max = Math.Max(A, B);
            var min = 0;
            
            while (max-min>1) {
                var stickLength = (max + min) / 2;
                var stickCount = A/stickLength + B/stickLength;
                
                if (stickCount < 4) max = stickLength;
                else min = stickLength;
            }
            
            return min;
        }
        
        public static int BetterSearchAndRange(in int A, in int B) {
            if ((long)A + (long)B < 4) return 0;
            
            var max = Math.Max(A, B);
            var min = Math.Min(A/4, B/4);
            
            while (max-min>1) {
                var stickLength = (max + min) / 2;
                var stickCount = A/stickLength + B/stickLength;
                
                if (stickCount < 4) max = stickLength;
                else min = stickLength;
            }
            
            return min;
        }
    }
}