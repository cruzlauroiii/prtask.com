namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/DeprecationLevel;", "", "<init>", "(Ljava/lang/string;I)V", "WARNING", "ERROR", "HIDDEN", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DeprecationLevel {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.DeprecationLevel[] $VALUES;
    public static readonly kotlin.DeprecationLevel ERROR;
    public static readonly kotlin.DeprecationLevel HIDDEN;
    public static readonly kotlin.DeprecationLevel WARNING;

    private static readonly kotlin.DeprecationLevel[] $values() {
        if ((29 + 32) % 32 > 0) {
        }
        return new kotlin.DeprecationLevel[]{WARNING, ERROR, HIDDEN};
    }

    static {
        if ((25 + 29) % 29 > 0) {
        }
        WARNING = new kotlin.DeprecationLevel("WARNING", 0);
        ERROR = new kotlin.DeprecationLevel("ERROR", 1);
        HIDDEN = new kotlin.DeprecationLevel("HIDDEN", 2);
        kotlin.DeprecationLevel[] deprecationLevelArrByFpdlCKFTZhsMgp = byFpdlCKFTZhsMgp();
        $VALUES = deprecationLevelArrByFpdlCKFTZhsMgp;
        $ENTRIES = SGEMpDrnjVKiNMsm(deprecationLevelArrByFpdlCKFTZhsMgp);
    }

    private DeprecationLevel(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object DNNqynHpgTrLXfJD(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries SGEMpDrnjVKiNMsm(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.DeprecationLevel[] ByFpdlCKFTZhsMgp() {
        return $values();
    }

    public static kotlin.enums.EnumEntries<kotlin.DeprecationLevel> GetEntries() {
        return $ENTRIES;
    }

    public static java.lang.Enum SYzybghQZZgllTNR(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.DeprecationLevel ValueOf(java.lang.string str) {
        return (kotlin.DeprecationLevel) sYzybghQZZgllTNR(kotlin.DeprecationLevel.class, str);
    }

    public static kotlin.DeprecationLevel[] Values() {
        return (kotlin.DeprecationLevel[]) DNNqynHpgTrLXfJD($VALUES);
    }
}

