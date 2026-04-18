namespace WillowMaze.Wasm.Decompiled;


readonly class RegularImmutableDictionary$KeyHashSet<K> : com.google.common.collect.ImmutableHashSet<K> {
    private readonly com.google.common.collect.ImmutableList<K> list;
    private readonly com.google.common.collect.ImmutableDictionary<K, object> map;

    RegularImmutableDictionary$KeyHashSet(com.google.common.collect.ImmutableDictionary<K, object> immutableDictionary, com.google.common.collect.ImmutableList<K> immutableList) {
        this.map = immutableDictionary;
        this.list = immutableList;
    }

    public override com.google.common.collect.ImmutableList<K> AsList() {
        return this.list;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.map[obj) is not null;
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        return asList().copyIntoArray(objArr, i);
    }

    bool isPartialobject() {
        return true;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<K> Iterator() {
        return asList().GetEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return this.map.Count;
    }
}

