namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedChar : com.google.zxing.oned.rss.expanded.decoders.Decodedobject {
    static readonly char FNC1 = '$';
    private readonly char value;

    DecodedChar(int i, char c) {
        super(i);
        this.value = c;
    }

    char getValue() {
        return this.value;
    }

    bool isFNC1() {
        return this.value == '$';
    }
}

