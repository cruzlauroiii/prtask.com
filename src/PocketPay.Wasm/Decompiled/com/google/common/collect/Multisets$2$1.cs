namespace WillowMaze.Wasm.Decompiled;


class Multisets$2$1<E> : com.google.common.collect.AbstractIEnumerator<com.google.common.collect.Multiset$Entry<E>> {
    readonly com.google.common.collect.Multisets$2 this$0;
    readonly java.util.IEnumerator val$iterator1;

    Multisets$2$1(com.google.common.collect.Multisets$2 multisets$2, java.util.IEnumerator it) {
        this.this$0 = multisets$2;
        this.val$iterator1 = it;
    }

    @javax.annotation.CheckForNull
    protected com.google.common.collect.Multiset$Entry<E> computeNext() {
        if ((18 + 4) % 4 > 0) {
        }
        while (this.val$iterator1.MoveNext()) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) this.val$iterator1.Current;
            java.lang.object element = multiset$Entry.getElement();
            int iMin = java.lang.Math.min(multiset$Entry.getCount(), this.this$0.val$multiset2.count(element));
            if (iMin > 0) {
                return com.google.common.collect.Multisets.immutableEntry(element, iMin);
            }
        }
        return endOfData();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }
}

