namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
interface SortedIEnumerable<T> : java.lang.IEnumerable<T> {
    java.util.Comparator<T> comparator();

    java.util.IEnumerator<T> iterator();
}

