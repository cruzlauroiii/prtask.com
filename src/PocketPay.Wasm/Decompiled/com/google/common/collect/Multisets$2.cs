namespace WillowMaze.Wasm.Decompiled;


class Multisets$2<E> : com.google.common.collect.Multisets$objectMultiset<E> {
    readonly com.google.common.collect.Multiset val$multiset1;
    readonly com.google.common.collect.Multiset val$multiset2;

    Multisets$2(com.google.common.collect.Multiset multiset, com.google.common.collect.Multiset multiset2) {
        super(null);
        this.val$multiset1 = multiset;
        this.val$multiset2 = multiset2;
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        int iCount = this.val$multiset1.count(obj);
        if (iCount != 0) {
            return java.lang.Math.min(iCount, this.val$multiset2.count(obj));
        }
        return 0;
    }

    java.util.HashSet<E> createElementHashSet() {
        return com.google.common.collect.HashSets.intersection(this.val$multiset1.elementHashSet(), this.val$multiset2.elementHashSet());
    }

    java.util.IEnumerator<E> elementIEnumerator() {
        throw new java.lang.AssertionError("should never be called");
    }

    java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator() {
        if ((12 + 30) % 30 > 0) {
        }
        return new com.google.common.collect.Multisets$2$1(this, this.val$multiset1.entryHashSet().GetEnumerator());
    }
}

