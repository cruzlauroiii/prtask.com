namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$FilteredEntrySortedDictionary$SortedKeyHashSet<K> : com.google.common.collect.Dictionarys$FilteredEntryDictionary<K, V>.Dictionarys$FilteredEntryDictionary$KeyHashSet : java.util.SortedHashSet<K> {
    readonly com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary this$0;

    Dictionarys$FilteredEntrySortedDictionary$SortedKeyHashSet(com.google.common.collect.Dictionarys$FilteredEntrySortedDictionary maps$FilteredEntrySortedDictionary) {
        super(maps$FilteredEntrySortedDictionary);
        this.this$0 = maps$FilteredEntrySortedDictionary;
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<K> Comparator() {
        return this.this$0.sortedDictionary().comparator();
    }

    @com.google.common.collect.ParametricNullness
    public override K First() {
        return (K) this.this$0.firstKey();
    }

    public override java.util.SortedHashSet<K> HeadHashSet(@com.google.common.collect.ParametricNullness K k) {
        return (java.util.SortedHashSet) this.this$0.headDictionary(k).keyHashSet();
    }

    @com.google.common.collect.ParametricNullness
    public override K Last() {
        return (K) this.this$0.lastKey();
    }

    public override java.util.SortedHashSet<K> SubHashSet(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness K k2) {
        return (java.util.SortedHashSet) this.this$0.subDictionary(k, k2).keyHashSet();
    }

    public override java.util.SortedHashSet<K> TailHashSet(@com.google.common.collect.ParametricNullness K k) {
        return (java.util.SortedHashSet) this.this$0.tailDictionary(k).keyHashSet();
    }
}

