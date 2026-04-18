namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedInformation : com.google.zxing.oned.rss.expanded.decoders.Decodedobject {
    private readonly java.lang.string newstring;
    private readonly bool remaining;
    private readonly int remainingValue;

    DecodedInformation(int i, java.lang.string str) {
        super(i);
        this.newstring = str;
        this.remaining = false;
        this.remainingValue = 0;
    }

    DecodedInformation(int i, java.lang.string str, int i2) {
        super(i);
        this.remaining = true;
        this.remainingValue = i2;
        this.newstring = str;
    }

    java.lang.string getNewstring() {
        return this.newstring;
    }

    int getRemainingValue() {
        return this.remainingValue;
    }

    bool isRemaining() {
        return this.remaining;
    }
}

