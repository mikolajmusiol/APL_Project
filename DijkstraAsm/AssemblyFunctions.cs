using System.Runtime.InteropServices;

namespace DijkstraAsm;

public static class AssemblyFunctions
{
    [DllImport("../../../../../x64/Debug/JADll.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int MyProc1(int arr, int vert, int start, int end);
}
