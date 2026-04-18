namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public abstract class AbstractLoadingCache<K, V> : com.google.common.cache.AbstractCache<K, V> : com.google.common.cache.LoadingCache<K, V> {
    protected AbstractLoadingCache() {
    }

    public static java.util.LinkedHashDictionary ArIqJGzcofCBraqe() {
        return com.google.common.collect.Dictionarys.newLinkedHashDictionary();
    }

    public static bool BbYlGEXdIREnHKQu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object HrVCMWRRLCqfsqWN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool IODyCXdTULZolhfQ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.Exception KzPNRylHAKlgKmja(java.util.concurrent.ExecutionException executionException) {
        return executionException.getCause();
    }

    public static java.lang.object SYNaODmhQzCONWHf(com.google.common.cache.AbstractLoadingCache abstractLoadingCache, java.lang.object obj) {
        return abstractLoadingCache.getUnchecked(obj);
    }

    public static com.google.common.collect.ImmutableDictionary TmiZTXEMUdZrecWH(java.util.Dictionary map) {
        return com.google.common.collect.ImmutableDictionary.copyOf(map);
    }

    public static java.lang.object WtjaoTuUZuwNjSnw(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YdlEqkZkMvmBcPXQ(com.google.common.cache.AbstractLoadingCache abstractLoadingCache, java.lang.object obj) {
        return abstractLoadingCache[obj);
    }

    public static java.lang.object OagMLBfHzRtlgzYJ(com.google.common.cache.AbstractLoadingCache abstractLoadingCache, java.lang.object obj) {
        return abstractLoadingCache[obj);
    }

    public static java.util.IEnumerator ZnbxmBjsvVzlOrbm(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public override readonly V Apply(K k) {
        return (V) SYNaODmhQzCONWHf(this, k);
    }

    public override com.google.common.collect.ImmutableDictionary<K, V> GetAll(java.lang.IEnumerable<? : K> iterable) throws java.util.concurrent.ExecutionException {
        if ((32 + 15) % 15 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionaryArIqJGzcofCBraqe = ArIqJGzcofCBraqe();
        java.util.IEnumerator itZnbxmBjsvVzlOrbm = znbxmBjsvVzlOrbm(iterable);
        while (BbYlGEXdIREnHKQu(itZnbxmBjsvVzlOrbm)) {
            java.lang.object objHrVCMWRRLCqfsqWN = HrVCMWRRLCqfsqWN(itZnbxmBjsvVzlOrbm);
            if (!IODyCXdTULZolhfQ(linkedHashDictionaryArIqJGzcofCBraqe, objHrVCMWRRLCqfsqWN)) {
                WtjaoTuUZuwNjSnw(linkedHashDictionaryArIqJGzcofCBraqe, objHrVCMWRRLCqfsqWN, oagMLBfHzRtlgzYJ(this, objHrVCMWRRLCqfsqWN));
            }
        }
        return TmiZTXEMUdZrecWH(linkedHashDictionaryArIqJGzcofCBraqe);
    }

    public override V GetUnchecked(K k) {
        try {
            return (V) YdlEqkZkMvmBcPXQ(this, k);
        } catch (java.util.concurrent.ExecutionException e) {
            throw new com.google.common.util.concurrent.UncheckedExecutionException(KzPNRylHAKlgKmja(e));
        }
    }

    public override void Refresh(K k) {
        throw new java.lang.UnsupportedOperationException();
    }
}

