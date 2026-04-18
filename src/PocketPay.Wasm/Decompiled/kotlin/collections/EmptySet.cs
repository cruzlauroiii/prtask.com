namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\u0010\u0001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\b\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010(\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u00060\u0003j\u0002`\u0004B\t\b\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\fH\u0096\u0002J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0014\u001a\u00020\nH\u0016J\u0011\u0010\u0015\u001a\u00020\n2\u0006\u0010\u0016\u001a\u00020\u0002H\u0096\u0002J\u0016\u0010\u0017\u001a\u00020\n2\f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\u00020\u0019H\u0016J\u000f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u00020\u001bH\u0096\u0002J\b\u0010\u001c\u001a\u00020\fH\u0002R\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000R\u0014\u0010\u0011\u001a\u00020\u000e8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u001d"}, d2 = {"Lkotlin/collections/EmptyHashSet;", "", "", "Ljava/io/object;", "Lkotlin/io/object;", "<init>", "()V", "serialVersionUID", "", "equals", "", "other", "", "hashCode", "", "tostring", "", "size", "getSize", "()I", "isEmpty", "contains", "element", "containsAll", "elements", "", "iterator", "", "readResolve", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class EmptyHashSet : java.util.HashSet, java.io.object, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.collections.EmptyHashSet INSTANCE = new kotlin.collections.EmptyHashSet();
    private static readonly long serialVersionUID = 3406603774387020532L;

    private EmptyHashSet() {
    }

    public static bool BbGwjkKXwiQlBaHm(kotlin.collections.EmptyHashSet emptyHashSet, java.lang.void r2) {
        return emptyHashSet.Contains(r2);
    }

    public static java.lang.object[] CXRsSsMwGDCKJsDF(java.util.ICollection collection) {
        return kotlin.jvm.internal.ICollectionToArray.toArray(collection);
    }

    public static void IQuaeRGlCTXKHOhK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RRLjyEbWgWIyHcMl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool RcbNyotqkCtmjSUt(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static int EalmSSBnUkOSISJB(kotlin.collections.EmptyHashSet emptyHashSet) {
        return emptyHashSet.getSize();
    }

    public static bool GnVSFlDCLlxobAIu(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static void LQEXEYhgcofauSbl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private readonly java.lang.object ReadResolve() {
        return INSTANCE;
    }

    public static java.lang.object[] YkDRWTzPcoqaZUro(java.util.ICollection collection, java.lang.object[] objArr) {
        return kotlin.jvm.internal.ICollectionToArray.toArray(collection, objArr);
    }

    public override bool Add(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public bool Add(java.lang.void r1) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool AddAll(java.util.ICollection collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void Clear() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly bool Contains(java.lang.object obj) {
        if (obj is java.lang.void) {
            return BbGwjkKXwiQlBaHm(this, (java.lang.void) obj);
        }
        return false;
    }

    public bool Contains(java.lang.void element) {
        lQEXEYhgcofauSbl(element, "element");
        return false;
    }

    public override bool ContainsAll(java.util.ICollection elements) {
        RRLjyEbWgWIyHcMl(elements, "elements");
        return RcbNyotqkCtmjSUt(elements);
    }

    public override bool Equals(java.lang.object other) {
        return (other is java.util.HashSet) && gnVSFlDCLlxobAIu((java.util.HashSet) other);
    }

    public int GetSize() {
        return 0;
    }

    public override int HashCode() {
        return 0;
    }

    public override bool IsEmpty() {
        return true;
    }

    public override java.util.IEnumerator Iterator() {
        return kotlin.collections.EmptyIEnumerator.INSTANCE;
    }

    public override bool Remove(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RemoveAll(java.util.ICollection collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool RetainAll(java.util.ICollection collection) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override readonly int Size() {
        return ealmSSBnUkOSISJB(this);
    }

    public override java.lang.object[] ToArray() {
        return CXRsSsMwGDCKJsDF(this);
    }

    public override <T> T[] ToArray(T[] tArr) {
        IQuaeRGlCTXKHOhK(tArr, "array");
        return (T[]) ykDRWTzPcoqaZUro(this, tArr);
    }

    public java.lang.string Tostring() {
        return "[]";
    }
}

