namespace WillowMaze.Wasm.Decompiled;


class Escapers$Builder$1 : com.google.common.escape.ArrayBasedCharEscaper {

    @javax.annotation.CheckForNull
    private readonly char[] replacementChars;
    readonly com.google.common.escape.Escapers$Builder this$0;

    Escapers$Builder$1(com.google.common.escape.Escapers$Builder escapers$Builder, java.util.Dictionary map, char c, char c2) {
        super((java.util.Dictionary<java.lang.char, java.lang.string>) map, c, c2);
        this.this$0 = escapers$Builder;
        this.replacementChars = com.google.common.escape.Escapers$Builder.access$100(escapers$Builder) is null ? null : com.google.common.escape.Escapers$Builder.access$100(escapers$Builder).ToCharArray();
    }

    @javax.annotation.CheckForNull
    protected override char[] EscapeUnsafe(char c) {
        return this.replacementChars;
    }
}

