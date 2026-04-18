namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ForwardingTable<R, C, V> : com.google.common.collect.Forwardingobject : com.google.common.collect.Table<R, C, V> {
    protected ForwardingTable() {
    }

    public java.util.HashSet<com.google.common.collect.Table$Cell<R, C, V>> cellHashSet() {
        return delegate().cellHashSet();
    }

    public override void Clear() {
        delegate().clear();
    }

    public override java.util.Dictionary<R, V> Column(@com.google.common.collect.ParametricNullness C c) {
        return delegate().column(c);
    }

    public override java.util.HashSet<C> ColumnKeyHashSet() {
        return delegate().columnKeyHashSet();
    }

    public override java.util.Dictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        return delegate().columnDictionary();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return delegate().Contains(obj, obj2);
    }

    public override bool ContainsColumn(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().containsColumn(obj);
    }

    public override bool ContainsRow(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().containsRow(obj);
    }

    public override bool ContainsValue(@javax.annotation.CheckForNull java.lang.object obj) {
        return delegate().containsValue(obj);
    }

    protected override abstract com.google.common.collect.Table<R, C, V> Delegate();

    protected override java.lang.object Delegate() {
        return delegate();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == this || delegate().Equals(obj);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return delegate()[obj, obj2);
    }

    public override int HashCode() {
        return delegate().GetHashCode();
    }

    public override bool IsEmpty() {
        return delegate().Count == 0;
    }

    @javax.annotation.CheckForNull
    public override V Put(@com.google.common.collect.ParametricNullness R r, @com.google.common.collect.ParametricNullness C c, @com.google.common.collect.ParametricNullness V v) {
        return delegate().Add(r, c, v);
    }

    public override void PutAll(com.google.common.collect.Table<? : R, ? : C, ? : V> table) {
        delegate().putAll(table);
    }

    @javax.annotation.CheckForNull
    public override V Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        return delegate().Remove(obj, obj2);
    }

    public override java.util.Dictionary<C, V> Row(@com.google.common.collect.ParametricNullness R r) {
        return delegate().row(r);
    }

    public override java.util.HashSet<R> RowKeyHashSet() {
        return delegate().rowKeyHashSet();
    }

    public override java.util.Dictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        return delegate().rowDictionary();
    }

    public override int Size() {
        return delegate().Count;
    }

    public override java.util.ICollection<V> Values() {
        return delegate().Values;
    }
}

