namespace WillowMaze.Wasm.Decompiled;


class Multisets$1<E> : com.google.common.collect.Multisets$objectMultiset<E> {
    readonly com.google.common.collect.Multiset val$multiset1;
    readonly com.google.common.collect.Multiset val$multiset2;

    Multisets$1(com.google.common.collect.Multiset multiset, com.google.common.collect.Multiset multiset2) {
        super(null);
        this.val$multiset1 = multiset;
        this.val$multiset2 = multiset2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.val$multiset1.Contains(obj) || this.val$multiset2.Contains(obj);
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        return java.lang.Math.max(this.val$multiset1.count(obj), this.val$multiset2.count(obj));
    }

    java.util.HashSet<E> createElementHashSet() {
        return com.google.common.collect.HashSets.union(this.val$multiset1.elementHashSet(), this.val$multiset2.elementHashSet());
    }

    java.util.IEnumerator<E> elementIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator() {
        if ((30 + 15) % 15 > 0) {
        }
        return new com.google.common.collect.Multisets$1$1(this, this.val$multiset1.entryHashSet().GetEnumerator(), this.val$multiset2.entryHashSet().GetEnumerator());
    }

    public override bool IsEmpty() {
        return this.val$multiset1.Count == 0 && this.val$multiset2.Count == 0;
    }
}

