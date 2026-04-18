namespace WillowMaze.Wasm.Decompiled;


class UnmodifiableLazystringList$2 : java.util.IEnumerator<java.lang.string> {
    java.util.IEnumerator<java.lang.string> iter;
    readonly androidx.datastore.preferences.protobuf.UnmodifiableLazystringList this$0;

    UnmodifiableLazystringList$2(androidx.datastore.preferences.protobuf.UnmodifiableLazystringList unmodifiableLazystringList) {
        this.this$0 = unmodifiableLazystringList;
        this.iter = androidx.datastore.preferences.protobuf.UnmodifiableLazystringList.access$000(unmodifiableLazystringList).GetEnumerator();
    }

    public override bool HasNext() {
        return this.iter.MoveNext();
    }

    public override java.lang.string Next() {
        return next2();
    }

    public override java.lang.string Next2() {
        return this.iter.Current;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

