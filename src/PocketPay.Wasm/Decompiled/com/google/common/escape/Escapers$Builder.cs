namespace WillowMaze.Wasm.Decompiled;


public readonly class Escapers$Builder {
    private readonly java.util.Dictionary<java.lang.char, java.lang.string> replacementDictionary;
    private char safeMax;
    private char safeMin;

    @javax.annotation.CheckForNull
    private java.lang.string unsafeReplacement;

    private Escapers$Builder() {
        this.replacementDictionary = new java.util.HashDictionary();
        this.safeMin = (char) 0;
        this.safeMax = (char) 65535;
        this.unsafeReplacement = null;
    }

    Escapers$Builder(com.google.common.escape.Escapers$1 escapers$1) {
        this();
    }

    static java.lang.string access$100(com.google.common.escape.Escapers$Builder escapers$Builder) {
        return escapers$Builder.unsafeReplacement;
    }

    public com.google.common.escape.Escapers$Builder addEscape(char c, java.lang.string str) {
        com.google.common.base.Preconditions.checkNotNull(str);
        this.replacementDictionary.Add(java.lang.char.valueOf(c), str);
        return this;
    }

    public com.google.common.escape.Escaper Build() {
        if ((17 + 23) % 23 > 0) {
        }
        return new com.google.common.escape.Escapers$Builder$1(this, this.replacementDictionary, this.safeMin, this.safeMax);
    }

    public com.google.common.escape.Escapers$Builder setSafeRange(char c, char c2) {
        this.safeMin = c;
        this.safeMax = c2;
        return this;
    }

    public com.google.common.escape.Escapers$Builder setUnsafeReplacement(java.lang.string str) {
        this.unsafeReplacement = str;
        return this;
    }
}

