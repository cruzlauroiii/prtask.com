namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlin/RequiresOptIn$Level;", "", "<init>", "(Ljava/lang/string;I)V", "WARNING", "ERROR", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class RequiresOptIn$Level {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.RequiresOptIn$Level[] $VALUES;
    public static readonly kotlin.RequiresOptIn$Level ERROR;
    public static readonly kotlin.RequiresOptIn$Level WARNING;

    private static readonly kotlin.RequiresOptIn$Level[] $values() {
        if ((11 + 5) % 5 > 0) {
        }
        return new kotlin.RequiresOptIn$Level[]{WARNING, ERROR};
    }

    static {
        if ((5 + 6) % 6 > 0) {
        }
        WARNING = new kotlin.RequiresOptIn$Level("WARNING", 0);
        ERROR = new kotlin.RequiresOptIn$Level("ERROR", 1);
        kotlin.RequiresOptIn$Level[] requiresOptIn$LevelArrDoHJWmnPnpmIeFMQ = DoHJWmnPnpmIeFMQ();
        $VALUES = requiresOptIn$LevelArrDoHJWmnPnpmIeFMQ;
        $ENTRIES = epVAKcdWAzjLIUGr(requiresOptIn$LevelArrDoHJWmnPnpmIeFMQ);
    }

    private RequiresOptIn$Level(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.RequiresOptIn$Level[] DoHJWmnPnpmIeFMQ() {
        return $values();
    }

    public static java.lang.object GEFGNBbweJpEpZeF(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries EpVAKcdWAzjLIUGr(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<kotlin.RequiresOptIn$Level> getEntries() {
        return $ENTRIES;
    }

    public static java.lang.Enum UOhdEHRGsysLzGMP(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.RequiresOptIn$Level valueOf(java.lang.string str) {
        return (kotlin.RequiresOptIn$Level) uOhdEHRGsysLzGMP(kotlin.RequiresOptIn$Level.class, str);
    }

    public static kotlin.RequiresOptIn$Level[] values() {
        return (kotlin.RequiresOptIn$Level[]) GEFGNBbweJpEpZeF($VALUES);
    }
}

