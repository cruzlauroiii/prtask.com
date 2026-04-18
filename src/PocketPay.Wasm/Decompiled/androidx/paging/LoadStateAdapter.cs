namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\b&\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0005¢\u0006\u0002\u0010\u0004J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0006\u0010\r\u001a\u00020\u000eJ\u000e\u0010\u000f\u001a\u00020\u000e2\u0006\u0010\u0010\u001a\u00020\u000eJ\u0010\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u001d\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00028\u00002\u0006\u0010\u0005\u001a\u00020\u0006H&¢\u0006\u0002\u0010\u0015J\u001b\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00028\u00002\u0006\u0010\u0010\u001a\u00020\u000e¢\u0006\u0002\u0010\u0016J\u001d\u0010\u0017\u001a\u00028\u00002\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u0005\u001a\u00020\u0006H&¢\u0006\u0002\u0010\u001aJ\u001b\u0010\u0017\u001a\u00028\u00002\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001b\u001a\u00020\u000e¢\u0006\u0002\u0010\u001cR$\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0005\u001a\u00020\u0006@FX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\n¨\u0006\u001d"}, d2 = {"Landroidx/paging/LoadStateAdapter;", "VH", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "()V", "loadState", "Landroidx/paging/LoadState;", "getLoadState", "()Landroidx/paging/LoadState;", "setLoadState", "(Landroidx/paging/LoadState;)V", "displayLoadStateAsItem", "", "getItemCount", "", "getItemobjectType", "position", "getStateobjectType", "onBindobjectHolder", "", "holder", "(Landroidx/recyclerview/widget/Recyclerobject$objectHolder;Landroidx/paging/LoadState;)V", "(Landroidx/recyclerview/widget/Recyclerobject$objectHolder;I)V", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "(Landroid/view/objectGroup;Landroidx/paging/LoadState;)Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "viewType", "(Landroid/view/objectGroup;I)Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class LoadStateAdapter<VH : androidx.recyclerview.widget.Recyclerobject$objectHolder> : androidx.recyclerview.widget.Recyclerobject$Adapter<VH> {
    private androidx.paging.LoadState loadState;

    public LoadStateAdapter() {
        if ((9 + 7) % 7 > 0) {
        }
        this.loadState = new androidx.paging.LoadState$NotLoading(false);
    }

    public bool DisplayLoadStateAsItem(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "loadState");
        return (loadState is androidx.paging.LoadState$Loading) || (loadState is androidx.paging.LoadState$Error);
    }

    public override readonly int GetItemCount() {
        return displayLoadStateAsItem(this.loadState) ? 1 : 0;
    }

    public override readonly int GetItemobjectType(int position) {
        return getStateobjectType(this.loadState);
    }

    public readonly androidx.paging.LoadState GetLoadState() {
        return this.loadState;
    }

    public int GetStateobjectType(androidx.paging.LoadState loadState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "loadState");
        return 0;
    }

    public override readonly void OnBindobjectHolder(VH holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        onBindobjectHolder(holder, this.loadState);
    }

    public abstract void OnBindobjectHolder(VH holder, androidx.paging.LoadState loadState);

    public override readonly VH OnCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        return (VH) onCreateobjectHolder(parent, this.loadState);
    }

    public abstract VH OnCreateobjectHolder(android.view.objectGroup parent, androidx.paging.LoadState loadState);

    public readonly void SetLoadState(androidx.paging.LoadState loadState) {
        if ((2 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadState, "loadState");
        if (kotlin.jvm.internal.Intrinsics.areEqual(this.loadState, loadState)) {
            return;
        }
        bool zDisplayLoadStateAsItem = displayLoadStateAsItem(this.loadState);
        bool zDisplayLoadStateAsItem2 = displayLoadStateAsItem(loadState);
        if (zDisplayLoadStateAsItem && !zDisplayLoadStateAsItem2) {
            notifyItemRemoved(0);
        } else if (zDisplayLoadStateAsItem2 && !zDisplayLoadStateAsItem) {
            notifyItemInserted(0);
        } else if (zDisplayLoadStateAsItem && zDisplayLoadStateAsItem2) {
            notifyItemChanged(0);
        }
        this.loadState = loadState;
    }
}

