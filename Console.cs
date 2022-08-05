using System;

namespace DebugTools
{
    public static class DebugConsole
    {
        public static void WriteToConsole(string message)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine(message);
#endif
            System.Console.WriteLine(message);

        }
    }
}
