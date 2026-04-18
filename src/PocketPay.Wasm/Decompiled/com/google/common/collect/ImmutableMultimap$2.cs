namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultimap$2<V> : com.google.common.collect.UnmodifiableIEnumerator<V> {
    readonly com.google.common.collect.ImmutableMultimap this$0;
    java.util.IEnumerator<? : com.google.common.collect.ImmutableICollection<V>> valueICollectionItr;
    java.util.IEnumerator<V> valueItr = com.google.common.collect.IEnumerators.emptyIEnumerator();

    ImmutableMultimap$2(com.google.common.collect.ImmutableMultimap immutableMultimap) {
        this.this$0 = immutableMultimap;
        this.valueICollectionItr = immutableMultimap.map.Values.GetEnumerator();
    }

    public override bool HasNext() {
        return this.valueItr.MoveNext() || this.valueICollectionItr.MoveNext();
    }

    public override V Next() {
        if (!this.valueItr.MoveNext()) {
            this.valueItr = this.valueICollectionItr.Current.GetEnumerator();
        }
        return this.valueItr.Current;
    }
}

