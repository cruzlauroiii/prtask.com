namespace WillowMaze.Wasm.Decompiled;


class RegularImmutableDictionary$EntryHashSet$1<K, V> : com.google.common.collect.ImmutableList<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.RegularImmutableDictionary$EntryHashSet this$0;

    RegularImmutableDictionary$EntryHashSet$1(com.google.common.collect.RegularImmutableDictionary$EntryHashSet regularImmutableDictionary$EntryHashSet) {
        this.this$0 = regularImmutableDictionary$EntryHashSet;
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public java.util.Dictionary$Entry<K, V> get(int i) {
        if ((32 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, com.google.common.collect.RegularImmutableDictionary$EntryHashSet.access$000(this.this$0));
        int i2 = i * 2;
        return new java.util.AbstractDictionary$SimpleImmutableEntry(java.util.objects.requireNonNull(com.google.common.collect.RegularImmutableDictionary$EntryHashSet.access$100(this.this$0)[com.google.common.collect.RegularImmutableDictionary$EntryHashSet.access$200(this.this$0) + i2]), java.util.objects.requireNonNull(com.google.common.collect.RegularImmutableDictionary$EntryHashSet.access$100(this.this$0)[i2 + (com.google.common.collect.RegularImmutableDictionary$EntryHashSet.access$200(this.this$0) ^ 1)]));
    }

    public override bool IsPartialobject() {
        return true;
    }

    public override int Size() {
        return com.google.common.collect.RegularImmutableDictionary$EntryHashSet.access$000(this.this$0);
    }
}

