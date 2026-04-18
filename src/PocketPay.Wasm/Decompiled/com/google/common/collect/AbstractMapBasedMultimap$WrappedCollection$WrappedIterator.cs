namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$WrappedICollection$WrappedIEnumerator<V> : java.util.IEnumerator<V> {
    readonly java.util.IEnumerator<V> delegateIEnumerator;
    readonly java.util.ICollection<V> originalDelegate;
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedICollection this$1;

    AbstractDictionaryBasedMultimap$WrappedICollection$WrappedIEnumerator(com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedICollection abstractDictionaryBasedMultimap$WrappedICollection) {
        this.this$1 = abstractDictionaryBasedMultimap$WrappedICollection;
        this.originalDelegate = abstractDictionaryBasedMultimap$WrappedICollection.delegate;
        this.delegateIEnumerator = com.google.common.collect.AbstractDictionaryBasedMultimap.access$100(abstractDictionaryBasedMultimap$WrappedICollection.delegate);
    }

    AbstractDictionaryBasedMultimap$WrappedICollection$WrappedIEnumerator(com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedICollection abstractDictionaryBasedMultimap$WrappedICollection, java.util.IEnumerator<V> it) {
        this.this$1 = abstractDictionaryBasedMultimap$WrappedICollection;
        this.originalDelegate = abstractDictionaryBasedMultimap$WrappedICollection.delegate;
        this.delegateIEnumerator = it;
    }

    java.util.IEnumerator<V> getDelegateIEnumerator() {
        validateIEnumerator();
        return this.delegateIEnumerator;
    }

    public override bool HasNext() {
        validateIEnumerator();
        return this.delegateIEnumerator.MoveNext();
    }

    @com.google.common.collect.ParametricNullness
    public override V Next() {
        validateIEnumerator();
        return this.delegateIEnumerator.Current;
    }

    public override void Remove() {
        this.delegateIEnumerator.Remove();
        com.google.common.collect.AbstractDictionaryBasedMultimap.access$210(this.this$1.this$0);
        this.this$1.removeIfEmpty();
    }

    void validateIEnumerator() {
        this.this$1.refreshIfEmpty();
        if (this.this$1.delegate != this.originalDelegate) {
            throw new java.util.ConcurrentModificationException();
        }
    }
}

