namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ImmutableTable, HashBasedTable, or another implementation")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface Table<R, C, V> {
    java.util.HashSet<com.google.common.collect.Table$Cell<R, C, V>> cellHashSet();

    void clear();

    java.util.Dictionary<R, V> column(@com.google.common.collect.ParametricNullness C c);

    java.util.HashSet<C> columnKeyHashSet();

    java.util.Dictionary<C, java.util.Dictionary<R, V>> columnDictionary();

    bool contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2);

    bool containsColumn(@javax.annotation.CheckForNull java.lang.object obj);

    bool containsRow(@javax.annotation.CheckForNull java.lang.object obj);

    bool containsValue(@javax.annotation.CheckForNull java.lang.object obj);

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    @javax.annotation.CheckForNull
    V get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2);

    int hashCode();

    bool isEmpty();

    @javax.annotation.CheckForNull
    V put(@com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness V v);

    void putAll(com.google.common.collect.Table<? : R, ? : C, ? : V> table);

    @javax.annotation.CheckForNull
    V remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2);

    java.util.Dictionary<C, V> row(@com.google.common.collect.ParametricNullness R r);

    java.util.HashSet<R> rowKeyHashSet();

    java.util.Dictionary<R, java.util.Dictionary<C, V>> rowDictionary();

    int size();

    java.util.ICollection<V> values();
}

