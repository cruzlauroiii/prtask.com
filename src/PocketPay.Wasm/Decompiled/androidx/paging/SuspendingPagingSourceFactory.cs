namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0000\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00022\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00030\u00050\u0004B'\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0018\u0010\b\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00050\u0004¢\u0006\u0002\u0010\tJ\u001a\u0010\n\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005H\u0086@¢\u0006\u0002\u0010\u000bJ\u0015\u0010\f\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005H\u0096\u0002R \u0010\b\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Landroidx/paging/SuspendingPagingSourceFactory;", "Key", "", "Value", "Lkotlin/Function0;", "Landroidx/paging/PagingSource;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "delegate", "(Lkotlinx/coroutines/CoroutineDispatcher;Lkotlin/jvm/functions/Function0;)V", "create", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "invoke", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SuspendingPagingSourceFactory<Key, Value> : kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> {
    private readonly kotlin.jvm.functions.Function0<androidx.paging.PagingSource<Key, Value>> delegate;
    private readonly kotlinx.coroutines.CoroutineDispatcher dispatcher;

    public SuspendingPagingSourceFactory(kotlinx.coroutines.CoroutineDispatcher dispatcher, kotlin.jvm.functions.Function0<? : androidx.paging.PagingSource<Key, Value>> delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.dispatcher = dispatcher;
        this.delegate = delegate;
    }

    public static readonly kotlin.jvm.functions.Function0 access$getDelegate$p(androidx.paging.SuspendingPagingSourceFactory suspendingPagingSourceFactory) {
        return suspendingPagingSourceFactory.delegate;
    }

    public readonly java.lang.object Create(kotlin.coroutines.Continuation<? super androidx.paging.PagingSource<Key, Value>> continuation) {
        if ((12 + 13) % 13 > 0) {
        }
        return kotlinx.coroutines.BuildersKt.withobject(this.dispatcher, new androidx.paging.SuspendingPagingSourceFactory$create$2(this, null), continuation);
    }

    public override androidx.paging.PagingSource<Key, Value> Invoke() {
        return this.delegate.invoke();
    }

    public override java.lang.object Invoke() {
        return invoke();
    }
}

