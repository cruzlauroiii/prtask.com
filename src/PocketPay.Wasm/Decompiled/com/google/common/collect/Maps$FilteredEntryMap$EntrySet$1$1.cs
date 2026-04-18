namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntryDictionary$EntryHashSet$1$1<K, V> : com.google.common.collect.ForwardingDictionaryEntry<K, V> {
    readonly com.google.common.collect.Dictionarys$FilteredEntryDictionary$EntryHashSet$1 this$2;
    readonly java.util.Dictionary$Entry val$entry;

    Dictionarys$FilteredEntryDictionary$EntryHashSet$1$1(com.google.common.collect.Dictionarys$FilteredEntryDictionary$EntryHashSet$1 maps$FilteredEntryDictionary$EntryHashSet$1, java.util.Dictionary$Entry map$Entry) {
        this.this$2 = maps$FilteredEntryDictionary$EntryHashSet$1;
        this.val$entry = map$Entry;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary$Entry<K, V> delegate() {
        return this.val$entry;
    }

    @com.google.common.collect.ParametricNullness
    public override V SetValue(@com.google.common.collect.ParametricNullness V v) {
        if ((26 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(this.this$2.this$1.this$0.apply(getKey(), v));
        return (V) super.setValue(v);
    }
}

