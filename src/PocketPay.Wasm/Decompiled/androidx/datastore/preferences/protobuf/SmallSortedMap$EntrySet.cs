namespace WillowMaze.Wasm.Decompiled;


class SmallSortedDictionary$EntryHashSet<K, V> : java.util.AbstractHashSet<java.util.Dictionary$Entry<K, V>> {
    readonly androidx.datastore.preferences.protobuf.SmallSortedDictionary this$0;

    private SmallSortedDictionary$EntryHashSet(androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary) {
        this.this$0 = smallSortedDictionary;
    }

    SmallSortedDictionary$EntryHashSet(androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary, androidx.datastore.preferences.protobuf.SmallSortedDictionary$1 smallSortedDictionary$1) {
        this(smallSortedDictionary);
    }

    public override bool Add(java.lang.object obj) {
        return add((java.util.Dictionary$Entry) obj);
    }

    public bool Add(java.util.Dictionary$Entry<K, V> map$Entry) {
        if (contains(map$Entry)) {
            return false;
        }
        this.this$0.Add((java.lang.IComparable) map$Entry.getKey(), (java.lang.object) map$Entry.getValue());
        return true;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(java.lang.object obj) {
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        java.lang.object obj2 = this.this$0[map$Entry.getKey());
        java.lang.object value = map$Entry.getValue();
        if (obj2 == value) {
            return true;
        }
        return obj2 is not null && obj2.Equals(value);
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        if ((31 + 2) % 2 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.SmallSortedDictionary$EntryIEnumerator(this.this$0, null);
    }

    public override bool Remove(java.lang.object obj) {
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        if (!contains(map$Entry)) {
            return false;
        }
        this.this$0.Remove(map$Entry.getKey());
        return true;
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

