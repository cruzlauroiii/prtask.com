namespace WillowMaze.Wasm.Decompiled;

public class UIntArray_Iterator : IEnumerator<object>, KMappedMarker
{
    private readonly int[] Array;
    private int Index;

    public static void LOhbKtjJLjgeaFVU(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void LOhbKtjJLjgeaFVU(object P0, string P1, char P2, float P3, short P4, byte P5)
    {
    }

    public static void LOhbKtjJLjgeaFVU(object P0, string P1, float P2, short P3, byte P4, char P5)
    {
    }

    public static void LOhbKtjJLjgeaFVU(object P0, string P1, short P2, float P3, char P4, byte P5)
    {
    }

    public static string NjkZDYdUqvsTvtqd(int P0)
    {
        // call: string.valueOf
        return string.Empty;
    }

    public static void NjkZDYdUqvsTvtqd(int P0, int P1, bool P2, short P3, float P4)
    {
    }

    public static void NjkZDYdUqvsTvtqd(int P0, short P1, bool P2, float P3, int P4)
    {
    }

    public static void NjkZDYdUqvsTvtqd(int P0, bool P1, short P2, int P3, float P4)
    {
    }

    public static int CcjzppwWIJyPheHI(int P0)
    {
        // call: UInt.constructor-impl
        return 0;
    }

    public static void CcjzppwWIJyPheHI(int P0, char P1, byte P2, int P3, bool P4)
    {
    }

    public static void CcjzppwWIJyPheHI(int P0, int P1, byte P2, char P3, bool P4)
    {
    }

    public static void CcjzppwWIJyPheHI(int P0, bool P1, byte P2, int P3, char P4)
    {
    }

    public static int FSXSlzAYGdfQBAVY(UIntArray$Iterator P0)
    {
        // call: UIntArray$Iterator.next-pVg5ArA
        return 0;
    }

    public static void FSXSlzAYGdfQBAVY(UIntArray$Iterator P0, byte P1, float P2, bool P3, short P4)
    {
    }

    public static void FSXSlzAYGdfQBAVY(UIntArray$Iterator P0, bool P1, byte P2, float P3, short P4)
    {
    }

    public static void FSXSlzAYGdfQBAVY(UIntArray$Iterator P0, bool P1, byte P2, short P3, float P4)
    {
    }

    public static UInt WiigvmBRlFcbbvJR(int P0)
    {
        // call: UInt.box-impl
        return default!;
    }

    public static void WiigvmBRlFcbbvJR(int P0, char P1, short P2, string P3, float P4)
    {
    }

    public static void WiigvmBRlFcbbvJR(int P0, float P1, short P2, string P3, char P4)
    {
    }

    public static void WiigvmBRlFcbbvJR(int P0, short P1, float P2, string P3, char P4)
    {
    }

    public bool HasNext()
    {
        // field: kotlin.UIntArray$Iterator.array
        // field: kotlin.UIntArray$Iterator.index
        return false;
    }

    public object Next()
    {
        // call: UIntArray$Iterator.fSXSlzAYGdfQBAVY
        // call: UIntArray$Iterator.wiigvmBRlFcbbvJR
        return default!;
    }

    public int Next-pVg5ArA()
    {
        // call: UIntArray$Iterator.ccjzppwWIJyPheHI
        // call: UIntArray$Iterator.NjkZDYdUqvsTvtqd
        // call: NoSuchElementException.<init>
        // field: kotlin.UIntArray$Iterator.index
        // field: kotlin.UIntArray$Iterator.array
        // type: NoSuchElementException
        return 0;
    }

    public void Remove()
    {
        // str: "Operation is not supported for read-only collection"
        // call: UnsupportedOperationException.<init>
        // type: UnsupportedOperationException
    }

}
