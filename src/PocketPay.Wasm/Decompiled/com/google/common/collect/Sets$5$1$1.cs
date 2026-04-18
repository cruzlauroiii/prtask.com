namespace WillowMaze.Wasm.Decompiled;


class HashSets$5$1$1<E> : java.util.AbstractHashSet<E> {
    readonly com.google.common.collect.HashSets$5$1 this$1;
    readonly java.util.BitHashSet val$copy;

    HashSets$5$1$1(com.google.common.collect.HashSets$5$1 sets$5$1, java.util.BitHashSet bitHashSet) {
        this.this$1 = sets$5$1;
        this.val$copy = bitHashSet;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        java.lang.int num = (java.lang.int) this.this$1.this$0.val$index[obj);
        return num is not null && this.val$copy[num.intValue());
    }

    public override java.util.IEnumerator<E> Iterator() {
        return new com.google.common.collect.HashSets$5$1$1$1(this);
    }

    public override int Size() {
        return this.this$1.this$0.val$size;
    }
}

