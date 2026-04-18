namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$JavaLowerCase : com.google.common.base.CharMatch {
    static readonly com.google.common.base.CharMatch$JavaLowerCase INSTANCE = new com.google.common.base.CharMatch$JavaLowerCase();

    private CharMatch$JavaLowerCase() {
    }

    public static bool AGSNxwcoEfIEBmCn(char c) {
        return java.lang.char.isLowerCase(c);
    }

    public static bool YKQipziDeLlpEUaV(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return YKQipziDeLlpEUaV(this, ch);
    }

    public override bool Matches(char c) {
        return AGSNxwcoEfIEBmCn(c);
    }

    public override java.lang.string Tostring() {
        return "CharMatch.javaLowerCase()";
    }
}

