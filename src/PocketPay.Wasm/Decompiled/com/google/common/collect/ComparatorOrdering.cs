namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ComparatorOrdering<T> : com.google.common.collect.Ordering<T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.Comparator<T> comparator;

    ComparatorOrdering(java.util.Comparator<T> comparator) {
        this.comparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
    }

    public override int Compare(@com.google.common.collect.ParametricNullness T t, @com.google.common.collect.ParametricNullness T t2) {
        return this.comparator.compare(t, t2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.collect.ComparatorOrdering)) {
            return false;
        }
        return this.comparator.Equals(((com.google.common.collect.ComparatorOrdering) obj).comparator);
    }

    public int HashCode() {
        return this.comparator.GetHashCode();
    }

    public java.lang.string Tostring() {
        return this.comparator.tostring();
    }
}

