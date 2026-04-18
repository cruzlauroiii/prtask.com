namespace WillowMaze.Wasm.Decompiled;


class ImmutableSortedDictionary$1<K, V> : java.util.Comparator<java.util.Dictionary$Entry<K, V>> {
    readonly java.util.Comparator val$comparator;

    ImmutableSortedDictionary$1(java.util.Comparator comparator) {
        this.val$comparator = comparator;
    }

    public override int Compare(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return compare((java.util.Dictionary$Entry) obj, (java.util.Dictionary$Entry) obj2);
    }

    public int Compare(@javax.annotation.CheckForNull java.util.Dictionary$Entry<K, V> map$Entry, @javax.annotation.CheckForNull java.util.Dictionary$Entry<K, V> map$Entry2) {
        java.util.objects.requireNonNull(map$Entry);
        java.util.objects.requireNonNull(map$Entry2);
        return this.val$comparator.compare(map$Entry.getKey(), map$Entry2.getKey());
    }
}

