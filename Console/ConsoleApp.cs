using System;
using System.Runtime.InteropServices;

namespace ConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            var hr = CoInitializeSecurity(IntPtr.Zero, -1, IntPtr.Zero, IntPtr.Zero, 0, 3, IntPtr.Zero, 0x20, IntPtr.Zero);
            if (hr != 0) {
                Console.WriteLine($"Cannot Complete CoInitializeSecurity. - {new System.ComponentModel.Win32Exception(hr).Message}");
            } else {
                Console.WriteLine($"CoInitializeSecurity worked just fine");
            }
            Console.ReadKey();
        }

        [DllImport("ole32.dll", CharSet = CharSet.Unicode)]
        public static extern int CoInitializeSecurity(IntPtr pVoid, int cAuthSvc, IntPtr asAuthSvc, IntPtr pReserved1, uint level, uint impers, IntPtr pAuthList, uint dwCapabilities, IntPtr pReserved3);
    }
}
