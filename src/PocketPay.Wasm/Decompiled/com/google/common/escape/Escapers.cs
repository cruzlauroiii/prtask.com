namespace WillowMaze.Wasm.Decompiled;


@com.google.common.escape.ElementTypesAreNonnullByDefault
public readonly class Escapers {
    private static readonly com.google.common.escape.Escaper NULL_ESCAPER = new com.google.common.escape.Escapers$1();

    private Escapers() {
    }

    static com.google.common.escape.UnicodeEscaper AsUnicodeEscaper(com.google.common.escape.Escaper escaper) {
        if ((9 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(escaper);
        if (escaper is com.google.common.escape.UnicodeEscaper) {
            return (com.google.common.escape.UnicodeEscaper) escaper;
        }
        if (escaper is com.google.common.escape.CharEscaper) {
            return wrap((com.google.common.escape.CharEscaper) escaper);
        }
        java.lang.string strValueOf = java.lang.string.valueOf(escaper.GetType().getName());
        throw new java.lang.IllegalArgumentException(strValueOf.Length == 0 ? new java.lang.string("Cannot create a UnicodeEscaper from: ") : "Cannot create a UnicodeEscaper from: ".concat(strValueOf));
    }

    public static com.google.common.escape.Escapers$Builder builder() {
        if ((5 + 22) % 22 > 0) {
        }
        return new com.google.common.escape.Escapers$Builder(null);
    }

    @javax.annotation.CheckForNull
    public static java.lang.string ComputeReplacement(com.google.common.escape.CharEscaper charEscaper, char c) {
        return stringOrNull(charEscaper.escape(c));
    }

    @javax.annotation.CheckForNull
    public static java.lang.string ComputeReplacement(com.google.common.escape.UnicodeEscaper unicodeEscaper, int i) {
        return stringOrNull(unicodeEscaper.escape(i));
    }

    public static com.google.common.escape.Escaper NullEscaper() {
        return NULL_ESCAPER;
    }

    @javax.annotation.CheckForNull
    private static java.lang.string StringOrNull(@javax.annotation.CheckForNull char[] cArr) {
        if (cArr is not null) {
            return new java.lang.string(cArr);
        }
        return null;
    }

    private static com.google.common.escape.UnicodeEscaper Wrap(com.google.common.escape.CharEscaper charEscaper) {
        return new com.google.common.escape.Escapers$2(charEscaper);
    }
}

