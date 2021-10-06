using Log.Interfaces;

namespace Log.Derived
{
    public class FileLog : LogBase, ILog
    {
        public void Log(string message)
        {
            // write to text file
            var debugger = 0;
        }
    }
}
