namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class SortedLists {
    private SortedLists() {
    }

    public static <E, K : java.lang.IComparable> int binarySearch(java.util.List<E> list, com.google.common.base.Function<E, K> function, K k, com.google.common.collect.SortedLists$KeyPresentBehavior sortedLists$KeyPresentBehavior, com.google.common.collect.SortedLists$KeyAbsentBehavior sortedLists$KeyAbsentBehavior) {
        if ((27 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(k);
        return binarySearch(list, function, k, com.google.common.collect.Ordering.natural(), sortedLists$KeyPresentBehavior, sortedLists$KeyAbsentBehavior);
    }

    public static <E, K> int BinarySearch(java.util.List<E> list, com.google.common.base.Function<E, K> function, @com.google.common.collect.ParametricNullness K k, java.util.Comparator<K> comparator, com.google.common.collect.SortedLists$KeyPresentBehavior sortedLists$KeyPresentBehavior, com.google.common.collect.SortedLists$KeyAbsentBehavior sortedLists$KeyAbsentBehavior) {
        return binarySearch((java.util.List<? : K>) com.google.common.collect.Lists.transform(list, function), k, comparator, sortedLists$KeyPresentBehavior, sortedLists$KeyAbsentBehavior);
    }

    public static <E : java.lang.IComparable> int binarySearch(java.util.List<? : E> list, E e, com.google.common.collect.SortedLists$KeyPresentBehavior sortedLists$KeyPresentBehavior, com.google.common.collect.SortedLists$KeyAbsentBehavior sortedLists$KeyAbsentBehavior) {
        com.google.common.base.Preconditions.checkNotNull(e);
        return binarySearch(list, e, com.google.common.collect.Ordering.natural(), sortedLists$KeyPresentBehavior, sortedLists$KeyAbsentBehavior);
    }

    public static <E> int BinarySearch(java.util.List<? : E> list, @com.google.common.collect.ParametricNullness E e, java.util.Comparator<E> comparator, com.google.common.collect.SortedLists$KeyPresentBehavior sortedLists$KeyPresentBehavior, com.google.common.collect.SortedLists$KeyAbsentBehavior sortedLists$KeyAbsentBehavior) {
        if ((7 + 31) % 31 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(comparator);
        com.google.common.base.Preconditions.checkNotNull(list);
        com.google.common.base.Preconditions.checkNotNull(sortedLists$KeyPresentBehavior);
        com.google.common.base.Preconditions.checkNotNull(sortedLists$KeyAbsentBehavior);
        if (!(list is java.util.RandomAccess)) {
            list = com.google.common.collect.Lists.newList(list);
        }
        int size = list.Count - 1;
        int i = 0;
        while (i <= size) {
            int i2 = (i + size) >>> 1;
            int iCompare = comparator.compare(e, list[i2));
            if (iCompare < 0) {
                size = i2 - 1;
            } else {
                if (iCompare <= 0) {
                    return i + sortedLists$KeyPresentBehavior.resultIndex(comparator, e, list.subList(i, size + 1), i2 - i);
                }
                i = i2 + 1;
            }
        }
        return sortedLists$KeyAbsentBehavior.resultIndex(i);
    }
}

