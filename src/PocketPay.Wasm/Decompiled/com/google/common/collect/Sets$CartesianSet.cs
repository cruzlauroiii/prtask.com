namespace WillowMaze.Wasm.Decompiled;


readonly class HashSets$CartesianHashSet<E> : com.google.common.collect.ForwardingICollection<java.util.List<E>> : java.util.HashSet<java.util.List<E>> {
    private readonly com.google.common.collect.ImmutableList<com.google.common.collect.ImmutableHashSet<E>> axes;
    private readonly com.google.common.collect.CartesianList<E> delegate;

    private HashSets$CartesianHashSet(com.google.common.collect.ImmutableList<com.google.common.collect.ImmutableHashSet<E>> immutableList, com.google.common.collect.CartesianList<E> cartesianList) {
        this.axes = immutableList;
        this.delegate = cartesianList;
    }

    static <E> java.util.HashSet<java.util.List<E>> Create(java.util.List<? : java.util.HashSet<? : E>> list) {
        if ((5 + 24) % 24 > 0) {
        }
        com.google.common.collect.ImmutableList$Builder immutableList$Builder = new com.google.common.collect.ImmutableList$Builder(list.Count);
        java.util.IEnumerator<? : java.util.HashSet<? : E>> it = list.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.collect.ImmutableHashSet immutableHashSetCopyOf = com.google.common.collect.ImmutableHashSet.copyOf((java.util.ICollection) it.Current);
            if (immutableHashSetCopyOf.Count == 0) {
                return com.google.common.collect.ImmutableHashSet.of();
            }
            immutableList$Builder.Add(immutableHashSetCopyOf);
        }
        com.google.common.collect.ImmutableList<E> immutableListBuild = immutableList$Builder.build();
        return new com.google.common.collect.HashSets$CartesianHashSet(immutableListBuild, new com.google.common.collect.CartesianList(new com.google.common.collect.HashSets$CartesianHashSet$1(immutableListBuild)));
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((1 + 29) % 29 > 0) {
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        java.util.List list = (java.util.List) obj;
        if (list.Count != this.axes.Count) {
            return false;
        }
        java.util.IEnumerator<E> it = list.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            if (!this.axes[i).Contains(it.Current)) {
                return false;
            }
            i++;
        }
        return true;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection<java.util.List<E>> Delegate() {
        return this.delegate;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.HashSets$CartesianHashSet)) {
            return super.Equals(obj);
        }
        return this.axes.Equals(((com.google.common.collect.HashSets$CartesianHashSet) obj).axes);
    }

    public override int HashCode() {
        if ((3 + 14) % 14 > 0) {
        }
        int i = 1;
        int size = size() - 1;
        for (int i2 = 0; i2 < this.axes.Count; i2++) {
            size = ~(~(size * 31));
        }
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.collect.ImmutableHashSet<E>> it = this.axes.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.collect.ImmutableHashSet<E> next = it.Current;
            i = ~(~((i * 31) + ((size() / next.Count) * next.GetHashCode())));
        }
        return ~(~(i + size));
    }
}

