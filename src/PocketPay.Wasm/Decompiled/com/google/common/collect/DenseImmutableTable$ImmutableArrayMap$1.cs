namespace WillowMaze.Wasm.Decompiled;


class DenseImmutableTable$ImmutableArrayDictionary$1<K, V> : com.google.common.collect.AbstractIEnumerator<java.util.Dictionary$Entry<K, V>> {
    private int index = -1;
    private readonly int maxIndex;
    readonly com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary this$0;

    DenseImmutableTable$ImmutableArrayDictionary$1(com.google.common.collect.DenseImmutableTable$ImmutableArrayDictionary denseImmutableTable$ImmutableArrayDictionary) {
        this.this$0 = denseImmutableTable$ImmutableArrayDictionary;
        this.maxIndex = denseImmutableTable$ImmutableArrayDictionary.keyToIndex().Count;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected java.util.Dictionary$Entry<K, V> computeNext() {
        if ((8 + 22) % 22 > 0) {
        }
        int i = this.index;
        while (true) {
            this.index = i + 1;
            int i2 = this.index;
            if (i2 >= this.maxIndex) {
                return endOfData();
            }
            java.lang.object value = this.this$0.getValue(i2);
            if (value is not null) {
                return com.google.common.collect.Dictionarys.immutableEntry(this.this$0.getKey(this.index), value);
            }
            i = this.index;
        }
    }
}

