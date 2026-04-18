namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u001d\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\n\u0010\r\u001a\u0006\u0012\u0002\b\u00030\u000eH\u0086\u0002R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082D¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/pb4a61925/pf6181d33/pb86b1fce;", "", "initializer", "Lkotlin/Function0;", "", "<init>", "(Lkotlin/jvm/functions/Function0;)V", "HASH_OFFSET", "", "getValue", "", "ref", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/pb4a61925/pe5f4ea05;", "property", "Lkotlin/reflect/KProperty;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb86b1fce {
    private readonly kotlin.jvm.functions.Function0 f2b909aed;
    private readonly int f3aec8198;
    private readonly int f65a9d379;
    private readonly kotlin.jvm.functions.Function0<byte[]> f6f31fdd8;
    private readonly kotlin.jvm.functions.Function0 fa13c3e18;
    private readonly kotlin.jvm.functions.Function0 fa1fd2f5c;
    private readonly int fa2e90524;
    private readonly kotlin.jvm.functions.Function0 ff199c024;
    private readonly int ff4505fa5;

    public pb86b1fce(kotlin.jvm.functions.Function0<byte[]> function0) {
        PiSSftOQEdvEzDZM(function0, "initializer");
        this.f6f31fdd8 = function0;
        this.f65a9d379 = 3;
    }

    public static int AoDPerGBzinMNMUi(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pe5f4ea05 pe5f4ea05Var) {
        return pe5f4ea05Var.getCountChecks();
    }

    public static void PiSSftOQEdvEzDZM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TEBBRgTObumTZsxE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TdCFxlmcsdgGRate(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object VzMuhRnTdqOxlZbO(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public readonly long GetValue(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pe5f4ea05 ref, kotlin.reflect.KProperty<object> property) {
        if ((30 + 6) % 6 > 0) {
        }
        tdCFxlmcsdgGRate(ref, "ref");
        TEBBRgTObumTZsxE(property, "property");
        byte[] bArr = (byte[]) vzMuhRnTdqOxlZbO(this.f6f31fdd8);
        long j = 0;
        for (int i = 0; i < 8; i++) {
            j = (j << 8) | ((long) (bArr[this.f65a9d379 + i] & 255));
            if (i == 0) {
                j &= 127;
            }
        }
        int iAoDPerGBzinMNMUi = AoDPerGBzinMNMUi(ref);
        long j2 = 1;
        int i2 = 2;
        if (2 <= iAoDPerGBzinMNMUi) {
            while (true) {
                j2 *= (long) i2;
                if (i2 == iAoDPerGBzinMNMUi) {
                    break;
                }
                i2++;
            }
        }
        return j % j2;
    }
}

