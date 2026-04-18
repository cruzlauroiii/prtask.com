namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$JavaLetterOrDigit : com.google.common.base.CharMatch {
    static readonly com.google.common.base.CharMatch$JavaLetterOrDigit INSTANCE = new com.google.common.base.CharMatch$JavaLetterOrDigit();

    private CharMatch$JavaLetterOrDigit() {
    }

    public static bool BMqHrMhBOKpXgjef(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static bool HEstyOeURSBVNFmh(char c) {
        return java.lang.char.isLetterOrDigit(c);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return bMqHrMhBOKpXgjef(this, ch);
    }

    public override bool Matches(char c) {
        return hEstyOeURSBVNFmh(c);
    }

    public override java.lang.string Tostring() {
        return "CharMatch.javaLetterOrDigit()";
    }
}

