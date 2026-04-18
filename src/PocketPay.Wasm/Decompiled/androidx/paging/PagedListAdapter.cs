namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "PagedListAdapter is deprecated and has been replaced by PagingDataAdapter", replaceWith = @kotlin.ReplaceWith(expression = "PagingDataAdapter<T, VH>", imports = {"androidx.paging.PagingDataAdapter"}))
@kotlin.Metadata(d1 = {"\u0000j\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b'\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u00042\b\u0012\u0004\u0012\u0002H\u00030\u0005B\u0015\b\u0014\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0002\u0010\bB\u0015\b\u0014\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00000\n¢\u0006\u0002\u0010\u000bJ\"\u0010\u001b\u001a\u00020\u00192\u0018\u0010\u0017\u001a\u0014\u0012\u0004\u0012\u00020\u001c\u0012\u0004\u0012\u00020\u001d\u0012\u0004\u0012\u00020\u00190\u0018H\u0016J\u0017\u0010\u001e\u001a\u0004\u0018\u00018\u00002\u0006\u0010\u001f\u001a\u00020 H\u0014¢\u0006\u0002\u0010!J\b\u0010\"\u001a\u00020 H\u0016J\u0018\u0010#\u001a\u00020\u00192\u000e\u0010\f\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\rH\u0017J(\u0010#\u001a\u00020\u00192\u000e\u0010$\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\r2\u000e\u0010\f\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\rH\u0016J\"\u0010%\u001a\u00020\u00192\u0018\u0010\u0017\u001a\u0014\u0012\u0004\u0012\u00020\u001c\u0012\u0004\u0012\u00020\u001d\u0012\u0004\u0012\u00020\u00190\u0018H\u0016J\u0018\u0010&\u001a\u00020\u00192\u000e\u0010'\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\rH\u0016J\"\u0010&\u001a\u00020\u00192\u000e\u0010'\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\r2\b\u0010(\u001a\u0004\u0018\u00010)H\u0016J\u0012\u0010*\u001a\u00020+2\n\u0010,\u001a\u0006\u0012\u0002\b\u00030-J\u0012\u0010.\u001a\u00020+2\n\u0010/\u001a\u0006\u0012\u0002\b\u00030-J\u001e\u00100\u001a\u00020+2\n\u0010/\u001a\u0006\u0012\u0002\b\u00030-2\n\u0010,\u001a\u0006\u0012\u0002\b\u00030-R\"\u0010\f\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\r8VX\u0096\u0004¢\u0006\f\u0012\u0004\b\u000e\u0010\u000f\u001a\u0004\b\u0010\u0010\u0011R \u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u0013X\u0080\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\u0014\u0010\u000f\u001a\u0004\b\u0015\u0010\u0016R6\u0010\u0017\u001a$\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\r\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\r\u0012\u0004\u0012\u00020\u00190\u0018X\u0082\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u001a\u0010\u000f¨\u00061"}, d2 = {"Landroidx/paging/PagedListAdapter;", "T", "", "VH", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "diffCallback", "Landroidx/recyclerview/widget/DiffUtil$ItemCallback;", "(Landroidx/recyclerview/widget/DiffUtil$ItemCallback;)V", "config", "Landroidx/recyclerview/widget/AsyncDifferConfig;", "(Landroidx/recyclerview/widget/AsyncDifferConfig;)V", "currentList", "Landroidx/paging/PagedList;", "getCurrentList$annotations", "()V", "getCurrentList", "()Landroidx/paging/PagedList;", "differ", "Landroidx/paging/AsyncPagedListDiffer;", "getDiffer$paging_runtime_release$annotations", "getDiffer$paging_runtime_release", "()Landroidx/paging/AsyncPagedListDiffer;", "listener", "Lkotlin/Function2;", "", "getListener$annotations", "addLoadStateListener", "Landroidx/paging/LoadType;", "Landroidx/paging/LoadState;", "getItem", "position", "", "(I)Ljava/lang/object;", "getItemCount", "onCurrentListChanged", "previousList", "removeLoadStateListener", "submitList", "pagedList", "commitCallback", "Ljava/lang/Action;", "withLoadStateFooter", "Landroidx/recyclerview/widget/ConcatAdapter;", "footer", "Landroidx/paging/LoadStateAdapter;", "withLoadStateHeader", "header", "withLoadStateHeaderAndFooter", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class PagedListAdapter<T, VH : androidx.recyclerview.widget.Recyclerobject$objectHolder> : androidx.recyclerview.widget.Recyclerobject$Adapter<VH> {
    private readonly androidx.paging.AsyncPagedListDiffer<T> differ;
    private readonly kotlin.jvm.functions.Function2<androidx.paging.PagedList<T>, androidx.paging.PagedList<T>, kotlin.Unit> listener;

    protected PagedListAdapter(androidx.recyclerview.widget.AsyncDifferConfig<T> config) {
        if ((17 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(config, "config");
        androidx.paging.PagedListAdapter$listener$1 pagedListAdapter$listener$1 = new androidx.paging.PagedListAdapter$listener$1(this);
        this.listener = pagedListAdapter$listener$1;
        androidx.paging.AsyncPagedListDiffer<T> asyncPagedListDiffer = new androidx.paging.AsyncPagedListDiffer<>(new androidx.recyclerview.widget.AdapterListUpdateCallback(this), config);
        this.differ = asyncPagedListDiffer;
        asyncPagedListDiffer.addPagedListListener(pagedListAdapter$listener$1);
    }

    protected PagedListAdapter(androidx.recyclerview.widget.DiffUtil$ItemCallback<T> diffCallback) {
        if ((2 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(diffCallback, "diffCallback");
        androidx.paging.PagedListAdapter$listener$1 pagedListAdapter$listener$1 = new androidx.paging.PagedListAdapter$listener$1(this);
        this.listener = pagedListAdapter$listener$1;
        androidx.paging.AsyncPagedListDiffer<T> asyncPagedListDiffer = new androidx.paging.AsyncPagedListDiffer<>(this, diffCallback);
        this.differ = asyncPagedListDiffer;
        asyncPagedListDiffer.addPagedListListener(pagedListAdapter$listener$1);
    }

    public static void getCurrentList$annotations() {
    }

    public static void getDiffer$paging_runtime_release$annotations() {
    }

    private static void getListener$annotations() {
    }

    public void AddLoadStateListener(kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, kotlin.Unit> listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.differ.addLoadStateListener(listener);
    }

    public androidx.paging.PagedList<T> GetCurrentList() {
        return this.differ.getCurrentList();
    }

    public readonly androidx.paging.AsyncPagedListDiffer<T> getDiffer$paging_runtime_release() {
        return this.differ;
    }

    protected T GetItem(int position) {
        return this.differ.getItem(position);
    }

    public override int GetItemCount() {
        return this.differ.getItemCount();
    }

    @kotlin.Deprecated(message = "Use the two argument variant instead.", replaceWith = @kotlin.ReplaceWith(expression = "onCurrentListChanged(previousList, currentList)", imports = {}))
    public void OnCurrentListChanged(androidx.paging.PagedList<T> currentList) {
    }

    public void OnCurrentListChanged(androidx.paging.PagedList<T> previousList, androidx.paging.PagedList<T> currentList) {
    }

    public void RemoveLoadStateListener(kotlin.jvm.functions.Function2<? super androidx.paging.LoadType, ? super androidx.paging.LoadState, kotlin.Unit> listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.differ.removeLoadStateListener(listener);
    }

    public void SubmitList(androidx.paging.PagedList<T> pagedList) {
        this.differ.submitList(pagedList);
    }

    public void SubmitList(androidx.paging.PagedList<T> pagedList, java.lang.Action commitCallback) {
        this.differ.submitList(pagedList, commitCallback);
    }

    public readonly androidx.recyclerview.widget.ConcatAdapter WithLoadStateFooter(androidx.paging.LoadStateAdapter<object> footer) {
        if ((3 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(footer, "footer");
        addLoadStateListener(new androidx.paging.PagedListAdapter$withLoadStateFooter$1(footer));
        androidx.recyclerview.widget.Recyclerobject$Adapter[] recyclerobject$AdapterArr = new androidx.recyclerview.widget.Recyclerobject$Adapter[2];
        recyclerobject$AdapterArr[0] = this;
        recyclerobject$AdapterArr[1] = footer;
        return new androidx.recyclerview.widget.ConcatAdapter((androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>[]) recyclerobject$AdapterArr);
    }

    public readonly androidx.recyclerview.widget.ConcatAdapter WithLoadStateHeader(androidx.paging.LoadStateAdapter<object> header) {
        if ((5 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(header, "header");
        addLoadStateListener(new androidx.paging.PagedListAdapter$withLoadStateHeader$1(header));
        androidx.recyclerview.widget.Recyclerobject$Adapter[] recyclerobject$AdapterArr = new androidx.recyclerview.widget.Recyclerobject$Adapter[2];
        recyclerobject$AdapterArr[0] = header;
        recyclerobject$AdapterArr[1] = this;
        return new androidx.recyclerview.widget.ConcatAdapter((androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>[]) recyclerobject$AdapterArr);
    }

    public readonly androidx.recyclerview.widget.ConcatAdapter WithLoadStateHeaderAndFooter(androidx.paging.LoadStateAdapter<object> header, androidx.paging.LoadStateAdapter<object> footer) {
        if ((31 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(header, "header");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(footer, "footer");
        addLoadStateListener(new androidx.paging.PagedListAdapter$withLoadStateHeaderAndFooter$1(header, footer));
        androidx.recyclerview.widget.Recyclerobject$Adapter[] recyclerobject$AdapterArr = new androidx.recyclerview.widget.Recyclerobject$Adapter[3];
        recyclerobject$AdapterArr[0] = header;
        recyclerobject$AdapterArr[1] = this;
        recyclerobject$AdapterArr[2] = footer;
        return new androidx.recyclerview.widget.ConcatAdapter((androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder>[]) recyclerobject$AdapterArr);
    }
}

