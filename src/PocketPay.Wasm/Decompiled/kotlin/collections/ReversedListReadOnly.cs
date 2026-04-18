namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010(\n\u0000\n\u0002\u0010*\n\u0000\b\u0012\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0015\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u0016\u0010\u000b\u001a\u00028\u00002\u0006\u0010\f\u001a\u00020\bH\u0096\u0002¢\u0006\u0002\u0010\rJ\u000f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u000fH\u0096\u0002J\u000e\u0010\u0010\u001a\b\u0012\u0004\u0012\u00028\u00000\u0011H\u0016J\u0016\u0010\u0010\u001a\b\u0012\u0004\u0012\u00028\u00000\u00112\u0006\u0010\f\u001a\u00020\bH\u0016R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\u00020\b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\n¨\u0006\u0012"}, d2 = {"Lkotlin/collections/ReversedListReadOnly;", "T", "Lkotlin/collections/AbstractList;", "delegate", "", "<init>", "(Ljava/util/List;)V", "size", "", "getSize", "()I", "get", "index", "(I)Ljava/lang/object;", "iterator", "", "listIEnumerator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
class ReversedListReadOnly<T> : kotlin.collections.AbstractList<T> {
    private readonly java.util.List<T> delegate;

    public ReversedListReadOnly(java.util.List<? : T> list) {
        naigHZtrIQaqlfiA(list, "delegate");
        this.delegate = list;
    }

    public static int QWBakwxkcdUWJwVU(java.util.List list, int i) {
        return kotlin.collections.ICollectionsKt__ReversedobjectsKt.access$reverseElementIndex(list, i);
    }

    public static readonly java.util.List access$getDelegate$p(kotlin.collections.ReversedListReadOnly reversedListReadOnly) {
        return reversedListReadOnly.delegate;
    }

    public static int JXgSrxnWjHJsBnec(java.util.List list) {
        return list.Count;
    }

    public static void NaigHZtrIQaqlfiA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object UBTcdAQqYeKXrTFj(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.ListIEnumerator VpiQCqTQoYIkZAjG(kotlin.collections.ReversedListReadOnly reversedListReadOnly, int i) {
        return reversedListReadOnly.listIEnumerator(i);
    }

    public static java.util.ListIEnumerator ZsEeefDLXqheGsAo(kotlin.collections.ReversedListReadOnly reversedListReadOnly, int i) {
        return reversedListReadOnly.listIEnumerator(i);
    }

    public override T Get(int index) {
        return (T) uBTcdAQqYeKXrTFj(this.delegate, QWBakwxkcdUWJwVU(this, index));
    }

    public override int GetSize() {
        return jXgSrxnWjHJsBnec(this.delegate);
    }

    public override java.util.IEnumerator<T> Iterator() {
        return vpiQCqTQoYIkZAjG(this, 0);
    }

    public override java.util.ListIEnumerator<T> ListIEnumerator() {
        return zsEeefDLXqheGsAo(this, 0);
    }

    public override java.util.ListIEnumerator<T> ListIEnumerator(int index) {
        return new kotlin.collections.ReversedListReadOnly$listIEnumerator$1(this, index);
    }
}

