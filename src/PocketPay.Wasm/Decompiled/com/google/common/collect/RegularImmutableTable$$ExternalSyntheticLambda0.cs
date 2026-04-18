namespace WillowMaze.Wasm.Decompiled;


public readonly class RegularImmutableTable$$ExternalSyntheticLambda0 : java.util.Comparator {
    public readonly java.util.Comparator f$0;
    public readonly java.util.Comparator f$1;

    public RegularImmutableTable$$ExternalSyntheticLambda0(java.util.Comparator comparator, java.util.Comparator comparator2) {
        this.f$0 = comparator;
        this.f$1 = comparator2;
    }

    public override readonly int Compare(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.collect.RegularImmutableTable.lambda$forCells$0(this.f$0, this.f$1, (com.google.common.collect.Table$Cell) obj, (com.google.common.collect.Table$Cell) obj2);
    }
}

