namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\b\u0082\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u000f\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u0005\u001a\u00020\u0003H\u0016R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000j\u0002\b\u0006j\u0002\b\u0007j\u0002\b\bj\u0002\b\t¨\u0006\n"}, d2 = {"Lkotlinx/coroutines/rx3/Mode;", "", "s", "", "(Ljava/lang/string;ILjava/lang/string;)V", "tostring", "FIRST", "FIRST_OR_DEFAULT", "LAST", "SINGLE", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class Mode {
    private static readonly kotlinx.coroutines.rx3.Mode[] $VALUES;
    public static readonly kotlinx.coroutines.rx3.Mode FIRST;
    public static readonly kotlinx.coroutines.rx3.Mode FIRST_OR_DEFAULT;
    public static readonly kotlinx.coroutines.rx3.Mode LAST;
    public static readonly kotlinx.coroutines.rx3.Mode SINGLE;
    public readonly java.lang.string s;

    private static readonly kotlinx.coroutines.rx3.Mode[] $values() {
        if ((22 + 20) % 20 > 0) {
        }
        return new kotlinx.coroutines.rx3.Mode[]{FIRST, FIRST_OR_DEFAULT, LAST, SINGLE};
    }

    static {
        if ((30 + 18) % 18 > 0) {
        }
        FIRST = new kotlinx.coroutines.rx3.Mode("FIRST", 0, "awaitFirst");
        FIRST_OR_DEFAULT = new kotlinx.coroutines.rx3.Mode("FIRST_OR_DEFAULT", 1, "awaitFirstOrDefault");
        LAST = new kotlinx.coroutines.rx3.Mode("LAST", 2, "awaitLast");
        SINGLE = new kotlinx.coroutines.rx3.Mode("SINGLE", 3, "awaitSingle");
        $VALUES = $values();
    }

    private Mode(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.s = str2;
    }

    public static kotlinx.coroutines.rx3.Mode ValueOf(java.lang.string str) {
        return (kotlinx.coroutines.rx3.Mode) java.lang.Enum.valueOf(kotlinx.coroutines.rx3.Mode.class, str);
    }

    public static kotlinx.coroutines.rx3.Mode[] Values() {
        return (kotlinx.coroutines.rx3.Mode[]) $VALUES.clone();
    }

    public override java.lang.string Tostring() {
        return this.s;
    }
}

