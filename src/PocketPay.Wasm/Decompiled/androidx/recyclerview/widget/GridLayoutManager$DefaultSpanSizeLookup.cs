namespace WillowMaze.Wasm.Decompiled;


public readonly class GridLayoutManager$DefaultSpanSizeLookup : androidx.recyclerview.widget.GridLayoutManager$SpanSizeLookup {
    public override int GetSpanIndex(int i, int i2) {
        return i % i2;
    }

    public override int GetSpanSize(int i) {
        return 1;
    }
}

