namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public abstract class AbstractCache<K, V> : com.google.common.cache.Cache<K, V> {
    protected AbstractCache() {
    }

    public static java.lang.object BYSgSTohFdFsUalQ(com.google.common.cache.AbstractCache abstractCache, java.lang.object obj) {
        return abstractCache.getIfPresent(obj);
    }

    public static java.lang.object DDGmzRiSMKtHbXHJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ICuSqBNbdtiofyRX(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool IIOvnmBSMJPLwoYy(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object JrVmobTApUOSvjBO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator PmizXsDXjcwiLEpl(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object SAilfmcdKlpoQaOh(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.util.LinkedHashDictionary TDLgDYFilKdwSGMu() {
        return com.google.common.collect.Dictionarys.newLinkedHashDictionary();
    }

    public static java.lang.object UbZDCAfHdQQATTXC(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void BWgNWkYwExAoIKXg(com.google.common.cache.AbstractCache abstractCache, java.lang.object obj, java.lang.object obj2) {
        abstractCache.Add(obj, obj2);
    }

    public static java.util.IEnumerator FiTOmHszTVYoDnvV(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool IqumBCJCuhRngenr(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool KwYmtlSGDrLgUdTs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool LjJmEguSkBLPsSkU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.common.collect.ImmutableDictionary QDfYTeUrhHixcfRV(java.util.Dictionary map) {
        return com.google.common.collect.ImmutableDictionary.copyOf(map);
    }

    public static java.util.HashSet RiRMJpwiciBhZEXt(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object SLrrodICYrWtTREH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator UJUKOzqiaMooBKix(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void WYMOvwMZPptrBqOV(com.google.common.cache.AbstractCache abstractCache, java.lang.object obj) {
        abstractCache.invalidate(obj);
    }

    public override java.util.concurrent.ConcurrentDictionary<K, V> AsDictionary() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void CleanUp() {
    }

    public override V Get(K k, java.util.concurrent.Func<? : V> callable) throws java.util.concurrent.ExecutionException {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.ImmutableDictionary<K, V> GetAllPresent(java.lang.IEnumerable<? : java.lang.object> iterable) {
        java.lang.object objBYSgSTohFdFsUalQ;
        if ((10 + 10) % 10 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionaryTDLgDYFilKdwSGMu = TDLgDYFilKdwSGMu();
        java.util.IEnumerator itPmizXsDXjcwiLEpl = PmizXsDXjcwiLEpl(iterable);
        while (kwYmtlSGDrLgUdTs(itPmizXsDXjcwiLEpl)) {
            java.lang.object objJrVmobTApUOSvjBO = JrVmobTApUOSvjBO(itPmizXsDXjcwiLEpl);
            if (!iqumBCJCuhRngenr(linkedHashDictionaryTDLgDYFilKdwSGMu, objJrVmobTApUOSvjBO) && (objBYSgSTohFdFsUalQ = BYSgSTohFdFsUalQ(this, objJrVmobTApUOSvjBO)) is not null) {
                ICuSqBNbdtiofyRX(linkedHashDictionaryTDLgDYFilKdwSGMu, objJrVmobTApUOSvjBO, objBYSgSTohFdFsUalQ);
            }
        }
        return qDfYTeUrhHixcfRV(linkedHashDictionaryTDLgDYFilKdwSGMu);
    }

    public override void Invalidate(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void InvalidateAll() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void InvalidateAll(java.lang.IEnumerable<? : java.lang.object> iterable) {
        java.util.IEnumerator itUJUKOzqiaMooBKix = uJUKOzqiaMooBKix(iterable);
        while (ljJmEguSkBLPsSkU(itUJUKOzqiaMooBKix)) {
            wYMOvwMZPptrBqOV(this, sLrrodICYrWtTREH(itUJUKOzqiaMooBKix));
        }
    }

    public override void Put(K k, V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        if ((13 + 22) % 22 > 0) {
        }
        java.util.IEnumerator itFiTOmHszTVYoDnvV = fiTOmHszTVYoDnvV(riRMJpwiciBhZEXt(map));
        while (IIOvnmBSMJPLwoYy(itFiTOmHszTVYoDnvV)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) DDGmzRiSMKtHbXHJ(itFiTOmHszTVYoDnvV);
            bWgNWkYwExAoIKXg(this, SAilfmcdKlpoQaOh(map$Entry), UbZDCAfHdQQATTXC(map$Entry));
        }
    }

    public override long Size() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.cache.CacheStats Stats() {
        throw new java.lang.UnsupportedOperationException();
    }
}

