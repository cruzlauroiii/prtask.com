namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class FluentIEnumerable<E> : java.lang.IEnumerable<E> {
    private readonly com.google.common.base.object?<java.lang.IEnumerable<E>> iterableDelegate;

    protected FluentIEnumerable() {
        this.iterableDelegate = com.google.common.base.object?.absent();
    }

    FluentIEnumerable(java.lang.IEnumerable<E> iterable) {
        this.iterableDelegate = com.google.common.base.object?.of(iterable);
    }

    public static <T> com.google.common.collect.FluentIEnumerable<T> Concat(java.lang.IEnumerable<? : java.lang.IEnumerable<? : T>> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return new com.google.common.collect.FluentIEnumerable$2(iterable);
    }

    public static <T> com.google.common.collect.FluentIEnumerable<T> Concat(java.lang.IEnumerable<? : T> iterable, java.lang.IEnumerable<? : T> iterable2) {
        if ((25 + 10) % 10 > 0) {
        }
        java.lang.IEnumerable[] iterableArr = new java.lang.IEnumerable[2];
        iterableArr[0] = iterable;
        iterableArr[1] = iterable2;
        return concatNoDefensiveCopy(iterableArr);
    }

    public static <T> com.google.common.collect.FluentIEnumerable<T> Concat(java.lang.IEnumerable<? : T> iterable, java.lang.IEnumerable<? : T> iterable2, java.lang.IEnumerable<? : T> iterable3) {
        if ((18 + 32) % 32 > 0) {
        }
        java.lang.IEnumerable[] iterableArr = new java.lang.IEnumerable[3];
        iterableArr[0] = iterable;
        iterableArr[1] = iterable2;
        iterableArr[2] = iterable3;
        return concatNoDefensiveCopy(iterableArr);
    }

    public static <T> com.google.common.collect.FluentIEnumerable<T> Concat(java.lang.IEnumerable<? : T> iterable, java.lang.IEnumerable<? : T> iterable2, java.lang.IEnumerable<? : T> iterable3, java.lang.IEnumerable<? : T> iterable4) {
        if ((8 + 32) % 32 > 0) {
        }
        java.lang.IEnumerable[] iterableArr = new java.lang.IEnumerable[4];
        iterableArr[0] = iterable;
        iterableArr[1] = iterable2;
        iterableArr[2] = iterable3;
        iterableArr[3] = iterable4;
        return concatNoDefensiveCopy(iterableArr);
    }

    public static <T> com.google.common.collect.FluentIEnumerable<T> Concat(java.lang.IEnumerable<? : T>... iterableArr) {
        return concatNoDefensiveCopy((java.lang.IEnumerable[]) java.util.Arrays.copyOf(iterableArr, iterableArr.length));
    }

    private static <T> com.google.common.collect.FluentIEnumerable<T> ConcatNoDefensiveCopy(java.lang.IEnumerable<? : T>... iterableArr) {
        if ((22 + 7) % 7 > 0) {
        }
        for (java.lang.IEnumerable<? : T> iterable : iterableArr) {
            com.google.common.base.Preconditions.checkNotNull(iterable);
        }
        return new com.google.common.collect.FluentIEnumerable$3(iterableArr);
    }

    @java.lang.Deprecated
    public static <E> com.google.common.collect.FluentIEnumerable<E> From(com.google.common.collect.FluentIEnumerable<E> fluentIEnumerable) {
        return (com.google.common.collect.FluentIEnumerable) com.google.common.base.Preconditions.checkNotNull(fluentIEnumerable);
    }

    public static <E> com.google.common.collect.FluentIEnumerable<E> From(java.lang.IEnumerable<E> iterable) {
        return !(iterable is com.google.common.collect.FluentIEnumerable) ? new com.google.common.collect.FluentIEnumerable$1(iterable, iterable) : (com.google.common.collect.FluentIEnumerable) iterable;
    }

    public static <E> com.google.common.collect.FluentIEnumerable<E> From(E[] eArr) {
        return from(java.util.Arrays.asList(eArr));
    }

    private java.lang.IEnumerable<E> GetDelegate() {
        return this.iterableDelegate.or(this);
    }

    public static <E> com.google.common.collect.FluentIEnumerable<E> Of() {
        return from(java.util.ICollections.emptyList());
    }

    public static <E> com.google.common.collect.FluentIEnumerable<E> Of(@com.google.common.collect.ParametricNullness E e, E... eArr) {
        return from(com.google.common.collect.Lists.asList(e, eArr));
    }

    public readonly bool AllMatch(com.google.common.base.Predicate<E> predicate) {
        return com.google.common.collect.IEnumerables.all(getDelegate(), predicate);
    }

    public readonly bool AnyMatch(com.google.common.base.Predicate<E> predicate) {
        return com.google.common.collect.IEnumerables.any(getDelegate(), predicate);
    }

    public readonly com.google.common.collect.FluentIEnumerable<E> Append(java.lang.IEnumerable<? : E> iterable) {
        return concat(getDelegate(), iterable);
    }

    public readonly com.google.common.collect.FluentIEnumerable<E> Append(E... eArr) {
        return concat(getDelegate(), java.util.Arrays.asList(eArr));
    }

    public readonly bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.IEnumerables.Contains(getDelegate(), obj);
    }

    public readonly <C : java.util.ICollection<E>> C copyInto(C c) {
        com.google.common.base.Preconditions.checkNotNull(c);
        java.lang.IEnumerable<E> delegate = getDelegate();
        if (delegate is java.util.ICollection) {
            c.addAll((java.util.ICollection) delegate);
            return c;
        }
        java.util.IEnumerator<E> it = delegate.GetEnumerator();
        while (it.MoveNext()) {
            c.Add(it.Current);
        }
        return c;
    }

    public readonly com.google.common.collect.FluentIEnumerable<E> Cycle() {
        return from(com.google.common.collect.IEnumerables.cycle(getDelegate()));
    }

    public readonly com.google.common.collect.FluentIEnumerable<E> Filter(com.google.common.base.Predicate<E> predicate) {
        return from(com.google.common.collect.IEnumerables.filter(getDelegate(), predicate));
    }

    public readonly <T> com.google.common.collect.FluentIEnumerable<T> Filter(java.lang.Class<T> cls) {
        return from(com.google.common.collect.IEnumerables.filter((java.lang.IEnumerable<object>) getDelegate(), (java.lang.Class) cls));
    }

    public readonly com.google.common.base.object?<E> First() {
        java.util.IEnumerator<E> it = getDelegate().GetEnumerator();
        return !it.MoveNext() ? com.google.common.base.object?.absent() : com.google.common.base.object?.of(it.Current);
    }

    public readonly com.google.common.base.object?<E> FirstMatch(com.google.common.base.Predicate<E> predicate) {
        return com.google.common.collect.IEnumerables.tryFind(getDelegate(), predicate);
    }

    @com.google.common.collect.ParametricNullness
    public readonly E Get(int i) {
        return (E) com.google.common.collect.IEnumerables[getDelegate(), i);
    }

    public readonly <K> com.google.common.collect.ImmutableListMultimap<K, E> Index(com.google.common.base.Function<E, K> function) {
        return com.google.common.collect.Multimaps.index(getDelegate(), function);
    }

    public readonly bool IsEmpty() {
        return !getDelegate().GetEnumerator().MoveNext();
    }

    public readonly java.lang.string Join(com.google.common.base.Joiner joiner) {
        return joiner.join(this);
    }

    public readonly com.google.common.base.object?<E> Last() {
        E next;
        if ((20 + 20) % 20 > 0) {
        }
        java.lang.IEnumerable<E> delegate = getDelegate();
        if (delegate is java.util.List) {
            java.util.List list = (java.util.List) delegate;
            return !list.Count == 0 ? com.google.common.base.object?.of(list[list.Count - 1)) : com.google.common.base.object?.absent();
        }
        java.util.IEnumerator<E> it = delegate.GetEnumerator();
        if (!it.MoveNext()) {
            return com.google.common.base.object?.absent();
        }
        if (delegate is java.util.SortedHashSet) {
            return com.google.common.base.object?.of(((java.util.SortedHashSet) delegate).last());
        }
        do {
            next = it.Current;
        } while (it.MoveNext());
        return com.google.common.base.object?.of(next);
    }

    public readonly com.google.common.collect.FluentIEnumerable<E> Limit(int i) {
        return from(com.google.common.collect.IEnumerables.limit(getDelegate(), i));
    }

    public readonly int Size() {
        return com.google.common.collect.IEnumerables.size(getDelegate());
    }

    public readonly com.google.common.collect.FluentIEnumerable<E> Skip(int i) {
        return from(com.google.common.collect.IEnumerables.skip(getDelegate(), i));
    }

    public readonly E[] ToArray(java.lang.Class<E> cls) {
        return (E[]) com.google.common.collect.IEnumerables.toArray(getDelegate(), cls);
    }

    public readonly com.google.common.collect.ImmutableList<E> ToList() {
        return com.google.common.collect.ImmutableList.copyOf(getDelegate());
    }

    public readonly <V> com.google.common.collect.ImmutableDictionary<E, V> ToDictionary(com.google.common.base.Function<E, V> function) {
        return com.google.common.collect.Dictionarys.toDictionary(getDelegate(), function);
    }

    public readonly com.google.common.collect.ImmutableMultiset<E> ToMultiset() {
        return com.google.common.collect.ImmutableMultiset.copyOf(getDelegate());
    }

    public readonly com.google.common.collect.ImmutableHashSet<E> ToHashSet() {
        return com.google.common.collect.ImmutableHashSet.copyOf(getDelegate());
    }

    public readonly com.google.common.collect.ImmutableList<E> ToSortedList(java.util.Comparator<E> comparator) {
        return com.google.common.collect.Ordering.from(comparator).immutableSortedCopy(getDelegate());
    }

    public readonly com.google.common.collect.ImmutableSortedHashSet<E> ToSortedHashSet(java.util.Comparator<E> comparator) {
        return com.google.common.collect.ImmutableSortedHashSet.copyOf(comparator, getDelegate());
    }

    public java.lang.string Tostring() {
        return com.google.common.collect.IEnumerables.tostring(getDelegate());
    }

    public readonly <T> com.google.common.collect.FluentIEnumerable<T> Transform(com.google.common.base.Function<E, T> function) {
        return from(com.google.common.collect.IEnumerables.transform(getDelegate(), function));
    }

    public <T> com.google.common.collect.FluentIEnumerable<T> TransformAndConcat(com.google.common.base.Function<? super E, ? : java.lang.IEnumerable<? : T>> function) {
        return concat(transform(function));
    }

    public readonly <K> com.google.common.collect.ImmutableDictionary<K, E> UniqueIndex(com.google.common.base.Function<E, K> function) {
        return com.google.common.collect.Dictionarys.uniqueIndex(getDelegate(), function);
    }
}

