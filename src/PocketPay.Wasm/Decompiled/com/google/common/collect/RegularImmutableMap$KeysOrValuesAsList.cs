namespace WillowMaze.Wasm.Decompiled;


readonly class RegularImmutableDictionary$KeysOrValuesAsList : com.google.common.collect.ImmutableList<java.lang.object> {
    private readonly java.lang.object[] alternatingKeysAndValues;
    private readonly int offset;
    private readonly int size;

    RegularImmutableDictionary$KeysOrValuesAsList(java.lang.object[] objArr, int i, int i2) {
        this.alternatingKeysAndValues = objArr;
        this.offset = i;
        this.size = i2;
    }

    public override java.lang.object Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, this.size);
        return java.util.objects.requireNonNull(this.alternatingKeysAndValues[(i * 2) + this.offset]);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.size;
    }
}

