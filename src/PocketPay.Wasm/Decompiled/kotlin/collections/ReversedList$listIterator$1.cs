namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0010+\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\t\u0010\u0005\u001a\u00020\u0006H\u0096\u0002J\b\u0010\u0007\u001a\u00020\u0006H\u0016J\u000e\u0010\b\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\tJ\b\u0010\n\u001a\u00020\u000bH\u0016J\r\u0010\f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\tJ\b\u0010\r\u001a\u00020\u000bH\u0016J\u0015\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0011J\b\u0010\u0012\u001a\u00020\u000fH\u0016J\u0015\u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0011R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u0014"}, d2 = {"kotlin/collections/ReversedList$listIEnumerator$1", "", "delegateIEnumerator", "getDelegateIEnumerator", "()Ljava/util/ListIEnumerator;", "hasNext", "", "hasPrevious", "next", "()Ljava/lang/object;", "nextIndex", "", "previous", "previousIndex", "add", "", "element", "(Ljava/lang/object;)V", "remove", "set", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class ReversedList$listIEnumerator$1<T> : java.util.ListIEnumerator<T>, kotlin.jvm.internal.markers.KMutableListIEnumerator {
    private readonly java.util.ListIEnumerator<T> delegateIEnumerator;
    readonly kotlin.collections.ReversedList<T> this$0;

    ReversedList$listIEnumerator$1(kotlin.collections.ReversedList<T> reversedList, int i) {
        this.this$0 = reversedList;
        this.delegateIEnumerator = gcNyOyaxDJdoJEjS(fRahxiDfMucJPMXz(reversedList), tOZkBgPIXurdcmok(reversedList, i));
    }

    public static java.lang.object HnzAUuldrCGXJOQm(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.previous();
    }

    public static java.lang.object JKGxUTYOvIpwXltq(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.Current;
    }

    public static bool TqsTOsXcelCfSxSF(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.MoveNext();
    }

    public static int WeKuhbEmRsvWjqFq(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseIEnumeratorIndex(list, i);
    }

    public static java.util.List FRahxiDfMucJPMXz(kotlin.collections.ReversedList reversedList) {
        return kotlin.collections.ReversedList.access$getDelegate$p(reversedList);
    }

    public static java.util.ListIEnumerator GcNyOyaxDJdoJEjS(java.util.List list, int i) {
        return list.listIEnumerator(i);
    }

    public static int IDLlRHSQPTRzRiWQ(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.nextIndex();
    }

    public static int JWfHnELWnTbqYeBN(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.previousIndex();
    }

    public static void MvxbIbMhxAQORwbw(java.util.ListIEnumerator listIEnumerator, java.lang.object obj) {
        listIEnumerator.set(obj);
    }

    public static int OIUBbpWVvWSwYQmP(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseIEnumeratorIndex(list, i);
    }

    public static java.lang.object OPCyPraEmVCjZdcP(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.previous();
    }

    public static void RhcuZLNgPflJUaIU(java.util.ListIEnumerator listIEnumerator, java.lang.object obj) {
        listIEnumerator.Add(obj);
    }

    public static int TOZkBgPIXurdcmok(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reversePositionIndex(list, i);
    }

    public static bool VAYVEwkhpQllItnC(java.util.ListIEnumerator listIEnumerator) {
        return listIEnumerator.hasPrevious();
    }

    public static void XfjVFZExVNEHQPgb(java.util.ListIEnumerator listIEnumerator) {
        listIEnumerator.Remove();
    }

    public override void Add(T element) {
        rhcuZLNgPflJUaIU(this.delegateIEnumerator, element);
        oPCyPraEmVCjZdcP(this.delegateIEnumerator);
    }

    public readonly java.util.ListIEnumerator<T> GetDelegateIEnumerator() {
        return this.delegateIEnumerator;
    }

    public override bool HasNext() {
        return vAYVEwkhpQllItnC(this.delegateIEnumerator);
    }

    public override bool HasPrevious() {
        return TqsTOsXcelCfSxSF(this.delegateIEnumerator);
    }

    public override T Next() {
        return (T) HnzAUuldrCGXJOQm(this.delegateIEnumerator);
    }

    public override int NextIndex() {
        return WeKuhbEmRsvWjqFq(this.this$0, jWfHnELWnTbqYeBN(this.delegateIEnumerator));
    }

    public override T Previous() {
        return (T) JKGxUTYOvIpwXltq(this.delegateIEnumerator);
    }

    public override int PreviousIndex() {
        return oIUBbpWVvWSwYQmP(this.this$0, iDLlRHSQPTRzRiWQ(this.delegateIEnumerator));
    }

    public override void Remove() {
        xfjVFZExVNEHQPgb(this.delegateIEnumerator);
    }

    public override void Set(T element) {
        mvxbIbMhxAQORwbw(this.delegateIEnumerator, element);
    }
}

