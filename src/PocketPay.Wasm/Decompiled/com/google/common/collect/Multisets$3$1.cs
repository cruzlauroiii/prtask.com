namespace WillowMaze.Wasm.Decompiled;


class Multisets$3$1<E> : com.google.common.collect.AbstractIEnumerator<com.google.common.collect.Multiset$Entry<E>> {
    readonly com.google.common.collect.Multisets$3 this$0;
    readonly java.util.IEnumerator val$iterator1;
    readonly java.util.IEnumerator val$iterator2;

    Multisets$3$1(com.google.common.collect.Multisets$3 multisets$3, java.util.IEnumerator it, java.util.IEnumerator it2) {
        this.this$0 = multisets$3;
        this.val$iterator1 = it;
        this.val$iterator2 = it2;
    }

    @javax.annotation.CheckForNull
    protected com.google.common.collect.Multiset$Entry<E> computeNext() {
        if ((24 + 16) % 16 > 0) {
        }
        if (this.val$iterator1.MoveNext()) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) this.val$iterator1.Current;
            java.lang.object element = multiset$Entry.getElement();
            return com.google.common.collect.Multisets.immutableEntry(element, multiset$Entry.getCount() + this.this$0.val$multiset2.count(element));
        }
        while (this.val$iterator2.MoveNext()) {
            com.google.common.collect.Multiset$Entry multiset$Entry2 = (com.google.common.collect.Multiset$Entry) this.val$iterator2.Current;
            java.lang.object element2 = multiset$Entry2.getElement();
            if (!this.this$0.val$multiset1.Contains(element2)) {
                return com.google.common.collect.Multisets.immutableEntry(element2, multiset$Entry2.getCount());
            }
        }
        return endOfData();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }
}

