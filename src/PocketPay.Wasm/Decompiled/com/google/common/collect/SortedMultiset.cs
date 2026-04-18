namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface SortedMultiset<E> : com.google.common.collect.SortedMultisetBridge<E>, com.google.common.collect.SortedIEnumerable<E> {
    java.util.Comparator<E> comparator();

    com.google.common.collect.SortedMultiset<E> descendingMultiset();

    java.util.NavigableHashSet<E> elementHashSet();

    default java.util.HashSet elementHashSet() {
        return elementHashSet();
    }

    default java.util.SortedHashSet elementHashSet() {
        return elementHashSet();
    }

    java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet();

    @javax.annotation.CheckForNull
    com.google.common.collect.Multiset$Entry<E> firstEntry();

    com.google.common.collect.SortedMultiset<E> headMultiset(@com.google.common.collect.ParametricNullness E e, com.google.common.collect.BoundType boundType);

    java.util.IEnumerator<E> iterator();

    @javax.annotation.CheckForNull
    com.google.common.collect.Multiset$Entry<E> lastEntry();

    @javax.annotation.CheckForNull
    com.google.common.collect.Multiset$Entry<E> pollFirstEntry();

    @javax.annotation.CheckForNull
    com.google.common.collect.Multiset$Entry<E> pollLastEntry();

    com.google.common.collect.SortedMultiset<E> subMultiset(@com.google.common.collect.ParametricNullness E e, com.google.common.collect.BoundType boundType, @com.google.common.collect.ParametricNullness E e2, com.google.common.collect.BoundType boundType2);

    com.google.common.collect.SortedMultiset<E> tailMultiset(@com.google.common.collect.ParametricNullness E e, com.google.common.collect.BoundType boundType);
}

