namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007J\u000e\u0010\b\u001a\u00020\u00072\u0006\u0010\u0006\u001a\u00020\u0007J\u000e\u0010\t\u001a\u00020\u00072\u0006\u0010\u0006\u001a\u00020\u0007J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000bH\u0002¨\u0006\r"}, d2 = {"Lkotlin/text/Regex$Companion;", "", "<init>", "()V", "fromLiteral", "Lkotlin/text/Regex;", "literal", "", "escape", "escapeReplacement", "ensureUnicodeCase", "", "flags", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class Regex$Companion {
    private Regex$Companion() {
    }

    public Regex$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly int access$ensureUnicodeCase(kotlin.text.Regex$Companion regex$Companion, int i) {
        return regex$Companion.ensureUnicodeCase(i);
    }

    private readonly int EnsureUnicodeCase(int flags) {
        return (flags & 2) == 0 ? flags : flags | 64;
    }

    public readonly java.lang.string Escape(java.lang.string literal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(literal, "literal");
        java.lang.string strQuote = java.util.regex.Regex.quote(literal);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strQuote, "quote(...)");
        return strQuote;
    }

    public readonly java.lang.string EscapeReplacement(java.lang.string literal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(literal, "literal");
        java.lang.string strQuoteReplacement = java.util.regex.Match.quoteReplacement(literal);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strQuoteReplacement, "quoteReplacement(...)");
        return strQuoteReplacement;
    }

    public readonly kotlin.text.Regex FromLiteral(java.lang.string literal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(literal, "literal");
        return new kotlin.text.Regex(literal, kotlin.text.RegexOption.LITERAL);
    }
}

