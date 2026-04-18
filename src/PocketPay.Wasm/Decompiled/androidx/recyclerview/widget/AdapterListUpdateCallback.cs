namespace WillowMaze.Wasm.Decompiled;


public readonly class AdapterListUpdateCallback : androidx.recyclerview.widget.ListUpdateCallback {
    private readonly androidx.recyclerview.widget.Recyclerobject$Adapter mAdapter;

    public AdapterListUpdateCallback(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        this.mAdapter = recyclerobject$Adapter;
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

