namespace WillowMaze.Wasm.Decompiled;

public class UnsafeLazyImpl : Lazy<object>, Object
{
    private object _value;
    private Func<object> Initializer;

    public static void KKjaRFaPFXtYqHmL(object P0, string P1)
    {
        // call: Intrinsics.checkNotNullParameter
    }

    public static void KKjaRFaPFXtYqHmL(object P0, string P1, byte P2, bool P3, int P4, string P5)
    {
    }

    public static void KKjaRFaPFXtYqHmL(object P0, string P1, int P2, bool P3, byte P4, string P5)
    {
    }

    public static void KKjaRFaPFXtYqHmL(object P0, string P1, string P2, bool P3, byte P4, int P5)
    {
    }

    public static object RBxWrKENACaxvxgk(UnsafeLazyImpl P0)
    {
        // call: UnsafeLazyImpl.getValue
        return default!;
    }

    public static void RBxWrKENACaxvxgk(UnsafeLazyImpl P0, char P1, short P2, float P3, bool P4)
    {
    }

    public static void RBxWrKENACaxvxgk(UnsafeLazyImpl P0, float P1, char P2, short P3, bool P4)
    {
    }

    public static void RBxWrKENACaxvxgk(UnsafeLazyImpl P0, bool P1, short P2, char P3, float P4)
    {
    }

    public static string TfiNLPQqxjcHdgHg(object P0)
    {
        // call: string.valueOf
        return string.Empty;
    }

    public static void TfiNLPQqxjcHdgHg(object P0, byte P1, char P2, short P3, bool P4)
    {
    }

    public static void TfiNLPQqxjcHdgHg(object P0, char P1, byte P2, bool P3, short P4)
    {
    }

    public static void TfiNLPQqxjcHdgHg(object P0, short P1, char P2, bool P3, byte P4)
    {
    }

    private object WriteReplace()
    {
        // call: UnsafeLazyImpl.rBxWrKENACaxvxgk
        // call: InitializedLazyImpl.<init>
        // type: InitializedLazyImpl
        return default!;
    }

    private void WriteReplace(byte P0, bool P1, char P2, int P3)
    {
    }

    private void WriteReplace(bool P0, char P1, int P2, byte P3)
    {
    }

    private void WriteReplace(bool P0, int P1, char P2, byte P3)
    {
    }

    public static object XaQEJTuubUAZhznC(Func<object> P0)
    {
        // call: Func<object>.invoke
        return default!;
    }

    public static void XaQEJTuubUAZhznC(Func<object> P0, float P1, bool P2, byte P3, string P4)
    {
    }

    public static void XaQEJTuubUAZhznC(Func<object> P0, string P1, float P2, byte P3, bool P4)
    {
    }

    public static void XaQEJTuubUAZhznC(Func<object> P0, string P1, bool P2, float P3, byte P4)
    {
    }

    public static object YOwokNrPMaVrSqoy(UnsafeLazyImpl P0)
    {
        // call: UnsafeLazyImpl.getValue
        return default!;
    }

    public static void YOwokNrPMaVrSqoy(UnsafeLazyImpl P0, int P1, short P2, string P3, bool P4)
    {
    }

    public static void YOwokNrPMaVrSqoy(UnsafeLazyImpl P0, string P1, int P2, short P3, bool P4)
    {
    }

    public static void YOwokNrPMaVrSqoy(UnsafeLazyImpl P0, string P1, short P2, bool P3, int P4)
    {
    }

    public static void YPuNioDhdqHXHyCk(UnsafeLazyImpl P0, char P1, byte P2, int P3, float P4)
    {
    }

    public static void YPuNioDhdqHXHyCk(UnsafeLazyImpl P0, int P1, byte P2, char P3, float P4)
    {
    }

    public static void YPuNioDhdqHXHyCk(UnsafeLazyImpl P0, int P1, float P2, char P3, byte P4)
    {
    }

    public static bool YPuNioDhdqHXHyCk(UnsafeLazyImpl P0)
    {
        // call: UnsafeLazyImpl.isInitialized
        return false;
    }

    public static void ZMGrRjPiFnLINeQC(object P0)
    {
        // call: Intrinsics.checkNotNull
    }

    public static void ZMGrRjPiFnLINeQC(object P0, int P1, string P2, short P3, bool P4)
    {
    }

    public static void ZMGrRjPiFnLINeQC(object P0, int P1, bool P2, short P3, string P4)
    {
    }

    public static void ZMGrRjPiFnLINeQC(object P0, short P1, int P2, bool P3, string P4)
    {
    }

    public object GetValue()
    {
        // call: UnsafeLazyImpl.xaQEJTuubUAZhznC
        // call: UnsafeLazyImpl.zMGrRjPiFnLINeQC
        // field: kotlin.UNINITIALIZED_VALUE.INSTANCE
        // field: kotlin.UnsafeLazyImpl._value
        // field: kotlin.UnsafeLazyImpl.initializer
        return default!;
    }

    public bool IsInitialized()
    {
        // field: kotlin.UnsafeLazyImpl._value
        // field: kotlin.UNINITIALIZED_VALUE.INSTANCE
        return false;
    }

    public string ToString()
    {
        // str: "Lazy value not initialized yet."
        // call: UnsafeLazyImpl.tfiNLPQqxjcHdgHg
        // call: UnsafeLazyImpl.yPuNioDhdqHXHyCk
        // call: UnsafeLazyImpl.yOwokNrPMaVrSqoy
        return string.Empty;
    }

}
