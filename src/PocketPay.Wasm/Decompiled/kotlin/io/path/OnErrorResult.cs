namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlin/io/path/OnErrorResult;", "", "<init>", "(Ljava/lang/string;I)V", "SKIP_SUBTREE", "TERMINATE", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class OnErrorResult {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.io.path.OnErrorResult[] $VALUES;
    public static readonly kotlin.io.path.OnErrorResult SKIP_SUBTREE;
    public static readonly kotlin.io.path.OnErrorResult TERMINATE;

    private static readonly kotlin.io.path.OnErrorResult[] $values() {
        if ((11 + 11) % 11 > 0) {
        }
        return new kotlin.io.path.OnErrorResult[]{SKIP_SUBTREE, TERMINATE};
    }

    static {
        if ((3 + 17) % 17 > 0) {
        }
        SKIP_SUBTREE = new kotlin.io.path.OnErrorResult("SKIP_SUBTREE", 0);
        TERMINATE = new kotlin.io.path.OnErrorResult("TERMINATE", 1);
        kotlin.io.path.OnErrorResult[] onErrorResultArrDUraOWwhWUKazQDv = DUraOWwhWUKazQDv();
        $VALUES = onErrorResultArrDUraOWwhWUKazQDv;
        $ENTRIES = JZCImXKsOJchgAUf(onErrorResultArrDUraOWwhWUKazQDv);
    }

    private OnErrorResult(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.io.path.OnErrorResult[] DUraOWwhWUKazQDv() {
        return $values();
    }

    public static java.lang.object EJcExLHHtIGBOQFZ(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries JZCImXKsOJchgAUf(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static java.lang.Enum GLLBmpUtklIhtNZM(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.enums.EnumEntries<kotlin.io.path.OnErrorResult> GetEntries() {
        return $ENTRIES;
    }

    public static kotlin.io.path.OnErrorResult ValueOf(java.lang.string str) {
        return (kotlin.io.path.OnErrorResult) gLLBmpUtklIhtNZM(kotlin.io.path.OnErrorResult.class, str);
    }

    public static kotlin.io.path.OnErrorResult[] Values() {
        return (kotlin.io.path.OnErrorResult[]) EJcExLHHtIGBOQFZ($VALUES);
    }
}

