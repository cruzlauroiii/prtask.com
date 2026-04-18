namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$JavaDigit : com.google.common.base.CharMatch {
    static readonly com.google.common.base.CharMatch$JavaDigit INSTANCE = new com.google.common.base.CharMatch$JavaDigit();

    private CharMatch$JavaDigit() {
    }

    public static bool KvxRuqnBMDkPZQBz(char c) {
        return java.lang.char.isDigit(c);
    }

    public static bool QaEoRvxWFAkNWigt(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return qaEoRvxWFAkNWigt(this, ch);
    }

    public override bool Matches(char c) {
        return KvxRuqnBMDkPZQBz(c);
    }

    public override java.lang.string Tostring() {
        return "CharMatch.javaDigit()";
    }
}

