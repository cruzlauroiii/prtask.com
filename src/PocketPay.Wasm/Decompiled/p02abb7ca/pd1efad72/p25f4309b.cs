namespace WillowMaze.Wasm.Decompiled;


public readonly class p25f4309b<V> : java.util.Dictionary<java.lang.Class<object>, V> {
    private readonly java.util.Dictionary f47fe6743;
    private readonly java.util.Dictionary<java.lang.string, V> f7f662005;
    private readonly java.util.Dictionary f9c3f1d22;

    private p25f4309b(java.util.Dictionary<java.lang.string, V> map) {
        this.f7f662005 = map;
    }

    public static java.lang.object MWsnRWpeeWvsiOGf(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool SxqHIDJDYvoconlr(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static java.lang.object ZHiVBLBNdXSNaTKK(p02abb7ca.pd1efad72.p25f4309b p25f4309bVar, java.lang.Class cls, java.lang.object obj) {
        return p25f4309bVar.put2((java.lang.Class<object>) cls, obj);
    }

    public static java.lang.string ZZgooGKAKMAzARjD(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool BYuYBwqiZDwUdORd(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.string KLluVKzjNnwmmCgN(java.lang.Class cls) {
        return cls.getName();
    }

    public static <V> java.util.Dictionary<java.lang.Class<object>, V> M8bf8854b(java.util.Dictionary<java.lang.string, V> map) {
        return new p02abb7ca.pd1efad72.p25f4309b(map);
    }

    public static bool TPlzIimOeDQvQOLl(java.util.Dictionary map, java.lang.object obj) {
        return map.containsValue(obj);
    }

    public static java.util.ICollection YTEMyyAzUWUMddIq(java.util.Dictionary map) {
        return map.Values;
    }

    public static int ZaYPEkdCrPtsjstE(java.util.Dictionary map) {
        return map.Count;
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Dagger map bindings are immutable");
    }

    public override bool ContainsKey(java.lang.object obj) {
        if (obj is java.lang.Class) {
            return bYuYBwqiZDwUdORd(this.f7f662005, kLluVKzjNnwmmCgN((java.lang.Class) obj));
        }
        throw new java.lang.IllegalArgumentException("Key must be a class");
    }

    public override bool ContainsValue(java.lang.object obj) {
        return tPlzIimOeDQvQOLl(this.f7f662005, obj);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<java.lang.Class<object>, V>> entryHashSet() {
        throw new java.lang.UnsupportedOperationException("Dictionarys created with @LazyClassKey do not support usage of entryHashSet(). Consider @ClassKey instead.");
    }

    public override V Get(java.lang.object obj) {
        if (obj is java.lang.Class) {
            return (V) MWsnRWpeeWvsiOGf(this.f7f662005, ZZgooGKAKMAzARjD((java.lang.Class) obj));
        }
        throw new java.lang.IllegalArgumentException("Key must be a class");
    }

    public override bool IsEmpty() {
        return SxqHIDJDYvoconlr(this.f7f662005);
    }

    public override java.util.HashSet<java.lang.Class<object>> KeyHashSet() {
        throw new java.lang.UnsupportedOperationException("Dictionarys created with @LazyClassKey do not support usage of keyHashSet(). Consider @ClassKey instead.");
    }

    public V Put2(java.lang.Class<object> cls, V v) {
        throw new java.lang.UnsupportedOperationException("Dagger map bindings are immutable");
    }

    public override java.lang.object Put(java.lang.Class<object> cls, java.lang.object obj) {
        return ZHiVBLBNdXSNaTKK(this, cls, obj);
    }

    public override void PutAll(java.util.Dictionary<? : java.lang.Class<object>, ? : V> map) {
        throw new java.lang.UnsupportedOperationException("Dagger map bindings are immutable");
    }

    public override V Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Dagger map bindings are immutable");
    }

    public override int Size() {
        return zaYPEkdCrPtsjstE(this.f7f662005);
    }

    public override java.util.ICollection<V> Values() {
        return yTEMyyAzUWUMddIq(this.f7f662005);
    }
}

