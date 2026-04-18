namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$JavaUpperCase : com.google.common.base.CharMatch {
    static readonly com.google.common.base.CharMatch$JavaUpperCase INSTANCE = new com.google.common.base.CharMatch$JavaUpperCase();

    private CharMatch$JavaUpperCase() {
    }

    public static bool BVZLDdLpdLlsaEPq(char c) {
        return java.lang.char.isUpperCase(c);
    }

    public static bool DxcTQChmDNVKBiwV(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return dxcTQChmDNVKBiwV(this, ch);
    }

    public override bool Matches(char c) {
        return bVZLDdLpdLlsaEPq(c);
    }

    public override java.lang.string Tostring() {
        return "CharMatch.javaUpperCase()";
    }
}

