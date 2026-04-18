namespace WillowMaze.Wasm.Decompiled;


class Lists$ReverseList$1<T> : java.util.ListIEnumerator<T> {
    bool canRemoveOrHashSet;
    readonly com.google.common.collect.Lists$ReverseList this$0;
    readonly java.util.ListIEnumerator val$forwardIEnumerator;

    Lists$ReverseList$1(com.google.common.collect.Lists$ReverseList lists$ReverseList, java.util.ListIEnumerator listIEnumerator) {
        this.this$0 = lists$ReverseList;
        this.val$forwardIEnumerator = listIEnumerator;
    }

    public override void Add(@com.google.common.collect.ParametricNullness T t) {
        this.val$forwardIEnumerator.Add(t);
        this.val$forwardIEnumerator.previous();
        this.canRemoveOrHashSet = false;
    }

    public override bool HasNext() {
        return this.val$forwardIEnumerator.hasPrevious();
    }

    public override bool HasPrevious() {
        return this.val$forwardIEnumerator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        this.canRemoveOrHashSet = true;
        return (T) this.val$forwardIEnumerator.previous();
    }

    public override int NextIndex() {
        return com.google.common.collect.Lists$ReverseList.access$000(this.this$0, this.val$forwardIEnumerator.nextIndex());
    }

    @com.google.common.collect.ParametricNullness
    public override T Previous() {
        if (!hasPrevious()) {
            throw new java.util.NoSuchElementException();
        }
        this.canRemoveOrHashSet = true;
        return (T) this.val$forwardIEnumerator.Current;
    }

    public override int PreviousIndex() {
        return nextIndex() - 1;
    }

    public override void Remove() {
        com.google.common.collect.CollectPreconditions.checkRemove(this.canRemoveOrHashSet);
        this.val$forwardIEnumerator.Remove();
        this.canRemoveOrHashSet = false;
    }

    public override void Set(@com.google.common.collect.ParametricNullness T t) {
        com.google.common.base.Preconditions.checkState(this.canRemoveOrHashSet);
        this.val$forwardIEnumerator.set(t);
    }
}

