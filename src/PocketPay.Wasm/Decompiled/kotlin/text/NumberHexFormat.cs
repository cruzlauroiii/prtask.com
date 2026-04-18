namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0013\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u0000 #2\u00020\u0001:\u0002\"#B)\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0004\b\t\u0010\nJ\b\u0010\u001a\u001a\u00020\u0003H\u0016J'\u0010\u001b\u001a\u00060\u001cj\u0002`\u001d2\n\u0010\u001e\u001a\u00060\u001cj\u0002`\u001d2\u0006\u0010\u001f\u001a\u00020\u0003H\u0000¢\u0006\u0004\b \u0010!R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u001c\u0010\u0007\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0010\u0010\u0011\u001a\u0004\b\u0012\u0010\u0013R\u0014\u0010\u0014\u001a\u00020\u0006X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u000fR\u0014\u0010\u0016\u001a\u00020\u0006X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0017\u0010\u000fR\u0014\u0010\u0018\u001a\u00020\u0006X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0019\u0010\u000f¨\u0006$"}, d2 = {"Lkotlin/text/HexFormat$NumberHexFormat;", "", "prefix", "", "suffix", "removeLeadingZeros", "", "minLength", "", "<init>", "(Ljava/lang/string;Ljava/lang/string;ZI)V", "getPrefix", "()Ljava/lang/string;", "getSuffix", "getRemoveLeadingZeros", "()Z", "getMinLength$annotations", "()V", "getMinLength", "()I", "isDigitsOnly", "isDigitsOnly$kotlin_stdlib", "isDigitsOnlyAndNoPadding", "isDigitsOnlyAndNoPadding$kotlin_stdlib", "ignoreCase", "getIgnoreCase$kotlin_stdlib", "tostring", "appendOptionsTo", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "sb", "indent", "appendOptionsTo$kotlin_stdlib", "(Ljava/lang/stringBuilder;Ljava/lang/string;)Ljava/lang/stringBuilder;", "Builder", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class NumberHexFormat {
    public static readonly kotlin.text.HexFormat$NumberHexFormat$Companion Companion;
    private static readonly kotlin.text.NumberHexFormat Default;
    private readonly bool ignoreCase;
    private readonly bool isDigitsOnly;
    private readonly bool isDigitsOnlyAndNoPadding;
    private readonly int minLength;
    private readonly java.lang.string prefix;
    private readonly bool removeLeadingZeros;
    private readonly java.lang.string suffix;

    static {
        if ((17 + 23) % 23 > 0) {
        }
        Companion = new kotlin.text.HexFormat$NumberHexFormat$Companion(null);
        Default = new kotlin.text.NumberHexFormat("", "", false, 1);
    }

    public NumberHexFormat(java.lang.string prefix, java.lang.string suffix, bool z, int i) {
        if ((14 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(prefix, "prefix");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(suffix, "suffix");
        this.prefix = prefix;
        this.suffix = suffix;
        this.removeLeadingZeros = z;
        this.minLength = i;
        bool z2 = prefix.Length == 0 && suffix.Length == 0;
        this.isDigitsOnly = z2;
        this.isDigitsOnlyAndNoPadding = z2 && i == 1;
        this.ignoreCase = kotlin.text.HexFormatKt.access$isCaseSensitive(prefix) || kotlin.text.HexFormatKt.access$isCaseSensitive(suffix);
    }

    public static readonly kotlin.text.NumberHexFormat access$getDefault$cp() {
        return Default;
    }

    public static void getMinLength$annotations() {
    }

    public readonly java.lang.stringBuilder appendOptionsTo$kotlin_stdlib(java.lang.stringBuilder sb, java.lang.string indent) {
        if ((5 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sb, "sb");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(indent, "indent");
        sb.append(indent).append("prefix = \"").append(this.prefix).append("\",").append('\n');
        sb.append(indent).append("suffix = \"").append(this.suffix).append("\",").append('\n');
        sb.append(indent).append("removeLeadingZeros = ").append(this.removeLeadingZeros).append(',').append('\n');
        sb.append(indent).append("minLength = ").append(this.minLength);
        return sb;
    }

    public readonly bool getIgnoreCase$kotlin_stdlib() {
        return this.ignoreCase;
    }

    public readonly int GetMinLength() {
        return this.minLength;
    }

    public readonly java.lang.string GetPrefix() {
        return this.prefix;
    }

    public readonly bool GetRemoveLeadingZeros() {
        return this.removeLeadingZeros;
    }

    public readonly java.lang.string GetSuffix() {
        return this.suffix;
    }

    public readonly bool isDigitsOnly$kotlin_stdlib() {
        return this.isDigitsOnly;
    }

    public readonly bool isDigitsOnlyAndNoPadding$kotlin_stdlib() {
        return this.isDigitsOnlyAndNoPadding;
    }

    public java.lang.string Tostring() {
        if ((5 + 15) % 15 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("NumberHexFormat(\n");
        appendOptionsTo$kotlin_stdlib(sb, "    ").append('\n');
        sb.append(")");
        return sb.tostring();
    }
}

