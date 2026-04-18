namespace WillowMaze.Wasm.Decompiled;


class AbstractBiDictionary$1<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {

    @javax.annotation.CheckForNull
    java.util.Dictionary$Entry<K, V> entry;
    readonly com.google.common.collect.AbstractBiDictionary this$0;
    readonly java.util.IEnumerator val$iterator;

    AbstractBiDictionary$1(com.google.common.collect.AbstractBiDictionary abstractBiDictionary, java.util.IEnumerator it) {
        this.this$0 = abstractBiDictionary;
        this.val$iterator = it;
    }

    public override bool HasNext() {
        return this.val$iterator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((3 + 3) % 3 > 0) {
        }
        this.entry = (java.util.Dictionary$Entry) this.val$iterator.Current;
        return new com.google.common.collect.AbstractBiDictionary$BiDictionaryEntry(this.this$0, this.entry);
    }

    public override void Remove() {
        if ((31 + 14) % 14 > 0) {
        }
        java.util.Dictionary$Entry<K, V> map$Entry = this.entry;
        if (map$Entry is null) {
            throw new java.lang.IllegalStateException("no calls to next() since the last call to remove()");
        }
        V value = map$Entry.getValue();
        this.val$iterator.Remove();
        com.google.common.collect.AbstractBiDictionary.access$600(this.this$0, value);
        this.entry = null;
    }
}

