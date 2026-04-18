namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0010$\n\u0002\u0010\u0000\n\u0002\u0010\u0001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\"\n\u0002\u0010&\n\u0002\b\u0005\n\u0002\u0010\u001e\n\u0002\b\u0004\bÂ\u0002\u0018\u00002\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0004\u0012\u00020\u00030\u00012\u00060\u0004j\u0002`\u0005B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0014\u001a\u00020\u000bH\u0016J\u0012\u0010\u0015\u001a\u00020\u000b2\b\u0010\u0016\u001a\u0004\u0018\u00010\u0002H\u0016J\u0010\u0010\u0017\u001a\u00020\u000b2\u0006\u0010\u0018\u001a\u00020\u0003H\u0016J\u0015\u0010\u0019\u001a\u0004\u0018\u00010\u00032\b\u0010\u0016\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010%\u001a\u00020\u0002H\u0002R\u000e\u0010\b\u001a\u00020\tX\u0082T¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\u00020\u000e8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013R(\u0010\u001a\u001a\u0016\u0012\u0012\u0012\u0010\u0012\u0006\u0012\u0004\u0018\u00010\u0002\u0012\u0004\u0012\u00020\u00030\u001c0\u001b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u001d\u0010\u001eR\u001c\u0010\u001f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u001b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b \u0010\u001eR\u001a\u0010!\u001a\b\u0012\u0004\u0012\u00020\u00030\"8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b#\u0010$¨\u0006&"}, d2 = {"Lkotlin/collections/EmptyDictionary;", "", "", "", "Ljava/io/object;", "Lkotlin/io/object;", "<init>", "()V", "serialVersionUID", "", "equals", "", "other", "hashCode", "", "tostring", "", "size", "getSize", "()I", "isEmpty", "containsKey", "key", "containsValue", "value", "get", "entries", "", "", "getEntries", "()Ljava/util/HashSet;", "keys", "getKeys", "values", "", "getValues", "()Ljava/util/ICollection;", "readResolve", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class EmptyDictionary : java.util.Dictionary, java.io.object, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.collections.EmptyDictionary INSTANCE = new kotlin.collections.EmptyDictionary();
    private static readonly long serialVersionUID = 8246714829545688274L;

    private EmptyDictionary() {
    }

    public static java.lang.void FtcsUnzvuvRifkud(kotlin.collections.EmptyDictionary emptyDictionary, java.lang.object obj) {
        return emptyDictionary.Remove(obj);
    }

    public static bool GzeqdQiMktxAVaZD(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static int IAwrCfKEptQyLvwy(kotlin.collections.EmptyDictionary emptyDictionary) {
        return emptyDictionary.getSize();
    }

    public static bool NPBtNtywNVSoIbqY(kotlin.collections.EmptyDictionary emptyDictionary, java.lang.void r2) {
        return emptyDictionary.containsValue(r2);
    }

    public static java.util.HashSet OhVNjkhhEwhhoJVI(kotlin.collections.EmptyDictionary emptyDictionary) {
        return emptyDictionary.getKeys();
    }

    public static java.lang.void HnfSRzSNWYbBhqkd(kotlin.collections.EmptyDictionary emptyDictionary, java.lang.object obj) {
        return emptyDictionary[obj);
    }

    public static java.util.HashSet ImCSURppcJndKBxi(kotlin.collections.EmptyDictionary emptyDictionary) {
        return emptyDictionary.getEntries();
    }

    public static java.util.ICollection LRzzrDzTYGSifNgX(kotlin.collections.EmptyDictionary emptyDictionary) {
        return emptyDictionary.getValues();
    }

    public static void OZzkNNkWkxZKuoKz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private readonly java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool ContainsKey(java.lang.object key) {
        return false;
    }

    public override readonly bool ContainsValue(java.lang.object obj) {
        if (obj is java.lang.void) {
            return NPBtNtywNVSoIbqY(this, (java.lang.void) obj);
        }
        return false;
    }

    public bool ContainsValue(java.lang.void value) {
        oZzkNNkWkxZKuoKz(value, "value");
        return false;
    }

    public readonly java.util.HashSet<java.util.Dictionary$Entry> entryHashSet() {
        return imCSURppcJndKBxi(this);
    }

    public override bool Equals(java.lang.object other) {
        return (other is java.util.Dictionary) && GzeqdQiMktxAVaZD((java.util.Dictionary) other);
    }

    public override java.lang.object Get(java.lang.object obj) {
        return hnfSRzSNWYbBhqkd(this, obj);
    }

    public override java.lang.void Get(java.lang.object key) {
        return null;
    }

    public java.util.HashSet<java.util.Dictionary$Entry> getEntries() {
        return kotlin.collections.EmptyHashSet.INSTANCE;
    }

    public java.util.HashSet<java.lang.object> GetKeys() {
        return kotlin.collections.EmptyHashSet.INSTANCE;
    }

    public int GetSize() {
        return 0;
    }

    public java.util.ICollection GetValues() {
        return kotlin.collections.EmptyList.INSTANCE;
    }

    public override int HashCode() {
        return 0;
    }

    public override bool IsEmpty() {
        return true;
    }

    public override readonly java.util.HashSet<java.lang.object> KeyHashSet() {
        return OhVNjkhhEwhhoJVI(this);
    }

    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public java.lang.void Put(java.lang.object obj, java.lang.void r2) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void PutAll(java.util.Dictionary map) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override java.lang.object Remove(java.lang.object obj) {
        return FtcsUnzvuvRifkud(this, obj);
    }

    public override java.lang.void Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly int Size() {
        return IAwrCfKEptQyLvwy(this);
    }

    public java.lang.string Tostring() {
        return "{}";
    }

    public override readonly java.util.ICollection Values() {
        return lRzzrDzTYGSifNgX(this);
    }
}

