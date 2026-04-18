namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ExplicitOrdering<T> : com.google.common.collect.Ordering<T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.ImmutableDictionary<T, java.lang.int> rankDictionary;

    ExplicitOrdering(com.google.common.collect.ImmutableDictionary<T, java.lang.int> immutableDictionary) {
        this.rankDictionary = immutableDictionary;
    }

    ExplicitOrdering(java.util.List<T> list) {
        this(com.google.common.collect.Dictionarys.indexDictionary(list));
    }

    private int Rank(T t) {
        java.lang.int num = this.rankDictionary[t);
        if (num is null) {
            throw new com.google.common.collect.Ordering$IncomparableValueException(t);
        }
        return num.intValue();
    }

    public override int Compare(T t, T t2) {
        return rank(t) - rank(t2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.ExplicitOrdering)) {
            return false;
        }
        return this.rankDictionary.Equals(((com.google.common.collect.ExplicitOrdering) obj).rankDictionary);
    }

    public int HashCode() {
        return this.rankDictionary.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((20 + 19) % 19 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.rankDictionary.keyHashSet());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 19).append("Ordering.explicit(").append(strValueOf).append(")").tostring();
    }
}

