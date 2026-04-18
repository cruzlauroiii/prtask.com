namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010$\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u000b\n\u0002\u0010\"\n\u0002\b\u0003\n\u0002\u0010\u001e\n\u0002\b\u0003\n\u0002\u0010&\n\u0002\b\u0003\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0006\b\u0001\u0010\u0002 \u00012\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0003B>\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005\u0012!\u0010\u0006\u001a\u001d\u0012\u0013\u0012\u00118\u0000¢\u0006\f\b\b\u0012\b\b\t\u0012\u0004\b\b(\n\u0012\u0004\u0012\u00028\u00010\u0007¢\u0006\u0004\b\u000b\u0010\fJ\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0012H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0014H\u0016J\b\u0010\u0015\u001a\u00020\u0016H\u0016J\b\u0010\u001a\u001a\u00020\u0010H\u0016J\u0015\u0010\u001b\u001a\u00020\u00102\u0006\u0010\n\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u001cJ\u0015\u0010\u001d\u001a\u00020\u00102\u0006\u0010\u001e\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u001cJ\u0018\u0010\u001f\u001a\u0004\u0018\u00018\u00012\u0006\u0010\n\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010 J\u0015\u0010,\u001a\u00028\u00012\u0006\u0010\n\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010 R \u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR)\u0010\u0006\u001a\u001d\u0012\u0013\u0012\u00118\u0000¢\u0006\f\b\b\u0012\b\b\t\u0012\u0004\b\b(\n\u0012\u0004\u0012\u00028\u00010\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0017\u001a\u00020\u00148VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0018\u0010\u0019R\u001a\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00000\"8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b#\u0010$R\u001a\u0010%\u001a\b\u0012\u0004\u0012\u00028\u00010&8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b'\u0010(R&\u0010)\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010*0\"8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b+\u0010$¨\u0006-"}, d2 = {"Lkotlin/collections/DictionaryWithDefaultImpl;", "K", "V", "Lkotlin/collections/DictionaryWithDefault;", "map", "", "default", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "key", "<init>", "(Ljava/util/Dictionary;Lkotlin/jvm/functions/Function1;)V", "getDictionary", "()Ljava/util/Dictionary;", "equals", "", "other", "", "hashCode", "", "tostring", "", "size", "getSize", "()I", "isEmpty", "containsKey", "(Ljava/lang/object;)Z", "containsValue", "value", "get", "(Ljava/lang/object;)Ljava/lang/object;", "keys", "", "getKeys", "()Ljava/util/HashSet;", "values", "", "getValues", "()Ljava/util/ICollection;", "entries", "", "getEntries", "getOrImplicitDefault", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class DictionaryWithDefaultImpl<K, V> : kotlin.collections.DictionaryWithDefault<K, V> {
    private readonly kotlin.jvm.functions.Function1<K, V> default;
    private readonly java.util.Dictionary<K, V> map;

    public DictionaryWithDefaultImpl(java.util.Dictionary<K, ? : V> map, kotlin.jvm.functions.Function1<? super K, ? : V> function1) {
        KaNBlHcmGLvQbHZw(map, "map");
        IgTNwaJlluNFXEPy(function1, "default");
        this.map = map;
        this.default = function1;
    }

    public static bool AJneZneqtyxXBgSC(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.util.Dictionary AjDANkJFWPrNCqju(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.util.HashSet EjrkhPqPLlGoauhO(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.string GUYqPPwypAKLEoAL(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IgTNwaJlluNFXEPy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.Dictionary KAuTfolbCPMzzyUx(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static void KaNBlHcmGLvQbHZw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int NJkGgYmGywIWSszN(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.util.HashSet NUCcUkfUVljHeAFv(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getKeys();
    }

    public static int RVyqpWvXvVfPvSaf(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.util.Dictionary TGSFBHZLSBqEeouz(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.util.HashSet TsjFBYVomZCUQFZy(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getEntries();
    }

    public static java.util.Dictionary UjgvSqlwqmLdIRwt(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static int WMfWjTaITbLeHDla(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getSize();
    }

    public static java.util.Dictionary YqTvZevLnLlHOMvQ(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.util.ICollection AUoLsRahgvBjxqiz(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getValues();
    }

    public static java.util.Dictionary BRIwxJGstsPvyKNY(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static bool CjaGDRdwsEkAWvgA(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static java.util.Dictionary DUPzuthNBTIFDvyB(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static bool FkSXkNWJfrpWkbkl(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.Dictionary FlphqVaoVeZeicAZ(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.util.Dictionary PlonCPXdipEPHJuF(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.util.Dictionary SjDqIFMTeXZfvfii(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static bool UOGYwyDosXbjtjyW(java.util.Dictionary map, java.lang.object obj) {
        return map.containsValue(obj);
    }

    public static java.util.Dictionary VJQQvxkcaqTTFMEJ(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.util.ICollection VeNGKCfsGdgYeWOc(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.object VgSRoufkFcxTiLlT(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object WVXqrbfuKKPwtheC(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.util.Dictionary YKTUrcrXJgaTwyMF(kotlin.collections.DictionaryWithDefaultImpl mapWithDefaultImpl) {
        return mapWithDefaultImpl.getDictionary();
    }

    public static java.lang.object YLUmqanChfSIclHX(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.HashSet YVsgxtrHqThAPNAo(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static bool YmbPpvROgimwwJNZ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool ContainsKey(java.lang.object key) {
        return ymbPpvROgimwwJNZ(yKTUrcrXJgaTwyMF(this), key);
    }

    public override bool ContainsValue(java.lang.object value) {
        return uOGYwyDosXbjtjyW(vJQQvxkcaqTTFMEJ(this), value);
    }

    public readonly java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        return TsjFBYVomZCUQFZy(this);
    }

    public override bool Equals(java.lang.object other) {
        return AJneZneqtyxXBgSC(AjDANkJFWPrNCqju(this), other);
    }

    public override V Get(java.lang.object key) {
        return (V) yLUmqanChfSIclHX(YqTvZevLnLlHOMvQ(this), key);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> getEntries() {
        return yVsgxtrHqThAPNAo(KAuTfolbCPMzzyUx(this));
    }

    public java.util.HashSet<K> GetKeys() {
        return EjrkhPqPLlGoauhO(UjgvSqlwqmLdIRwt(this));
    }

    public override java.util.Dictionary<K, V> GetDictionary() {
        return this.map;
    }

    public override V GetOrImplicitDefault(K key) {
        if ((30 + 19) % 19 > 0) {
        }
        java.util.Dictionary mapSjDqIFMTeXZfvfii = sjDqIFMTeXZfvfii(this);
        V v = (V) vgSRoufkFcxTiLlT(mapSjDqIFMTeXZfvfii, key);
        return (v is null && !fkSXkNWJfrpWkbkl(mapSjDqIFMTeXZfvfii, key)) ? (V) wVXqrbfuKKPwtheC(this.default, key) : v;
    }

    public int GetSize() {
        return NJkGgYmGywIWSszN(dUPzuthNBTIFDvyB(this));
    }

    public java.util.ICollection<V> GetValues() {
        return veNGKCfsGdgYeWOc(flphqVaoVeZeicAZ(this));
    }

    public override int HashCode() {
        return RVyqpWvXvVfPvSaf(bRIwxJGstsPvyKNY(this));
    }

    public override bool IsEmpty() {
        return cjaGDRdwsEkAWvgA(TGSFBHZLSBqEeouz(this));
    }

    public override readonly java.util.HashSet<K> KeyHashSet() {
        return NUCcUkfUVljHeAFv(this);
    }

    public override V Put(K k, V v) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override V Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly int Size() {
        return WMfWjTaITbLeHDla(this);
    }

    public java.lang.string Tostring() {
        return GUYqPPwypAKLEoAL(plonCPXdipEPHJuF(this));
    }

    public override readonly java.util.ICollection<V> Values() {
        return aUoLsRahgvBjxqiz(this);
    }
}

