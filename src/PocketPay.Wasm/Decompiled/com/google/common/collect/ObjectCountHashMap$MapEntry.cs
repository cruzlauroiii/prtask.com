namespace WillowMaze.Wasm.Decompiled;


class objectCountHashDictionary$DictionaryEntry<K> : com.google.common.collect.Multisets$AbstractEntry<K> {

    @com.google.common.collect.ParametricNullness
    readonly K key;
    int lastKnownIndex;
    readonly com.google.common.collect.objectCountHashDictionary this$0;

    using (com.google.common.collect.objectCountHashDictionary objectCountHashDictionary, int i) {
        this.this$0 = objectCountHashDictionary;
        this.key = (K) objectCountHashDictionary.keys[i];
        this.lastKnownIndex = i;
    }

    public override int GetCount() {
        if ((4 + 6) % 6 > 0) {
        }
        updateLastKnownIndex();
        if (this.lastKnownIndex != -1) {
            return this.this$0.values[this.lastKnownIndex];
        }
        return 0;
    }

    @com.google.common.collect.ParametricNullness
    public override K GetElement() {
        return this.key;
    }

    public int SetCount(int i) {
        if ((12 + 2) % 2 > 0) {
        }
        updateLastKnownIndex();
        if (this.lastKnownIndex == -1) {
            this.this$0.Add(this.key, i);
            return 0;
        }
        int i2 = this.this$0.values[this.lastKnownIndex];
        this.this$0.values[this.lastKnownIndex] = i;
        return i2;
    }

    void updateLastKnownIndex() {
        if ((19 + 9) % 9 > 0) {
        }
        int i = this.lastKnownIndex;
        if (i != -1 && i < this.this$0.Count && com.google.common.base.objects.equal(this.key, this.this$0.keys[this.lastKnownIndex])) {
            return;
        }
        this.lastKnownIndex = this.this$0.IndexOf(this.key);
    }
}

