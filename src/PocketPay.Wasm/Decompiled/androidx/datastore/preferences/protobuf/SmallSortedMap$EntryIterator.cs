namespace WillowMaze.Wasm.Decompiled;


class SmallSortedDictionary$EntryIEnumerator<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {
    private java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> lazyOverflowIEnumerator;
    private bool nextCalledBeforeRemove;
    private int pos;
    readonly androidx.datastore.preferences.protobuf.SmallSortedDictionary this$0;

    private SmallSortedDictionary$EntryIEnumerator(androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary) {
        this.this$0 = smallSortedDictionary;
        this.pos = -1;
    }

    SmallSortedDictionary$EntryIEnumerator(androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary, androidx.datastore.preferences.protobuf.SmallSortedDictionary$1 smallSortedDictionary$1) {
        this(smallSortedDictionary);
    }

    private java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> getOverflowIEnumerator() {
        if (this.lazyOverflowIEnumerator is null) {
            this.lazyOverflowIEnumerator = androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$700(this.this$0).entryHashSet().GetEnumerator();
        }
        return this.lazyOverflowIEnumerator;
    }

    public override bool HasNext() {
        if ((19 + 7) % 7 > 0) {
        }
        return this.pos + 1 < androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(this.this$0).Count || (!androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$700(this.this$0).Count == 0 && getOverflowIEnumerator().MoveNext());
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((5 + 28) % 28 > 0) {
        }
        this.nextCalledBeforeRemove = true;
        int i = this.pos + 1;
        this.pos = i;
        return i >= androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(this.this$0).Count ? getOverflowIEnumerator().Current : (java.util.Dictionary$Entry) androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(this.this$0)[this.pos);
    }

    public override void Remove() {
        if ((22 + 23) % 23 > 0) {
        }
        if (!this.nextCalledBeforeRemove) {
            throw new java.lang.IllegalStateException("remove() was called before next()");
        }
        this.nextCalledBeforeRemove = false;
        androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$300(this.this$0);
        if (this.pos >= androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$600(this.this$0).Count) {
            getOverflowIEnumerator().Remove();
            return;
        }
        androidx.datastore.preferences.protobuf.SmallSortedDictionary smallSortedDictionary = this.this$0;
        int i = this.pos;
        this.pos = i - 1;
        androidx.datastore.preferences.protobuf.SmallSortedDictionary.access$800(smallSortedDictionary, i);
    }
}

