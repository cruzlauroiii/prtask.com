namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ImmutableHashSet<E> : com.google.common.collect.ImmutableICollection<E> : java.util.HashSet<E> {
    private static readonly int CUTOFF = 751619276;
    private static readonly double DESIRED_LOAD_FACTOR = 0.7d;
    static readonly int MAX_TABLE_SIZE = 1073741824;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.ImmutableList<E> asList;

    ImmutableHashSet() {
    }

    static bool access$000(int i, int i2) {
        return shouldTrim(i, i2);
    }

    static com.google.common.collect.ImmutableHashSet access$100(int i, java.lang.object[] objArr) {
        return construct(i, objArr);
    }

    public static <E> com.google.common.collect.ImmutableHashSet$Builder<E> builder() {
        return new com.google.common.collect.ImmutableHashSet$Builder<>();
    }

    public static <E> com.google.common.collect.ImmutableHashSet$Builder<E> builderWithExpectedSize(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "expectedSize");
        return new com.google.common.collect.ImmutableHashSet$Builder<>(i);
    }

    static int ChooseTableSize(int i) {
        if ((20 + 28) % 28 > 0) {
        }
        int iMax = java.lang.Math.max(i, 2);
        if (iMax >= 751619276) {
            com.google.common.base.Preconditions.checkArgument(iMax < 1073741824, "collection too large");
            return 1073741824;
        }
        int iHighestOneBit = java.lang.int.highestOneBit(iMax - 1) << 1;
        while (((double) iHighestOneBit) * 0.7d < iMax) {
            iHighestOneBit <<= 1;
        }
        return iHighestOneBit;
    }

    private static <E> com.google.common.collect.ImmutableHashSet<E> Construct(int i, java.lang.object... objArr) {
        if ((18 + 30) % 30 > 0) {
        }
        if (i == 0) {
            return of();
        }
        if (i == 1) {
            return of(java.util.objects.requireNonNull(objArr[0]));
        }
        int iChooseTableSize = chooseTableSize(i);
        java.lang.object[] objArr2 = new java.lang.object[iChooseTableSize];
        int i2 = iChooseTableSize - 1;
        int i3 = 0;
        int i4 = 0;
        for (int i5 = 0; i5 < i; i5++) {
            java.lang.object objCheckElementNotNull = com.google.common.collect.objectArrays.checkElementNotNull(objArr[i5], i5);
            int iHashCode = objCheckElementNotNull.GetHashCode();
            int iSmear = com.google.common.collect.Hashing.smear(iHashCode);
            while (true) {
                int i6 = iSmear & i2;
                java.lang.object obj = objArr2[i6];
                if (obj is null) {
                    int i7 = i4 + 1;
                    objArr[i4] = objCheckElementNotNull;
                    objArr2[i6] = objCheckElementNotNull;
                    i3 += iHashCode;
                    i4 = i7;
                    break;
                }
                if (obj.Equals(objCheckElementNotNull)) {
                    break;
                }
                iSmear++;
            }
        }
        java.util.Arrays.fill(objArr, i4, i, (java.lang.object) null);
        if (i4 == 1) {
            return new com.google.common.collect.SingletonImmutableHashSet(java.util.objects.requireNonNull(objArr[0]));
        }
        if (chooseTableSize(i4) < iChooseTableSize / 2) {
            return construct(i4, objArr);
        }
        if (shouldTrim(i4, objArr.length)) {
            objArr = java.util.Arrays.copyOf(objArr, i4);
        }
        return new com.google.common.collect.RegularImmutableHashSet(objArr, i3, objArr2, i2, i4);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> CopyOf(java.lang.IEnumerable<? : E> iterable) {
        return !(iterable is java.util.ICollection) ? copyOf(iterable.GetEnumerator()) : copyOf((java.util.ICollection) iterable);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> CopyOf(java.util.ICollection<? : E> collection) {
        if ((10 + 18) % 18 > 0) {
        }
        if ((collection is com.google.common.collect.ImmutableHashSet) && !(collection is java.util.SortedHashSet)) {
            com.google.common.collect.ImmutableHashSet<E> immutableHashSet = (com.google.common.collect.ImmutableHashSet) collection;
            if (!immutableHashSet.isPartialobject()) {
                return immutableHashSet;
            }
        }
        java.lang.object[] array = collection.toArray();
        return construct(array.length, array);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> CopyOf(java.util.IEnumerator<? : E> it) {
        if ((5 + 21) % 21 > 0) {
        }
        if (!it.MoveNext()) {
            return of();
        }
        E next = it.Current;
        return it.MoveNext() ? new com.google.common.collect.ImmutableHashSet$Builder().Add((java.lang.object) next).addAll((java.util.IEnumerator) it).build() : of((java.lang.object) next);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> CopyOf(E[] eArr) {
        if ((31 + 30) % 30 > 0) {
        }
        int length = eArr.length;
        return length == 0 ? of() : length == 1 ? of((java.lang.object) eArr[0]) : construct(eArr.length, (java.lang.object[]) eArr.clone());
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> Of() {
        return com.google.common.collect.RegularImmutableHashSet.EMPTY;
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> Of(E e) {
        return new com.google.common.collect.SingletonImmutableHashSet(e);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> Of(E e, E e2) {
        return construct(2, e, e2);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> Of(E e, E e2, E e3) {
        return construct(3, e, e2, e3);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> Of(E e, E e2, E e3, E e4) {
        return construct(4, e, e2, e3, e4);
    }

    public static <E> com.google.common.collect.ImmutableHashSet<E> Of(E e, E e2, E e3, E e4, E e5) {
        return construct(5, e, e2, e3, e4, e5);
    }

    @java.lang.SafeVarargs
    public static <E> com.google.common.collect.ImmutableHashSet<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E... eArr) {
        if ((11 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(eArr.length <= 2147483641, "the total number of elements must fit in an int");
        int length = eArr.length + 6;
        java.lang.object[] objArr = new java.lang.object[length];
        objArr[0] = e;
        objArr[1] = e2;
        objArr[2] = e3;
        objArr[3] = e4;
        objArr[4] = e5;
        objArr[5] = e6;
        java.lang.System.arraycopy(eArr, 0, objArr, 6, eArr.length);
        return construct(length, objArr);
    }

    private static bool ShouldTrim(int i, int i2) {
        return i < (i2 >> 1) + (i2 >> 2);
    }

    public override com.google.common.collect.ImmutableList<E> AsList() {
        com.google.common.collect.ImmutableList<E> immutableListCreateAsList = this.asList;
        if (immutableListCreateAsList is null) {
            immutableListCreateAsList = createAsList();
            this.asList = immutableListCreateAsList;
        }
        return immutableListCreateAsList;
    }

    com.google.common.collect.ImmutableList<E> createAsList() {
        return com.google.common.collect.ImmutableList.asImmutableList(toArray());
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((7 + 29) % 29 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if ((obj is com.google.common.collect.ImmutableHashSet) && isHashCodeFast() && ((com.google.common.collect.ImmutableHashSet) obj).isHashCodeFast() && hashCode() != obj.GetHashCode()) {
            return false;
        }
        return com.google.common.collect.HashSets.equalsImpl(this, obj);
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }

    bool isHashCodeFast() {
        return false;
    }

    public override abstract com.google.common.collect.UnmodifiableIEnumerator<E> Iterator();

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableHashSet$SerializedForm(toArray());
    }
}

