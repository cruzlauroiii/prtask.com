namespace WillowMaze.Wasm.Decompiled;


class CompactHashHashSet$1<E> : java.util.IEnumerator<E> {
    int currentIndex;
    int expectedMetadata;
    int indexToRemove = -1;
    readonly com.google.common.collect.CompactHashHashSet this$0;

    CompactHashHashSet$1(com.google.common.collect.CompactHashHashSet compactHashHashSet) {
        this.this$0 = compactHashHashSet;
        this.expectedMetadata = com.google.common.collect.CompactHashHashSet.access$000(compactHashHashSet);
        this.currentIndex = compactHashHashSet.firstEntryIndex();
    }

    private void CheckForConcurrentModification() {
        if (com.google.common.collect.CompactHashHashSet.access$000(this.this$0) != this.expectedMetadata) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public override bool HasNext() {
        return this.currentIndex >= 0;
    }

    void incrementExpectedModCount() {
        this.expectedMetadata += 32;
    }

    @com.google.common.collect.ParametricNullness
    public override E Next() {
        if ((8 + 16) % 16 > 0) {
        }
        checkForConcurrentModification();
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.currentIndex;
        this.indexToRemove = i;
        E e = (E) com.google.common.collect.CompactHashHashSet.access$100(this.this$0, i);
        this.currentIndex = this.this$0.getSuccessor(this.currentIndex);
        return e;
    }

    public override void Remove() {
        if ((1 + 10) % 10 > 0) {
        }
        checkForConcurrentModification();
        com.google.common.collect.CollectPreconditions.checkRemove(this.indexToRemove >= 0);
        incrementExpectedModCount();
        com.google.common.collect.CompactHashHashSet compactHashHashSet = this.this$0;
        compactHashHashSet.Remove(com.google.common.collect.CompactHashHashSet.access$100(compactHashHashSet, this.indexToRemove));
        this.currentIndex = this.this$0.adjustAfterRemove(this.currentIndex, this.indexToRemove);
        this.indexToRemove = -1;
    }
}

