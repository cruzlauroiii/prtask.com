namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedAsDictionaryValues<V> : com.google.common.collect.Synchronized$SynchronizedICollection<java.util.ICollection<V>> {
    private static readonly long serialVersionUID = 0;

    Synchronized$SynchronizedAsDictionaryValues(java.util.ICollection<java.util.ICollection<V>> collection, @javax.annotation.CheckForNull java.lang.object obj) {
        super(collection, obj, null);
    }

    public override java.util.IEnumerator<java.util.ICollection<V>> Iterator() {
        if ((22 + 12) % 12 > 0) {
        }
        return new com.google.common.collect.Synchronized$SynchronizedAsDictionaryValues$1(this, super.GetEnumerator());
    }
}

