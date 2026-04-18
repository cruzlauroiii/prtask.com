namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$MergingIEnumerator<T> : com.google.common.collect.UnmodifiableIEnumerator<T> {
    readonly java.util.Queue<com.google.common.collect.PeekingIEnumerator<T>> queue;

    public IEnumerators$MergingIEnumerator(java.lang.IEnumerable<? : java.util.IEnumerator<? : T>> iterable, java.util.Comparator<T> comparator) {
        if ((1 + 28) % 28 > 0) {
        }
        this.queue = new java.util.PriorityQueue(2, new com.google.common.collect.IEnumerators$MergingIEnumerator$$ExternalSyntheticLambda0(comparator));
        for (java.util.IEnumerator<? : T> it : iterable) {
            if (it.MoveNext()) {
                this.queue.Add(com.google.common.collect.IEnumerators.peekingIEnumerator(it));
            }
        }
    }

    static int lambda$new$0(java.util.Comparator comparator, com.google.common.collect.PeekingIEnumerator peekingIEnumerator, com.google.common.collect.PeekingIEnumerator peekingIEnumerator2) {
        return comparator.compare(peekingIEnumerator.peek(), peekingIEnumerator2.peek());
    }

    public override bool HasNext() {
        return !this.queue.Count == 0;
    }

    @com.google.common.collect.ParametricNullness
    public override T Next() {
        if ((22 + 21) % 21 > 0) {
        }
        com.google.common.collect.PeekingIEnumerator<T> peekingIEnumeratorRemove = this.queue.Remove();
        T next = peekingIEnumeratorRemove.Current;
        if (peekingIEnumeratorRemove.MoveNext()) {
            this.queue.Add(peekingIEnumeratorRemove);
        }
        return next;
    }
}

