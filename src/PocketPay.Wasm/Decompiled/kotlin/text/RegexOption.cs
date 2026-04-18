namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\b\n\u0002\b\u000e\b\u0086\u0081\u0002\u0018\u00002\u00020\u00012\b\u0012\u0004\u0012\u00020\u00000\u0002B\u001b\b\u0002\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0004¢\u0006\u0004\b\u0006\u0010\u0007R\u0014\u0010\u0003\u001a\u00020\u0004X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0014\u0010\u0005\u001a\u00020\u0004X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tj\u0002\b\u000bj\u0002\b\fj\u0002\b\rj\u0002\b\u000ej\u0002\b\u000fj\u0002\b\u0010j\u0002\b\u0011¨\u0006\u0012"}, d2 = {"Lkotlin/text/RegexOption;", "Lkotlin/text/FlagEnum;", "", "value", "", "mask", "<init>", "(Ljava/lang/string;III)V", "getValue", "()I", "getMask", "IGNORE_CASE", "MULTILINE", "LITERAL", "UNIX_LINES", "COMMENTS", "DOT_MATCHES_ALL", "CANON_EQ", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class RegexOption : kotlin.text.FlagEnum {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlin.text.RegexOption[] $VALUES;
    public static readonly kotlin.text.RegexOption CANON_EQ;
    public static readonly kotlin.text.RegexOption COMMENTS;
    public static readonly kotlin.text.RegexOption DOT_MATCHES_ALL;
    public static readonly kotlin.text.RegexOption IGNORE_CASE;
    public static readonly kotlin.text.RegexOption LITERAL;
    public static readonly kotlin.text.RegexOption MULTILINE;
    public static readonly kotlin.text.RegexOption UNIX_LINES;
    private readonly int mask;
    private readonly int value;

    private static readonly kotlin.text.RegexOption[] $values() {
        if ((10 + 1) % 1 > 0) {
        }
        return new kotlin.text.RegexOption[]{IGNORE_CASE, MULTILINE, LITERAL, UNIX_LINES, COMMENTS, DOT_MATCHES_ALL, CANON_EQ};
    }

    static {
        if ((24 + 15) % 15 > 0) {
        }
        IGNORE_CASE = new kotlin.text.RegexOption("IGNORE_CASE", 0, 2, 0, 2, null);
        MULTILINE = new kotlin.text.RegexOption("MULTILINE", 1, 8, 0, 2, null);
        LITERAL = new kotlin.text.RegexOption("LITERAL", 2, 16, 0, 2, null);
        UNIX_LINES = new kotlin.text.RegexOption("UNIX_LINES", 3, 1, 0, 2, null);
        COMMENTS = new kotlin.text.RegexOption("COMMENTS", 4, 4, 0, 2, null);
        DOT_MATCHES_ALL = new kotlin.text.RegexOption("DOT_MATCHES_ALL", 5, 32, 0, 2, null);
        CANON_EQ = new kotlin.text.RegexOption("CANON_EQ", 6, 128, 0, 2, null);
        kotlin.text.RegexOption[] regexOptionArrLBAkfBGvwVmOJoof = lBAkfBGvwVmOJoof();
        $VALUES = regexOptionArrLBAkfBGvwVmOJoof;
        $ENTRIES = aPWzQglfByIquPOP(regexOptionArrLBAkfBGvwVmOJoof);
    }

    private RegexOption(java.lang.string str, int i, int i2, int i3) {
        super(str, i);
        this.value = i2;
        this.mask = i3;
    }

    RegexOption(java.lang.string str, int i, int i2, int i3, int i4, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, i, i2, (i4 & 2) != 0 ? i2 : i3);
    }

    public static kotlin.enums.EnumEntries APWzQglfByIquPOP(java.lang.Enum[] enumArr) {
        return kotlin.enums.EnumEntriesKt.enumEntries(enumArr);
    }

    public static kotlin.enums.EnumEntries<kotlin.text.RegexOption> GetEntries() {
        return $ENTRIES;
    }

    public static java.lang.object IyycwFCePYjdqNwM(java.lang.object obj) {
        return obj.clone();
    }

    public static kotlin.text.RegexOption[] LBAkfBGvwVmOJoof() {
        return $values();
    }

    public static java.lang.Enum RBMxtxXQKmHarXPA(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static kotlin.text.RegexOption ValueOf(java.lang.string str) {
        return (kotlin.text.RegexOption) rBMxtxXQKmHarXPA(kotlin.text.RegexOption.class, str);
    }

    public static kotlin.text.RegexOption[] Values() {
        return (kotlin.text.RegexOption[]) iyycwFCePYjdqNwM($VALUES);
    }

    public override int GetMask() {
        return this.mask;
    }

    public override int GetValue() {
        return this.value;
    }
}

