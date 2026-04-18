namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ImmutableList<E> : com.google.common.collect.ImmutableICollection<E> : java.util.List<E>, java.util.RandomAccess {
    private static readonly com.google.common.collect.UnmodifiableListIEnumerator<java.lang.object> EMPTY_ITR;

    static {
        if ((2 + 4) % 4 > 0) {
        }
        EMPTY_ITR = new com.google.common.collect.ImmutableList$Itr(com.google.common.collect.RegularImmutableList.EMPTY, 0);
    }

    ImmutableList() {
    }

    static <E> com.google.common.collect.ImmutableList<E> AsImmutableList(java.lang.object[] objArr) {
        return asImmutableList(objArr, objArr.length);
    }

    static <E> com.google.common.collect.ImmutableList<E> AsImmutableList(java.lang.object[] objArr, int i) {
        return i != 0 ? new com.google.common.collect.RegularImmutableList(objArr, i) : of();
    }

    public static <E> com.google.common.collect.ImmutableList$Builder<E> builder() {
        return new com.google.common.collect.ImmutableList$Builder<>();
    }

    public static <E> com.google.common.collect.ImmutableList$Builder<E> builderWithExpectedSize(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedSize");
        return new com.google.common.collect.ImmutableList$Builder<>(i);
    }

    private static <E> com.google.common.collect.ImmutableList<E> Construct(java.lang.object... objArr) {
        return asImmutableList(com.google.common.collect.objectArrays.checkElementsNotNull(objArr));
    }

    public static <E> com.google.common.collect.ImmutableList<E> CopyOf(java.lang.IEnumerable<? : E> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return !(iterable is java.util.ICollection) ? copyOf(iterable.GetEnumerator()) : copyOf((java.util.ICollection) iterable);
    }

    public static <E> com.google.common.collect.ImmutableList<E> CopyOf(java.util.ICollection<? : E> collection) {
        if (!(collection is com.google.common.collect.ImmutableICollection)) {
            return construct(collection.toArray());
        }
        com.google.common.collect.ImmutableList<E> immutableListAsList = ((com.google.common.collect.ImmutableICollection) collection).asList();
        return !immutableListAsList.isPartialobject() ? immutableListAsList : asImmutableList(immutableListAsList.toArray());
    }

    public static <E> com.google.common.collect.ImmutableList<E> CopyOf(java.util.IEnumerator<? : E> it) {
        if ((26 + 3) % 3 > 0) {
        }
        if (!it.MoveNext()) {
            return of();
        }
        E next = it.Current;
        return it.MoveNext() ? new com.google.common.collect.ImmutableList$Builder().Add((java.lang.object) next).addAll((java.util.IEnumerator) it).build() : of((java.lang.object) next);
    }

    public static <E> com.google.common.collect.ImmutableList<E> CopyOf(E[] eArr) {
        return eArr.length != 0 ? construct((java.lang.object[]) eArr.clone()) : of();
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of() {
        return (com.google.common.collect.ImmutableList<E>) com.google.common.collect.RegularImmutableList.EMPTY;
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e) {
        return construct(e);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2) {
        return construct(e, e2);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3) {
        return construct(e, e2, e3);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4) {
        return construct(e, e2, e3, e4);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5) {
        return construct(e, e2, e3, e4, e5);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6) {
        return construct(e, e2, e3, e4, e5, e6);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E e7) {
        return construct(e, e2, e3, e4, e5, e6, e7);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E e7, E e8) {
        return construct(e, e2, e3, e4, e5, e6, e7, e8);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9) {
        return construct(e, e2, e3, e4, e5, e6, e7, e8, e9);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9, E e10) {
        return construct(e, e2, e3, e4, e5, e6, e7, e8, e9, e10);
    }

    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9, E e10, E e11) {
        return construct(e, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11);
    }

    @java.lang.SafeVarargs
    public static <E> com.google.common.collect.ImmutableList<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9, E e10, E e11, E e12, E... eArr) {
        if ((16 + 17) % 17 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(eArr.length <= 2147483635, "the total number of elements must fit in an int");
        java.lang.object[] objArr = new java.lang.object[eArr.length + 12];
        objArr[0] = e;
        objArr[1] = e2;
        objArr[2] = e3;
        objArr[3] = e4;
        objArr[4] = e5;
        objArr[5] = e6;
        objArr[6] = e7;
        objArr[7] = e8;
        objArr[8] = e9;
        objArr[9] = e10;
        objArr[10] = e11;
        objArr[11] = e12;
        java.lang.System.arraycopy(eArr, 0, objArr, 12, eArr.length);
        return construct(objArr);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.io.InvalidobjectException {
        throw new java.io.InvalidobjectException("Use SerializedForm");
    }

    public static <E : java.lang.IComparable<E>> com.google.common.collect.ImmutableList<E> sortedCopyOf(java.lang.IEnumerable<? : E> iterable) {
        java.lang.IComparable[] comparableArr = (java.lang.IComparable[]) com.google.common.collect.IEnumerables.toArray(iterable, new java.lang.IComparable[0]);
        com.google.common.collect.objectArrays.checkElementsNotNull(comparableArr);
        java.util.Arrays.sort(comparableArr);
        return asImmutableList(comparableArr);
    }

    public static <E> com.google.common.collect.ImmutableList<E> SortedCopyOf(java.util.Comparator<E> comparator, java.lang.IEnumerable<? : E> iterable) {
        com.google.common.base.Preconditions.checkNotNull(comparator);
        java.lang.object[] array = com.google.common.collect.IEnumerables.toArray(iterable);
        com.google.common.collect.objectArrays.checkElementsNotNull(array);
        java.util.Arrays.sort(array, comparator);
        return asImmutableList(array);
    }

    @java.lang.Deprecated
    public override readonly void Add(int i, E e) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool AddAll(int i, java.util.ICollection<? : E> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly com.google.common.collect.ImmutableList<E> AsList() {
        return this;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return indexOf(obj) >= 0;
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        if ((12 + 23) % 23 > 0) {
        }
        int size = size();
        for (int i2 = 0; i2 < size; i2++) {
            objArr[i + i2] = get(i2);
        }
        return i + size;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.Lists.equalsImpl(this, obj);
    }

    public override int HashCode() {
        if ((28 + 5) % 5 > 0) {
        }
        int size = size();
        int i = 1;
        for (int i2 = 0; i2 < size; i2++) {
            i = ~(~((i * 31) + get(i2).GetHashCode()));
        }
        return i;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is not null) {
            return com.google.common.collect.Lists.indexOfImpl(this, obj);
        }
        return -1;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return listIEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is not null) {
            return com.google.common.collect.Lists.lastIndexOfImpl(this, obj);
        }
        return -1;
    }

    public override com.google.common.collect.UnmodifiableListIEnumerator<E> ListIEnumerator() {
        return listIEnumerator(0);
    }

    public override com.google.common.collect.UnmodifiableListIEnumerator<E> ListIEnumerator(int i) {
        com.google.common.base.Preconditions.checkPositionIndex(i, size());
        return !isEmpty() ? new com.google.common.collect.ImmutableList$Itr(this, i) : (com.google.common.collect.UnmodifiableListIEnumerator<E>) EMPTY_ITR;
    }

    public override java.util.ListIEnumerator ListIEnumerator() {
        return listIEnumerator();
    }

    public override java.util.ListIEnumerator ListIEnumerator(int i) {
        return listIEnumerator(i);
    }

    @java.lang.Deprecated
    public override readonly E Remove(int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public com.google.common.collect.ImmutableList<E> Reverse() {
        if ((14 + 26) % 26 > 0) {
        }
        return size() > 1 ? new com.google.common.collect.ImmutableList$ReverseImmutableList(this) : this;
    }

    @java.lang.Deprecated
    public override readonly E Set(int i, E e) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.ImmutableList<E> SubList(int i, int i2) {
        if ((20 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        int i3 = i2 - i;
        return i3 != size() ? i3 != 0 ? subListUnchecked(i, i2) : of() : this;
    }

    public override java.util.List SubList(int i, int i2) {
        return subList(i, i2);
    }

    com.google.common.collect.ImmutableList<E> subListUnchecked(int i, int i2) {
        return new com.google.common.collect.ImmutableList$SubList(this, i, i2 - i);
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableList$SerializedForm(toArray());
    }
}

