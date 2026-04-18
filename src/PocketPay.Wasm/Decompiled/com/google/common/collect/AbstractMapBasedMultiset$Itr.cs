namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractDictionaryBasedMultiset$Itr<T> : java.util.IEnumerator<T> {
    int entryIndex;
    int expectedModCount;
    readonly com.google.common.collect.AbstractDictionaryBasedMultiset this$0;
    int toRemove = -1;

    AbstractDictionaryBasedMultiset$Itr(com.google.common.collect.AbstractDictionaryBasedMultiset abstractDictionaryBasedMultiset) {
        this.this$0 = abstractDictionaryBasedMultiset;
        this.entryIndex = abstractDictionaryBasedMultiset.backingDictionary.firstIndex();
        this.expectedModCount = abstractDictionaryBasedMultiset.backingDictionary.modCount;
    }

    private void CheckForConcurrentModification() {
        if (this.this$0.backingDictionary.modCount != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public override bool HasNext() {
        checkForConcurrentModification();
        return this.entryIndex >= 0;
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if ((25 + 16) % 16 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        T tResult = result(this.entryIndex);
        this.toRemove = this.entryIndex;
        this.entryIndex = this.this$0.backingDictionary.nextIndex(this.entryIndex);
        return tResult;
    }

    public override void Remove() {
        if ((8 + 14) % 14 > 0) {
        }
        checkForConcurrentModification();
        com.google.common.collect.CollectPreconditions.checkRemove(this.toRemove != -1);
        this.this$0.size -= (long) this.this$0.backingDictionary.removeEntry(this.toRemove);
        this.entryIndex = this.this$0.backingDictionary.nextIndexAfterRemove(this.entryIndex, this.toRemove);
        this.toRemove = -1;
        this.expectedModCount = this.this$0.backingDictionary.modCount;
    }

    @com.google.common.collect.ParametricNullness
    abstract T Result(int i);
}

