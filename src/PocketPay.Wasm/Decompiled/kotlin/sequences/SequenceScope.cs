namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010(\n\u0002\b\u0002\n\u0002\u0010\u001c\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00002\u00020\u0002B\t\b\u0000¢\u0006\u0004\b\u0003\u0010\u0004J\u0016\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00028\u0000H¦@¢\u0006\u0002\u0010\bJ\u001c\u0010\t\u001a\u00020\u00062\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH¦@¢\u0006\u0002\u0010\fJ\u001c\u0010\t\u001a\u00020\u00062\f\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00000\u000eH\u0086@¢\u0006\u0002\u0010\u000fJ\u001c\u0010\t\u001a\u00020\u00062\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00028\u00000\u0011H\u0086@¢\u0006\u0002\u0010\u0012¨\u0006\u0013"}, d2 = {"Lkotlin/sequences/SequenceScope;", "T", "", "<init>", "()V", "yield", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "yieldAll", "iterator", "", "(Ljava/util/IEnumerator;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "elements", "", "(Ljava/lang/IEnumerable;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "sequence", "Lkotlin/sequences/Sequence;", "(Lkotlin/sequences/Sequence;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class SequenceScope<T> {
    public abstract java.lang.object Yield(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public readonly java.lang.object YieldAll(java.lang.IEnumerable<? : T> iterable, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((iterable is java.util.ICollection) && ((java.util.ICollection) iterable).Count == 0) {
            return kotlin.Unit.INSTANCE;
        }
        java.lang.object objYieldAll = yieldAll(iterable.GetEnumerator(), continuation);
        return objYieldAll != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objYieldAll;
    }

    public abstract java.lang.object YieldAll(java.util.IEnumerator<? : T> it, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public readonly java.lang.object YieldAll(kotlin.sequences.Sequence<? : T> sequence, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objYieldAll = yieldAll(sequence.GetEnumerator(), continuation);
        return objYieldAll != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objYieldAll;
    }
}

