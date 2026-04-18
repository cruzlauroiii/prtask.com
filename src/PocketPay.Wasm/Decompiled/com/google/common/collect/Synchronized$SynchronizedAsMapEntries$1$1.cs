namespace WillowMaze.Wasm.Decompiled;


class Synchronized$SynchronizedAsDictionaryEntries$1$1<K, V> : com.google.common.collect.ForwardingDictionaryEntry<K, java.util.ICollection<V>> {
    readonly com.google.common.collect.Synchronized$SynchronizedAsDictionaryEntries$1 this$1;
    readonly java.util.Dictionary$Entry val$entry;

    Synchronized$SynchronizedAsDictionaryEntries$1$1(com.google.common.collect.Synchronized$SynchronizedAsDictionaryEntries$1 synchronized$SynchronizedAsDictionaryEntries$1, java.util.Dictionary$Entry map$Entry) {
        this.this$1 = synchronized$SynchronizedAsDictionaryEntries$1;
        this.val$entry = map$Entry;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary$Entry<K, java.util.ICollection<V>> delegate() {
        return this.val$entry;
    }

    public override java.lang.object GetValue() {
        return getValue();
    }

    public override java.util.ICollection<V> GetValue() {
        return com.google.common.collect.Synchronized.access$400((java.util.ICollection) this.val$entry.getValue(), this.this$1.this$0.mutex);
    }
}

