using System.Diagnostics;

namespace Asap2
{
    public class ErrorHandler : IErrorReporter
    {
        public ErrorHandler()
        {
            informations = 0;
            warnings = 0;
            errors = 0;
        }

        public uint informations { private set; get; }
        public uint warnings { private set; get; }
        public uint errors { private set; get; }
        public void reportError(string message)
        {
            errors++;
            Debug.WriteLine($"Error{message}");
        }

        public void reportWarning(string message)
        {
            warnings++;
            Debug.WriteLine($"Warning{message}");
        }

        public void reportInformation(string message)
        {
            informations++;
            Debug.WriteLine($"Info{message}");
        }
    }
}
