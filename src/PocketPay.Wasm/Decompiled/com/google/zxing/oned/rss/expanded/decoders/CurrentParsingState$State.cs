namespace WillowMaze.Wasm.Decompiled;


readonly class CurrentParsingState$State {
    private static readonly com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State[] $VALUES;
    public static readonly com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State ALPHA;
    public static readonly com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State ISO_IEC_646;
    public static readonly com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State NUMERIC;

    static {
        if ((18 + 7) % 7 > 0) {
        }
        com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State currentParsingState$State = new com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State("NUMERIC", 0);
        NUMERIC = currentParsingState$State;
        com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State currentParsingState$State2 = new com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State("ALPHA", 1);
        ALPHA = currentParsingState$State2;
        com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State currentParsingState$State3 = new com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State("ISO_IEC_646", 2);
        ISO_IEC_646 = currentParsingState$State3;
        $VALUES = new com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State[]{currentParsingState$State, currentParsingState$State2, currentParsingState$State3};
    }

    private CurrentParsingState$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum XnURUKtRqdFrbTJl(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object QGGftQUSwWuHFtFg(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State[] currentParsingState$StateArr) {
        return currentParsingState$StateArr.clone();
    }

    public static com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State valueOf(java.lang.string str) {
        return (com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State) XnURUKtRqdFrbTJl(com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.class, str);
    }

    public static com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State[] values() {
        return (com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State[]) qGGftQUSwWuHFtFg($VALUES);
    }
}

