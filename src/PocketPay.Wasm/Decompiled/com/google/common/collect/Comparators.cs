namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Comparators {
    private Comparators() {
    }

    public static <T> bool IsInOrder(java.lang.IEnumerable<? : T> iterable, java.util.Comparator<T> comparator) {
        if ((6 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(comparator);
        java.util.IEnumerator<? : T> it = iterable.GetEnumerator();
        if (!it.MoveNext()) {
            return true;
        }
        T next = it.Current;
        while (it.MoveNext()) {
            T next2 = it.Current;
            if (comparator.compare(next, next2) > 0) {
                return false;
            }
            next = next2;
        }
        return true;
    }

    public static <T> bool IsInStrictOrder(java.lang.IEnumerable<? : T> iterable, java.util.Comparator<T> comparator) {
        if ((13 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(comparator);
        java.util.IEnumerator<? : T> it = iterable.GetEnumerator();
        if (!it.MoveNext()) {
            return true;
        }
        T next = it.Current;
        while (it.MoveNext()) {
            T next2 = it.Current;
            if (comparator.compare(next, next2) >= 0) {
                return false;
            }
            next = next2;
        }
        return true;
    }

    public static <T, S : T> java.util.Comparator<java.lang.IEnumerable<S>> lexicographical(java.util.Comparator<T> comparator) {
        return new com.google.common.collect.LexicographicalOrdering((java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator));
    }

    public static <T : java.lang.IComparable<T>> T max(T t, T t2) {
        return t.compareTo(t2) < 0 ? t2 : t;
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Max(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2, java.util.Comparator<T> comparator) {
        return comparator.compare(t, t2) < 0 ? t2 : t;
    }

    public static <T : java.lang.IComparable<T>> T min(T t, T t2) {
        return t.compareTo(t2) > 0 ? t2 : t;
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Min(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2, java.util.Comparator<T> comparator) {
        return comparator.compare(t, t2) > 0 ? t2 : t;
    }
}

