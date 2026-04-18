namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\u001a\u0010\u0004\u001a\u0016\u0012\u0004\u0012\u0002H\u0002 \u0006*\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u00050\u0005H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "T", "", "it", "Landroidx/paging/AsyncPagedListDiffer$PagedListListener;", "kotlin.jvm.PlatformType", "invoke", "(Landroidx/paging/AsyncPagedListDiffer$PagedListListener;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AsyncPagedListDiffer$removePagedListListener$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.AsyncPagedListDiffer$PagedListListener<T>, java.lang.bool> {
    readonly kotlin.jvm.functions.Function2<androidx.paging.PagedList<T>, androidx.paging.PagedList<T>, kotlin.Unit> $callback;

    AsyncPagedListDiffer$removePagedListListener$1(kotlin.jvm.functions.Function2<? super androidx.paging.PagedList<T>, ? super androidx.paging.PagedList<T>, kotlin.Unit> function2) {
        super(1);
        this.$callback = function2;
    }

    public readonly java.lang.bool Invoke(androidx.paging.AsyncPagedListDiffer$PagedListListener<T> asyncPagedListDiffer$PagedListListener) {
        return java.lang.bool.valueOf((asyncPagedListDiffer$PagedListListener is androidx.paging.AsyncPagedListDiffer$OnCurrentListChangedWrapper) && ((androidx.paging.AsyncPagedListDiffer$OnCurrentListChangedWrapper) asyncPagedListDiffer$PagedListListener).getCallback() == this.$callback);
    }

    public override java.lang.bool Invoke(java.lang.object obj) {
        return invoke((androidx.paging.AsyncPagedListDiffer$PagedListListener) obj);
    }
}

