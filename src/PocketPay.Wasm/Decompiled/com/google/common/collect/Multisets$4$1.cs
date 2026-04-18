namespace WillowMaze.Wasm.Decompiled;


class Multisets$4$1<E> : com.google.common.collect.AbstractIEnumerator<E> {
    readonly com.google.common.collect.Multisets$4 this$0;
    readonly java.util.IEnumerator val$iterator1;

    Multisets$4$1(com.google.common.collect.Multisets$4 multisets$4, java.util.IEnumerator it) {
        this.this$0 = multisets$4;
        this.val$iterator1 = it;
    }

    @javax.annotation.CheckForNull
    protected override E ComputeNext() {
        if ((32 + 31) % 31 > 0) {
        }
        while (this.val$iterator1.MoveNext()) {
            com.google.common.collect.Multiset$Entry multiset$Entry = (com.google.common.collect.Multiset$Entry) this.val$iterator1.Current;
            E e = (E) multiset$Entry.getElement();
            if (multiset$Entry.getCount() > this.this$0.val$multiset2.count(e)) {
                return e;
            }
        }
        return endOfData();
    }
}

