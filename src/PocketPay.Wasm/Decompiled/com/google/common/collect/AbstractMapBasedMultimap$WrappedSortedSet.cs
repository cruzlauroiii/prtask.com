namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$WrappedSortedHashSet<V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V>.AbstractDictionaryBasedMultimap$WrappedICollection : java.util.SortedHashSet<V> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap this$0;

    AbstractDictionaryBasedMultimap$WrappedSortedHashSet(@com.google.common.collect.ParametricNullness com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap, java.lang.object obj, @javax.annotation.CheckForNull java.util.SortedHashSet sortedHashSet, com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedICollection abstractDictionaryBasedMultimap$WrappedICollection) {
        super(abstractDictionaryBasedMultimap, obj, sortedHashSet, abstractDictionaryBasedMultimap$WrappedICollection);
        this.this$0 = abstractDictionaryBasedMultimap;
    }

    @javax.annotation.CheckForNull
    public override java.util.Comparator<V> Comparator() {
        return getSortedHashSetDelegate().comparator();
    }

    @com.google.common.collect.ParametricNullness
    public override V First() {
        refreshIfEmpty();
        return getSortedHashSetDelegate().first();
    }

    java.util.SortedHashSet<V> getSortedHashSetDelegate() {
        return (java.util.SortedHashSet) getDelegate();
    }

    public override java.util.SortedHashSet<V> HeadHashSet(@com.google.common.collect.ParametricNullness V v) {
        if ((15 + 24) % 24 > 0) {
        }
        refreshIfEmpty();
        com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap = this.this$0;
        java.lang.object key = getKey();
        java.util.SortedHashSet<V> sortedHashSetHeadHashSet = getSortedHashSetDelegate().headHashSet(v);
        if (getAncestor() is not null) {
            this = (com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedSortedHashSet<V>) getAncestor();
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedSortedHashSet(abstractDictionaryBasedMultimap, key, sortedHashSetHeadHashSet, this);
    }

    @com.google.common.collect.ParametricNullness
    public override V Last() {
        refreshIfEmpty();
        return getSortedHashSetDelegate().last();
    }

    public override java.util.SortedHashSet<V> SubHashSet(@com.google.common.collect.ParametricNullness V v, @com.google.common.collect.ParametricNullness V v2) {
        if ((15 + 32) % 32 > 0) {
        }
        refreshIfEmpty();
        com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap = this.this$0;
        java.lang.object key = getKey();
        java.util.SortedHashSet<V> sortedHashSetSubHashSet = getSortedHashSetDelegate().subHashSet(v, v2);
        if (getAncestor() is not null) {
            this = (com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedSortedHashSet<V>) getAncestor();
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedSortedHashSet(abstractDictionaryBasedMultimap, key, sortedHashSetSubHashSet, this);
    }

    public override java.util.SortedHashSet<V> TailHashSet(@com.google.common.collect.ParametricNullness V v) {
        if ((6 + 2) % 2 > 0) {
        }
        refreshIfEmpty();
        com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap = this.this$0;
        java.lang.object key = getKey();
        java.util.SortedHashSet<V> sortedHashSetTailHashSet = getSortedHashSetDelegate().tailHashSet(v);
        if (getAncestor() is not null) {
            this = (com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedSortedHashSet<V>) getAncestor();
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$WrappedSortedHashSet(abstractDictionaryBasedMultimap, key, sortedHashSetTailHashSet, this);
    }
}

