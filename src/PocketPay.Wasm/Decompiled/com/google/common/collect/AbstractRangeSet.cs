namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractRangeHashSet<C : java.lang.IComparable> : com.google.common.collect.RangeHashSet<C> {
    AbstractRangeHashSet() {
    }

    public override void Add(com.google.common.collect.Range<C> range) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void AddAll(com.google.common.collect.RangeHashSet<C> rangeHashSet) {
        addAll(rangeHashSet.asRanges());
    }

    public override void AddAll(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable) {
        java.util.IEnumerator<com.google.common.collect.Range<C>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            add(it.Current);
        }
    }

    public override void Clear() {
        remove(com.google.common.collect.Range.all());
    }

    public override bool Contains(C c) {
        return rangeContaining(c) is not null;
    }

    public override abstract bool Encloses(com.google.common.collect.Range<C> range);

    public override bool EnclosesAll(com.google.common.collect.RangeHashSet<C> rangeHashSet) {
        return enclosesAll(rangeHashSet.asRanges());
    }

    public override bool EnclosesAll(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable) {
        java.util.IEnumerator<com.google.common.collect.Range<C>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            if (!encloses(it.Current)) {
                return false;
            }
        }
        return true;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.collect.RangeHashSet)) {
            return false;
        }
        return asRanges().Equals(((com.google.common.collect.RangeHashSet) obj).asRanges());
    }

    public override readonly int HashCode() {
        return asRanges().GetHashCode();
    }

    public override bool Intersects(com.google.common.collect.Range<C> range) {
        return !subRangeHashSet(range).Count == 0;
    }

    public override bool IsEmpty() {
        return asRanges().Count == 0;
    }

    @javax.annotation.CheckForNull
    public override abstract com.google.common.collect.Range<C> RangeContaining(C c);

    public override void Remove(com.google.common.collect.Range<C> range) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void RemoveAll(com.google.common.collect.RangeHashSet<C> rangeHashSet) {
        removeAll(rangeHashSet.asRanges());
    }

    public override void RemoveAll(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable) {
        java.util.IEnumerator<com.google.common.collect.Range<C>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            remove(it.Current);
        }
    }

    public override readonly java.lang.string Tostring() {
        return asRanges().tostring();
    }
}

