using BenchmarkDotNet.Attributes;
using BenchmarkSampleAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkSampleTests
{
    // By default will show execution time
    // The memory diagnoser supports the additional measurement of allocations and GC collections which can be extremely helpful when optimising code.

    [MemoryDiagnoser]
    public class PrivacyEndpointTest
    {
        /// <summary>
        /// Don’t want to include these within the Benchmark method itself since, want 
        /// to measure the performance and allocations of the Privacy endpoint in isolation.
        /// </summary>
        private const string FullName = "Steve J Gordon";
        private static readonly HomeController controller = new HomeController();

        [Benchmark(Baseline = true)] // TODO don't fully understand what the baseline does
        public void PrivacyEndpoint()
        {
            controller.Privacy(FullName);
        }
    }
}
