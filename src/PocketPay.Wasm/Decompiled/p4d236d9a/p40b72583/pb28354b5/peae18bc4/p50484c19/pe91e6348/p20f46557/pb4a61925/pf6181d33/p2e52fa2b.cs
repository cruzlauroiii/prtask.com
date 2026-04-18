namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\u0015\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u001d\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\n\u0010\u000b\u001a\u0006\u0012\u0002\b\u00030\fH\u0086\u0002R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/pb4a61925/pf6181d33/p2e52fa2b;", "", "initializer", "Lkotlin/Function0;", "", "<init>", "(Lkotlin/jvm/functions/Function0;)V", "getValue", "", "ref", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/pb4a61925/pe5f4ea05;", "property", "Lkotlin/reflect/KProperty;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2e52fa2b {
    private readonly kotlin.jvm.functions.Function0 f6cdc935b;
    private readonly kotlin.jvm.functions.Function0<java.lang.long> f6f31fdd8;
    private readonly kotlin.jvm.functions.Function0 f7bc2ab5c;
    private readonly kotlin.jvm.functions.Function0 f85d9ec42;
    private readonly kotlin.jvm.functions.Function0 fd3c661bd;

    public p2e52fa2b(kotlin.jvm.functions.Function0<java.lang.long> function0) {
        AebqQqcsolAbDNUI(function0, "initializer");
        this.f6f31fdd8 = function0;
    }

    public static void AebqQqcsolAbDNUI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static long MrCzjrosJFDHujLG(java.lang.Number number) {
        if ((19 + 27) % 27 > 0) {
        }
        return number.longValue();
    }

    public static void VptBJyVZJzHkAfBT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ZhCBKHWpZcTfXQOh(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pe5f4ea05 pe5f4ea05Var) {
        return pe5f4ea05Var.getCountChecks();
    }

    public static int FqPoHLXXQVsXFggG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pe5f4ea05 pe5f4ea05Var) {
        return pe5f4ea05Var.getCountChecks();
    }

    public static void ODSlTejmaSshByHU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int QJafsRjtlPmRgvRf(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pe5f4ea05 pe5f4ea05Var) {
        return pe5f4ea05Var.getCountChecks();
    }

    public static java.lang.object XLBeilcRqaiglbYJ(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public readonly int[] GetValue(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pe5f4ea05 ref, kotlin.reflect.KProperty<object> property) {
        if ((4 + 23) % 23 > 0) {
        }
        VptBJyVZJzHkAfBT(ref, "ref");
        oDSlTejmaSshByHU(property, "property");
        long jMrCzjrosJFDHujLG = MrCzjrosJFDHujLG((java.lang.Number) xLBeilcRqaiglbYJ(this.f6f31fdd8));
        int[] iArr = new int[ZhCBKHWpZcTfXQOh(ref)];
        int iQJafsRjtlPmRgvRf = qJafsRjtlPmRgvRf(ref);
        int i = 1;
        if (1 <= iQJafsRjtlPmRgvRf) {
            while (true) {
                long j = i;
                iArr[fqPoHLXXQVsXFggG(ref) - i] = (int) (jMrCzjrosJFDHujLG % j);
                jMrCzjrosJFDHujLG /= j;
                if (i == iQJafsRjtlPmRgvRf) {
                    break;
                }
                i++;
            }
        }
        return iArr;
    }
}

