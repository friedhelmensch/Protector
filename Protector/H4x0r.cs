using System.Runtime.InteropServices;

namespace Protector
{
    class H4x0r
    {
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

    }
}
