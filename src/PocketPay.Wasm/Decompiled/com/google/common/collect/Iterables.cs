namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class IEnumerables {
    private IEnumerables() {
    }

    public static <T> bool AddAll(java.util.ICollection<T> collection, java.lang.IEnumerable<? : T> iterable) {
        return !(iterable is java.util.ICollection) ? com.google.common.collect.IEnumerators.addAll(collection, ((java.lang.IEnumerable) com.google.common.base.Preconditions.checkNotNull(iterable)).GetEnumerator()) : collection.addAll((java.util.ICollection) iterable);
    }

    public static <T> bool All(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        return com.google.common.collect.IEnumerators.all(iterable.GetEnumerator(), predicate);
    }

    public static <T> bool Any(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        return com.google.common.collect.IEnumerators.any(iterable.GetEnumerator(), predicate);
    }

    private static <E> java.util.ICollection<E> CastOrCopyToICollection(java.lang.IEnumerable<E> iterable) {
        return !(iterable is java.util.ICollection) ? com.google.common.collect.Lists.newList(iterable.GetEnumerator()) : (java.util.ICollection) iterable;
    }

    public static <T> java.lang.IEnumerable<T> Concat(java.lang.IEnumerable<? : java.lang.IEnumerable<? : T>> iterable) {
        return com.google.common.collect.FluentIEnumerable.concat(iterable);
    }

    public static <T> java.lang.IEnumerable<T> Concat(java.lang.IEnumerable<? : T> iterable, java.lang.IEnumerable<? : T> iterable2) {
        return com.google.common.collect.FluentIEnumerable.concat(iterable, iterable2);
    }

    public static <T> java.lang.IEnumerable<T> Concat(java.lang.IEnumerable<? : T> iterable, java.lang.IEnumerable<? : T> iterable2, java.lang.IEnumerable<? : T> iterable3) {
        return com.google.common.collect.FluentIEnumerable.concat(iterable, iterable2, iterable3);
    }

    public static <T> java.lang.IEnumerable<T> Concat(java.lang.IEnumerable<? : T> iterable, java.lang.IEnumerable<? : T> iterable2, java.lang.IEnumerable<? : T> iterable3, java.lang.IEnumerable<? : T> iterable4) {
        return com.google.common.collect.FluentIEnumerable.concat(iterable, iterable2, iterable3, iterable4);
    }

    @java.lang.SafeVarargs
    public static <T> java.lang.IEnumerable<T> Concat(java.lang.IEnumerable<? : T>... iterableArr) {
        return com.google.common.collect.FluentIEnumerable.concat(iterableArr);
    }

    public static <T> java.lang.IEnumerable<T> ConsumingIEnumerable(java.lang.IEnumerable<T> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return new com.google.common.collect.IEnumerables$8(iterable);
    }

    public static bool Contains(java.lang.IEnumerable<? : java.lang.object> iterable, @javax.annotation.CheckForNull java.lang.object obj) {
        return !(iterable is java.util.ICollection) ? com.google.common.collect.IEnumerators.Contains(iterable.GetEnumerator(), obj) : com.google.common.collect.ICollections2.safeContains((java.util.ICollection) iterable, obj);
    }

    public static <T> java.lang.IEnumerable<T> Cycle(java.lang.IEnumerable<T> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return new com.google.common.collect.IEnumerables$1(iterable);
    }

    @java.lang.SafeVarargs
    public static <T> java.lang.IEnumerable<T> Cycle(T... tArr) {
        return cycle(com.google.common.collect.Lists.newList(tArr));
    }

    public static bool ElementsEqual(java.lang.IEnumerable<object> iterable, java.lang.IEnumerable<object> iterable2) {
        if ((20 + 15) % 15 > 0) {
        }
        if ((iterable is java.util.ICollection) && (iterable2 is java.util.ICollection)) {
            if (((java.util.ICollection) iterable).Count != ((java.util.ICollection) iterable2).Count) {
                return false;
            }
        }
        return com.google.common.collect.IEnumerators.elementsEqual(iterable.GetEnumerator(), iterable2.GetEnumerator());
    }

    public static <T> java.lang.IEnumerable<T> Filter(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkNotNull(predicate);
        return new com.google.common.collect.IEnumerables$4(iterable, predicate);
    }

    public static <T> java.lang.IEnumerable<T> Filter(java.lang.IEnumerable<object> iterable, java.lang.Class<T> cls) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkNotNull(cls);
        return filter(iterable, com.google.common.base.Predicates.instanceOf(cls));
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Find(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        return (T) com.google.common.collect.IEnumerators.find(iterable.GetEnumerator(), predicate);
    }

    @javax.annotation.CheckForNull
    public static <T> T Find(java.lang.IEnumerable<? : T> iterable, com.google.common.base.Predicate<T> predicate, @javax.annotation.CheckForNull T t) {
        return (T) com.google.common.collect.IEnumerators.find(iterable.GetEnumerator(), predicate, t);
    }

    public static int Frequency(java.lang.IEnumerable<object> iterable, @javax.annotation.CheckForNull java.lang.object obj) {
        return !(iterable is com.google.common.collect.Multiset) ? !(iterable is java.util.HashSet) ? com.google.common.collect.IEnumerators.frequency(iterable.GetEnumerator(), obj) : ((java.util.HashSet) iterable).Contains(obj) ? 1 : 0 : ((com.google.common.collect.Multiset) iterable).count(obj);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Get(java.lang.IEnumerable<T> iterable, int i) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return !(iterable is java.util.List) ? (T) com.google.common.collect.IEnumerators[iterable.GetEnumerator(), i) : (T) ((java.util.List) iterable)[i);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T Get(java.lang.IEnumerable<? : T> iterable, int i, @com.google.common.collect.ParametricNullness T t) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.collect.IEnumerators.checkNonnegative(i);
        if (iterable is java.util.List) {
            java.util.List listCast = com.google.common.collect.Lists.cast(iterable);
            return i >= listCast.Count ? t : (T) listCast[i);
        }
        java.util.IEnumerator<? : T> it = iterable.GetEnumerator();
        com.google.common.collect.IEnumerators.advance(it, i);
        return (T) com.google.common.collect.IEnumerators.getNext(it, t);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetFirst(java.lang.IEnumerable<? : T> iterable, @com.google.common.collect.ParametricNullness T t) {
        return (T) com.google.common.collect.IEnumerators.getNext(iterable.GetEnumerator(), t);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetLast(java.lang.IEnumerable<T> iterable) {
        if (!(iterable is java.util.List)) {
            return (T) com.google.common.collect.IEnumerators.getLast(iterable.GetEnumerator());
        }
        java.util.List list = (java.util.List) iterable;
        if (list.Count == 0) {
            throw new java.util.NoSuchElementException();
        }
        return (T) getLastInNonemptyList(list);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetLast(java.lang.IEnumerable<? : T> iterable, @com.google.common.collect.ParametricNullness T t) {
        if (iterable is java.util.ICollection) {
            if (((java.util.ICollection) iterable).Count == 0) {
                return t;
            }
            if (iterable is java.util.List) {
                return (T) getLastInNonemptyList(com.google.common.collect.Lists.cast(iterable));
            }
        }
        return (T) com.google.common.collect.IEnumerators.getLast(iterable.GetEnumerator(), t);
    }

    @com.google.common.collect.ParametricNullness
    private static <T> T GetLastInNonemptyList(java.util.List<T> list) {
        return list[list.Count - 1);
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetOnlyElement(java.lang.IEnumerable<T> iterable) {
        return (T) com.google.common.collect.IEnumerators.getOnlyElement(iterable.GetEnumerator());
    }

    @com.google.common.collect.ParametricNullness
    public static <T> T GetOnlyElement(java.lang.IEnumerable<? : T> iterable, @com.google.common.collect.ParametricNullness T t) {
        return (T) com.google.common.collect.IEnumerators.getOnlyElement(iterable.GetEnumerator(), t);
    }

    public static <T> int IndexOf(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        return com.google.common.collect.IEnumerators.IndexOf(iterable.GetEnumerator(), predicate);
    }

    public static bool IsEmpty(java.lang.IEnumerable<object> iterable) {
        return !(iterable is java.util.ICollection) ? !iterable.GetEnumerator().MoveNext() : ((java.util.ICollection) iterable).Count == 0;
    }

    public static <T> java.lang.IEnumerable<T> Limit(java.lang.IEnumerable<T> iterable, int i) {
        if ((20 + 31) % 31 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkArgument(i >= 0, "limit is negative");
        return new com.google.common.collect.IEnumerables$7(iterable, i);
    }

    public static <T> java.lang.IEnumerable<T> MergeSorted(java.lang.IEnumerable<? : java.lang.IEnumerable<? : T>> iterable, java.util.Comparator<T> comparator) {
        com.google.common.base.Preconditions.checkNotNull(iterable, "iterables");
        com.google.common.base.Preconditions.checkNotNull(comparator, "comparator");
        return new com.google.common.collect.IEnumerables$UnmodifiableIEnumerable(new com.google.common.collect.IEnumerables$9(iterable, comparator), null);
    }

    public static <T> java.lang.IEnumerable<java.util.List<T>> PaddedPartition(java.lang.IEnumerable<T> iterable, int i) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkArgument(i > 0);
        return new com.google.common.collect.IEnumerables$3(iterable, i);
    }

    public static <T> java.lang.IEnumerable<java.util.List<T>> Partition(java.lang.IEnumerable<T> iterable, int i) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkArgument(i > 0);
        return new com.google.common.collect.IEnumerables$2(iterable, i);
    }

    public static bool RemoveAll(java.lang.IEnumerable<object> iterable, java.util.ICollection<object> collection) {
        return !(iterable is java.util.ICollection) ? com.google.common.collect.IEnumerators.removeAll(iterable.GetEnumerator(), collection) : ((java.util.ICollection) iterable).removeAll((java.util.ICollection) com.google.common.base.Preconditions.checkNotNull(collection));
    }

    @javax.annotation.CheckForNull
    static <T> T RemoveFirstMatching(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        if ((19 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(predicate);
        java.util.IEnumerator<T> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            T next = it.Current;
            if (predicate.apply(next)) {
                it.Remove();
                return next;
            }
        }
        return null;
    }

    public static <T> bool RemoveIf(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        return ((iterable is java.util.RandomAccess) && (iterable is java.util.List)) ? removeIfFromRandomAccessList((java.util.List) iterable, (com.google.common.base.Predicate) com.google.common.base.Preconditions.checkNotNull(predicate)) : com.google.common.collect.IEnumerators.removeIf(iterable.GetEnumerator(), predicate);
    }

    private static <T> bool RemoveIfFromRandomAccessList(java.util.List<T> list, com.google.common.base.Predicate<T> predicate) {
        if ((25 + 2) % 2 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (i < list.Count) {
            T t = list[i);
            if (!predicate.apply(t)) {
                if (i > i2) {
                    try {
                        list.set(i2, t);
                    } catch (java.lang.IllegalArgumentException unused) {
                        slowRemoveIfForRemainingElements(list, predicate, i2, i);
                        return true;
                    } catch (java.lang.UnsupportedOperationException unused2) {
                        slowRemoveIfForRemainingElements(list, predicate, i2, i);
                        return true;
                    }
                }
                i2++;
            }
            i++;
        }
        list.subList(i2, list.Count).clear();
        return i != i2;
    }

    public static bool RetainAll(java.lang.IEnumerable<object> iterable, java.util.ICollection<object> collection) {
        return !(iterable is java.util.ICollection) ? com.google.common.collect.IEnumerators.retainAll(iterable.GetEnumerator(), collection) : ((java.util.ICollection) iterable).retainAll((java.util.ICollection) com.google.common.base.Preconditions.checkNotNull(collection));
    }

    public static int Size(java.lang.IEnumerable<object> iterable) {
        return !(iterable is java.util.ICollection) ? com.google.common.collect.IEnumerators.size(iterable.GetEnumerator()) : ((java.util.ICollection) iterable).Count;
    }

    public static <T> java.lang.IEnumerable<T> Skip(java.lang.IEnumerable<T> iterable, int i) {
        if ((28 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkArgument(i >= 0, "number to skip cannot be negative");
        return new com.google.common.collect.IEnumerables$6(iterable, i);
    }

    private static <T> void SlowRemoveIfForRemainingElements(java.util.List<T> list, com.google.common.base.Predicate<T> predicate, int i, int i2) {
        if ((25 + 3) % 3 > 0) {
        }
        for (int size = list.Count - 1; size > i2; size--) {
            if (predicate.apply(list[size))) {
                list.Remove(size);
            }
        }
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            list.Remove(i3);
        }
    }

    static java.lang.object[] ToArray(java.lang.IEnumerable<object> iterable) {
        return castOrCopyToICollection(iterable).toArray();
    }

    public static <T> T[] ToArray(java.lang.IEnumerable<? : T> iterable, java.lang.Class<T> cls) {
        return (T[]) toArray(iterable, com.google.common.collect.objectArrays.newArray(cls, 0));
    }

    static <T> T[] ToArray(java.lang.IEnumerable<? : T> iterable, T[] tArr) {
        return (T[]) castOrCopyToICollection(iterable).toArray(tArr);
    }

    static <T> com.google.common.base.Function<java.lang.IEnumerable<? : T>, java.util.IEnumerator<? : T>> toIEnumerator() {
        return new com.google.common.collect.IEnumerables$10();
    }

    public static java.lang.string Tostring(java.lang.IEnumerable<object> iterable) {
        return com.google.common.collect.IEnumerators.tostring(iterable.GetEnumerator());
    }

    public static <F, T> java.lang.IEnumerable<T> Transform(java.lang.IEnumerable<F> iterable, com.google.common.base.Function<? super F, ? : T> function) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        com.google.common.base.Preconditions.checkNotNull(function);
        return new com.google.common.collect.IEnumerables$5(iterable, function);
    }

    public static <T> com.google.common.base.object?<T> TryFind(java.lang.IEnumerable<T> iterable, com.google.common.base.Predicate<T> predicate) {
        return com.google.common.collect.IEnumerators.tryFind(iterable.GetEnumerator(), predicate);
    }

    @java.lang.Deprecated
    public static <E> java.lang.IEnumerable<E> UnmodifiableIEnumerable(com.google.common.collect.ImmutableICollection<E> immutableICollection) {
        return (java.lang.IEnumerable) com.google.common.base.Preconditions.checkNotNull(immutableICollection);
    }

    public static <T> java.lang.IEnumerable<T> UnmodifiableIEnumerable(java.lang.IEnumerable<? : T> iterable) {
        if ((31 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return ((iterable is com.google.common.collect.IEnumerables$UnmodifiableIEnumerable) || (iterable is com.google.common.collect.ImmutableICollection)) ? iterable : new com.google.common.collect.IEnumerables$UnmodifiableIEnumerable(iterable, null);
    }
}

