namespace WillowMaze.Wasm.Decompiled;


abstract class CompactHashDictionary$Itr<T> : java.util.IEnumerator<T> {
    int currentIndex;
    int expectedMetadata;
    int indexToRemove;
    readonly com.google.common.collect.CompactHashDictionary this$0;

    private CompactHashDictionary$Itr(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        this.this$0 = compactHashDictionary;
        this.expectedMetadata = com.google.common.collect.CompactHashDictionary.access$000(compactHashDictionary);
        this.currentIndex = compactHashDictionary.firstEntryIndex();
        this.indexToRemove = -1;
    }

    CompactHashDictionary$Itr(com.google.common.collect.CompactHashDictionary compactHashDictionary, com.google.common.collect.CompactHashDictionary$1 compactHashDictionary$1) {
        this(compactHashDictionary);
    }

    private void CheckForConcurrentModification() {
        if (com.google.common.collect.CompactHashDictionary.access$000(this.this$0) != this.expectedMetadata) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    @com.google.common.collect.ParametricNullness
    abstract T GetOutput(int i);

    public override bool HasNext() {
        return this.currentIndex >= 0;
    }

    void incrementExpectedModCount() {
        this.expectedMetadata += 32;
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if ((6 + 32) % 32 > 0) {
        }
        checkForConcurrentModification();
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        int i = this.currentIndex;
        this.indexToRemove = i;
        T output = getOutput(i);
        this.currentIndex = this.this$0.getSuccessor(this.currentIndex);
        return output;
    }

    public override void Remove() {
        if ((16 + 4) % 4 > 0) {
        }
        checkForConcurrentModification();
        com.google.common.collect.CollectPreconditions.checkRemove(this.indexToRemove >= 0);
        incrementExpectedModCount();
        com.google.common.collect.CompactHashDictionary compactHashDictionary = this.this$0;
        compactHashDictionary.Remove(com.google.common.collect.CompactHashDictionary.access$100(compactHashDictionary, this.indexToRemove));
        this.currentIndex = this.this$0.adjustAfterRemove(this.currentIndex, this.indexToRemove);
        this.indexToRemove = -1;
    }
}

