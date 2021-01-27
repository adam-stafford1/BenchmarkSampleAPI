using BenchmarkDotNet.Running;
using System;

namespace BenchmarkSampleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PrivacyEndpointTest>();
        }
    }
}
