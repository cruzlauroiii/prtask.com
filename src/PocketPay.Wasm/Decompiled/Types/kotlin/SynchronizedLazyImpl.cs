namespace WillowMaze.Wasm.Decompiled;

public class SynchronizedLazyImpl : Lazy<object>, Object
{
    private object _value;
    private Func<object> Initializer;
    private readonly object Lock;

    public static void CFkEUyovqZrFsPdV(object P0)
    {
        // call: Intrinsics.checkNotNull
    }

    public static void CFkEUyovqZrFsPdV(object P0, int P1, string P2, bool P3, char P4)
    {
    }

    public static void CFkEUyovqZrFsPdV(object P0, string P1, int P2, bool P3, char P4)
    {
    }

    public static void CFkEUyovqZrFsPdV(object P0, bool P1, int P2, string P3, char P4)
    {
    }

    public static void NOCpEwRjxEHqoZUd(SynchronizedLazyImpl P0, byte P1, short P2, char P3, bool P4)
    {
    }

    public static void NOCpEwRjxEHqoZUd(SynchronizedLazyImpl P0, byte P1, bool P2, char P3, short P4)
    {
    }

    public static void NOCpEwRjxEHqoZUd(SynchronizedLazyImpl P0, char P1, short P2, bool P3, byte P4)
    {
    }

    public static bool NOCpEwRjxEHqoZUd(SynchronizedLazyImpl P0)
    {
        // call: SynchronizedLazyImpl.isInitialized
        return false;
    }

    public static object TArlNWcEHXXKzVFh(Func<object> P0)
    {
        // call: Func<object>.invoke
        return default!;
    }

    public static void TArlNWcEHXXKzVFh(Func<object> P0, string P1, char P2, short P3, byte P4)
    {
    }

    public static void TArlNWcEHXXKzVFh(Func<object> P0, short P1, byte P2, char P3, string P4)
    {
    }

    public static void TArlNWcEHXXKzVFh(Func<object> P0, short P1, byte P2, string P3, char P4)
    {
    }

    public static object WrZjPpWexffXLeTY(SynchronizedLazyImpl P0)
    {
        // call: SynchronizedLazyImpl.getValue
        return default!;
    }

    public static void WrZjPpWexffXLeTY(SynchronizedLazyImpl P0, byte P1, char P2, string P3, int P4)
    {
    }

    public static void WrZjPpWexffXLeTY(SynchronizedLazyImpl P0, byte P1, string P2, char P3, int P4)
    {
    }

    public static void WrZjPpWexffXLeTY(SynchronizedLazyImpl P0, string P1, byte P2, char P3, int P4)
    {
    }

    public static string MmyrKUDMVLjdpXhg(object P0)
    {
        // call: string.valueOf
        return string.Empty;
    }

    public static void MmyrKUDMVLjdpXhg(object P0, char P1, float P2, short P3, string P4)
    {
    }

    public static void MmyrKUDMVLjdpXhg(object P0, string P1, float P2, short P3, char P4)
    {
    }

    public static void MmyrKUDMVLjdpXhg(object P0, short P1, float P2, char P3, string P4)
    {
    }

    public static object VQqzQpXMGAYRtoay(SynchronizedLazyImpl P0)
    {
        // call: SynchronizedLazyImpl.getValue
        return default!;
    }

    public static void VQqzQpXMGAYRtoay(SynchronizedLazyImpl P0, float P1, short P2, bool P3, string P4)
    {
    }

    public static void VQqzQpXMGAYRtoay(SynchronizedLazyImpl P0, string P1, short P2, bool P3, float P4)
    {
    }

    public static void VQqzQpXMGAYRtoay(SynchronizedLazyImpl P0, short P1, string P2, bool P3, float P4)
    {
    }

    public static void WbCYYTzvjulWhsgH(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void WbCYYTzvjulWhsgH(object P0, string P1, int P2, short P3, bool P4, string P5)
    {
    }

    public static void WbCYYTzvjulWhsgH(object P0, string P1, short P2, int P3, string P4, bool P5)
    {
    }

    public static void WbCYYTzvjulWhsgH(object P0, string P1, bool P2, string P3, short P4, int P5)
    {
    }

    private object WriteReplace()
    {
        // call: SynchronizedLazyImpl.vQqzQpXMGAYRtoay
        // call: InitializedLazyImpl.<init>
        // type: InitializedLazyImpl
        return default!;
    }

    private void WriteReplace(byte P0, bool P1, char P2, int P3)
    {
    }

    private void WriteReplace(bool P0, byte P1, char P2, int P3)
    {
    }

    private void WriteReplace(bool P0, int P1, byte P2, char P3)
    {
    }

    public object GetValue()
    {
        // call: SynchronizedLazyImpl.CFkEUyovqZrFsPdV
        // call: SynchronizedLazyImpl.TArlNWcEHXXKzVFh
        // field: kotlin.SynchronizedLazyImpl._value
        // field: kotlin.UNINITIALIZED_VALUE.INSTANCE
        // field: kotlin.SynchronizedLazyImpl.initializer
        // field: kotlin.SynchronizedLazyImpl.lock
        return default!;
    }

    public bool IsInitialized()
    {
        // field: kotlin.UNINITIALIZED_VALUE.INSTANCE
        // field: kotlin.SynchronizedLazyImpl._value
        return false;
    }

    public string ToString()
    {
        // str: "Lazy value not initialized yet."
        // call: SynchronizedLazyImpl.NOCpEwRjxEHqoZUd
        // call: SynchronizedLazyImpl.mmyrKUDMVLjdpXhg
        // call: SynchronizedLazyImpl.WrZjPpWexffXLeTY
        return string.Empty;
    }

}
