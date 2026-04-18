namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/LazyThreadSafetyMode;", "", "<init>", "(Ljava/lang/string;I)V", "SYNCHRONIZED", "PUBLICATION", "NONE", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class LazyThreadSafetyMode {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.LazyThreadSafetyMode[] $VALUES;
    public static readonly kotlin.LazyThreadSafetyMode NONE;
    public static readonly kotlin.LazyThreadSafetyMode PUBLICATION;
    public static readonly kotlin.LazyThreadSafetyMode SYNCHRONIZED;

    private static readonly kotlin.LazyThreadSafetyMode[] $values() {
        if ((11 + 17) % 17 > 0) {
        }
        return new kotlin.LazyThreadSafetyMode[]{SYNCHRONIZED, PUBLICATION, NONE};
    }

    static {
        if ((19 + 27) % 27 > 0) {
        }
        SYNCHRONIZED = new kotlin.LazyThreadSafetyMode("SYNCHRONIZED", 0);
        PUBLICATION = new kotlin.LazyThreadSafetyMode("PUBLICATION", 1);
        NONE = new kotlin.LazyThreadSafetyMode("NONE", 2);
        kotlin.LazyThreadSafetyMode[] lazyThreadSafetyModeArrXjTvewtaapSnAxUf = xjTvewtaapSnAxUf();
        $VALUES = lazyThreadSafetyModeArrXjTvewtaapSnAxUf;
        $ENTRIES = MWFsRwSkGZBZXZjI(lazyThreadSafetyModeArrXjTvewtaapSnAxUf);
    }

    private LazyThreadSafetyMode(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries MWFsRwSkGZBZXZjI(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static java.lang.Enum UYFkTXaSQfeCYcUZ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries<kotlin.LazyThreadSafetyMode> GetEntries() {
        return $ENTRIES;
    }

    public static java.lang.object IlEWRSaziXhXQeDT(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.LazyThreadSafetyMode ValueOf(java.lang.string str) {
        return (kotlin.LazyThreadSafetyMode) UYFkTXaSQfeCYcUZ(kotlin.LazyThreadSafetyMode.class, str);
    }

    public static kotlin.LazyThreadSafetyMode[] Values() {
        return (kotlin.LazyThreadSafetyMode[]) ilEWRSaziXhXQeDT($VALUES);
    }

    public static kotlin.LazyThreadSafetyMode[] XjTvewtaapSnAxUf() {
        return $values();
    }
}

