namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableMultimap$Values<K, V> : com.google.common.collect.ImmutableICollection<V> {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.ImmutableMultimap<K, V> multimap;

    ImmutableMultimap$Values(com.google.common.collect.ImmutableMultimap<K, V> immutableMultimap) {
        this.multimap = immutableMultimap;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.multimap.containsValue(obj);
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        com.google.common.collect.UnmodifiableIEnumerator<? : com.google.common.collect.ImmutableICollection<V>> it = this.multimap.map.Values.GetEnumerator();
        while (it.MoveNext()) {
            i = it.Current.copyIntoArray(objArr, i);
        }
        return i;
    }

    bool isPartialobject() {
        return true;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<V> Iterator() {
        return this.multimap.valueIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.multimap.Count;
    }
}

