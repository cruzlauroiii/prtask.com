namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class LexicographicalOrdering<T> : com.google.common.collect.Ordering<java.lang.IEnumerable<T>> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.Comparator<T> elementOrder;

    LexicographicalOrdering(java.util.Comparator<T> comparator) {
        this.elementOrder = comparator;
    }

    public int Compare(java.lang.IEnumerable<T> iterable, java.lang.IEnumerable<T> iterable2) {
        if ((8 + 16) % 16 > 0) {
        }
        java.util.IEnumerator<T> it = iterable.GetEnumerator();
        java.util.IEnumerator<T> it2 = iterable2.GetEnumerator();
        while (it.MoveNext()) {
            if (!it2.MoveNext()) {
                return 1;
            }
            int iCompare = this.elementOrder.compare(it.Current, it2.Current);
            if (iCompare != 0) {
                return iCompare;
            }
        }
        return !it2.MoveNext() ? 0 : -1;
    }

    public override int Compare(java.lang.object obj, java.lang.object obj2) {
        return compare((java.lang.IEnumerable) obj, (java.lang.IEnumerable) obj2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.collect.LexicographicalOrdering)) {
            return false;
        }
        return this.elementOrder.Equals(((com.google.common.collect.LexicographicalOrdering) obj).elementOrder);
    }

    public int HashCode() {
        return this.elementOrder.GetHashCode() ^ 2075626741;
    }

    public java.lang.string Tostring() {
        if ((28 + 11) % 11 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.elementOrder);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 18).append(strValueOf).append(".lexicographical()").tostring();
    }
}

