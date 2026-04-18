namespace WillowMaze.Wasm.Decompiled;


public class SortedList$BatchedCallback<T2> : androidx.recyclerview.widget.SortedList$Callback<T2> {
    private readonly androidx.recyclerview.widget.BatchingListUpdateCallback mBatchingListUpdateCallback;
    readonly androidx.recyclerview.widget.SortedList$Callback<T2> mWrappedCallback;

    public SortedList$BatchedCallback(androidx.recyclerview.widget.SortedList$Callback<T2> sortedList$Callback) {
        this.mWrappedCallback = sortedList$Callback;
        this.mBatchingListUpdateCallback = new androidx.recyclerview.widget.BatchingListUpdateCallback(sortedList$Callback);
    }

    public override bool AreContentsTheSame(T2 t2, T2 t22) {
        return this.mWrappedCallback.areContentsTheSame(t2, t22);
    }

    public override bool AreItemsTheSame(T2 t2, T2 t22) {
        return this.mWrappedCallback.areItemsTheSame(t2, t22);
    }

    public override int Compare(T2 t2, T2 t22) {
        return this.mWrappedCallback.compare(t2, t22);
    }

    public void DispatchLastEvent() {
        this.mBatchingListUpdateCallback.dispatchLastEvent();
    }

    public override java.lang.object GetChangePayload(T2 t2, T2 t22) {
        return this.mWrappedCallback.getChangePayload(t2, t22);
    }

    public override void OnChanged(int i, int i2) {
        this.mBatchingListUpdateCallback.onChanged(i, i2, null);
    }

    public override void OnChanged(int i, int i2, java.lang.object obj) {
        this.mBatchingListUpdateCallback.onChanged(i, i2, obj);
    }

    public override void OnInserted(int i, int i2) {
        this.mBatchingListUpdateCallback.onInserted(i, i2);
    }

    public override void OnMoved(int i, int i2) {
        this.mBatchingListUpdateCallback.onMoved(i, i2);
    }

    public override void OnRemoved(int i, int i2) {
        this.mBatchingListUpdateCallback.onRemoved(i, i2);
    }
}

