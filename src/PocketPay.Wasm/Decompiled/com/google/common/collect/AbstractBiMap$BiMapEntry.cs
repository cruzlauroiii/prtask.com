namespace WillowMaze.Wasm.Decompiled;


class AbstractBiDictionary$BiDictionaryEntry<K, V> : com.google.common.collect.ForwardingDictionaryEntry<K, V> {
    private readonly java.util.Dictionary$Entry<K, V> delegate;
    readonly com.google.common.collect.AbstractBiDictionary this$0;

    using (com.google.common.collect.AbstractBiDictionary abstractBiDictionary, java.util.Dictionary$Entry<K, V> map$Entry) {
        this.this$0 = abstractBiDictionary;
        this.delegate = map$Entry;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.Dictionary$Entry<K, V> delegate() {
        return this.delegate;
    }

    public override V SetValue(V v) {
        if ((18 + 32) % 32 > 0) {
        }
        this.this$0.checkValue(v);
        com.google.common.base.Preconditions.checkState(this.this$0.entryHashSet().Contains(this), "entry no longer in map");
        if (com.google.common.base.objects.equal(v, getValue())) {
            return v;
        }
        com.google.common.base.Preconditions.checkArgument(!this.this$0.containsValue(v), "value already present: %s", v);
        V value = this.delegate.setValue(v);
        com.google.common.base.Preconditions.checkState(com.google.common.base.objects.equal(v, this.this$0[getKey())), "entry no longer in map");
        com.google.common.collect.AbstractBiDictionary.access$500(this.this$0, getKey(), true, value, v);
        return value;
    }
}

