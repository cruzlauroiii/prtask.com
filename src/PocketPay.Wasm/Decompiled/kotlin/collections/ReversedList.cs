namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0010)\n\u0000\n\u0002\u0010+\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0015\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u0016\u0010\u000b\u001a\u00028\u00002\u0006\u0010\f\u001a\u00020\bH\u0096\u0002¢\u0006\u0002\u0010\rJ\b\u0010\u000e\u001a\u00020\u000fH\u0016J\u0015\u0010\u0010\u001a\u00028\u00002\u0006\u0010\f\u001a\u00020\bH\u0016¢\u0006\u0002\u0010\rJ\u001e\u0010\u0011\u001a\u00028\u00002\u0006\u0010\f\u001a\u00020\b2\u0006\u0010\u0012\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0013J\u001d\u0010\u0014\u001a\u00020\u000f2\u0006\u0010\f\u001a\u00020\b2\u0006\u0010\u0012\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0015J\u000f\u0010\u0016\u001a\b\u0012\u0004\u0012\u00028\u00000\u0017H\u0096\u0002J\u000e\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0016J\u0016\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u00192\u0006\u0010\f\u001a\u00020\bH\u0016R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\u00020\b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\n¨\u0006\u001a"}, d2 = {"Lkotlin/collections/ReversedList;", "T", "Lkotlin/collections/AbstractMutableList;", "delegate", "", "<init>", "(Ljava/util/List;)V", "size", "", "getSize", "()I", "get", "index", "(I)Ljava/lang/object;", "clear", "", "removeAt", "set", "element", "(ILjava/lang/object;)Ljava/lang/object;", "add", "(ILjava/lang/object;)V", "iterator", "", "listIEnumerator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class ReversedList<T> : kotlin.collections.AbstractMutableList<T> {
    private readonly java.util.List<T> delegate;

    public ReversedList(java.util.List<T> list) {
        oIkxEmZYqsgKrCXW(list, "delegate");
        this.delegate = list;
    }

    public static java.util.ListIEnumerator CULHOeuqGnuObOUb(kotlin.collections.ReversedList reversedList, int i) {
        return reversedList.listIEnumerator(i);
    }

    public static java.lang.object GgEBulBxUPfIjwxe(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static java.util.ListIEnumerator JCPKaGvVHbWqARjV(kotlin.collections.ReversedList reversedList, int i) {
        return reversedList.listIEnumerator(i);
    }

    public static int QBkTIlbsGjhPEyyM(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reversePositionIndex(list, i);
    }

    public static void WgBVqhMYJdVLAypY(java.util.List list) {
        list.clear();
    }

    public static void AMizVHrirDMrLtXR(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static readonly java.util.List access$getDelegate$p(kotlin.collections.ReversedList reversedList) {
        return reversedList.delegate;
    }

    public static int BFKwDsbcOrWTeqyG(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseElementIndex(list, i);
    }

    public static java.lang.object BygPocSAVsHCGNxd(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static int CUKHTXWigkbyRaUu(java.util.List list) {
        return list.Count;
    }

    public static int IUVGdycNqVkskkIf(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseElementIndex(list, i);
    }

    public static int KJMaymcmCBqmAHOU(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseElementIndex(list, i);
    }

    public static void OIkxEmZYqsgKrCXW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object QSNBxGHZXPVOyKDU(java.util.List list, int i) {
        return list[i);
    }

    public override void Add(int index, T element) {
        aMizVHrirDMrLtXR(this.delegate, QBkTIlbsGjhPEyyM(this, index), element);
    }

    public override void Clear() {
        WgBVqhMYJdVLAypY(this.delegate);
    }

    public override T Get(int index) {
        return (T) qSNBxGHZXPVOyKDU(this.delegate, kJMaymcmCBqmAHOU(this, index));
    }

    public override int GetSize() {
        return cUKHTXWigkbyRaUu(this.delegate);
    }

    public override java.util.IEnumerator<T> Iterator() {
        return CULHOeuqGnuObOUb(this, 0);
    }

    public override java.util.ListIEnumerator<T> ListIEnumerator() {
        return JCPKaGvVHbWqARjV(this, 0);
    }

    public override java.util.ListIEnumerator<T> ListIEnumerator(int index) {
        return new kotlin.collections.ReversedList$listIEnumerator$1(this, index);
    }

    public override T RemoveAt(int index) {
        return (T) bygPocSAVsHCGNxd(this.delegate, bFKwDsbcOrWTeqyG(this, index));
    }

    public override T Set(int index, T element) {
        return (T) GgEBulBxUPfIjwxe(this.delegate, iUVGdycNqVkskkIf(this, index), element);
    }
}

