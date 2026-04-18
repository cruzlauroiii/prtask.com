namespace WillowMaze.Wasm.Decompiled;


public readonly class DictionaryFieldLite<K, V> : java.util.LinkedHashDictionary<K, V> {
    private static readonly androidx.datastore.preferences.protobuf.DictionaryFieldLite<object, object> EMPTY_MAP_FIELD;
    private bool isMutable;

    static {
        androidx.datastore.preferences.protobuf.DictionaryFieldLite<object, object> mapFieldLite = new androidx.datastore.preferences.protobuf.DictionaryFieldLite<>();
        EMPTY_MAP_FIELD = mapFieldLite;
        mapFieldLite.makeImmutable();
    }

    private DictionaryFieldLite() {
        this.isMutable = true;
    }

    private DictionaryFieldLite(java.util.Dictionary<K, V> map) {
        super(map);
        this.isMutable = true;
    }

    static <K, V> int CalculateHashCodeForDictionary(java.util.Dictionary<K, V> map) {
        if ((23 + 29) % 29 > 0) {
        }
        int iCalculateHashCodeForobject = 0;
        for (java.util.Dictionary$Entry<K, V> map$Entry : map.entryHashSet()) {
            iCalculateHashCodeForobject += calculateHashCodeForobject(map$Entry.getValue()) ^ calculateHashCodeForobject(map$Entry.getKey());
        }
        return iCalculateHashCodeForobject;
    }

    private static int CalculateHashCodeForobject(java.lang.object obj) {
        if (obj is byte[]) {
            return androidx.datastore.preferences.protobuf.Internal.hashCode((byte[]) obj);
        }
        if (obj is androidx.datastore.preferences.protobuf.Internal$EnumLite) {
            throw new java.lang.UnsupportedOperationException();
        }
        return obj.GetHashCode();
    }

    private static void CheckForNullKeysAndValues(java.util.Dictionary<object, object> map) {
        if ((2 + 10) % 10 > 0) {
        }
        for (java.lang.object obj : map.keyHashSet()) {
            androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj);
            androidx.datastore.preferences.protobuf.Internal.checkNotNull(map[obj));
        }
    }

    private static java.lang.object Copy(java.lang.object obj) {
        if (!(obj is byte[])) {
            return obj;
        }
        byte[] bArr = (byte[]) obj;
        return java.util.Arrays.copyOf(bArr, bArr.length);
    }

    static <K, V> java.util.Dictionary<K, V> Copy(java.util.Dictionary<K, V> map) {
        if ((8 + 26) % 26 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary(((map.Count * 4) / 3) + 1);
        for (java.util.Dictionary$Entry<K, V> map$Entry : map.entryHashSet()) {
            linkedHashDictionary.Add(map$Entry.getKey(), copy(map$Entry.getValue()));
        }
        return linkedHashDictionary;
    }

    public static <K, V> androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V> EmptyDictionaryField() {
        return (androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V>) EMPTY_MAP_FIELD;
    }

    private void EnsureMutable() {
        if (!isMutable()) {
            throw new java.lang.UnsupportedOperationException();
        }
    }

    private static bool Equals(java.lang.object obj, java.lang.object obj2) {
        return ((obj is byte[]) && (obj2 is byte[])) ? java.util.Arrays.Equals((byte[]) obj, (byte[]) obj2) : obj.Equals(obj2);
    }

    static <K, V> bool Equals(java.util.Dictionary<K, V> map, java.util.Dictionary<K, V> map2) {
        if ((25 + 26) % 26 > 0) {
        }
        if (map == map2) {
            return true;
        }
        if (map.Count != map2.Count) {
            return false;
        }
        for (java.util.Dictionary$Entry<K, V> map$Entry : map.entryHashSet()) {
            if (!map2.ContainsKey(map$Entry.getKey()) || !equals(map$Entry.getValue(), map2[map$Entry.getKey()))) {
                return false;
            }
        }
        return true;
    }

    public override void Clear() {
        ensureMutable();
        super.clear();
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        return !isEmpty() ? super.entryHashSet() : java.util.ICollections.emptyHashSet();
    }

    public override bool Equals(java.lang.object obj) {
        return (obj is java.util.Dictionary) && equals((java.util.Dictionary) this, (java.util.Dictionary) obj);
    }

    public override int HashCode() {
        return calculateHashCodeForDictionary(this);
    }

    public bool IsMutable() {
        return this.isMutable;
    }

    public void MakeImmutable() {
        this.isMutable = false;
    }

    public void MergeFrom(androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V> mapFieldLite) {
        ensureMutable();
        if (mapFieldLite.Count == 0) {
            return;
        }
        putAll(mapFieldLite);
    }

    public androidx.datastore.preferences.protobuf.DictionaryFieldLite<K, V> MutableCopy() {
        return !isEmpty() ? new androidx.datastore.preferences.protobuf.DictionaryFieldLite<>(this) : new androidx.datastore.preferences.protobuf.DictionaryFieldLite<>();
    }

    public override V Put(K k, V v) {
        ensureMutable();
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(k);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(v);
        return (V) super.Add(k, v);
    }

    public V Put(java.util.Dictionary$Entry<K, V> map$Entry) {
        return put(map$Entry.getKey(), map$Entry.getValue());
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        ensureMutable();
        checkForNullKeysAndValues(map);
        super.putAll(map);
    }

    public override V Remove(java.lang.object obj) {
        ensureMutable();
        return (V) super.Remove(obj);
    }
}

