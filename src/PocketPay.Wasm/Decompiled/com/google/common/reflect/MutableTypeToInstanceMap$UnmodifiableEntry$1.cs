namespace WillowMaze.Wasm.Decompiled;


class MutableTypeToInstanceDictionary$UnmodifiableEntry$1<K, V> : com.google.common.collect.ForwardingHashSet<java.util.Dictionary$Entry<K, V>> {
    readonly java.util.HashSet val$entries;

    MutableTypeToInstanceDictionary$UnmodifiableEntry$1(java.util.HashSet set) {
        this.val$entries = set;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected java.util.HashSet<java.util.Dictionary$Entry<K, V>> delegate() {
        return this.val$entries;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return com.google.common.reflect.MutableTypeToInstanceDictionary$UnmodifiableEntry.access$000(super.GetEnumerator());
    }

    public override java.lang.object[] ToArray() {
        return standardToArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) standardToArray(tArr);
    }
}

