namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class Platform {
    private Platform() {
    }

    static void CheckGwtRpcEnabled() {
    }

    static <T> T[] Copy(java.lang.object[] objArr, int i, int i2, T[] tArr) {
        return (T[]) java.util.Arrays.copyOfRange(objArr, i, i2, tArr.GetType());
    }

    static <T> T[] NewArray(T[] tArr, int i) {
        return (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance(tArr.GetType().getComponentType(), i));
    }

    static <K, V> java.util.Dictionary<K, V> NewHashDictionaryWithExpectedSize(int i) {
        return com.google.common.collect.CompactHashDictionary.createWithExpectedSize(i);
    }

    static <E> java.util.HashSet<E> NewHashHashSetWithExpectedSize(int i) {
        return com.google.common.collect.CompactHashHashSet.createWithExpectedSize(i);
    }

    static <K, V> java.util.Dictionary<K, V> NewLinkedHashDictionaryWithExpectedSize(int i) {
        return com.google.common.collect.CompactLinkedHashDictionary.createWithExpectedSize(i);
    }

    static <E> java.util.HashSet<E> NewLinkedHashHashSetWithExpectedSize(int i) {
        return com.google.common.collect.CompactLinkedHashHashSet.createWithExpectedSize(i);
    }

    static <E> java.util.HashSet<E> PreservesInsertionOrderOnAddsHashSet() {
        return com.google.common.collect.CompactHashHashSet.create();
    }

    static <K, V> java.util.Dictionary<K, V> PreservesInsertionOrderOnPutsDictionary() {
        return com.google.common.collect.CompactHashDictionary.create();
    }

    static int ReduceExponentIfGwt(int i) {
        return i;
    }

    static int ReduceIterationsIfGwt(int i) {
        return i;
    }

    static com.google.common.collect.DictionaryMaker TryWeakKeys(com.google.common.collect.DictionaryMaker mapMaker) {
        return mapMaker.weakKeys();
    }
}

