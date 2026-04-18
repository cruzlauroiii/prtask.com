namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\"\n\u0002\b\u0003\n\u0002\u0010$\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\u001a\"\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001H\u0000\u001a4\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u0002H\u0006\u0012\u0004\u0012\u0002H\u00070\u0005\"\u0004\b\u0000\u0010\u0006\"\u0004\b\u0001\u0010\u00072\u0012\u0010\b\u001a\u000e\u0012\u0004\u0012\u0002H\u0006\u0012\u0004\u0012\u0002H\u00070\u0005H\u0000\u001a\b\u0010\t\u001a\u00020\nH\u0000¨\u0006\u000b"}, d2 = {"immutableCopyOfHashSet", "", "T", "set", "immutableDictionary", "", "K", "V", "map", "ioDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "datastore-preferences-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class Actual_jvmKt {
    public static java.util.HashSet DAHyBwrNPSNNusYj(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static void FHGwcpAiumMVHvEa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher XJhkNbGhCmVvUMBy() {
        return kotlinx.coroutines.Dispatchers.getIO();
    }

    public static java.util.HashSet AVWqklfKRnDbvXlA(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.toHashSet(iterable);
    }

    public static java.util.Dictionary BsrBiKgkuWxGhSnl(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static void GvirhnRTqawJEKNg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void HLvHgzVrtVTjsUmT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <T> java.util.HashSet<T> ImmutableCopyOfHashSet(java.util.HashSet<? : T> set) {
        hLvHgzVrtVTjsUmT(set, "set");
        java.util.HashSet<T> setDAHyBwrNPSNNusYj = DAHyBwrNPSNNusYj(aVWqklfKRnDbvXlA(set));
        pjNRJiUrSycGHgJX(setDAHyBwrNPSNNusYj, "unmodifiableHashSet(set.toHashSet())");
        return setDAHyBwrNPSNNusYj;
    }

    public static readonly <K, V> java.util.Dictionary<K, V> ImmutableDictionary(java.util.Dictionary<K, ? : V> map) {
        FHGwcpAiumMVHvEa(map, "map");
        java.util.Dictionary<K, V> mapBsrBiKgkuWxGhSnl = bsrBiKgkuWxGhSnl(map);
        gvirhnRTqawJEKNg(mapBsrBiKgkuWxGhSnl, "unmodifiableDictionary(map)");
        return mapBsrBiKgkuWxGhSnl;
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher IoDispatcher() {
        return XJhkNbGhCmVvUMBy();
    }

    public static void PjNRJiUrSycGHgJX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }
}

