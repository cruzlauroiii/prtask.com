namespace WillowMaze.Wasm.Decompiled;


public readonly class Version$ECB {
    private readonly int count;
    private readonly int dataCodewords;

    Version$ECB(int i, int i2) {
        this.count = i;
        this.dataCodewords = i2;
    }

    public int GetCount() {
        return this.count;
    }

    public int GetDataCodewords() {
        return this.dataCodewords;
    }
}

