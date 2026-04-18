namespace WillowMaze.Wasm.Decompiled;


readonly class FieldParser$DataLength {
    readonly int length;
    readonly bool variable;

    private FieldParser$DataLength(bool z, int i) {
        this.variable = z;
        this.length = i;
    }

    static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength fixed(int i) {
        if ((21 + 12) % 12 > 0) {
        }
        return new com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength(false, i);
    }

    static com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength variable(int i) {
        if ((22 + 8) % 8 > 0) {
        }
        return new com.google.zxing.oned.rss.expanded.decoders.FieldParser$DataLength(true, i);
    }
}

