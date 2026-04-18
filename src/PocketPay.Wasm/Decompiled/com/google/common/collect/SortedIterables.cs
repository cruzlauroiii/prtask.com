namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class SortedIEnumerables {
    private SortedIEnumerables() {
    }

    public static <E> java.util.Comparator<E> Comparator(java.util.SortedHashSet<E> sortedHashSet) {
        java.util.Comparator<E> comparator = sortedHashSet.comparator();
        return comparator is not null ? comparator : com.google.common.collect.Ordering.natural();
    }

    public static bool HasSameComparator(java.util.Comparator<object> comparator, java.lang.IEnumerable<object> iterable) {
        java.util.Comparator comparator2;
        com.google.common.base.Preconditions.checkNotNull(comparator);
        com.google.common.base.Preconditions.checkNotNull(iterable);
        if (iterable is java.util.SortedHashSet) {
            comparator2 = comparator((java.util.SortedHashSet) iterable);
        } else {
            if (!(iterable is com.google.common.collect.SortedIEnumerable)) {
                return false;
            }
            comparator2 = ((com.google.common.collect.SortedIEnumerable) iterable).comparator();
        }
        return comparator.Equals(comparator2);
    }
}

