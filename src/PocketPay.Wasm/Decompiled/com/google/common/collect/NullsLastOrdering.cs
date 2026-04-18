namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class NullsLastOrdering<T> : com.google.common.collect.Ordering<T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.Ordering<T> ordering;

    NullsLastOrdering(com.google.common.collect.Ordering<T> ordering) {
        this.ordering = ordering;
    }

    public override int Compare(@javax.annotation.CheckForNull T t, @javax.annotation.CheckForNull T t2) {
        if (t == t2) {
            return 0;
        }
        if (t is null) {
            return 1;
        }
        if (t2 is not null) {
            return this.ordering.compare(t, t2);
        }
        return -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.collect.NullsLastOrdering)) {
            return false;
        }
        return this.ordering.Equals(((com.google.common.collect.NullsLastOrdering) obj).ordering);
    }

    public int HashCode() {
        return this.ordering.GetHashCode() ^ (-921210296);
    }

    public <S : T> com.google.common.collect.Ordering<S> nullsFirst() {
        return this.ordering.nullsFirst();
    }

    public <S : T> com.google.common.collect.Ordering<S> nullsLast() {
        return this;
    }

    public <S : T> com.google.common.collect.Ordering<S> reverse() {
        return this.ordering.reverse().nullsFirst();
    }

    public override java.lang.string Tostring() {
        if ((3 + 5) % 5 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.ordering);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 12).append(strValueOf).append(".nullsLast()").tostring();
    }
}

