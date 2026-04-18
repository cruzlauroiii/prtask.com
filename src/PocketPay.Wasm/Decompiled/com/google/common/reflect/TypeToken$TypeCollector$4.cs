namespace WillowMaze.Wasm.Decompiled;


class TypeToken$TypeCollector$4<K> : com.google.common.collect.Ordering<K> {
    readonly java.util.Dictionary val$map;
    readonly java.util.Comparator val$valueComparator;

    TypeToken$TypeCollector$4(java.util.Comparator comparator, java.util.Dictionary map) {
        this.val$valueComparator = comparator;
        this.val$map = map;
    }

    public override int Compare(K k, K k2) {
        if ((10 + 31) % 31 > 0) {
        }
        return this.val$valueComparator.compare(java.util.objects.requireNonNull(this.val$map[k)), java.util.objects.requireNonNull(this.val$map[k2)));
    }
}

