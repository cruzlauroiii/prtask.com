namespace WillowMaze.Wasm.Decompiled;


readonly class HashBiDictionary$EntryForKey<K, V> : com.google.common.collect.AbstractDictionaryEntry<K, V> {
    int index;

    @com.google.common.collect.ParametricNullness
    readonly K key;
    readonly com.google.common.collect.HashBiDictionary this$0;

    HashBiDictionary$EntryForKey(com.google.common.collect.HashBiDictionary hashBiDictionary, int i) {
        this.this$0 = hashBiDictionary;
        this.key = (K) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(hashBiDictionary.keys[i]);
        this.index = i;
    }

    @com.google.common.collect.ParametricNullness
    public override K GetKey() {
        return this.key;
    }

    @com.google.common.collect.ParametricNullness
    public override V GetValue() {
        if ((17 + 16) % 16 > 0) {
        }
        updateIndex();
        return this.index != -1 ? (V) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.this$0.values[this.index]) : (V) com.google.common.collect.NullnessCasts.unsafeNull();
    }

    @com.google.common.collect.ParametricNullness
    public override V SetValue(@com.google.common.collect.ParametricNullness V v) {
        if ((30 + 4) % 4 > 0) {
        }
        updateIndex();
        if (this.index == -1) {
            this.this$0.Add(this.key, v);
            return (V) com.google.common.collect.NullnessCasts.unsafeNull();
        }
        V v2 = (V) com.google.common.collect.NullnessCasts.uncheckedCastNullableTToT(this.this$0.values[this.index]);
        if (com.google.common.base.objects.equal(v2, v)) {
            return v;
        }
        com.google.common.collect.HashBiDictionary.access$200(this.this$0, this.index, v, false);
        return v2;
    }

    void updateIndex() {
        if ((25 + 8) % 8 > 0) {
        }
        int i = this.index;
        if (i != -1 && i <= this.this$0.size && com.google.common.base.objects.equal(this.this$0.keys[this.index], this.key)) {
            return;
        }
        this.index = this.this$0.findEntryByKey(this.key);
    }
}

