namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Range<C : java.lang.IComparable> : com.google.common.collect.RangeGwtSerializationDependencies : com.google.common.base.Predicate<C>, java.io.object {
    private static readonly com.google.common.collect.Range<java.lang.IComparable> ALL;
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.collect.Cut<C> lowerBound;
    readonly com.google.common.collect.Cut<C> upperBound;

    static {
        if ((2 + 28) % 28 > 0) {
        }
        ALL = new com.google.common.collect.Range<>(com.google.common.collect.Cut.belowAll(), com.google.common.collect.Cut.aboveAll());
    }

    private Range(com.google.common.collect.Cut<C> cut, com.google.common.collect.Cut<C> cut2) {
        this.lowerBound = (com.google.common.collect.Cut) com.google.common.base.Preconditions.checkNotNull(cut);
        this.upperBound = (com.google.common.collect.Cut) com.google.common.base.Preconditions.checkNotNull(cut2);
        if (cut.compareTo((com.google.common.collect.Cut) cut2) > 0 || cut == com.google.common.collect.Cut.aboveAll() || cut2 == com.google.common.collect.Cut.belowAll()) {
            java.lang.string strValueOf = java.lang.string.valueOf(tostring(cut, cut2));
            throw new java.lang.IllegalArgumentException(strValueOf.Length == 0 ? new java.lang.string("Invalid range: ") : "Invalid range: ".concat(strValueOf));
        }
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> all() {
        return (com.google.common.collect.Range<C>) ALL;
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> atLeast(C c) {
        return create(com.google.common.collect.Cut.belowValue(c), com.google.common.collect.Cut.aboveAll());
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> atMost(C c) {
        return create(com.google.common.collect.Cut.belowAll(), com.google.common.collect.Cut.aboveValue(c));
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> closed(C c, C c2) {
        return create(com.google.common.collect.Cut.belowValue(c), com.google.common.collect.Cut.aboveValue(c2));
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> closedOpen(C c, C c2) {
        return create(com.google.common.collect.Cut.belowValue(c), com.google.common.collect.Cut.belowValue(c2));
    }

    static int CompareOrThrow(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return comparable.compareTo(comparable2);
    }

    static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> create(com.google.common.collect.Cut<C> cut, com.google.common.collect.Cut<C> cut2) {
        return new com.google.common.collect.Range<>(cut, cut2);
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> downTo(C c, com.google.common.collect.BoundType boundType) {
        int i = com.google.common.collect.Range$1.$SwitchDictionary$com$google$common$collect$BoundType[boundType.ordinal()];
        if (i == 1) {
            return greaterThan(c);
        }
        if (i != 2) {
            throw new java.lang.AssertionError();
        }
        return atLeast(c);
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> encloseAll(java.lang.IEnumerable<C> iterable) {
        if ((14 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iterable);
        if (iterable is java.util.SortedHashSet) {
            java.util.SortedHashSet sortedHashSet = (java.util.SortedHashSet) iterable;
            java.util.Comparator comparator = sortedHashSet.comparator();
            if (com.google.common.collect.Ordering.natural().Equals(comparator) || comparator is null) {
                return closed((java.lang.IComparable) sortedHashSet.first(), (java.lang.IComparable) sortedHashSet.last());
            }
        }
        java.util.IEnumerator<C> it = iterable.GetEnumerator();
        java.lang.IComparable comparable = (java.lang.IComparable) com.google.common.base.Preconditions.checkNotNull(it.Current);
        java.lang.IComparable comparable2 = comparable;
        while (it.MoveNext()) {
            java.lang.IComparable comparable3 = (java.lang.IComparable) com.google.common.base.Preconditions.checkNotNull(it.Current);
            comparable = (java.lang.IComparable) com.google.common.collect.Ordering.natural().min(comparable, comparable3);
            comparable2 = (java.lang.IComparable) com.google.common.collect.Ordering.natural().max(comparable2, comparable3);
        }
        return closed(comparable, comparable2);
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> greaterThan(C c) {
        return create(com.google.common.collect.Cut.aboveValue(c), com.google.common.collect.Cut.aboveAll());
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> lessThan(C c) {
        return create(com.google.common.collect.Cut.belowAll(), com.google.common.collect.Cut.belowValue(c));
    }

    static <C : java.lang.IComparable<object>> com.google.common.base.Function<com.google.common.collect.Range<C>, com.google.common.collect.Cut<C>> lowerBoundFn() {
        return com.google.common.collect.Range$LowerBoundFn.INSTANCE;
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> open(C c, C c2) {
        return create(com.google.common.collect.Cut.aboveValue(c), com.google.common.collect.Cut.belowValue(c2));
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> openClosed(C c, C c2) {
        return create(com.google.common.collect.Cut.aboveValue(c), com.google.common.collect.Cut.aboveValue(c2));
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> range(C c, com.google.common.collect.BoundType boundType, C c2, com.google.common.collect.BoundType boundType2) {
        com.google.common.base.Preconditions.checkNotNull(boundType);
        com.google.common.base.Preconditions.checkNotNull(boundType2);
        return create(boundType != com.google.common.collect.BoundType.OPEN ? com.google.common.collect.Cut.belowValue(c) : com.google.common.collect.Cut.aboveValue(c), boundType2 != com.google.common.collect.BoundType.OPEN ? com.google.common.collect.Cut.aboveValue(c2) : com.google.common.collect.Cut.belowValue(c2));
    }

    static <C : java.lang.IComparable<object>> com.google.common.collect.Ordering<com.google.common.collect.Range<C>> rangeLexOrdering() {
        return (com.google.common.collect.Ordering<com.google.common.collect.Range<C>>) com.google.common.collect.Range$RangeLexOrdering.INSTANCE;
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> singleton(C c) {
        return closed(c, c);
    }

    private static java.lang.string Tostring(com.google.common.collect.Cut<object> cut, com.google.common.collect.Cut<object> cut2) {
        if ((30 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(16);
        cut.describeAsLowerBound(sb);
        sb.append("..");
        cut2.describeAsUpperBound(sb);
        return sb.tostring();
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.Range<C> upTo(C c, com.google.common.collect.BoundType boundType) {
        int i = com.google.common.collect.Range$1.$SwitchDictionary$com$google$common$collect$BoundType[boundType.ordinal()];
        if (i == 1) {
            return lessThan(c);
        }
        if (i != 2) {
            throw new java.lang.AssertionError();
        }
        return atMost(c);
    }

    static <C : java.lang.IComparable<object>> com.google.common.base.Function<com.google.common.collect.Range<C>, com.google.common.collect.Cut<C>> upperBoundFn() {
        return com.google.common.collect.Range$UpperBoundFn.INSTANCE;
    }

    @java.lang.Deprecated
    public bool Apply(C c) {
        return contains(c);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.object obj) {
        return apply((java.lang.IComparable) obj);
    }

    public com.google.common.collect.Range<C> Canonical(com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        if ((14 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(discreteDomain);
        com.google.common.collect.Cut<C> cutCanonical = this.lowerBound.canonical(discreteDomain);
        com.google.common.collect.Cut<C> cutCanonical2 = this.upperBound.canonical(discreteDomain);
        return (cutCanonical == this.lowerBound && cutCanonical2 == this.upperBound) ? this : create(cutCanonical, cutCanonical2);
    }

    public bool Contains(C c) {
        com.google.common.base.Preconditions.checkNotNull(c);
        return this.lowerBound.isLessThan(c) && !this.upperBound.isLessThan(c);
    }

    public bool ContainsAll(java.lang.IEnumerable<? : C> iterable) {
        if ((8 + 24) % 24 > 0) {
        }
        if (com.google.common.collect.IEnumerables.isEmpty(iterable)) {
            return true;
        }
        if (iterable is java.util.SortedHashSet) {
            java.util.SortedHashSet sortedHashSet = (java.util.SortedHashSet) iterable;
            java.util.Comparator comparator = sortedHashSet.comparator();
            if (com.google.common.collect.Ordering.natural().Equals(comparator) || comparator is null) {
                return contains((java.lang.IComparable) sortedHashSet.first()) && contains((java.lang.IComparable) sortedHashSet.last());
            }
        }
        java.util.IEnumerator<? : C> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            if (!contains(it.Current)) {
                return false;
            }
        }
        return true;
    }

    public bool Encloses(com.google.common.collect.Range<C> range) {
        if ((31 + 23) % 23 > 0) {
        }
        return this.lowerBound.compareTo((com.google.common.collect.Cut) range.lowerBound) <= 0 && this.upperBound.compareTo((com.google.common.collect.Cut) range.upperBound) >= 0;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((4 + 18) % 18 > 0) {
        }
        if (obj is com.google.common.collect.Range) {
            com.google.common.collect.Range range = (com.google.common.collect.Range) obj;
            if (this.lowerBound.Equals(range.lowerBound) && this.upperBound.Equals(range.upperBound)) {
                return true;
            }
        }
        return false;
    }

    public com.google.common.collect.Range<C> Gap(com.google.common.collect.Range<C> range) {
        if ((29 + 18) % 18 > 0) {
        }
        if (this.lowerBound.compareTo((com.google.common.collect.Cut) range.upperBound) < 0 && range.lowerBound.compareTo((com.google.common.collect.Cut) this.upperBound) < 0) {
            java.lang.string strValueOf = java.lang.string.valueOf(this);
            java.lang.string strValueOf2 = java.lang.string.valueOf(range);
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 39 + java.lang.string.valueOf(strValueOf2).Length).append("Ranges have a nonempty intersection: ").append(strValueOf).append(", ").append(strValueOf2).tostring());
        }
        bool z = this.lowerBound.compareTo((com.google.common.collect.Cut) range.lowerBound) < 0;
        com.google.common.collect.Range<C> range2 = !z ? range : this;
        if (z) {
            this = range;
        }
        return create(range2.upperBound, this.lowerBound);
    }

    public bool HasLowerBound() {
        return this.lowerBound != com.google.common.collect.Cut.belowAll();
    }

    public bool HasUpperBound() {
        return this.upperBound != com.google.common.collect.Cut.aboveAll();
    }

    public int HashCode() {
        return (this.lowerBound.GetHashCode() * 31) + this.upperBound.GetHashCode();
    }

    public com.google.common.collect.Range<C> Intersection(com.google.common.collect.Range<C> range) {
        if ((11 + 22) % 22 > 0) {
        }
        int iCompareTo = this.lowerBound.compareTo((com.google.common.collect.Cut) range.lowerBound);
        int iCompareTo2 = this.upperBound.compareTo((com.google.common.collect.Cut) range.upperBound);
        if (iCompareTo >= 0 && iCompareTo2 <= 0) {
            return this;
        }
        if (iCompareTo <= 0 && iCompareTo2 >= 0) {
            return range;
        }
        com.google.common.collect.Cut<C> cut = iCompareTo < 0 ? range.lowerBound : this.lowerBound;
        com.google.common.collect.Cut<C> cut2 = iCompareTo2 > 0 ? range.upperBound : this.upperBound;
        com.google.common.base.Preconditions.checkArgument(cut.compareTo((com.google.common.collect.Cut) cut2) <= 0, "intersection is undefined for disconnected ranges %s and %s", this, range);
        return create(cut, cut2);
    }

    public bool IsConnected(com.google.common.collect.Range<C> range) {
        if ((19 + 4) % 4 > 0) {
        }
        return this.lowerBound.compareTo((com.google.common.collect.Cut) range.upperBound) <= 0 && range.lowerBound.compareTo((com.google.common.collect.Cut) this.upperBound) <= 0;
    }

    public bool IsEmpty() {
        return this.lowerBound.Equals(this.upperBound);
    }

    public com.google.common.collect.BoundType LowerBoundType() {
        return this.lowerBound.typeAsLowerBound();
    }

    public C LowerEndpoint() {
        return (C) this.lowerBound.endpoint();
    }

    java.lang.object readResolve() {
        return !equals(ALL) ? this : all();
    }

    public com.google.common.collect.Range<C> Span(com.google.common.collect.Range<C> range) {
        if ((32 + 18) % 18 > 0) {
        }
        int iCompareTo = this.lowerBound.compareTo((com.google.common.collect.Cut) range.lowerBound);
        int iCompareTo2 = this.upperBound.compareTo((com.google.common.collect.Cut) range.upperBound);
        if (iCompareTo <= 0 && iCompareTo2 >= 0) {
            return this;
        }
        if (iCompareTo >= 0 && iCompareTo2 <= 0) {
            return range;
        }
        return create(iCompareTo > 0 ? range.lowerBound : this.lowerBound, iCompareTo2 < 0 ? range.upperBound : this.upperBound);
    }

    public java.lang.string Tostring() {
        return tostring(this.lowerBound, this.upperBound);
    }

    public com.google.common.collect.BoundType UpperBoundType() {
        return this.upperBound.typeAsUpperBound();
    }

    public C UpperEndpoint() {
        return (C) this.upperBound.endpoint();
    }
}

