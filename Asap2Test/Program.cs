#define TRACE_ACTIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Asap2;
using System.Text.RegularExpressions;

namespace Asap2Test
{
    class Program
    {

        static void Main(string[] args)
        {
            var errorHandler = new ErrorHandler();
            //var parser = new Asap2.Parser("../../../FCR-21_Dev.A2L", errorHandler);
            var parser = new Asap2.Parser("../../../UnitTest/TestData/GDI-2.A2L", errorHandler);
            Asap2.FileComment comment = new Asap2.FileComment(Environment.NewLine + "A2l file for testing ASAP2 parser." + Environment.NewLine, true);
            Asap2.Asap2File tree = parser.DoParse();
            if (tree != null)
            {
                var project = tree.elements.Last() as PROJECT;
                var module = project.modules.FirstOrDefault();
                var measurements = module.Value.AxisPtsCharacteristicMeasurement.Where(c => c.Value is MEASUREMENT).ToList();


                var compuMethods = module.Value.CompuMethods.ToList();

                var airTemp = measurements[2].Value as MEASUREMENT;
                var airTempCompuMethod = compuMethods.Where(cm => cm.Key.Equals(airTemp.Conversion)).FirstOrDefault().Value;

                var if_data = airTemp.if_data.First();

                var events = if_data.daq_event;
                Console.WriteLine(events.eventid);

            }
            Console.ReadLine();
        }
    }
}
