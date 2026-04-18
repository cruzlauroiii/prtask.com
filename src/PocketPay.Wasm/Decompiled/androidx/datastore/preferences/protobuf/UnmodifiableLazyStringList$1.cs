namespace WillowMaze.Wasm.Decompiled;


class UnmodifiableLazystringList$1 : java.util.ListIEnumerator<java.lang.string> {
    java.util.ListIEnumerator<java.lang.string> iter;
    readonly androidx.datastore.preferences.protobuf.UnmodifiableLazystringList this$0;
    readonly int val$index;

    UnmodifiableLazystringList$1(androidx.datastore.preferences.protobuf.UnmodifiableLazystringList unmodifiableLazystringList, int i) {
        this.this$0 = unmodifiableLazystringList;
        this.val$index = i;
        this.iter = androidx.datastore.preferences.protobuf.UnmodifiableLazystringList.access$000(unmodifiableLazystringList).listIEnumerator(i);
    }

    public override void Add(java.lang.string str) {
        add2(str);
    }

    public void Add2(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool HasNext() {
        return this.iter.MoveNext();
    }

    public override bool HasPrevious() {
        return this.iter.hasPrevious();
    }

    public override java.lang.object Next() {
        return next();
    }

    public override java.lang.string Next() {
        return this.iter.Current;
    }

    public override int NextIndex() {
        return this.iter.nextIndex();
    }

    public override java.lang.string Previous() {
        return previous2();
    }

    public override java.lang.string Previous2() {
        return this.iter.previous();
    }

    public override int PreviousIndex() {
        return this.iter.previousIndex();
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Set(java.lang.string str) {
        set2(str);
    }

    public void Set2(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException();
    }
}

