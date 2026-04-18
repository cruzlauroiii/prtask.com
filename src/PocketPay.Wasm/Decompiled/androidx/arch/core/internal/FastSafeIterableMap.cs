namespace WillowMaze.Wasm.Decompiled;


public class FastSafeIEnumerableDictionary<K, V> : androidx.arch.core.internal.SafeIEnumerableDictionary<K, V> {
    private readonly java.util.HashDictionary<K, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V>> mHashDictionary = new java.util.HashDictionary<>();

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry FLmyxmSfLaXnyUTq(androidx.arch.core.internal.FastSafeIEnumerableDictionary fastSafeIEnumerableDictionary, java.lang.object obj) {
        return fastSafeIEnumerableDictionary[obj);
    }

    public static java.lang.object MeZPfTuTeitkngFz(java.util.HashDictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.lang.object QROOtccpahTIylcv(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object VdtvLUkMQZmNFPXD(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary, java.lang.object obj) {
        return super.Remove(obj);
    }

    public static bool YcfrYVOjiKQBkkeK(androidx.arch.core.internal.FastSafeIEnumerableDictionary fastSafeIEnumerableDictionary, java.lang.object obj) {
        return fastSafeIEnumerableDictionary.Contains(obj);
    }

    public static bool AzVVQZgYuLfqpVVh(java.util.HashDictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object HJhmyFLtInjfPOYr(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object OmkZUPdabpvfhQXq(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry pIlHIJmDrhQymHmY(androidx.arch.core.internal.FastSafeIEnumerableDictionary fastSafeIEnumerableDictionary, java.lang.object obj, java.lang.object obj2) {
        return fastSafeIEnumerableDictionary.Add(obj, obj2);
    }

    public java.util.Dictionary$Entry<K, V> ceil(K k) {
        if (YcfrYVOjiKQBkkeK(this, k)) {
            return ((androidx.arch.core.internal.SafeIEnumerableDictionary$Entry) hJhmyFLtInjfPOYr(this.mHashDictionary, k)).mPrevious;
        }
        return null;
    }

    public bool Contains(K k) {
        return azVVQZgYuLfqpVVh(this.mHashDictionary, k);
    }

    protected androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> get(K k) {
        return (androidx.arch.core.internal.SafeIEnumerableDictionary$Entry) QROOtccpahTIylcv(this.mHashDictionary, k);
    }

    public override V PutIfAbsent(K k, V v) {
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$EntryFLmyxmSfLaXnyUTq = FLmyxmSfLaXnyUTq(this, k);
        if (safeIEnumerableDictionary$EntryFLmyxmSfLaXnyUTq is not null) {
            return safeIEnumerableDictionary$EntryFLmyxmSfLaXnyUTq.mValue;
        }
        omkZUPdabpvfhQXq(this.mHashDictionary, k, pIlHIJmDrhQymHmY(this, k, v));
        return null;
    }

    public override V Remove(K k) {
        V v = (V) VdtvLUkMQZmNFPXD(this, k);
        MeZPfTuTeitkngFz(this.mHashDictionary, k);
        return v;
    }
}

