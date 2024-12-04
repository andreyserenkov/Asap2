using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    public class Startup
    {
        private static readonly Dictionary<string, Stream> resStreams = new Dictionary<string, Stream>();
        public static List<Stream> a2lStreams => resStreams.Where(r => r.Key.IndexOf(".a2l", StringComparison.OrdinalIgnoreCase) > 0).Select(r => r.Value).ToList();
        public static List<Stream> dbcStreams => resStreams.Where(r => r.Key.IndexOf(".dbc", StringComparison.OrdinalIgnoreCase) > 0).Select(r => r.Value).ToList();

        [TestClass]
        public class Initialize
        {
            [AssemblyInitialize]
            public static void AssemblyInitialize(TestContext context)
            {
                // Load binary resources to the dictionary as MemoryStreams
                var executingAssembly = Assembly.GetExecutingAssembly();
                var resNames = executingAssembly.GetManifestResourceNames();

                foreach (var resName in resNames)
                {
                    using (var resStream = executingAssembly.GetManifestResourceStream(resName))
                    {
                        if (resStream != null)
                        {
                            var memStream = new MemoryStream();
                            resStream.CopyTo(memStream);
                            memStream.Position = 0;
                            resStreams[resName] = memStream;
                        }
                    }
                }
            }
        }
    }
}
