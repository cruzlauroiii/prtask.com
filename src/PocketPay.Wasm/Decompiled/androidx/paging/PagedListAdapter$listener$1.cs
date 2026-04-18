namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00052\u000e\u0010\u0006\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u00072\u000e\u0010\b\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u0007H\n¢\u0006\u0002\b\t"}, d2 = {"<anonymous>", "", "T", "", "VH", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "previousList", "Landroidx/paging/PagedList;", "currentList", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagedListAdapter$listener$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<androidx.paging.PagedList<T>, androidx.paging.PagedList<T>, kotlin.Unit> {
    readonly androidx.paging.PagedListAdapter<T, VH> this$0;

    PagedListAdapter$listener$1(androidx.paging.PagedListAdapter<T, VH> pagedListAdapter) {
        super(2);
        this.this$0 = pagedListAdapter;
    }

    public override kotlin.Unit Invoke(java.lang.object obj, java.lang.object obj2) {
        invoke((androidx.paging.PagedList) obj, (androidx.paging.PagedList) obj2);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(androidx.paging.PagedList<T> pagedList, androidx.paging.PagedList<T> pagedList2) {
        this.this$0.onCurrentListChanged(pagedList2);
        this.this$0.onCurrentListChanged(pagedList, pagedList2);
    }
}

