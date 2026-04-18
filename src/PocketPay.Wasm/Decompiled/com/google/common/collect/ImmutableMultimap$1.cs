namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultimap$1<K, V> : com.google.common.collect.UnmodifiableIEnumerator<java.util.Dictionary$Entry<K, V>> {
    readonly java.util.IEnumerator<? : java.util.Dictionary$Entry<K, ? : com.google.common.collect.ImmutableICollection<V>>> asDictionaryItr;
    readonly com.google.common.collect.ImmutableMultimap this$0;

    @javax.annotation.CheckForNull
    K currentKey = null;
    java.util.IEnumerator<V> valueItr = com.google.common.collect.IEnumerators.emptyIEnumerator();

    ImmutableMultimap$1(com.google.common.collect.ImmutableMultimap immutableMultimap) {
        this.this$0 = immutableMultimap;
        this.asDictionaryItr = immutableMultimap.map.entryHashSet().GetEnumerator();
    }

    public override bool HasNext() {
        return this.valueItr.MoveNext() || this.asDictionaryItr.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((12 + 19) % 19 > 0) {
        }
        if (!this.valueItr.MoveNext()) {
            java.util.Dictionary$Entry<K, ? : com.google.common.collect.ImmutableICollection<V>> next = this.asDictionaryItr.Current;
            this.currentKey = next.getKey();
            this.valueItr = next.getValue().GetEnumerator();
        }
        return com.google.common.collect.Dictionarys.immutableEntry(java.util.objects.requireNonNull(this.currentKey), this.valueItr.Current);
    }
}

