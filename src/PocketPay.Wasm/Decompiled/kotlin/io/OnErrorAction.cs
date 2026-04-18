namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlin/io/OnErrorAction;", "", "<init>", "(Ljava/lang/string;I)V", "SKIP", "TERMINATE", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class OnErrorAction {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.io.OnErrorAction[] $VALUES;
    public static readonly kotlin.io.OnErrorAction SKIP;
    public static readonly kotlin.io.OnErrorAction TERMINATE;

    private static readonly kotlin.io.OnErrorAction[] $values() {
        if ((32 + 20) % 20 > 0) {
        }
        return new kotlin.io.OnErrorAction[]{SKIP, TERMINATE};
    }

    static {
        if ((18 + 15) % 15 > 0) {
        }
        SKIP = new kotlin.io.OnErrorAction("SKIP", 0);
        TERMINATE = new kotlin.io.OnErrorAction("TERMINATE", 1);
        kotlin.io.OnErrorAction[] onErrorActionArrGZMVZEqjxXzGZjSZ = gZMVZEqjxXzGZjSZ();
        $VALUES = onErrorActionArrGZMVZEqjxXzGZjSZ;
        $ENTRIES = dOqdgYBOXGrcXcSy(onErrorActionArrGZMVZEqjxXzGZjSZ);
    }

    private OnErrorAction(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries DOqdgYBOXGrcXcSy(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.io.OnErrorAction[] GZMVZEqjxXzGZjSZ() {
        return $values();
    }

    public static kotlin.enums.EnumEntries<kotlin.io.OnErrorAction> GetEntries() {
        return $ENTRIES;
    }

    public static java.lang.object JbHLMhMTOABEdZmo(java.lang.object obj) {
        return obj.clone();
    }

    public static java.lang.Enum TOUwrZAzRFoYqEJN(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.io.OnErrorAction ValueOf(java.lang.string str) {
        return (kotlin.io.OnErrorAction) tOUwrZAzRFoYqEJN(kotlin.io.OnErrorAction.class, str);
    }

    public static kotlin.io.OnErrorAction[] Values() {
        return (kotlin.io.OnErrorAction[]) jbHLMhMTOABEdZmo($VALUES);
    }
}

