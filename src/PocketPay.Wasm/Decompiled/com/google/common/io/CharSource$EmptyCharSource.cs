namespace WillowMaze.Wasm.Decompiled;


readonly class CharSource$EmptyCharSource : com.google.common.io.CharSource$stringCharSource {
    private static readonly com.google.common.io.CharSource$EmptyCharSource INSTANCE = new com.google.common.io.CharSource$EmptyCharSource();

    private CharSource$EmptyCharSource() {
        super("");
    }

    static com.google.common.io.CharSource$EmptyCharSource access$000() {
        return INSTANCE;
    }

    public override java.lang.string Tostring() {
        return "CharSource.empty()";
    }
}

