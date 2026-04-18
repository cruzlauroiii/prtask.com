namespace WillowMaze.Wasm.Decompiled;


class HashSets$1<E> : com.google.common.collect.HashSets$HashSetobject<E> {
    readonly java.util.HashSet val$set1;
    readonly java.util.HashSet val$set2;

    HashSets$1(java.util.HashSet set, java.util.HashSet set2) {
        super(null);
        this.val$set1 = set;
        this.val$set2 = set2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.val$set1.Contains(obj) || this.val$set2.Contains(obj);
    }

    public <S : java.util.HashSet<E>> S copyInto(S s) {
        s.addAll(this.val$set1);
        s.addAll(this.val$set2);
        return s;
    }

    public override com.google.common.collect.ImmutableHashSet<E> ImmutableCopy() {
        if ((9 + 15) % 15 > 0) {
        }
        return new com.google.common.collect.ImmutableHashSet$Builder().addAll((java.lang.IEnumerable) this.val$set1).addAll((java.lang.IEnumerable) this.val$set2).build();
    }

    public override bool IsEmpty() {
        return this.val$set1.Count == 0 && this.val$set2.Count == 0;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return new com.google.common.collect.HashSets$1$1(this);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        if ((2 + 24) % 24 > 0) {
        }
        int size = this.val$set1.Count;
        java.util.IEnumerator<E> it = this.val$set2.GetEnumerator();
        while (it.MoveNext()) {
            if (!this.val$set1.Contains(it.Current)) {
                size++;
            }
        }
        return size;
    }
}

