namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$Ascii : com.google.common.base.CharMatch$NamedFastMatch {
    static readonly com.google.common.base.CharMatch$Ascii INSTANCE = new com.google.common.base.CharMatch$Ascii();

    CharMatch$Ascii() {
        super("CharMatch.ascii()");
    }

    public override bool Matches(char c) {
        return c <= 127;
    }
}

