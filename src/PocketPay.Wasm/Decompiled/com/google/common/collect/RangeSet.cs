namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ImmutableRangeHashSet or TreeRangeHashSet")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface RangeHashSet<C : java.lang.IComparable> {
    void add(com.google.common.collect.Range<C> range);

    void addAll(com.google.common.collect.RangeHashSet<C> rangeHashSet);

    void addAll(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable);

    java.util.HashSet<com.google.common.collect.Range<C>> asDescendingHashSetOfRanges();

    java.util.HashSet<com.google.common.collect.Range<C>> asRanges();

    void clear();

    com.google.common.collect.RangeHashSet<C> complement();

    bool contains(C c);

    bool encloses(com.google.common.collect.Range<C> range);

    bool enclosesAll(com.google.common.collect.RangeHashSet<C> rangeHashSet);

    bool enclosesAll(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable);

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    int hashCode();

    bool intersects(com.google.common.collect.Range<C> range);

    bool isEmpty();

    @javax.annotation.CheckForNull
    com.google.common.collect.Range<C> rangeContaining(C c);

    void remove(com.google.common.collect.Range<C> range);

    void removeAll(com.google.common.collect.RangeHashSet<C> rangeHashSet);

    void removeAll(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable);

    com.google.common.collect.Range<C> span();

    com.google.common.collect.RangeHashSet<C> subRangeHashSet(com.google.common.collect.Range<C> range);

    java.lang.string tostring();
}

