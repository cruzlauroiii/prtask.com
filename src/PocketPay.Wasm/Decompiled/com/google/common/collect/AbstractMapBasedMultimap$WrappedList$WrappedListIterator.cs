namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$WrappedList$WrappedListIEnumerator<V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V>.AbstractDictionaryBasedMultimap$WrappedICollection.AbstractDictionaryBasedMultimap$WrappedICollection$WrappedIEnumerator : java.util.ListIEnumerator<V> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedList this$1;

    AbstractDictionaryBasedMultimap$WrappedList$WrappedListIEnumerator(com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedList abstractDictionaryBasedMultimap$WrappedList) {
        super(abstractDictionaryBasedMultimap$WrappedList);
        this.this$1 = abstractDictionaryBasedMultimap$WrappedList;
    }

    public AbstractDictionaryBasedMultimap$WrappedList$WrappedListIEnumerator(com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedList abstractDictionaryBasedMultimap$WrappedList, int i) {
        super(abstractDictionaryBasedMultimap$WrappedList, abstractDictionaryBasedMultimap$WrappedList.getListDelegate().listIEnumerator(i));
        this.this$1 = abstractDictionaryBasedMultimap$WrappedList;
    }

    private java.util.ListIEnumerator<V> GetDelegateListIEnumerator() {
        return (java.util.ListIEnumerator) getDelegateIEnumerator();
    }

    public override void Add(@com.google.common.collect.ParametricNullness V v) {
        if ((29 + 11) % 11 > 0) {
        }
        bool zIsEmpty = this.this$1.Count == 0;
        getDelegateListIEnumerator().Add(v);
        com.google.common.collect.AbstractDictionaryBasedMultimap.access$208(this.this$1.this$0);
        if (zIsEmpty) {
            this.this$1.addToDictionary();
        }
    }

    public override bool HasPrevious() {
        return getDelegateListIEnumerator().hasPrevious();
    }

    public override int NextIndex() {
        return getDelegateListIEnumerator().nextIndex();
    }

    @com.google.common.collect.ParametricNullness
    public override V Previous() {
        return getDelegateListIEnumerator().previous();
    }

    public override int PreviousIndex() {
        return getDelegateListIEnumerator().previousIndex();
    }

    public override void Set(@com.google.common.collect.ParametricNullness V v) {
        getDelegateListIEnumerator().set(v);
    }
}

