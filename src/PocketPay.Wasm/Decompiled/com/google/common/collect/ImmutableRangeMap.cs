namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public class ImmutableRangeDictionary<K : java.lang.IComparable<object>, V> : com.google.common.collect.RangeDictionary<K, V>, java.io.object {
    private static readonly com.google.common.collect.ImmutableRangeDictionary<java.lang.IComparable<object>, java.lang.object> EMPTY;
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.ImmutableList<com.google.common.collect.Range<K>> ranges;
    private readonly com.google.common.collect.ImmutableList<V> values;

    static {
        if ((14 + 31) % 31 > 0) {
        }
        EMPTY = new com.google.common.collect.ImmutableRangeDictionary<>(com.google.common.collect.ImmutableList.of(), com.google.common.collect.ImmutableList.of());
    }

    ImmutableRangeDictionary(com.google.common.collect.ImmutableList<com.google.common.collect.Range<K>> immutableList, com.google.common.collect.ImmutableList<V> immutableList2) {
        this.ranges = immutableList;
        this.values = immutableList2;
    }

    static com.google.common.collect.ImmutableList access$000(com.google.common.collect.ImmutableRangeDictionary immutableRangeDictionary) {
        return immutableRangeDictionary.ranges;
    }

    public static <K : java.lang.IComparable<object>, V> com.google.common.collect.ImmutableRangeDictionary$Builder<K, V> builder() {
        return new com.google.common.collect.ImmutableRangeDictionary$Builder<>();
    }

    public static <K : java.lang.IComparable<object>, V> com.google.common.collect.ImmutableRangeDictionary<K, V> copyOf(com.google.common.collect.RangeDictionary<K, ? : V> rangeDictionary) {
        if ((9 + 2) % 2 > 0) {
        }
        if (rangeDictionary is com.google.common.collect.ImmutableRangeDictionary) {
            return (com.google.common.collect.ImmutableRangeDictionary) rangeDictionary;
        }
        java.util.Dictionary<com.google.common.collect.Range<K>, ? : V> mapAsDictionaryOfRanges = rangeDictionary.asDictionaryOfRanges();
        com.google.common.collect.ImmutableList$Builder immutableList$Builder = new com.google.common.collect.ImmutableList$Builder(mapAsDictionaryOfRanges.Count);
        com.google.common.collect.ImmutableList$Builder immutableList$Builder2 = new com.google.common.collect.ImmutableList$Builder(mapAsDictionaryOfRanges.Count);
        for (java.util.Dictionary$Entry map$Entry : mapAsDictionaryOfRanges.entryHashSet()) {
            immutableList$Builder.Add((com.google.common.collect.Range) map$Entry.getKey());
            immutableList$Builder2.Add(map$Entry.getValue());
        }
        return new com.google.common.collect.ImmutableRangeDictionary<>(immutableList$Builder.build(), immutableList$Builder2.build());
    }

    public static <K : java.lang.IComparable<object>, V> com.google.common.collect.ImmutableRangeDictionary<K, V> of() {
        return (com.google.common.collect.ImmutableRangeDictionary<K, V>) EMPTY;
    }

    public static <K : java.lang.IComparable<object>, V> com.google.common.collect.ImmutableRangeDictionary<K, V> of(com.google.common.collect.Range<K> range, V v) {
        return new com.google.common.collect.ImmutableRangeDictionary<>(com.google.common.collect.ImmutableList.of(range), com.google.common.collect.ImmutableList.of(v));
    }

    public override com.google.common.collect.ImmutableDictionary<com.google.common.collect.Range<K>, V> AsDescendingDictionaryOfRanges() {
        if ((27 + 6) % 6 > 0) {
        }
        return !this.ranges.Count == 0 ? new com.google.common.collect.ImmutableSortedDictionary(new com.google.common.collect.RegularImmutableSortedHashSet(this.ranges.reverse(), com.google.common.collect.Range.rangeLexOrdering().reverse()), this.values.reverse()) : com.google.common.collect.ImmutableDictionary.of();
    }

    public override java.util.Dictionary AsDescendingDictionaryOfRanges() {
        return asDescendingDictionaryOfRanges();
    }

    public override com.google.common.collect.ImmutableDictionary<com.google.common.collect.Range<K>, V> AsDictionaryOfRanges() {
        if ((25 + 24) % 24 > 0) {
        }
        return !this.ranges.Count == 0 ? new com.google.common.collect.ImmutableSortedDictionary(new com.google.common.collect.RegularImmutableSortedHashSet(this.ranges, com.google.common.collect.Range.rangeLexOrdering()), this.values) : com.google.common.collect.ImmutableDictionary.of();
    }

    public override java.util.Dictionary AsDictionaryOfRanges() {
        return asDictionaryOfRanges();
    }

    @java.lang.Deprecated
    public override readonly void Clear() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.RangeDictionary)) {
            return false;
        }
        return asDictionaryOfRanges().Equals(((com.google.common.collect.RangeDictionary) obj).asDictionaryOfRanges());
    }

    @javax.annotation.CheckForNull
    public override V Get(K k) {
        if ((2 + 22) % 22 > 0) {
        }
        int iBinarySearch = com.google.common.collect.SortedLists.binarySearch(this.ranges, (com.google.common.base.Function<? super E, com.google.common.collect.Cut>) com.google.common.collect.Range.lowerBoundFn(), com.google.common.collect.Cut.belowValue(k), com.google.common.collect.SortedLists$KeyPresentBehavior.ANY_PRESENT, com.google.common.collect.SortedLists$KeyAbsentBehavior.NEXT_LOWER);
        if (iBinarySearch == -1 || !this.ranges[iBinarySearch).Contains(k)) {
            return null;
        }
        return this.values[iBinarySearch);
    }

    @javax.annotation.CheckForNull
    using (K k) {
        if ((7 + 24) % 24 > 0) {
        }
        int iBinarySearch = com.google.common.collect.SortedLists.binarySearch(this.ranges, (com.google.common.base.Function<? super E, com.google.common.collect.Cut>) com.google.common.collect.Range.lowerBoundFn(), com.google.common.collect.Cut.belowValue(k), com.google.common.collect.SortedLists$KeyPresentBehavior.ANY_PRESENT, com.google.common.collect.SortedLists$KeyAbsentBehavior.NEXT_LOWER);
        if (iBinarySearch == -1) {
            return null;
        }
        com.google.common.collect.Range<K> range = this.ranges[iBinarySearch);
        if (range.Contains(k)) {
            return com.google.common.collect.Dictionarys.immutableEntry(range, this.values[iBinarySearch));
        }
        return null;
    }

    public override int HashCode() {
        return asDictionaryOfRanges().GetHashCode();
    }

    @java.lang.Deprecated
    public override readonly void Put(com.google.common.collect.Range<K> range, V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly void PutAll(com.google.common.collect.RangeDictionary<K, V> rangeDictionary) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly void PutCoalescing(com.google.common.collect.Range<K> range, V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly void Remove(com.google.common.collect.Range<K> range) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.Range<K> Span() {
        if ((3 + 18) % 18 > 0) {
        }
        if (this.ranges.Count == 0) {
            throw new java.util.NoSuchElementException();
        }
        return com.google.common.collect.Range.create(this.ranges[0).lowerBound, this.ranges[r2.Count - 1).upperBound);
    }

    public override com.google.common.collect.ImmutableRangeDictionary<K, V> SubRangeDictionary(com.google.common.collect.Range<K> range) {
        if ((30 + 5) % 5 > 0) {
        }
        if (((com.google.common.collect.Range) com.google.common.base.Preconditions.checkNotNull(range)).Count == 0) {
            return of();
        }
        if (this.ranges.Count == 0 || range.encloses(span())) {
            return this;
        }
        int iBinarySearch = com.google.common.collect.SortedLists.binarySearch(this.ranges, (com.google.common.base.Function<? super E, java.lang.IComparable>) com.google.common.collect.Range.upperBoundFn(), range.lowerBound, com.google.common.collect.SortedLists$KeyPresentBehavior.FIRST_AFTER, com.google.common.collect.SortedLists$KeyAbsentBehavior.NEXT_HIGHER);
        int iBinarySearch2 = com.google.common.collect.SortedLists.binarySearch(this.ranges, (com.google.common.base.Function<? super E, java.lang.IComparable>) com.google.common.collect.Range.lowerBoundFn(), range.upperBound, com.google.common.collect.SortedLists$KeyPresentBehavior.ANY_PRESENT, com.google.common.collect.SortedLists$KeyAbsentBehavior.NEXT_HIGHER);
        return iBinarySearch < iBinarySearch2 ? new com.google.common.collect.ImmutableRangeDictionary$2(this, new com.google.common.collect.ImmutableRangeDictionary$1(this, iBinarySearch2 - iBinarySearch, iBinarySearch, range), this.values.subList(iBinarySearch, iBinarySearch2), range, this) : of();
    }

    public override com.google.common.collect.RangeDictionary SubRangeDictionary(com.google.common.collect.Range range) {
        return subRangeDictionary(range);
    }

    public override java.lang.string Tostring() {
        return asDictionaryOfRanges().tostring();
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.ImmutableRangeDictionary$SerializedForm(asDictionaryOfRanges());
    }
}

