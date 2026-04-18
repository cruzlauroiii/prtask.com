namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$JavaLetter : com.google.common.base.CharMatch {
    static readonly com.google.common.base.CharMatch$JavaLetter INSTANCE = new com.google.common.base.CharMatch$JavaLetter();

    private CharMatch$JavaLetter() {
    }

    public static bool IWcVcuQSVteyBIZM(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static bool ToiEHyflBlTSgZzb(char c) {
        return java.lang.char.isLetter(c);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return IWcVcuQSVteyBIZM(this, ch);
    }

    public override bool Matches(char c) {
        return ToiEHyflBlTSgZzb(c);
    }

    public override java.lang.string Tostring() {
        return "CharMatch.javaLetter()";
    }
}

