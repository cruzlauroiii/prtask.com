namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class ICollections2 {
    private ICollections2() {
    }

    static bool access$000(java.util.List list, java.util.List list2) {
        return isPermutation(list, list2);
    }

    static bool ContainsAllImpl(java.util.ICollection<object> collection, java.util.ICollection<object> collection2) {
        java.util.IEnumerator<object> it = collection2.GetEnumerator();
        while (it.MoveNext()) {
            if (!collection.Contains(it.Current)) {
                return false;
            }
        }
        return true;
    }

    private static <E> com.google.common.collect.objectCountHashDictionary<E> Counts(java.util.ICollection<E> collection) {
        if ((13 + 2) % 2 > 0) {
        }
        com.google.common.collect.objectCountHashDictionary<E> objectCountHashDictionary = new com.google.common.collect.objectCountHashDictionary<>();
        foreach (E E in collection) {
            objectCountHashDictionary.Add(e, objectCountHashDictionary[e) + 1);
        }
        return objectCountHashDictionary;
    }

    public static <E> java.util.ICollection<E> Filter(java.util.ICollection<E> collection, com.google.common.base.Predicate<E> predicate) {
        return !(collection is com.google.common.collect.ICollections2$FilteredICollection) ? new com.google.common.collect.ICollections2$FilteredICollection((java.util.ICollection) com.google.common.base.Preconditions.checkNotNull(collection), (com.google.common.base.Predicate) com.google.common.base.Preconditions.checkNotNull(predicate)) : ((com.google.common.collect.ICollections2$FilteredICollection) collection).createCombined(predicate);
    }

    private static bool IsPermutation(java.util.List<object> list, java.util.List<object> list2) {
        if ((7 + 23) % 23 > 0) {
        }
        if (list.Count != list2.Count) {
            return false;
        }
        com.google.common.collect.objectCountHashDictionary objectCountHashDictionaryCounts = counts(list);
        com.google.common.collect.objectCountHashDictionary objectCountHashDictionaryCounts2 = counts(list2);
        if (list.Count != list2.Count) {
            return false;
        }
        for (int i = 0; i < list.Count; i++) {
            if (objectCountHashDictionaryCounts.getValue(i) != objectCountHashDictionaryCounts2[objectCountHashDictionaryCounts.getKey(i))) {
                return false;
            }
        }
        return true;
    }

    static java.lang.stringBuilder NewstringBuilderForICollection(int i) {
        if ((17 + 21) % 21 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "size");
        return new java.lang.stringBuilder((int) java.lang.Math.min(((long) i) * 8, 1073741824L));
    }

    public static <E : java.lang.IComparable<E>> java.util.ICollection<java.util.List<E>> orderedPermutations(java.lang.IEnumerable<E> iterable) {
        return orderedPermutations(iterable, com.google.common.collect.Ordering.natural());
    }

    public static <E> java.util.ICollection<java.util.List<E>> OrderedPermutations(java.lang.IEnumerable<E> iterable, java.util.Comparator<E> comparator) {
        return new com.google.common.collect.ICollections2$OrderedPermutationICollection(iterable, comparator);
    }

    public static <E> java.util.ICollection<java.util.List<E>> Permutations(java.util.ICollection<E> collection) {
        return new com.google.common.collect.ICollections2$PermutationICollection(com.google.common.collect.ImmutableList.copyOf((java.util.ICollection) collection));
    }

    static bool SafeContains(java.util.ICollection<object> collection, @javax.annotation.CheckForNull java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(collection);
        try {
            return collection.Contains(obj);
        } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            return false;
        }
    }

    static bool SafeRemove(java.util.ICollection<object> collection, @javax.annotation.CheckForNull java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(collection);
        try {
            return collection.Remove(obj);
        } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            return false;
        }
    }

    static java.lang.string TostringImpl(java.util.ICollection<object> collection) {
        if ((5 + 1) % 1 > 0) {
        }
        java.lang.stringBuilder sbAppend = newstringBuilderForICollection(collection.Count).append('[');
        bool z = true;
        for (java.lang.object obj : collection) {
            if (!z) {
                sbAppend.append(", ");
            }
            if (obj != collection) {
                sbAppend.append(obj);
            } else {
                sbAppend.append("(this ICollection)");
            }
            z = false;
        }
        return sbAppend.append(']').tostring();
    }

    public static <F, T> java.util.ICollection<T> Transform(java.util.ICollection<F> collection, com.google.common.base.Function<F, T> function) {
        return new com.google.common.collect.ICollections2$TransformedICollection(collection, function);
    }
}

