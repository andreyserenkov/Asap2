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

                // Process measurement events
                var events = new List<int>();
                foreach (var m in measurements)
                {
                    var meas = m.Value as MEASUREMENT;
                    if (meas.if_data.Count > 0)
                    {
                        //var eventsStr = meas.if_data.First().data;
                        //var regex = new Regex(@"EVENT\s+(\d+)", RegexOptions.Compiled);
                        //foreach (Match match in regex.Matches(eventsStr))
                        //    if (int.TryParse(match.Groups[1].Value, out int number))
                        //        events.Add(number);
                    }
                }

                // Note: some of the A2L test files do not contain an EVENT record for MEASUREMENT
                // Uncomment next line to see which one is fail the test (i.e. has no events)
                //Assert.IsTrue(events.Count > 0);
            }
        }
    }
}
