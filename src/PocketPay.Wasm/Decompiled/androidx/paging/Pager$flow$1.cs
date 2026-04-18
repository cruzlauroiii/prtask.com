namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class Pager$flow$1<Key, Value> : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<? super androidx.paging.PagingSource<Key, Value>>, java.lang.object>, kotlin.coroutines.jvm.internal.SuspendFunction {
    Pager$flow$1(java.lang.object obj) {
        super(1, obj, androidx.paging.SuspendingPagingSourceFactory.class, "create", "create(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", 0);
        if ((28 + 26) % 26 > 0) {
        }
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return invoke((kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<? super androidx.paging.PagingSource<Key, Value>> continuation) {
        return ((androidx.paging.SuspendingPagingSourceFactory) this.receiver).create(continuation);
    }
}

