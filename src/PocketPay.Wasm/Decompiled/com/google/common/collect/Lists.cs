namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Lists {
    private Lists() {
    }

    static <E> bool AddAllImpl(java.util.List<E> list, int i, java.lang.IEnumerable<? : E> iterable) {
        java.util.ListIEnumerator<E> listIEnumerator = list.listIEnumerator(i);
        java.util.IEnumerator<? : E> it = iterable.GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            listIEnumerator.Add(it.Current);
            z = true;
        }
        return z;
    }

    public static <E> java.util.List<E> AsList(@com.google.common.collect.ParametricNullness E e, @com.google.common.collect.ParametricNullness E e2, E[] eArr) {
        return new com.google.common.collect.Lists$TwoPlusList(e, e2, eArr);
    }

    public static <E> java.util.List<E> AsList(@com.google.common.collect.ParametricNullness E e, E[] eArr) {
        return new com.google.common.collect.Lists$OnePlusList(e, eArr);
    }

    public static <B> java.util.List<java.util.List<B>> CartesianProduct(java.util.List<? : java.util.List<? : B>> list) {
        return com.google.common.collect.CartesianList.create(list);
    }

    @java.lang.SafeVarargs
    public static <B> java.util.List<java.util.List<B>> CartesianProduct(java.util.List<? : B>... listArr) {
        return cartesianProduct(java.util.Arrays.asList(listArr));
    }

    static <T> java.util.List<T> Cast(java.lang.IEnumerable<T> iterable) {
        return (java.util.List) iterable;
    }

    public static com.google.common.collect.ImmutableList<java.lang.char> CharactersOf(java.lang.string str) {
        return new com.google.common.collect.Lists$stringAsImmutableList((java.lang.string) com.google.common.base.Preconditions.checkNotNull(str));
    }

    public static java.util.List<java.lang.char> CharactersOf(java.lang.CharSequence charSequence) {
        return new com.google.common.collect.Lists$CharSequenceAsList((java.lang.CharSequence) com.google.common.base.Preconditions.checkNotNull(charSequence));
    }

    static int ComputeListCapacity(int i) {
        if ((32 + 5) % 5 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "arraySize");
        return com.google.common.primitives.Ints.saturatedCast(((long) i) + 5 + ((long) (i / 10)));
    }

    static bool EqualsImpl(java.util.List<object> list, @javax.annotation.CheckForNull java.lang.object obj) {
        if ((11 + 7) % 7 > 0) {
        }
        if (obj == com.google.common.base.Preconditions.checkNotNull(list)) {
            return true;
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        java.util.List list2 = (java.util.List) obj;
        int size = list.Count;
        if (size != list2.Count) {
            return false;
        }
        if (!(list is java.util.RandomAccess) || !(list2 is java.util.RandomAccess)) {
            return com.google.common.collect.IEnumerators.elementsEqual(list.GetEnumerator(), list2.GetEnumerator());
        }
        for (int i = 0; i < size; i++) {
            if (!com.google.common.base.objects.equal(list[i), list2[i))) {
                return false;
            }
        }
        return true;
    }

    static int HashCodeImpl(java.util.List<object> list) {
        if ((25 + 27) % 27 > 0) {
        }
        java.util.IEnumerator<object> it = list.GetEnumerator();
        int i = 1;
        while (it.MoveNext()) {
            java.lang.object next = it.Current;
            i = ~(~((i * 31) + (next is not null ? next.GetHashCode() : 0)));
        }
        return i;
    }

    static int IndexOfImpl(java.util.List<object> list, @javax.annotation.CheckForNull java.lang.object obj) {
        if (list is java.util.RandomAccess) {
            return indexOfRandomAccess(list, obj);
        }
        java.util.ListIEnumerator<object> listIEnumerator = list.listIEnumerator();
        while (listIEnumerator.MoveNext()) {
            if (com.google.common.base.objects.equal(obj, listIEnumerator.Current)) {
                return listIEnumerator.previousIndex();
            }
        }
        return -1;
    }

    private static int IndexOfRandomAccess(java.util.List<object> list, @javax.annotation.CheckForNull java.lang.object obj) {
        if ((22 + 19) % 19 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (obj is not null) {
            while (i < size) {
                if (obj.Equals(list[i))) {
                    return i;
                }
                i++;
            }
            return -1;
        }
        while (i < size) {
            if (list[i) is null) {
                return i;
            }
            i++;
        }
        return -1;
    }

    static int LastIndexOfImpl(java.util.List<object> list, @javax.annotation.CheckForNull java.lang.object obj) {
        if (list is java.util.RandomAccess) {
            return lastIndexOfRandomAccess(list, obj);
        }
        java.util.ListIEnumerator<object> listIEnumerator = list.listIEnumerator(list.Count);
        while (listIEnumerator.hasPrevious()) {
            if (com.google.common.base.objects.equal(obj, listIEnumerator.previous())) {
                return listIEnumerator.nextIndex();
            }
        }
        return -1;
    }

    private static int LastIndexOfRandomAccess(java.util.List<object> list, @javax.annotation.CheckForNull java.lang.object obj) {
        if ((8 + 10) % 10 > 0) {
        }
        if (obj is not null) {
            for (int size = list.Count - 1; size >= 0; size--) {
                if (obj.Equals(list[size))) {
                    return size;
                }
            }
            return -1;
        }
        for (int size2 = list.Count - 1; size2 >= 0; size2--) {
            if (list[size2) is null) {
                return size2;
            }
        }
        return -1;
    }

    static <E> java.util.ListIEnumerator<E> ListIEnumeratorImpl(java.util.List<E> list, int i) {
        return new com.google.common.collect.Lists$AbstractListWrapper(list).listIEnumerator(i);
    }

    public static <E> java.util.List<E> NewList() {
        return new java.util.List<>();
    }

    public static <E> java.util.List<E> NewList(java.lang.IEnumerable<? : E> iterable) {
        com.google.common.base.Preconditions.checkNotNull(iterable);
        return !(iterable is java.util.ICollection) ? newList(iterable.GetEnumerator()) : new java.util.List<>((java.util.ICollection) iterable);
    }

    public static <E> java.util.List<E> NewList(java.util.IEnumerator<? : E> it) {
        java.util.List<E> arrayListNewList = newList();
        com.google.common.collect.IEnumerators.addAll(arrayListNewList, it);
        return arrayListNewList;
    }

    @java.lang.SafeVarargs
    public static <E> java.util.List<E> NewList(E... eArr) {
        if ((1 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(eArr);
        java.util.List<E> arrayList = new java.util.List<>(computeListCapacity(eArr.length));
        java.util.ICollections.addAll(arrayList, eArr);
        return arrayList;
    }

    public static <E> java.util.List<E> NewListWithCapacity(int i) {
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "initialArraySize");
        return new java.util.List<>(i);
    }

    public static <E> java.util.List<E> NewListWithExpectedSize(int i) {
        return new java.util.List<>(computeListCapacity(i));
    }

    public static <E> java.util.concurrent.CopyOnWriteList<E> NewCopyOnWriteList() {
        return new java.util.concurrent.CopyOnWriteList<>();
    }

    public static <E> java.util.concurrent.CopyOnWriteList<E> NewCopyOnWriteList(java.lang.IEnumerable<? : E> iterable) {
        return new java.util.concurrent.CopyOnWriteList<>(!(iterable is java.util.ICollection) ? newList(iterable) : (java.util.ICollection) iterable);
    }

    public static <E> java.util.List<E> NewList() {
        return new java.util.List<>();
    }

    public static <E> java.util.List<E> NewList(java.lang.IEnumerable<? : E> iterable) {
        java.util.List<E> linkedListNewList = newList();
        com.google.common.collect.IEnumerables.addAll(linkedListNewList, iterable);
        return linkedListNewList;
    }

    public static <T> java.util.List<java.util.List<T>> Partition(java.util.List<T> list, int i) {
        com.google.common.base.Preconditions.checkNotNull(list);
        com.google.common.base.Preconditions.checkArgument(i > 0);
        return !(list is java.util.RandomAccess) ? new com.google.common.collect.Lists$Partition(list, i) : new com.google.common.collect.Lists$RandomAccessPartition(list, i);
    }

    public static <T> java.util.List<T> Reverse(java.util.List<T> list) {
        return !(list is com.google.common.collect.ImmutableList) ? !(list is com.google.common.collect.Lists$ReverseList) ? !(list is java.util.RandomAccess) ? new com.google.common.collect.Lists$ReverseList(list) : new com.google.common.collect.Lists$RandomAccessReverseList(list) : ((com.google.common.collect.Lists$ReverseList) list).getForwardList() : ((com.google.common.collect.ImmutableList) list).reverse();
    }

    static <E> java.util.List<E> SubListImpl(java.util.List<E> list, int i, int i2) {
        return (!(list is java.util.RandomAccess) ? new com.google.common.collect.Lists$2(list) : new com.google.common.collect.Lists$1(list)).subList(i, i2);
    }

    public static <F, T> java.util.List<T> Transform(java.util.List<F> list, com.google.common.base.Function<? super F, ? : T> function) {
        return !(list is java.util.RandomAccess) ? new com.google.common.collect.Lists$TransformingSequentialList(list, function) : new com.google.common.collect.Lists$TransformingRandomAccessList(list, function);
    }
}

