namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u001a \u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004\u001a(\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004\u001a*\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004¨\u0006\t"}, d2 = {"lazy", "Lkotlin/Lazy;", "T", "initializer", "Lkotlin/Function0;", "mode", "Lkotlin/LazyThreadSafetyMode;", "lock", "", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/LazyKt")
class LazyKt__LazyJVMKt {
    public static void AFGsEOCBLwEwYYGH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AFGsEOCBLwEwYYGH(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFGsEOCBLwEwYYGH(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFGsEOCBLwEwYYGH(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HGGuLzmqTALWktBU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HGGuLzmqTALWktBU(java.lang.object obj, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HGGuLzmqTALWktBU(java.lang.object obj, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HGGuLzmqTALWktBU(java.lang.object obj, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CHPGJCOjlUaEQTDk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CHPGJCOjlUaEQTDk(java.lang.object obj, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CHPGJCOjlUaEQTDk(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CHPGJCOjlUaEQTDk(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly <T> kotlin.Lazy<T> Lazy(java.lang.object obj, kotlin.jvm.functions.Function0<? : T> function0) {
        HGGuLzmqTALWktBU(function0, "initializer");
        return new kotlin.SynchronizedLazyImpl(function0, obj);
    }

    public static readonly <T> kotlin.Lazy<T> Lazy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0<? : T> function0) {
        if ((28 + 1) % 1 > 0) {
        }
        cHPGJCOjlUaEQTDk(lazyThreadSafetyMode, "mode");
        pdnHSsHWGFpUcHsZ(function0, "initializer");
        int i = kotlin.LazyKt__LazyJVMKt$WhenDictionarypings.$EnumSwitchDictionaryping$0[zLEgpIKMBKsietDw(lazyThreadSafetyMode)];
        if (i == 1) {
            return new kotlin.SynchronizedLazyImpl(function0, null, 2, null);
        }
        if (i == 2) {
            return new kotlin.SafePublicationLazyImpl(function0);
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return new kotlin.UnsafeLazyImpl(function0);
    }

    public static readonly <T> kotlin.Lazy<T> Lazy(kotlin.jvm.functions.Function0<? : T> function0) {
        if ((6 + 15) % 15 > 0) {
        }
        AFGsEOCBLwEwYYGH(function0, "initializer");
        return new kotlin.SynchronizedLazyImpl(function0, null, 2, null);
    }

    public static readonly void Lazy(java.lang.object obj, kotlin.jvm.functions.Function0 function0, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(java.lang.object obj, kotlin.jvm.functions.Function0 function0, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(java.lang.object obj, kotlin.jvm.functions.Function0 function0, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(kotlin.jvm.functions.Function0 function0, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(kotlin.jvm.functions.Function0 function0, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Lazy(kotlin.jvm.functions.Function0 function0, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdnHSsHWGFpUcHsZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PdnHSsHWGFpUcHsZ(java.lang.object obj, java.lang.string str, char c, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PdnHSsHWGFpUcHsZ(java.lang.object obj, java.lang.string str, char c, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PdnHSsHWGFpUcHsZ(java.lang.object obj, java.lang.string str, bool z, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZLEgpIKMBKsietDw(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode) {
        return lazyThreadSafetyMode.ordinal();
    }

    public static void ZLEgpIKMBKsietDw(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLEgpIKMBKsietDw(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLEgpIKMBKsietDw(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }
}

