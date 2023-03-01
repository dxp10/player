using System.Runtime.InteropServices;

namespace Music
{
    class InternetConnection
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValuine);
        public static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out int desc, 0);
        }
    }
}
