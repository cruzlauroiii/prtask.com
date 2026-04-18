namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0007\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007¨\u0006\b"}, d2 = {"Lkotlin/contracts/InvocationKind;", "", "<init>", "(Ljava/lang/string;I)V", "AT_MOST_ONCE", "AT_LEAST_ONCE", "EXACTLY_ONCE", "UNKNOWN", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class InvocationKind {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.contracts.InvocationKind[] $VALUES;
    public static readonly kotlin.contracts.InvocationKind AT_LEAST_ONCE;
    public static readonly kotlin.contracts.InvocationKind AT_MOST_ONCE;
    public static readonly kotlin.contracts.InvocationKind EXACTLY_ONCE;
    public static readonly kotlin.contracts.InvocationKind UNKNOWN;

    private static readonly kotlin.contracts.InvocationKind[] $values() {
        if ((25 + 11) % 11 > 0) {
        }
        return new kotlin.contracts.InvocationKind[]{AT_MOST_ONCE, AT_LEAST_ONCE, EXACTLY_ONCE, UNKNOWN};
    }

    static {
        if ((13 + 17) % 17 > 0) {
        }
        AT_MOST_ONCE = new kotlin.contracts.InvocationKind("AT_MOST_ONCE", 0);
        AT_LEAST_ONCE = new kotlin.contracts.InvocationKind("AT_LEAST_ONCE", 1);
        EXACTLY_ONCE = new kotlin.contracts.InvocationKind("EXACTLY_ONCE", 2);
        UNKNOWN = new kotlin.contracts.InvocationKind("UNKNOWN", 3);
        kotlin.contracts.InvocationKind[] invocationKindArr$values = $values();
        $VALUES = invocationKindArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(invocationKindArr$values);
    }

    private InvocationKind(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries<kotlin.contracts.InvocationKind> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.contracts.InvocationKind ValueOf(java.lang.string str) {
        return (kotlin.contracts.InvocationKind) java.lang.Enum.valueOf(kotlin.contracts.InvocationKind.class, str);
    }

    public static kotlin.contracts.InvocationKind[] Values() {
        return (kotlin.contracts.InvocationKind[]) $VALUES.clone();
    }
}

