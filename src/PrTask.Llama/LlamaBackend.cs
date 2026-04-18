using System.Runtime.InteropServices;

namespace PrTask.Llama;

public static class LlamaBackend
{
    public static void Init()
    {
        NativeMethods.llama_backend_init();
    }

    public static void Free()
    {
        NativeMethods.llama_backend_free();
    }

    public static string GetSystemInfo()
    {
        var Ptr = NativeMethods.llama_print_system_info();
        return Ptr == nint.Zero ? string.Empty : Marshal.PtrToStringUTF8(Ptr) ?? string.Empty;
    }

    public static long TimeUs()
    {
        return NativeMethods.llama_time_us();
    }

    public static nuint MaxDevices()
    {
        return NativeMethods.llama_max_devices();
    }

    public static bool SupportsMmap()
    {
        return NativeMethods.llama_supports_mmap();
    }

    public static bool SupportsMlock()
    {
        return NativeMethods.llama_supports_mlock();
    }

    public static bool SupportsGpuOffload()
    {
        return NativeMethods.llama_supports_gpu_offload();
    }

    public static void SuppressLog()
    {
        NativeMethods.llama_log_set(nint.Zero, nint.Zero);
    }
}
