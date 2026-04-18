namespace WillowMaze.Wasm.Decompiled;


readonly class ValueTuple : com.google.zxing.oned.rss.Datachar {
    private int count;
    private readonly com.google.zxing.oned.rss.FinderRegex finderRegex;

    ValueTuple(int i, int i2, com.google.zxing.oned.rss.FinderRegex finderRegex) {
        super(i, i2);
        this.finderRegex = finderRegex;
    }

    int getCount() {
        return this.count;
    }

    com.google.zxing.oned.rss.FinderRegex getFinderRegex() {
        return this.finderRegex;
    }

    void incrementCount() {
        this.count++;
    }
}

