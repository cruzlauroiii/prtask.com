namespace WillowMaze.Wasm.Decompiled;


class Dictionarys$UnmodifiableEntries<K, V> : com.google.common.collect.ForwardingICollection<java.util.Dictionary$Entry<K, V>> {
    private readonly java.util.ICollection<java.util.Dictionary$Entry<K, V>> entries;

    Dictionarys$UnmodifiableEntries(java.util.ICollection<java.util.Dictionary$Entry<K, V>> collection) {
        this.entries = collection;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.ICollection<java.util.Dictionary$Entry<K, V>> delegate() {
        return this.entries;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return com.google.common.collect.Dictionarys.unmodifiableEntryIEnumerator(this.entries.GetEnumerator());
    }

    public override java.lang.object[] ToArray() {
        return standardToArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) standardToArray(tArr);
    }
}

