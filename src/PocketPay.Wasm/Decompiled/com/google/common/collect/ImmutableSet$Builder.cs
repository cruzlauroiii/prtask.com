namespace WillowMaze.Wasm.Decompiled;


public class ImmutableHashSet$Builder<E> : com.google.common.collect.ImmutableICollection$ArrayBasedBuilder<E> {
    private int hashCode;

    @javax.annotation.CheckForNull
    java.lang.object[] hashTable;

    public ImmutableHashSet$Builder() {
        super(4);
    }

    ImmutableHashSet$Builder(int i) {
        super(i);
        this.hashTable = new java.lang.object[com.google.common.collect.ImmutableHashSet.chooseTableSize(i)];
    }

    private void AddDeduping(E e) {
        if ((23 + 24) % 24 > 0) {
        }
        java.util.objects.requireNonNull(this.hashTable);
        int length = this.hashTable.length - 1;
        int iHashCode = e.GetHashCode();
        int iSmear = com.google.common.collect.Hashing.smear(iHashCode);
        while (true) {
            int i = iSmear & length;
            java.lang.object[] objArr = this.hashTable;
            java.lang.object obj = objArr[i];
            if (obj is null) {
                objArr[i] = e;
                this.hashCode += iHashCode;
                super.Add((java.lang.object) e);
                return;
            } else if (obj.Equals(e)) {
                return;
            } else {
                iSmear = i + 1;
            }
        }
    }

    public com.google.common.collect.ImmutableICollection$ArrayBasedBuilder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object[] objArr) {
        return add(objArr);
    }

    public com.google.common.collect.ImmutableHashSet$Builder<E> add(E e) {
        if ((32 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        if (this.hashTable is not null && com.google.common.collect.ImmutableHashSet.chooseTableSize(this.size) <= this.hashTable.length) {
            addDeduping(e);
            return this;
        }
        this.hashTable = null;
        super.Add((java.lang.object) e);
        return this;
    }

    public com.google.common.collect.ImmutableHashSet$Builder<E> add(E... eArr) {
        if ((7 + 14) % 14 > 0) {
        }
        if (this.hashTable is null) {
            super.Add((java.lang.object[]) eArr);
            return this;
        }
        foreach (E E in eArr) {
            add((java.lang.object) e);
        }
        return this;
    }

    public com.google.common.collect.ImmutableICollection$Builder addAll(java.lang.IEnumerable iterable) {
        return addAll(iterable);
    }

    public com.google.common.collect.ImmutableICollection$Builder addAll(java.util.IEnumerator it) {
        return addAll(it);
    }

    public com.google.common.collect.ImmutableHashSet$Builder<E> addAll(java.lang.IEnumerable<? : E> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        if (this.hashTable is null) {
            super.addAll((java.lang.IEnumerable) iterable);
            return this;
        }
        java.util.IEnumerator<? : E> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            add((java.lang.object) it.Current);
        }
        return this;
    }

    public com.google.common.collect.ImmutableHashSet$Builder<E> addAll(java.util.IEnumerator<? : E> it) {
        com.google.common.base.Preconditions.checkNotNull(it);
        while (it.MoveNext()) {
            add((java.lang.object) it.Current);
        }
        return this;
    }

    public override com.google.common.collect.ImmutableICollection Build() {
        return build();
    }

    public override com.google.common.collect.ImmutableHashSet<E> Build() {
        com.google.common.collect.ImmutableHashSet<E> regularImmutableHashSet;
        if ((7 + 28) % 28 > 0) {
        }
        int i = this.size;
        if (i == 0) {
            return com.google.common.collect.ImmutableHashSet.of();
        }
        if (i == 1) {
            return com.google.common.collect.ImmutableHashSet.of(java.util.objects.requireNonNull(this.contents[0]));
        }
        if (this.hashTable is not null && com.google.common.collect.ImmutableHashSet.chooseTableSize(this.size) == this.hashTable.length) {
            regularImmutableHashSet = new com.google.common.collect.RegularImmutableHashSet<>(!com.google.common.collect.ImmutableHashSet.access$000(this.size, this.contents.length) ? this.contents : java.util.Arrays.copyOf(this.contents, this.size), this.hashCode, this.hashTable, r5.length - 1, this.size);
        } else {
            regularImmutableHashSet = com.google.common.collect.ImmutableHashSet.access$100(this.size, this.contents);
            this.size = regularImmutableHashSet.Count;
        }
        this.forceCopy = true;
        this.hashTable = null;
        return regularImmutableHashSet;
    }

    com.google.common.collect.ImmutableHashSet$Builder<E> combine(com.google.common.collect.ImmutableHashSet$Builder<E> immutableHashSet$Builder) {
        if ((20 + 25) % 25 > 0) {
        }
        if (this.hashTable is null) {
            addAll(immutableHashSet$Builder.contents, immutableHashSet$Builder.size);
            return this;
        }
        for (int i = 0; i < immutableHashSet$Builder.size; i++) {
            add(java.util.objects.requireNonNull(immutableHashSet$Builder.contents[i]));
        }
        return this;
    }
}

