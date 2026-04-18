namespace WillowMaze.Wasm.Decompiled;


class HighLevelEncoder$1 : java.util.Comparator<com.google.zxing.aztec.encoder.State> {
    readonly com.google.zxing.aztec.encoder.HighLevelEncoder this$0;

    HighLevelEncoder$1(com.google.zxing.aztec.encoder.HighLevelEncoder highLevelEncoder) {
        this.this$0 = highLevelEncoder;
    }

    public static int OSmFNLaHonhAtvyE(com.google.zxing.aztec.encoder.State state) {
        return state.getBitCount();
    }

    public static int UKgMhxaBdyTUAenF(com.google.zxing.aztec.encoder.State state) {
        return state.getBitCount();
    }

    public static int WQEVOdqEPXWKKFiK(com.google.zxing.aztec.encoder.HighLevelEncoder$1 highLevelEncoder$1, com.google.zxing.aztec.encoder.State state, com.google.zxing.aztec.encoder.State state2) {
        return highLevelEncoder$1.compare2(state, state2);
    }

    public int Compare2(com.google.zxing.aztec.encoder.State state, com.google.zxing.aztec.encoder.State state2) {
        return uKgMhxaBdyTUAenF(state) - OSmFNLaHonhAtvyE(state2);
    }

    public override int Compare(com.google.zxing.aztec.encoder.State state, com.google.zxing.aztec.encoder.State state2) {
        return wQEVOdqEPXWKKFiK(this, state, state2);
    }
}

