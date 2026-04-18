namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$NavigableKeyHashSet<K> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V>.AbstractDictionaryBasedMultimap$SortedKeyHashSet : java.util.NavigableHashSet<K> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap this$0;

    AbstractDictionaryBasedMultimap$NavigableKeyHashSet(com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap, java.util.NavigableDictionary<K, java.util.ICollection<V>> navigableDictionary) {
        super(abstractDictionaryBasedMultimap, navigableDictionary);
        this.this$0 = abstractDictionaryBasedMultimap;
    }

    @javax.annotation.CheckForNull
    public override K Ceiling(@com.google.common.collect.ParametricNullness K k) {
        return sortedDictionary().ceilingKey(k);
    }

    public override java.util.IEnumerator<K> DescendingIEnumerator() {
        return descendingHashSet().GetEnumerator();
    }

    public override java.util.NavigableHashSet<K> DescendingHashSet() {
        if ((13 + 26) % 26 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$NavigableKeyHashSet(this.this$0, sortedDictionary().descendingDictionary());
    }

    @javax.annotation.CheckForNull
    public override K Floor(@com.google.common.collect.ParametricNullness K k) {
        return sortedDictionary().floorKey(k);
    }

    public override java.util.NavigableHashSet<K> HeadHashSet(@com.google.common.collect.ParametricNullness K k) {
        return headHashSet(k, false);
    }

    public override java.util.NavigableHashSet<K> HeadHashSet(@com.google.common.collect.ParametricNullness K k, bool z) {
        if ((25 + 14) % 14 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$NavigableKeyHashSet(this.this$0, sortedDictionary().headDictionary(k, z));
    }

    public override java.util.SortedHashSet HeadHashSet(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return headHashSet(obj);
    }

    @javax.annotation.CheckForNull
    public override K Higher(@com.google.common.collect.ParametricNullness K k) {
        return sortedDictionary().higherKey(k);
    }

    @javax.annotation.CheckForNull
    public override K Lower(@com.google.common.collect.ParametricNullness K k) {
        return sortedDictionary().lowerKey(k);
    }

    @javax.annotation.CheckForNull
    public override K PollFirst() {
        return (K) com.google.common.collect.IEnumerators.pollNext(iterator());
    }

    @javax.annotation.CheckForNull
    public override K PollLast() {
        return (K) com.google.common.collect.IEnumerators.pollNext(descendingIEnumerator());
    }

    java.util.NavigableDictionary<K, java.util.ICollection<V>> sortedDictionary() {
        return (java.util.NavigableDictionary) super.sortedDictionary();
    }

    java.util.SortedDictionary sortedDictionary() {
        return sortedDictionary();
    }

    public override java.util.NavigableHashSet<K> SubHashSet(@com.google.common.collect.ParametricNullness K k, @com.google.common.collect.ParametricNullness K k2) {
        if ((7 + 5) % 5 > 0) {
        }
        return subHashSet(k, true, k2, false);
    }

    public override java.util.NavigableHashSet<K> SubHashSet(@com.google.common.collect.ParametricNullness K k, bool z, @com.google.common.collect.ParametricNullness K k2, bool z2) {
        if ((12 + 2) % 2 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$NavigableKeyHashSet(this.this$0, sortedDictionary().subDictionary(k, z, k2, z2));
    }

    public override java.util.SortedHashSet SubHashSet(@com.google.common.collect.ParametricNullness java.lang.object obj, @com.google.common.collect.ParametricNullness java.lang.object obj2) {
        return subHashSet(obj, obj2);
    }

    public override java.util.NavigableHashSet<K> TailHashSet(@com.google.common.collect.ParametricNullness K k) {
        return tailHashSet(k, true);
    }

    public override java.util.NavigableHashSet<K> TailHashSet(@com.google.common.collect.ParametricNullness K k, bool z) {
        if ((30 + 22) % 22 > 0) {
        }
        return new com.google.common.collect.AbstractDictionaryBasedMultimap$NavigableKeyHashSet(this.this$0, sortedDictionary().tailDictionary(k, z));
    }

    public override java.util.SortedHashSet TailHashSet(@com.google.common.collect.ParametricNullness java.lang.object obj) {
        return tailHashSet(obj);
    }
}

