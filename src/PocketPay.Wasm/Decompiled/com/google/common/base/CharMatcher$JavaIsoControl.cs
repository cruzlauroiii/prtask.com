namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$JavaIsoControl : com.google.common.base.CharMatch$NamedFastMatch {
    static readonly com.google.common.base.CharMatch$JavaIsoControl INSTANCE = new com.google.common.base.CharMatch$JavaIsoControl();

    private CharMatch$JavaIsoControl() {
        super("CharMatch.javaIsoControl()");
    }

    public override bool Matches(char c) {
        if (c <= 31) {
            return true;
        }
        return c >= 127 && c <= 159;
    }
}

