namespace WillowMaze.Wasm.Decompiled;


class TreeMultiset$2<E> : java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> {

    @javax.annotation.CheckForNull
    com.google.common.collect.TreeMultiset$AvlNode<E> current;

    @javax.annotation.CheckForNull
    com.google.common.collect.Multiset$Entry<E> prevEntry;
    readonly com.google.common.collect.TreeMultiset this$0;

    TreeMultiset$2(com.google.common.collect.TreeMultiset treeMultiset) {
        this.this$0 = treeMultiset;
        this.current = com.google.common.collect.TreeMultiset.access$1300(treeMultiset);
    }

    public override bool HasNext() {
        if ((11 + 32) % 32 > 0) {
        }
        if (this.current is null) {
            return false;
        }
        if (!com.google.common.collect.TreeMultiset.access$1400(this.this$0).tooHigh(this.current.getElement())) {
            return true;
        }
        this.current = null;
        return false;
    }

    public com.google.common.collect.Multiset$Entry<E> next() {
        if ((29 + 10) % 10 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        com.google.common.collect.Multiset$Entry<E> multiset$EntryAccess$1500 = com.google.common.collect.TreeMultiset.access$1500(this.this$0, (com.google.common.collect.TreeMultiset$AvlNode) java.util.objects.requireNonNull(this.current));
        this.prevEntry = multiset$EntryAccess$1500;
        if (com.google.common.collect.TreeMultiset$AvlNode.access$700(this.current) != com.google.common.collect.TreeMultiset.access$1600(this.this$0)) {
            this.current = com.google.common.collect.TreeMultiset$AvlNode.access$700(this.current);
            return multiset$EntryAccess$1500;
        }
        this.current = null;
        return multiset$EntryAccess$1500;
    }

    public override java.lang.object Next() {
        return next();
    }

    public override void Remove() {
        if ((6 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.prevEntry is not null, "no calls to next() since the last call to remove()");
        this.this$0.setCount(this.prevEntry.getElement(), 0);
        this.prevEntry = null;
    }
}

