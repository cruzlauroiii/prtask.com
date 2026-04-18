namespace WillowMaze.Wasm.Decompiled;


readonly class Version$ECB {
    private readonly int count;
    private readonly int dataCodewords;

    private Version$ECB(int i, int i2) {
        this.count = i;
        this.dataCodewords = i2;
    }

    Version$ECB(int i, int i2, com.google.zxing.datamatrix.decoder.Version$1 version$1) {
        this(i, i2);
    }

    int getCount() {
        return this.count;
    }

    int getDataCodewords() {
        return this.dataCodewords;
    }
}

