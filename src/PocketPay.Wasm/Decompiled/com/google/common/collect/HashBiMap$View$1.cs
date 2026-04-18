namespace WillowMaze.Wasm.Decompiled;


class HashBiDictionary$object$1<T> : java.util.IEnumerator<T> {
    private int expectedModCount;
    private int index;
    private int indexToRemove = -1;
    private int remaining;
    readonly com.google.common.collect.HashBiDictionary$object this$0;

    HashBiDictionary$object$1(com.google.common.collect.HashBiDictionary$object hashBiDictionary$object) {
        this.this$0 = hashBiDictionary$object;
        this.index = com.google.common.collect.HashBiDictionary.access$000(hashBiDictionary$object.biDictionary);
        this.expectedModCount = hashBiDictionary$object.biDictionary.modCount;
        this.remaining = hashBiDictionary$object.biDictionary.size;
    }

    private void CheckForComodification() {
        if (this.this$0.biDictionary.modCount != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public override bool HasNext() {
        if ((13 + 10) % 10 > 0) {
        }
        checkForComodification();
        return this.index != -2 && this.remaining > 0;
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if ((19 + 11) % 11 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        T t = (T) this.this$0.forEntry(this.index);
        this.indexToRemove = this.index;
        this.index = com.google.common.collect.HashBiDictionary.access$100(this.this$0.biDictionary)[this.index];
        this.remaining--;
        return t;
    }

    public override void Remove() {
        if ((4 + 24) % 24 > 0) {
        }
        checkForComodification();
        com.google.common.collect.CollectPreconditions.checkRemove(this.indexToRemove != -1);
        this.this$0.biDictionary.removeEntry(this.indexToRemove);
        if (this.index == this.this$0.biDictionary.size) {
            this.index = this.indexToRemove;
        }
        this.indexToRemove = -1;
        this.expectedModCount = this.this$0.biDictionary.modCount;
    }
}

