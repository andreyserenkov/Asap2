using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asap2;

namespace UnitTest
{
    /// <summary>
    /// Tests covering A2L file parser
    /// </summary>
    [TestClass]
    public class A2LFileTests
    {
        [TestMethod]
        public void A2LParserTest()
        {
            int i = 1;
            foreach (var item in Startup.a2lStreams)
            {
                Debug.WriteLine($"Processing file {i++}.a2l");

                var errorHandler = new ErrorHandler();
                var parser = new Parser(item, errorHandler);

                var tree = parser.DoParse();
                Assert.IsNotNull(tree);
                var project = tree.elements.Last() as PROJECT;
                Assert.IsNotNull(project);
                var module = project.modules.FirstOrDefault();
                Assert.IsNotNull(module);
                var measurements = module.Value.AxisPtsCharacteristicMeasurement.Where(c => c.Value is MEASUREMENT).ToList();
                Assert.IsNotNull(measurements);
                Assert.IsTrue(measurements.Count > 0);
                var compuMethods = module.Value.CompuMethods.ToList();
                Assert.IsNotNull(compuMethods);
                Assert.IsTrue(compuMethods.Count > 0);

                // Check DAQ events; note: we should skip files 5 and 6 - there are no DAQ events on these files
                if (i < 5)
                {
                    var events = measurements
                        .SelectMany(m => (m.Value as MEASUREMENT)?.if_data)
                        .Where(ifData => ifData.daq_event != null)
                        .Select(ifData => ifData.daq_event)
                        .ToList();
                    Assert.IsTrue(events.Count > 0);
                }
            }
        }
    }
}
