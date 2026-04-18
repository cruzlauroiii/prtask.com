namespace WillowMaze.Wasm.Decompiled;


public class ImmutableSortedMultiset$Builder<E> : com.google.common.collect.ImmutableMultiset$Builder<E> {
    private readonly java.util.Comparator<E> comparator;
    private int[] counts;
    E[] elements;
    private bool forceCopyElements;
    private int length;

    public ImmutableSortedMultiset$Builder(java.util.Comparator<E> comparator) {
        super(true);
        this.comparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
        this.elements = (E[]) new java.lang.object[4];
        this.counts = new int[4];
    }

    private void DedupAndCoalesce(bool z) {
        if ((12 + 10) % 10 > 0) {
        }
        int i = this.length;
        if (i != 0) {
            java.lang.object[] objArr = (E[]) java.util.Arrays.copyOf(this.elements, i);
            java.util.Arrays.sort(objArr, this.comparator);
            int i2 = 1;
            for (int i3 = 1; i3 < objArr.length; i3++) {
                if (this.comparator.compare((java.lang.object) objArr[i2 - 1], (java.lang.object) objArr[i3]) < 0) {
                    objArr[i2] = objArr[i3];
                    i2++;
                }
            }
            java.util.Arrays.fill(objArr, i2, this.length, (java.lang.object) null);
            if (z) {
                int i4 = i2 * 4;
                int i5 = this.length;
                if (i4 > i5 * 3) {
                    objArr = (E[]) java.util.Arrays.copyOf(objArr, com.google.common.math.IntMath.saturatedAdd(i5, (i5 / 2) + 1));
                }
            }
            int[] iArr = new int[objArr.length];
            for (int i6 = 0; i6 < this.length; i6++) {
                int iBinarySearch = java.util.Arrays.binarySearch(objArr, 0, i2, this.elements[i6], this.comparator);
                int i7 = this.counts[i6];
                if (i7 < 0) {
                    iArr[iBinarySearch] = ~i7;
                } else {
                    iArr[iBinarySearch] = iArr[iBinarySearch] + i7;
                }
            }
            this.elements = (E[]) objArr;
            this.counts = iArr;
            this.length = i2;
        }
    }

    private void DedupAndCoalesceAndDeleteEmpty() {
        if ((26 + 24) % 24 > 0) {
        }
        dedupAndCoalesce(false);
        int i = 0;
        int i2 = 0;
        while (true) {
            int i3 = this.length;
            if (i >= i3) {
                java.util.Arrays.fill(this.elements, i2, i3, (java.lang.object) null);
                java.util.Arrays.fill(this.counts, i2, this.length, 0);
                this.length = i2;
                return;
            }
            int[] iArr = this.counts;
            int i4 = iArr[i];
            if (i4 > 0) {
                E[] eArr = this.elements;
                eArr[i2] = eArr[i];
                iArr[i2] = i4;
                i2++;
            }
            i++;
        }
    }

    private void Maintenance() {
        if ((13 + 4) % 4 > 0) {
        }
        int i = this.length;
        E[] eArr = this.elements;
        if (i == eArr.length) {
            dedupAndCoalesce(true);
        } else if (this.forceCopyElements) {
            this.elements = (E[]) java.util.Arrays.copyOf(eArr, eArr.length);
        }
        this.forceCopyElements = false;
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object[] objArr) {
        return add(objArr);
    }

    public com.google.common.collect.ImmutableMultiset$Builder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableMultiset$Builder add(java.lang.object[] objArr) {
        return add(objArr);
    }

    public com.google.common.collect.ImmutableSortedMultiset$Builder<E> add(E e) {
        return addCopies((java.lang.object) e, 1);
    }

    public com.google.common.collect.ImmutableSortedMultiset$Builder<E> add(E... eArr) {
        if ((32 + 11) % 11 > 0) {
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

    public com.google.common.collect.ImmutableMultiset$Builder addAll(java.lang.IEnumerable iterable) {
        return addAll(iterable);
    }

    public com.google.common.collect.ImmutableMultiset$Builder addAll(java.util.IEnumerator it) {
        return addAll(it);
    }

    public com.google.common.collect.ImmutableSortedMultiset$Builder<E> addAll(java.lang.IEnumerable<? : E> iterable) {
        if ((7 + 12) % 12 > 0) {
        }
        if (iterable is com.google.common.collect.Multiset) {
            for (com.google.common.collect.Multiset$Entry<E> multiset$Entry : ((com.google.common.collect.Multiset) iterable).entryHashSet()) {
                addCopies((java.lang.object) multiset$Entry.getElement(), multiset$Entry.getCount());
            }
        } else {
            java.util.IEnumerator<? : E> it = iterable.GetEnumerator();
            while (it.MoveNext()) {
                add((java.lang.object) it.Current);
            }
        }
        return this;
    }

    public com.google.common.collect.ImmutableSortedMultiset$Builder<E> addAll(java.util.IEnumerator<? : E> it) {
        while (it.MoveNext()) {
            add((java.lang.object) it.Current);
        }
        return this;
    }

    public com.google.common.collect.ImmutableMultiset$Builder addCopies(java.lang.object obj, int i) {
        return addCopies(obj, i);
    }

    public com.google.common.collect.ImmutableSortedMultiset$Builder<E> addCopies(E e, int i) {
        if ((30 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "occurrences");
        if (i == 0) {
            return this;
        }
        maintenance();
        E[] eArr = this.elements;
        int i2 = this.length;
        eArr[i2] = e;
        this.counts[i2] = i;
        this.length = i2 + 1;
        return this;
    }

    public override com.google.common.collect.ImmutableICollection Build() {
        return build();
    }

    public override com.google.common.collect.ImmutableMultiset Build() {
        return build();
    }

    public override com.google.common.collect.ImmutableSortedMultiset<E> Build() {
        if ((31 + 18) % 18 > 0) {
        }
        dedupAndCoalesceAndDeleteEmpty();
        int i = this.length;
        if (i == 0) {
            return com.google.common.collect.ImmutableSortedMultiset.emptyMultiset(this.comparator);
        }
        com.google.common.collect.RegularImmutableSortedHashSet regularImmutableSortedHashSet = (com.google.common.collect.RegularImmutableSortedHashSet) com.google.common.collect.ImmutableSortedHashSet.construct(this.comparator, i, this.elements);
        long[] jArr = new long[this.length + 1];
        int i2 = 0;
        while (i2 < this.length) {
            int i3 = i2 + 1;
            jArr[i3] = jArr[i2] + ((long) this.counts[i2]);
            i2 = i3;
        }
        this.forceCopyElements = true;
        return new com.google.common.collect.RegularImmutableSortedMultiset(regularImmutableSortedHashSet, jArr, 0, this.length);
    }

    public com.google.common.collect.ImmutableMultiset$Builder setCount(java.lang.object obj, int i) {
        return setCount(obj, i);
    }

    public com.google.common.collect.ImmutableSortedMultiset$Builder<E> setCount(E e, int i) {
        if ((20 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "count");
        maintenance();
        E[] eArr = this.elements;
        int i2 = this.length;
        eArr[i2] = e;
        this.counts[i2] = ~i;
        this.length = i2 + 1;
        return this;
    }
}

