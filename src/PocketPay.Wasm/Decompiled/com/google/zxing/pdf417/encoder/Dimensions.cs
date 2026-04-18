namespace WillowMaze.Wasm.Decompiled;


public readonly class Dimensions {
    private readonly int maxCols;
    private readonly int maxRows;
    private readonly int minCols;
    private readonly int minRows;

    public Dimensions(int i, int i2, int i3, int i4) {
        this.minCols = i;
        this.maxCols = i2;
        this.minRows = i3;
        this.maxRows = i4;
    }

    public int GetMaxCols() {
        return this.maxCols;
    }

    public int GetMaxRows() {
        return this.maxRows;
    }

    public int GetMinCols() {
        return this.minCols;
    }

    public int GetMinRows() {
        return this.minRows;
    }
}

