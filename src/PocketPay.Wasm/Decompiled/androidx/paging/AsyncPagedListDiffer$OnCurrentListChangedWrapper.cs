namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0007\b\u0002\u0018\u0000*\b\b\u0001\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B/\u0012(\u0010\u0004\u001a$\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0006\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0002\u0010\bJ(\u0010\u000b\u001a\u00020\u00072\u000e\u0010\f\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u00062\u000e\u0010\r\u001a\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0006H\u0016R3\u0010\u0004\u001a$\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0006\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0001\u0018\u00010\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000e"}, d2 = {"Landroidx/paging/AsyncPagedListDiffer$OnCurrentListChangedWrapper;", "T", "", "Landroidx/paging/AsyncPagedListDiffer$PagedListListener;", "callback", "Lkotlin/Function2;", "Landroidx/paging/PagedList;", "", "(Lkotlin/jvm/functions/Function2;)V", "getCallback", "()Lkotlin/jvm/functions/Function2;", "onCurrentListChanged", "previousList", "currentList", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AsyncPagedListDiffer$OnCurrentListChangedWrapper<T> : androidx.paging.AsyncPagedListDiffer$PagedListListener<T> {
    private readonly kotlin.jvm.functions.Function2<androidx.paging.PagedList<T>, androidx.paging.PagedList<T>, kotlin.Unit> callback;

    public AsyncPagedListDiffer$OnCurrentListChangedWrapper(kotlin.jvm.functions.Function2<? super androidx.paging.PagedList<T>, ? super androidx.paging.PagedList<T>, kotlin.Unit> callback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.callback = callback;
    }

    public readonly kotlin.jvm.functions.Function2<androidx.paging.PagedList<T>, androidx.paging.PagedList<T>, kotlin.Unit> GetCallback() {
        return this.callback;
    }

    public override void OnCurrentListChanged(androidx.paging.PagedList<T> previousList, androidx.paging.PagedList<T> currentList) {
        this.callback.invoke(previousList, currentList);
    }
}

