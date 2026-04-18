namespace WillowMaze.Wasm.Decompiled;


class Multisets$4<E> : com.google.common.collect.Multisets$objectMultiset<E> {
    readonly com.google.common.collect.Multiset val$multiset1;
    readonly com.google.common.collect.Multiset val$multiset2;

    Multisets$4(com.google.common.collect.Multiset multiset, com.google.common.collect.Multiset multiset2) {
        super(null);
        this.val$multiset1 = multiset;
        this.val$multiset2 = multiset2;
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((20 + 2) % 2 > 0) {
        }
        int iCount = this.val$multiset1.count(obj);
        if (iCount != 0) {
            return java.lang.Math.max(0, iCount - this.val$multiset2.count(obj));
        }
        return 0;
    }

    int distinctElements() {
        return com.google.common.collect.IEnumerators.size(entryIEnumerator());
    }

    java.util.IEnumerator<E> elementIEnumerator() {
        if ((21 + 4) % 4 > 0) {
        }
        return new com.google.common.collect.Multisets$4$1(this, this.val$multiset1.entryHashSet().GetEnumerator());
    }

    java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator() {
        if ((15 + 21) % 21 > 0) {
        }
        return new com.google.common.collect.Multisets$4$2(this, this.val$multiset1.entryHashSet().GetEnumerator());
    }
}

