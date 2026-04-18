namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0010*\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\t\u0010\u0005\u001a\u00020\u0006H\u0096\u0002J\b\u0010\u0007\u001a\u00020\u0006H\u0016J\u000e\u0010\b\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\tJ\b\u0010\n\u001a\u00020\u000bH\u0016J\r\u0010\f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\b\u0010\r\u001a\u00020\u000bH\u0016R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u000e"}, d2 = {"kotlin/collections/ReversedListReadOnly$listIEnumerator$1", "", "delegateIEnumerator", "getDelegateIEnumerator", "()Ljava/util/ListIEnumerator;", "hasNext", "", "hasPrevious", "next", "()Ljava/lang/object;", "nextIndex", "", "previous", "previousIndex", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class ReversedListReadOnly$listIEnumerator$1<T> : java.util.ListIEnumerator<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly java.util.ListIEnumerator<T> delegateIEnumerator;
    readonly kotlin.collections.ReversedListReadOnly<T> this$0;

    ReversedListReadOnly$listIEnumerator$1(kotlin.collections.ReversedListReadOnly<? : T> reversedListReadOnly, int i) {
        this.this$0 = reversedListReadOnly;
        this.delegateIEnumerator = dsavmQlhBetjDGGQ(HJhqomDmJBeRvgFI(reversedListReadOnly), YipWWWLeyJmpmiUk(reversedListReadOnly, i));
    }

    public static bool GvqXDysglZorUYSk(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.MoveNext();
    }

    public static java.util.List HJhqomDmJBeRvgFI(kotlin.collections.ReversedListReadOnly reversedListReadOnly) {
        return kotlin.collections.ReversedListReadOnly.access$getDelegate$p(reversedListReadOnly);
    }

    public static int OfAIBJKGzYtogpcZ(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.nextIndex();
    }

    public static int VheiASMeKZdYiioc(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseIEnumeratorIndex(list, i);
    }

    public static int YipWWWLeyJmpmiUk(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reversePositionIndex(list, i);
    }

    public static java.lang.object ZLbmhlnhKpsJuBEg(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.Current;
    }

    public static int ZZGkSFYJfTrAZYPN(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseIEnumeratorIndex(list, i);
    }

    public static java.util.ListIEnumerator DsavmQlhBetjDGGQ(java.util.List list, int i) {
        return list.listIEnumerator(i);
    }

    public static int EcPVyDjlBISrdheg(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.previousIndex();
    }

    public static bool OoBqRVtdOUahoXhC(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.hasPrevious();
    }

    public static java.lang.object VAQyaTJcFfpiQHbQ(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.previous();
    }

    public override void Add(T t) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly java.util.ListIEnumerator<T> GetDelegateIEnumerator() {
        return this.delegateIEnumerator;
    }

    public override bool HasNext() {
        return ooBqRVtdOUahoXhC(this.delegateIEnumerator);
    }

    public override bool HasPrevious() {
        return GvqXDysglZorUYSk(this.delegateIEnumerator);
    }

    public override T Next() {
        return (T) vAQyaTJcFfpiQHbQ(this.delegateIEnumerator);
    }

    public override int NextIndex() {
        return ZZGkSFYJfTrAZYPN(this.this$0, ecPVyDjlBISrdheg(this.delegateIEnumerator));
    }

    public override T Previous() {
        return (T) ZLbmhlnhKpsJuBEg(this.delegateIEnumerator);
    }

    public override int PreviousIndex() {
        return VheiASMeKZdYiioc(this.this$0, OfAIBJKGzYtogpcZ(this.delegateIEnumerator));
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void Set(T t) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

