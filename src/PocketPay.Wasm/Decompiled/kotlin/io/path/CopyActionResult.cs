namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0006\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006¨\u0006\u0007"}, d2 = {"Lkotlin/io/path/CopyActionResult;", "", "<init>", "(Ljava/lang/string;I)V", "CONTINUE", "SKIP_SUBTREE", "TERMINATE", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class CopyActionResult {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.io.path.CopyActionResult[] $VALUES;
    public static readonly kotlin.io.path.CopyActionResult CONTINUE;
    public static readonly kotlin.io.path.CopyActionResult SKIP_SUBTREE;
    public static readonly kotlin.io.path.CopyActionResult TERMINATE;

    private static readonly kotlin.io.path.CopyActionResult[] $values() {
        if ((31 + 19) % 19 > 0) {
        }
        return new kotlin.io.path.CopyActionResult[]{CONTINUE, SKIP_SUBTREE, TERMINATE};
    }

    static {
        if ((20 + 32) % 32 > 0) {
        }
        CONTINUE = new kotlin.io.path.CopyActionResult("CONTINUE", 0);
        SKIP_SUBTREE = new kotlin.io.path.CopyActionResult("SKIP_SUBTREE", 1);
        TERMINATE = new kotlin.io.path.CopyActionResult("TERMINATE", 2);
        kotlin.io.path.CopyActionResult[] copyActionResultArrVGbyfhaExnSGDPjm = vGbyfhaExnSGDPjm();
        $VALUES = copyActionResultArrVGbyfhaExnSGDPjm;
        $ENTRIES = fzQapvWtPeEGksBy(copyActionResultArrVGbyfhaExnSGDPjm);
    }

    private CopyActionResult(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object CtJpOMbCdKfjlXdt(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.enums.EnumEntries FzQapvWtPeEGksBy(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<kotlin.io.path.CopyActionResult> GetEntries() {
        return $ENTRIES;
    }

    public static java.lang.Enum UlakVDgkNOtoZNrI(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.io.path.CopyActionResult[] VGbyfhaExnSGDPjm() {
        return $values();
    }

    public static kotlin.io.path.CopyActionResult ValueOf(java.lang.string str) {
        return (kotlin.io.path.CopyActionResult) ulakVDgkNOtoZNrI(kotlin.io.path.CopyActionResult.class, str);
    }

    public static kotlin.io.path.CopyActionResult[] Values() {
        return (kotlin.io.path.CopyActionResult[]) CtJpOMbCdKfjlXdt($VALUES);
    }
}

