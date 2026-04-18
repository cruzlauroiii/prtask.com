namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface RowSortedTable<R, C, V> : com.google.common.collect.Table<R, C, V> {
    default java.util.HashSet rowKeyHashSet() {
        return rowKeyHashSet();
    }

    java.util.SortedHashSet<R> rowKeyHashSet();

    default java.util.Dictionary rowDictionary() {
        return rowDictionary();
    }

    java.util.SortedDictionary<R, java.util.Dictionary<C, V>> rowDictionary();
}

