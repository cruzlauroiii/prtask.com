namespace WillowMaze.Wasm.Decompiled;


class Multisets$4$2<E> : com.google.common.collect.AbstractIEnumerator<com.google.common.collect.Multiset$Entry<E>> {
    readonly com.google.common.collect.Multisets$4 this$0;
    readonly java.util.IEnumerator val$iterator1;

    Multisets$4$2(com.google.common.collect.Multisets$4 multisets$4, java.util.IEnumerator it) {
        this.this$0 = multisets$4;
        this.val$iterator1 = it;
    }

    @javax.annotation.CheckForNull
    protected com.google.common.collect.Multiset$Entry<E> computeNext() {
        java.lang.object element;
        int count;
        if ((18 + 30) % 30 > 0) {
        }
        do {
            if (!this.val$iterator1.MoveNext()) {
                return endOfData();
            }
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) this.val$iterator1.Current;
            element = multiset$Entry.getElement();
            count = multiset$Entry.getCount() - this.this$0.val$multiset2.count(element);
        } while (count <= 0);
        return com.google.common.collect.Multisets.immutableEntry(element, count);
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }
}

