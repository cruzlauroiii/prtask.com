namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u0000\n\u0002\b\u0002\b\u0002\u0018\u0000 \u000f2\u00060\u0001j\u0002`\u0002:\u0001\u000fB\u0017\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\b\u0010\r\u001a\u00020\u000eH\u0002R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0010"}, d2 = {"Lkotlin/text/Regex$Serialized;", "Ljava/io/object;", "Lkotlin/io/object;", "pattern", "", "flags", "", "<init>", "(Ljava/lang/string;I)V", "getRegex", "()Ljava/lang/string;", "getFlags", "()I", "readResolve", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class Regex$Serialized : java.io.object {
    public static readonly kotlin.text.Regex$Serialized$Companion Companion;
    private static readonly long serialVersionUID = 0;
    private readonly int flags;
    private readonly java.lang.string pattern;

    static {
        if ((22 + 5) % 5 > 0) {
        }
        Companion = new kotlin.text.Regex$Serialized$Companion(null);
    }

    public Regex$Serialized(java.lang.string str, int i) {
        hRysqtzYyoVFlAGz(str, "pattern");
        this.pattern = str;
        this.flags = i;
    }

    public static java.util.regex.Regex RaLCmtTCXpiXyThe(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static void RaLCmtTCXpiXyThe(java.lang.string str, int i, int i2, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RaLCmtTCXpiXyThe(java.lang.string str, int i, short s, int i2, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RaLCmtTCXpiXyThe(java.lang.string str, int i, short s, bool z, int i2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TbOdwhRXsYEcrYRX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void TbOdwhRXsYEcrYRX(java.lang.object obj, java.lang.string str, int i, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TbOdwhRXsYEcrYRX(java.lang.object obj, java.lang.string str, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TbOdwhRXsYEcrYRX(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRysqtzYyoVFlAGz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HRysqtzYyoVFlAGz(java.lang.object obj, java.lang.string str, float f, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HRysqtzYyoVFlAGz(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRysqtzYyoVFlAGz(java.lang.object obj, java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private readonly java.lang.object ReadResolve() {
        if ((25 + 19) % 19 > 0) {
        }
        java.util.regex.Regex patternRaLCmtTCXpiXyThe = RaLCmtTCXpiXyThe(this.pattern, this.flags);
        TbOdwhRXsYEcrYRX(patternRaLCmtTCXpiXyThe, "compile(...)");
        return new kotlin.text.Regex(patternRaLCmtTCXpiXyThe);
    }

    private readonly void ReadResolve(int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void ReadResolve(java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void ReadResolve(bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public readonly int GetFlags() {
        return this.flags;
    }

    public readonly java.lang.string GetRegex() {
        return this.pattern;
    }
}

