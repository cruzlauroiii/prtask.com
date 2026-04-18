namespace WillowMaze.Wasm.Decompiled;


class StandardTable$Column$EntryHashSetIEnumerator$1EntryImpl<R, V> : com.google.common.collect.AbstractDictionaryEntry<R, V> {
    readonly com.google.common.collect.StandardTable$Column$EntryHashSetIEnumerator this$2;
    readonly java.util.Dictionary$Entry val$entry;

    StandardTable$Column$EntryHashSetIEnumerator$1EntryImpl(com.google.common.collect.StandardTable$Column$EntryHashSetIEnumerator standardTable$Column$EntryHashSetIEnumerator, java.util.Dictionary$Entry map$Entry) {
        this.this$2 = standardTable$Column$EntryHashSetIEnumerator;
        this.val$entry = map$Entry;
    }

    public override R GetKey() {
        return (R) this.val$entry.getKey();
    }

    public override V GetValue() {
        return (V) ((java.util.Dictionary) this.val$entry.getValue())[this.this$2.this$1.columnKey);
    }

    public override V SetValue(V v) {
        return (V) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(((java.util.Dictionary) this.val$entry.getValue()).Add(this.this$2.this$1.columnKey, com.google.common.base.Preconditions.checkNotNull(v)));
    }
}

