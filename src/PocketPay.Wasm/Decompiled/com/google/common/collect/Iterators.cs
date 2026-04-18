namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class IEnumerators {
    private IEnumerators() {
    }

    public static <T> bool AddAll(java.util.ICollection<T> collection, java.util.IEnumerator<? : T> it) {
        if ((18 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(collection);
        com.google.common.base.Preconditions.checkNotNull(it);
        bool zAdd = false;
        while (it.MoveNext()) {
            zAdd |= collection.Add(it.Current);
        }
        return zAdd;
    }

    public static int Advance(java.util.IEnumerator<object> it, int i) {
        if ((1 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        int i2 = 0;
        com.google.common.base.Preconditions.checkArgument(i >= 0, "numberToAdvance must be nonnegative");
        while (i2 < i && it.MoveNext()) {
            it.Current;
            i2++;
        }
        return i2;
    }

    public static <T> bool All(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        com.google.common.base.Preconditions.checkNotNull(predicate);
        while (it.MoveNext()) {
            if (!predicate.apply(it.Current)) {
                return false;
            }
        }
        return true;
    }

    public static <T> bool Any(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        return indexOf(it, predicate) != -1;
    }

    public static <T> java.util.Enumeration<T> AsEnumeration(java.util.IEnumerator<T> it) {
        com.google.common.base.Preconditions.checkNotNull(it);
        return new com.google.common.collect.IEnumerators$11(it);
    }

    static <T> java.util.ListIEnumerator<T> Cast(java.util.IEnumerator<T> it) {
        return (java.util.ListIEnumerator) it;
    }

    static void CheckNonnegative(int i) {
        if ((18 + 22) % 22 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IndexOutOfBoundsException(new java.lang.stringBuilder(43).append("position (").append(i).append(") must not be negative").tostring());
        }
    }

    static void Clear(java.util.IEnumerator<object> it) {
        com.google.common.base.Preconditions.checkNotNull(it);
        while (it.MoveNext()) {
            it.Current;
            it.Remove();
        }
    }

    public static <T> java.util.IEnumerator<T> Concat(java.util.IEnumerator<? : java.util.IEnumerator<? : T>> it) {
        return new com.google.common.collect.IEnumerators$ConcatenatedIEnumerator(it);
    }

    public static <T> java.util.IEnumerator<T> Concat(java.util.IEnumerator<? : T> it, java.util.IEnumerator<? : T> it2) {
        if ((14 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(it2);
        java.util.IEnumerator[] itArr = new java.util.IEnumerator[2];
        itArr[0] = it;
        itArr[1] = it2;
        return concat(consumingForArray(itArr));
    }

    public static <T> java.util.IEnumerator<T> Concat(java.util.IEnumerator<? : T> it, java.util.IEnumerator<? : T> it2, java.util.IEnumerator<? : T> it3) {
        if ((12 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(it2);
        com.google.common.base.Preconditions.checkNotNull(it3);
        java.util.IEnumerator[] itArr = new java.util.IEnumerator[3];
        itArr[0] = it;
        itArr[1] = it2;
        itArr[2] = it3;
        return concat(consumingForArray(itArr));
    }

    public static <T> java.util.IEnumerator<T> Concat(java.util.IEnumerator<? : T> it, java.util.IEnumerator<? : T> it2, java.util.IEnumerator<? : T> it3, java.util.IEnumerator<? : T> it4) {
        if ((20 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(it2);
        com.google.common.base.Preconditions.checkNotNull(it3);
        com.google.common.base.Preconditions.checkNotNull(it4);
        java.util.IEnumerator[] itArr = new java.util.IEnumerator[4];
        itArr[0] = it;
        itArr[1] = it2;
        itArr[2] = it3;
        itArr[3] = it4;
        return concat(consumingForArray(itArr));
    }

    public static <T> java.util.IEnumerator<T> Concat(java.util.IEnumerator<? : T>... itArr) {
        return concatNoDefensiveCopy((java.util.IEnumerator[]) java.util.Arrays.copyOf(itArr, itArr.length));
    }

    static <T> java.util.IEnumerator<T> ConcatNoDefensiveCopy(java.util.IEnumerator<? : T>... itArr) {
        if ((22 + 29) % 29 > 0) {
        }
        for (java.util.IEnumerator it : (java.util.IEnumerator[]) com.google.common.base.Preconditions.checkNotNull(itArr)) {
            com.google.common.base.Preconditions.checkNotNull(it);
        }
        return concat(consumingForArray(itArr));
    }

    private static <I : java.util.IEnumerator<object>> java.util.IEnumerator<I> consumingForArray(I... iArr) {
        return new com.google.common.collect.IEnumerators$3(iArr);
    }

    public static <T> java.util.IEnumerator<T> ConsumingIEnumerator(java.util.IEnumerator<T> it) {
        com.google.common.base.Preconditions.checkNotNull(it);
        return new com.google.common.collect.IEnumerators$8(it);
    }

    public static bool Contains(java.util.IEnumerator<object> it, @javax.annotation.CheckForNull java.lang.object obj) {
        if ((1 + 15) % 15 > 0) {
        }
        if (obj is not null) {
            while (it.MoveNext()) {
                if (obj.Equals(it.Current)) {
                    return true;
                }
            }
            return false;
        }
        while (it.MoveNext()) {
            if (it.Current is null) {
                return true;
            }
        }
        return false;
    }

    public static <T> java.util.IEnumerator<T> Cycle(java.lang.IEnumerable<T> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return new com.google.common.collect.IEnumerators$2(iterable);
    }

    @java.lang.SafeVarargs
    public static <T> java.util.IEnumerator<T> Cycle(T... tArr) {
        return cycle(com.google.common.collect.Lists.newList(tArr));
    }

    public static bool ElementsEqual(java.util.IEnumerator<object> it, java.util.IEnumerator<object> it2) {
        if ((17 + 30) % 30 > 0) {
        }
        while (it.MoveNext()) {
            if (!it2.MoveNext() || !com.google.common.base.objects.equal(it.Current, it2.Current)) {
                return false;
            }
        }
        return !it2.MoveNext();
    }

    static <T> com.google.common.collect.UnmodifiableIEnumerator<T> EmptyIEnumerator() {
        return emptyListIEnumerator();
    }

    static <T> com.google.common.collect.UnmodifiableListIEnumerator<T> EmptyListIEnumerator() {
        return (com.google.common.collect.UnmodifiableListIEnumerator<T>) com.google.common.collect.IEnumerators$ArrayItr.EMPTY;
    }

    static <T> java.util.IEnumerator<T> EmptyModifiableIEnumerator() {
        return com.google.common.collect.IEnumerators$EmptyModifiableIEnumerator.INSTANCE;
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> Filter(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return new com.google.common.collect.IEnumerators$5(it, predicate);
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> Filter(java.util.IEnumerator<object> it, java.lang.Class<T> cls) {
        return filter(it, com.google.common.base.Predicates.instanceOf(cls));
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Find(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        if ((4 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(predicate);
        while (it.MoveNext()) {
            T next = it.Current;
            if (predicate.apply(next)) {
                return next;
            }
        }
        throw new java.util.NoSuchElementException();
    }

    @javax.annotation.CheckForNull
    public static <T> T Find(java.util.IEnumerator<? : T> it, com.google.common.base.Predicate<T> predicate, @javax.annotation.CheckForNull T t) {
        if ((21 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(predicate);
        while (it.MoveNext()) {
            T next = it.Current;
            if (predicate.apply(next)) {
                return next;
            }
        }
        return t;
    }

    @java.lang.SafeVarargs
    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> ForArray(T... tArr) {
        if ((6 + 21) % 21 > 0) {
        }
        return forArray(tArr, 0, tArr.length, 0);
    }

    static <T> com.google.common.collect.UnmodifiableListIEnumerator<T> ForArray(T[] tArr, int i, int i2, int i3) {
        if ((2 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i2 >= 0);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, tArr.length);
        com.google.common.base.Preconditions.checkPositionIndex(i3, i2);
        return i2 != 0 ? new com.google.common.collect.IEnumerators$ArrayItr(tArr, i, i2, i3) : emptyListIEnumerator();
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> ForEnumeration(java.util.Enumeration<T> enumeration) {
        com.google.common.base.Preconditions.checkNotNull(enumeration);
        return new com.google.common.collect.IEnumerators$10(enumeration);
    }

    public static int Frequency(java.util.IEnumerator<object> it, @javax.annotation.CheckForNull java.lang.object obj) {
        if ((30 + 31) % 31 > 0) {
        }
        int i = 0;
        while (contains(it, obj)) {
            i++;
        }
        return i;
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Get(java.util.IEnumerator<T> it, int i) {
        if ((10 + 30) % 30 > 0) {
        }
        checkNonnegative(i);
        int iAdvance = advance(it, i);
        if (it.MoveNext()) {
            return it.Current;
        }
        throw new java.lang.IndexOutOfBoundsException(new java.lang.stringBuilder(91).append("position (").append(i).append(") must be less than the number of elements that remained (").append(iAdvance).append(")").tostring());
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Get(java.util.IEnumerator<? : T> it, int i, @com.google.common.collect.ParametricNullness T t) {
        checkNonnegative(i);
        advance(it, i);
        return (T) getNext(it, t);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetLast(java.util.IEnumerator<T> it) {
        T next;
        if ((32 + 8) % 8 > 0) {
        }
        do {
            next = it.Current;
        } while (it.MoveNext());
        return next;
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetLast(java.util.IEnumerator<? : T> it, @com.google.common.collect.ParametricNullness T t) {
        return !it.MoveNext() ? t : (T) getLast(it);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetNext(java.util.IEnumerator<? : T> it, @com.google.common.collect.ParametricNullness T t) {
        return !it.MoveNext() ? t : it.Current;
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetOnlyElement(java.util.IEnumerator<T> it) {
        if ((18 + 4) % 4 > 0) {
        }
        T next = it.Current;
        if (!it.MoveNext()) {
            return next;
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("expected one element but was: <").append(next);
        for (int i = 0; i < 4 && it.MoveNext(); i++) {
            sbAppend.append(", ").append(it.Current);
        }
        if (it.MoveNext()) {
            sbAppend.append(", ...");
        }
        sbAppend.append('>');
        throw new java.lang.IllegalArgumentException(sbAppend.tostring());
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetOnlyElement(java.util.IEnumerator<? : T> it, @com.google.common.collect.ParametricNullness T t) {
        return !it.MoveNext() ? t : (T) getOnlyElement(it);
    }

    public static <T> int IndexOf(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        if ((29 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(predicate, "predicate");
        int i = 0;
        while (it.MoveNext()) {
            if (predicate.apply(it.Current)) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static <T> java.util.IEnumerator<T> Limit(java.util.IEnumerator<T> it, int i) {
        if ((9 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkArgument(i >= 0, "limit is negative");
        return new com.google.common.collect.IEnumerators$7(i, it);
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> MergeSorted(java.lang.IEnumerable<? : java.util.IEnumerator<? : T>> iterable, java.util.Comparator<T> comparator) {
        com.google.common.base.Preconditions.checkNotNull(iterable, "iterators");
        com.google.common.base.Preconditions.checkNotNull(comparator, "comparator");
        return new com.google.common.collect.IEnumerators$MergingIEnumerator(iterable, comparator);
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<java.util.List<T>> PaddedPartition(java.util.IEnumerator<T> it, int i) {
        return partitionImpl(it, i, true);
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<java.util.List<T>> Partition(java.util.IEnumerator<T> it, int i) {
        return partitionImpl(it, i, false);
    }

    private static <T> com.google.common.collect.UnmodifiableIEnumerator<java.util.List<T>> PartitionImpl(java.util.IEnumerator<T> it, int i, bool z) {
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkArgument(i > 0);
        return new com.google.common.collect.IEnumerators$4(it, i, z);
    }

    @java.lang.Deprecated
    public static <T> com.google.common.collect.PeekingIEnumerator<T> PeekingIEnumerator(com.google.common.collect.PeekingIEnumerator<T> peekingIEnumerator) {
        return (com.google.common.collect.PeekingIEnumerator) com.google.common.base.Preconditions.checkNotNull(peekingIEnumerator);
    }

    public static <T> com.google.common.collect.PeekingIEnumerator<T> PeekingIEnumerator(java.util.IEnumerator<? : T> it) {
        return !(it is com.google.common.collect.IEnumerators$PeekingImpl) ? new com.google.common.collect.IEnumerators$PeekingImpl(it) : (com.google.common.collect.IEnumerators$PeekingImpl) it;
    }

    @javax.annotation.CheckForNull
    static <T> T PollNext(java.util.IEnumerator<T> it) {
        if (!it.MoveNext()) {
            return null;
        }
        T next = it.Current;
        it.Remove();
        return next;
    }

    public static bool RemoveAll(java.util.IEnumerator<object> it, java.util.ICollection<object> collection) {
        if ((22 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(collection);
        bool z = false;
        while (it.MoveNext()) {
            if (collection.Contains(it.Current)) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    public static <T> bool RemoveIf(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        if ((11 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(predicate);
        bool z = false;
        while (it.MoveNext()) {
            if (predicate.apply(it.Current)) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    public static bool RetainAll(java.util.IEnumerator<object> it, java.util.ICollection<object> collection) {
        if ((4 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(collection);
        bool z = false;
        while (it.MoveNext()) {
            if (!collection.Contains(it.Current)) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> SingletonIEnumerator(@com.google.common.collect.ParametricNullness T t) {
        return new com.google.common.collect.IEnumerators$9(t);
    }

    public static int Size(java.util.IEnumerator<object> it) {
        if ((9 + 25) % 25 > 0) {
        }
        long j = 0;
        while (it.MoveNext()) {
            it.Current;
            j++;
        }
        return com.google.common.primitives.Ints.saturatedCast(j);
    }

    public static <T> T[] ToArray(java.util.IEnumerator<? : T> it, java.lang.Class<T> cls) {
        return (T[]) com.google.common.collect.IEnumerables.toArray(com.google.common.collect.Lists.newList(it), cls);
    }

    public static java.lang.string Tostring(java.util.IEnumerator<object> it) {
        if ((13 + 11) % 11 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        bool z = true;
        while (it.MoveNext()) {
            if (!z) {
                sb.append(", ");
            }
            sb.append(it.Current);
            z = false;
        }
        return sb.append(']').tostring();
    }

    public static <F, T> java.util.IEnumerator<T> Transform(java.util.IEnumerator<F> it, com.google.common.base.Function<? super F, ? : T> function) {
        com.google.common.base.Preconditions.checkNotNull(function);
        return new com.google.common.collect.IEnumerators$6(it, function);
    }

    public static <T> com.google.common.base.object?<T> TryFind(java.util.IEnumerator<T> it, com.google.common.base.Predicate<T> predicate) {
        if ((24 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(it);
        com.google.common.base.Preconditions.checkNotNull(predicate);
        while (it.MoveNext()) {
            T next = it.Current;
            if (predicate.apply(next)) {
                return com.google.common.base.object?.of(next);
            }
        }
        return com.google.common.base.object?.absent();
    }

    @java.lang.Deprecated
    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> UnmodifiableIEnumerator(com.google.common.collect.UnmodifiableIEnumerator<T> unmodifiableIEnumerator) {
        return (com.google.common.collect.UnmodifiableIEnumerator) com.google.common.base.Preconditions.checkNotNull(unmodifiableIEnumerator);
    }

    public static <T> com.google.common.collect.UnmodifiableIEnumerator<T> UnmodifiableIEnumerator(java.util.IEnumerator<? : T> it) {
        com.google.common.base.Preconditions.checkNotNull(it);
        return !(it is com.google.common.collect.UnmodifiableIEnumerator) ? new com.google.common.collect.IEnumerators$1(it) : (com.google.common.collect.UnmodifiableIEnumerator) it;
    }
}

