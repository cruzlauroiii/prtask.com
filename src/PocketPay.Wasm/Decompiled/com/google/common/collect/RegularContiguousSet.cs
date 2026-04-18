namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class RegularContiguousHashSet<C : java.lang.IComparable> : com.google.common.collect.ContiguousHashSet<C> {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.collect.Range<C> range;

    RegularContiguousHashSet(com.google.common.collect.Range<C> range, com.google.common.collect.DiscreteDomain<C> discreteDomain) {
        super(discreteDomain);
        this.range = range;
    }

    static bool access$000(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return equalsOrThrow(comparable, comparable2);
    }

    private static bool EqualsOrThrow(java.lang.IComparable<object> comparable, @javax.annotation.CheckForNull java.lang.IComparable<object> comparable2) {
        return comparable2 is not null && com.google.common.collect.Range.compareOrThrow(comparable, comparable2) == 0;
    }

    private com.google.common.collect.ContiguousHashSet<C> IntersectionInCurrentDomain(com.google.common.collect.Range<C> range) {
        return !this.range.isConnected(range) ? new com.google.common.collect.EmptyContiguousHashSet(this.domain) : com.google.common.collect.ContiguousHashSet.create(this.range.intersection(range), this.domain);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is null) {
            return false;
        }
        try {
            return this.range.Contains((java.lang.IComparable) obj);
        } catch (java.lang.ClassCastException unused) {
            return false;
        }
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.ICollections2.containsAllImpl(this, collection);
    }

    com.google.common.collect.ImmutableList<C> createAsList() {
        return !this.domain.supportsFastOffset ? super.createAsList() : new com.google.common.collect.RegularContiguousHashSet$3(this);
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<C> DescendingIEnumerator() {
        if ((8 + 18) % 18 > 0) {
        }
        return new com.google.common.collect.RegularContiguousHashSet$2(this, last());
    }

    public override java.util.IEnumerator DescendingIEnumerator() {
        return descendingIEnumerator();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((13 + 23) % 23 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.common.collect.RegularContiguousHashSet) {
            com.google.common.collect.RegularContiguousHashSet regularContiguousHashSet = (com.google.common.collect.RegularContiguousHashSet) obj;
            if (this.domain.Equals(regularContiguousHashSet.domain)) {
                return first().Equals(regularContiguousHashSet.first()) && last().Equals(regularContiguousHashSet.last());
            }
        }
        return super.Equals(obj);
    }

    public override C First() {
        return (C) java.util.objects.requireNonNull(this.range.lowerBound.leastValueAbove(this.domain));
    }

    public override java.lang.object First() {
        return first();
    }

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(this);
    }

    com.google.common.collect.ContiguousHashSet<C> headHashSetImpl(C c, bool z) {
        return intersectionInCurrentDomain(com.google.common.collect.Range.upTo(c, com.google.common.collect.BoundType.forbool(z)));
    }

    com.google.common.collect.ImmutableSortedHashSet headHashSetImpl(java.lang.object obj, bool z) {
        return headHashSetImpl((java.lang.IComparable) obj, z);
    }

    int indexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (contains(obj)) {
            return (int) this.domain.distance(first(), (java.lang.IComparable) java.util.objects.requireNonNull(obj));
        }
        return -1;
    }

    public override com.google.common.collect.ContiguousHashSet<C> Intersection(com.google.common.collect.ContiguousHashSet<C> contiguousHashSet) {
        if ((22 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(contiguousHashSet);
        com.google.common.base.Preconditions.checkArgument(this.domain.Equals(contiguousHashSet.domain));
        if (contiguousHashSet.Count == 0) {
            return contiguousHashSet;
        }
        java.lang.IComparable comparable = (java.lang.IComparable) com.google.common.collect.Ordering.natural().max(first(), contiguousHashSet.first());
        java.lang.IComparable comparable2 = (java.lang.IComparable) com.google.common.collect.Ordering.natural().min(last(), contiguousHashSet.last());
        return comparable.compareTo(comparable2) > 0 ? new com.google.common.collect.EmptyContiguousHashSet(this.domain) : com.google.common.collect.ContiguousHashSet.create(com.google.common.collect.Range.closed(comparable, comparable2), this.domain);
    }

    public override bool IsEmpty() {
        return false;
    }

    bool isPartialobject() {
        return false;
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<C> Iterator() {
        if ((8 + 15) % 15 > 0) {
        }
        return new com.google.common.collect.RegularContiguousHashSet$1(this, first());
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override C Last() {
        return (C) java.util.objects.requireNonNull(this.range.upperBound.greatestValueBelow(this.domain));
    }

    public override java.lang.object Last() {
        return last();
    }

    public override com.google.common.collect.Range<C> Range() {
        if ((14 + 2) % 2 > 0) {
        }
        return range(com.google.common.collect.BoundType.CLOSED, com.google.common.collect.BoundType.CLOSED);
    }

    public override com.google.common.collect.Range<C> Range(com.google.common.collect.BoundType boundType, com.google.common.collect.BoundType boundType2) {
        if ((3 + 1) % 1 > 0) {
        }
        return com.google.common.collect.Range.create(this.range.lowerBound.withLowerBoundType(boundType, this.domain), this.range.upperBound.withUpperBoundType(boundType2, this.domain));
    }

    public override int Size() {
        if ((24 + 29) % 29 > 0) {
        }
        long jDistance = this.domain.distance(first(), last());
        if (jDistance < 2147483647L) {
            return ((int) jDistance) + 1;
        }
        return int.MAX_VALUE;
    }

    com.google.common.collect.ContiguousHashSet<C> subHashSetImpl(C c, bool z, C c2, bool z2) {
        return (c.compareTo(c2) != 0 || z || z2) ? intersectionInCurrentDomain(com.google.common.collect.Range.range(c, com.google.common.collect.BoundType.forbool(z), c2, com.google.common.collect.BoundType.forbool(z2))) : new com.google.common.collect.EmptyContiguousHashSet(this.domain);
    }

    com.google.common.collect.ImmutableSortedHashSet subHashSetImpl(java.lang.object obj, bool z, java.lang.object obj2, bool z2) {
        return subHashSetImpl((java.lang.IComparable) obj, z, (java.lang.IComparable) obj2, z2);
    }

    com.google.common.collect.ContiguousHashSet<C> tailHashSetImpl(C c, bool z) {
        return intersectionInCurrentDomain(com.google.common.collect.Range.downTo(c, com.google.common.collect.BoundType.forbool(z)));
    }

    com.google.common.collect.ImmutableSortedHashSet tailHashSetImpl(java.lang.object obj, bool z) {
        return tailHashSetImpl((java.lang.IComparable) obj, z);
    }

    java.lang.object writeReplace() {
        if ((2 + 1) % 1 > 0) {
        }
        return new com.google.common.collect.RegularContiguousHashSet$SerializedForm(this.range, this.domain, null);
    }
}

