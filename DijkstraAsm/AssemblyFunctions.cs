using System.Runtime.InteropServices;

namespace DijkstraAsm;

public static class AssemblyFunctions
{
    [DllImport("../../../../../x64/Debug/JADll.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern Int64 MyProc1(Int64[] arr, int vert, int src, int end);
}
