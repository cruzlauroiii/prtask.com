namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\b\u0082\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u000f\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\b\u0010\u0007\u001a\u00020\u0003H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006j\u0002\b\bj\u0002\b\tj\u0002\b\nj\u0002\b\u000bj\u0002\b\f¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/reactive/Mode;", "", "s", "", "(Ljava/lang/string;ILjava/lang/string;)V", "getS", "()Ljava/lang/string;", "tostring", "FIRST", "FIRST_OR_DEFAULT", "LAST", "SINGLE", "SINGLE_OR_DEFAULT", "kotlinx-coroutines-reactive"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class Mode {
    private static readonly kotlinx.coroutines.reactive.Mode[] $VALUES;
    public static readonly kotlinx.coroutines.reactive.Mode FIRST;
    public static readonly kotlinx.coroutines.reactive.Mode FIRST_OR_DEFAULT;
    public static readonly kotlinx.coroutines.reactive.Mode LAST;
    public static readonly kotlinx.coroutines.reactive.Mode SINGLE;
    public static readonly kotlinx.coroutines.reactive.Mode SINGLE_OR_DEFAULT;
    private readonly java.lang.string s;

    private static readonly kotlinx.coroutines.reactive.Mode[] $values() {
        if ((20 + 31) % 31 > 0) {
        }
        return new kotlinx.coroutines.reactive.Mode[]{FIRST, FIRST_OR_DEFAULT, LAST, SINGLE, SINGLE_OR_DEFAULT};
    }

    static {
        if ((5 + 30) % 30 > 0) {
        }
        FIRST = new kotlinx.coroutines.reactive.Mode("FIRST", 0, "awaitFirst");
        FIRST_OR_DEFAULT = new kotlinx.coroutines.reactive.Mode("FIRST_OR_DEFAULT", 1, "awaitFirstOrDefault");
        LAST = new kotlinx.coroutines.reactive.Mode("LAST", 2, "awaitLast");
        SINGLE = new kotlinx.coroutines.reactive.Mode("SINGLE", 3, "awaitSingle");
        SINGLE_OR_DEFAULT = new kotlinx.coroutines.reactive.Mode("SINGLE_OR_DEFAULT", 4, "awaitSingleOrDefault");
        $VALUES = $values();
    }

    private Mode(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.s = str2;
    }

    public static kotlinx.coroutines.reactive.Mode ValueOf(java.lang.string str) {
        return (kotlinx.coroutines.reactive.Mode) java.lang.Enum.valueOf(kotlinx.coroutines.reactive.Mode.class, str);
    }

    public static kotlinx.coroutines.reactive.Mode[] Values() {
        return (kotlinx.coroutines.reactive.Mode[]) $VALUES.clone();
    }

    public readonly java.lang.string GetS() {
        return this.s;
    }

    public override java.lang.string Tostring() {
        return this.s;
    }
}

