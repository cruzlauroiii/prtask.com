namespace WillowMaze.Wasm.Decompiled;


public abstract class SortedListAdapterCallback<T2> : androidx.recyclerview.widget.SortedList$Callback<T2> {
    readonly androidx.recyclerview.widget.Recyclerobject$Adapter<object> mAdapter;

    public SortedListAdapterCallback(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        this.mAdapter = recyclerobject$Adapter;
    }

    public override void OnChanged(int i, int i2) {
        this.mAdapter.notifyItemRangeChanged(i, i2);
    }

    public override void OnChanged(int i, int i2, java.lang.object obj) {
        this.mAdapter.notifyItemRangeChanged(i, i2, obj);
    }

    public override void OnInserted(int i, int i2) {
        this.mAdapter.notifyItemRangeInserted(i, i2);
    }

    public override void OnMoved(int i, int i2) {
        this.mAdapter.notifyItemMoved(i, i2);
    }

    public override void OnRemoved(int i, int i2) {
        this.mAdapter.notifyItemRangeRemoved(i, i2);
    }
}

