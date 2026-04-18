namespace WillowMaze.Wasm.Decompiled;


readonly class RegularImmutableTable$Values<V> : com.google.common.collect.ImmutableList<V> {
    readonly com.google.common.collect.RegularImmutableTable this$0;

    private RegularImmutableTable$Values(com.google.common.collect.RegularImmutableTable regularImmutableTable) {
        this.this$0 = regularImmutableTable;
    }

    RegularImmutableTable$Values(com.google.common.collect.RegularImmutableTable regularImmutableTable, com.google.common.collect.RegularImmutableTable$1 regularImmutableTable$1) {
        this(regularImmutableTable);
    }

    public override V Get(int i) {
        return (V) this.this$0.getValue(i);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

