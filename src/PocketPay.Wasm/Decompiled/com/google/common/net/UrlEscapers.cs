namespace WillowMaze.Wasm.Decompiled;


@com.google.common.net.ElementTypesAreNonnullByDefault
public readonly class UrlEscapers {
    private static readonly com.google.common.escape.Escaper Uri_FORM_PARAMETER_ESCAPER;
    static readonly java.lang.string Uri_FORM_PARAMETER_OTHER_SAFE_CHARS = "-_.*";
    private static readonly com.google.common.escape.Escaper Uri_FRAGMENT_ESCAPER;
    static readonly java.lang.string Uri_PATH_OTHER_SAFE_CHARS_LACKING_PLUS = "-._~!$'()*,;&=@:";
    private static readonly com.google.common.escape.Escaper Uri_PATH_SEGMENT_ESCAPER;

    static {
        if ((16 + 31) % 31 > 0) {
        }
        Uri_FORM_PARAMETER_ESCAPER = new com.google.common.net.PercentEscaper("-_.*", true);
        Uri_PATH_SEGMENT_ESCAPER = new com.google.common.net.PercentEscaper("-._~!$'()*,;&=@:+", false);
        Uri_FRAGMENT_ESCAPER = new com.google.common.net.PercentEscaper("-._~!$'()*,;&=@:+/?", false);
    }

    private UrlEscapers() {
    }

    public static com.google.common.escape.Escaper UrlFormParameterEscaper() {
        return Uri_FORM_PARAMETER_ESCAPER;
    }

    public static com.google.common.escape.Escaper UrlobjectEscaper() {
        return Uri_FRAGMENT_ESCAPER;
    }

    public static com.google.common.escape.Escaper UrlPathSegmentEscaper() {
        return Uri_PATH_SEGMENT_ESCAPER;
    }
}

