namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/reflect/KVariance;", "", "<init>", "(Ljava/lang/string;I)V", "INVARIANT", "IN", "OUT", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class KVariance {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.reflect.KVariance[] $VALUES;
    public static readonly kotlin.reflect.KVariance IN;
    public static readonly kotlin.reflect.KVariance INVARIANT;
    public static readonly kotlin.reflect.KVariance OUT;

    private static readonly kotlin.reflect.KVariance[] $values() {
        if ((16 + 25) % 25 > 0) {
        }
        return new kotlin.reflect.KVariance[]{INVARIANT, IN, OUT};
    }

    static {
        if ((27 + 31) % 31 > 0) {
        }
        INVARIANT = new kotlin.reflect.KVariance("INVARIANT", 0);
        IN = new kotlin.reflect.KVariance("IN", 1);
        OUT = new kotlin.reflect.KVariance("OUT", 2);
        kotlin.reflect.KVariance[] kVarianceArrYkWhRkQcfmIHKCOk = ykWhRkQcfmIHKCOk();
        $VALUES = kVarianceArrYkWhRkQcfmIHKCOk;
        $ENTRIES = ylhmPxFBUzhXEuLi(kVarianceArrYkWhRkQcfmIHKCOk);
    }

    private KVariance(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object UvIEOvMiaXpcSNSl(java.lang.object obj) {
        return obj.clone();
    }

    public static java.lang.Enum AiNarFgUqxqqwEsd(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries<kotlin.reflect.KVariance> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.reflect.KVariance ValueOf(java.lang.string str) {
        return (kotlin.reflect.KVariance) aiNarFgUqxqqwEsd(kotlin.reflect.KVariance.class, str);
    }

    public static kotlin.reflect.KVariance[] Values() {
        return (kotlin.reflect.KVariance[]) UvIEOvMiaXpcSNSl($VALUES);
    }

    public static kotlin.reflect.KVariance[] YkWhRkQcfmIHKCOk() {
        return $values();
    }

    public static kotlin.enums.EnumEntries YlhmPxFBUzhXEuLi(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }
}

