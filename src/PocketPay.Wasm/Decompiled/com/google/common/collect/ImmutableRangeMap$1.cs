namespace WillowMaze.Wasm.Decompiled;


class ImmutableRangeDictionary$1<K> : com.google.common.collect.ImmutableList<com.google.common.collect.Range<K>> {
    readonly com.google.common.collect.ImmutableRangeDictionary this$0;
    readonly int val$len;
    readonly int val$off;
    readonly com.google.common.collect.Range val$range;

    ImmutableRangeDictionary$1(com.google.common.collect.ImmutableRangeDictionary immutableRangeDictionary, int i, int i2, com.google.common.collect.Range range) {
        this.this$0 = immutableRangeDictionary;
        this.val$len = i;
        this.val$off = i2;
        this.val$range = range;
    }

    public override com.google.common.collect.Range<K> Get(int i) {
        if ((24 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, this.val$len);
        return (i == 0 || i == this.val$len + (-1)) ? ((com.google.common.collect.Range) com.google.common.collect.ImmutableRangeDictionary.access$000(this.this$0)[i + this.val$off)).intersection(this.val$range) : (com.google.common.collect.Range) com.google.common.collect.ImmutableRangeDictionary.access$000(this.this$0)[i + this.val$off);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    bool isPartialobject() {
        return true;
    }

    public override int Size() {
        return this.val$len;
    }
}

