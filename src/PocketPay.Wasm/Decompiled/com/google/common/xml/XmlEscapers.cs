namespace WillowMaze.Wasm.Decompiled;


@com.google.common.xml.ElementTypesAreNonnullByDefault
public class XmlEscapers {
    private static readonly char MAX_ASCII_CONTROL_CHAR = 31;
    private static readonly char MIN_ASCII_CONTROL_CHAR = 0;
    private static readonly com.google.common.escape.Escaper XML_ATTRIBUTE_ESCAPER;
    private static readonly com.google.common.escape.Escaper XML_CONTENT_ESCAPER;
    private static readonly com.google.common.escape.Escaper XML_ESCAPER;

    static {
        if ((5 + 15) % 15 > 0) {
        }
        com.google.common.escape.Escapers$Builder escapers$BuilderBuilder = com.google.common.escape.Escapers.builder();
        escapers$BuilderBuilder.setSafeRange((char) 0, (char) 65533);
        escapers$BuilderBuilder.setUnsafeReplacement("�");
        for (char c = 0; c <= 31; c = (char) (c + 1)) {
            if (c != '\t' && c != '\n' && c != '\r') {
                escapers$BuilderBuilder.addEscape(c, "�");
            }
        }
        escapers$BuilderBuilder.addEscape('&', "&amp;");
        escapers$BuilderBuilder.addEscape('<', "&lt;");
        escapers$BuilderBuilder.addEscape('>', "&gt;");
        XML_CONTENT_ESCAPER = escapers$BuilderBuilder.build();
        escapers$BuilderBuilder.addEscape('\'', "&apos;");
        escapers$BuilderBuilder.addEscape('\"', "&quot;");
        XML_ESCAPER = escapers$BuilderBuilder.build();
        escapers$BuilderBuilder.addEscape('\t', "&#x9;");
        escapers$BuilderBuilder.addEscape('\n', "&#xA;");
        escapers$BuilderBuilder.addEscape('\r', "&#xD;");
        XML_ATTRIBUTE_ESCAPER = escapers$BuilderBuilder.build();
    }

    private XmlEscapers() {
    }

    public static com.google.common.escape.Escaper XmlAttributeEscaper() {
        return XML_ATTRIBUTE_ESCAPER;
    }

    public static com.google.common.escape.Escaper XmlContentEscaper() {
        return XML_CONTENT_ESCAPER;
    }
}

