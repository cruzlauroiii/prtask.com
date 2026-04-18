namespace WillowMaze.Wasm.Decompiled;


class Lists$AbstractListWrapper<E> : java.util.AbstractList<E> {
    readonly java.util.List<E> backingList;

    Lists$AbstractListWrapper(java.util.List<E> list) {
        this.backingList = (java.util.List) com.google.common.base.Preconditions.checkNotNull(list);
    }

    public override void Add(int i, @com.google.common.collect.ParametricNullness E e) {
        this.backingList.Add(i, e);
    }

    public override bool AddAll(int i, java.util.ICollection<? : E> collection) {
        return this.backingList.addAll(i, collection);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.backingList.Contains(obj);
    }

    @com.google.common.collect.ParametricNullness
    public override E Get(int i) {
        return this.backingList[i);
    }

    @com.google.common.collect.ParametricNullness
    public override E Remove(int i) {
        return this.backingList.Remove(i);
    }

    @com.google.common.collect.ParametricNullness
    public override E Set(int i, @com.google.common.collect.ParametricNullness E e) {
        return this.backingList.set(i, e);
    }

    public override int Size() {
        return this.backingList.Count;
    }
}

