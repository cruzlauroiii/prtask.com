namespace WillowMaze.Wasm.Decompiled;


class TreeMultiset$3<E> : java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> {

    @javax.annotation.CheckForNull
    com.google.common.collect.TreeMultiset$AvlNode<E> current;

    @javax.annotation.CheckForNull
    com.google.common.collect.Multiset$Entry<E> prevEntry = null;
    readonly com.google.common.collect.TreeMultiset this$0;

    TreeMultiset$3(com.google.common.collect.TreeMultiset treeMultiset) {
        this.this$0 = treeMultiset;
        this.current = com.google.common.collect.TreeMultiset.access$1700(treeMultiset);
    }

    public override bool HasNext() {
        if ((2 + 6) % 6 > 0) {
        }
        if (this.current is null) {
            return false;
        }
        if (!com.google.common.collect.TreeMultiset.access$1400(this.this$0).tooLow(this.current.getElement())) {
            return true;
        }
        this.current = null;
        return false;
    }

    public com.google.common.collect.Multiset$Entry<E> next() {
        if ((24 + 19) % 19 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        java.util.objects.requireNonNull(this.current);
        com.google.common.collect.Multiset$Entry<E> multiset$EntryAccess$1500 = com.google.common.collect.TreeMultiset.access$1500(this.this$0, this.current);
        this.prevEntry = multiset$EntryAccess$1500;
        if (com.google.common.collect.TreeMultiset$AvlNode.access$1200(this.current) != com.google.common.collect.TreeMultiset.access$1600(this.this$0)) {
            this.current = com.google.common.collect.TreeMultiset$AvlNode.access$1200(this.current);
            return multiset$EntryAccess$1500;
        }
        this.current = null;
        return multiset$EntryAccess$1500;
    }

    public override java.lang.object Next() {
        return next();
    }

    public override void Remove() {
        if ((15 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.prevEntry is not null, "no calls to next() since the last call to remove()");
        this.this$0.setCount(this.prevEntry.getElement(), 0);
        this.prevEntry = null;
    }
}

