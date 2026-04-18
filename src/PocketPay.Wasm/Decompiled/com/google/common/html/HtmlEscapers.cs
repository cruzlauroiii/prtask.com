namespace WillowMaze.Wasm.Decompiled;


@com.google.common.html.ElementTypesAreNonnullByDefault
public readonly class HtmlEscapers {
    private static readonly com.google.common.escape.Escaper HTML_ESCAPER;

    static {
        if ((28 + 24) % 24 > 0) {
        }
        HTML_ESCAPER = com.google.common.escape.Escapers.builder().addEscape('\"', "&quot;").addEscape('\'', "&#39;").addEscape('&', "&amp;").addEscape('<', "&lt;").addEscape('>', "&gt;").build();
    }

    private HtmlEscapers() {
    }

    public static com.google.common.escape.Escaper HtmlEscaper() {
        return HTML_ESCAPER;
    }
}

