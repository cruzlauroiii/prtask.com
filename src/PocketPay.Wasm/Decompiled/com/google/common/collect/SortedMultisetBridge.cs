namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
interface SortedMultisetBridge<E> : com.google.common.collect.Multiset<E> {
    default java.util.HashSet elementHashSet() {
        return elementHashSet();
    }

    java.util.SortedHashSet<E> elementHashSet();
}

