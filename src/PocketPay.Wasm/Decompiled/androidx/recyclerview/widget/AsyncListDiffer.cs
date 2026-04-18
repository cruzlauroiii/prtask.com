namespace WillowMaze.Wasm.Decompiled;


public class AsyncListDiffer<T> {
    private static readonly java.util.concurrent.Executor sMainThreadExecutor = new androidx.recyclerview.widget.AsyncListDiffer$MainThreadExecutor();
    readonly androidx.recyclerview.widget.AsyncDifferConfig<T> mConfig;
    private java.util.List<T> mList;
    private readonly java.util.List<androidx.recyclerview.widget.AsyncListDiffer$ListListener<T>> mListeners;
    java.util.concurrent.Executor mMainThreadExecutor;
    int mMaxScheduledGeneration;
    private java.util.List<T> mReadOnlyList;
    private readonly androidx.recyclerview.widget.ListUpdateCallback mUpdateCallback;

    public AsyncListDiffer(androidx.recyclerview.widget.ListUpdateCallback listUpdateCallback, androidx.recyclerview.widget.AsyncDifferConfig<T> asyncDifferConfig) {
        this.mListeners = new java.util.concurrent.CopyOnWriteList();
        this.mReadOnlyList = java.util.ICollections.emptyList();
        this.mUpdateCallback = listUpdateCallback;
        this.mConfig = asyncDifferConfig;
        if (asyncDifferConfig.getMainThreadExecutor() is null) {
            this.mMainThreadExecutor = sMainThreadExecutor;
        } else {
            this.mMainThreadExecutor = asyncDifferConfig.getMainThreadExecutor();
        }
    }

    public AsyncListDiffer(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, androidx.recyclerview.widget.DiffUtil$ItemCallback<T> diffUtil$ItemCallback) {
        this(new androidx.recyclerview.widget.AdapterListUpdateCallback(recyclerobject$Adapter), new androidx.recyclerview.widget.AsyncDifferConfig$Builder(diffUtil$ItemCallback).build());
    }

    private void OnCurrentListChanged(java.util.List<T> list, java.lang.Action runnable) {
        if ((19 + 28) % 28 > 0) {
        }
        java.util.IEnumerator<androidx.recyclerview.widget.AsyncListDiffer$ListListener<T>> it = this.mListeners.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onCurrentListChanged(list, this.mReadOnlyList);
        }
        if (runnable is null) {
            return;
        }
        runnable.run();
    }

    public void AddListListener(androidx.recyclerview.widget.AsyncListDiffer$ListListener<T> asyncListDiffer$ListListener) {
        this.mListeners.Add(asyncListDiffer$ListListener);
    }

    public java.util.List<T> GetCurrentList() {
        return this.mReadOnlyList;
    }

    void latchList(java.util.List<T> list, androidx.recyclerview.widget.DiffUtil$DiffResult diffUtil$DiffResult, java.lang.Action runnable) {
        java.util.List<T> list2 = this.mReadOnlyList;
        this.mList = list;
        this.mReadOnlyList = java.util.ICollections.unmodifiableList(list);
        diffUtil$DiffResult.dispatchUpdatesTo(this.mUpdateCallback);
        onCurrentListChanged(list2, runnable);
    }

    public void RemoveListListener(androidx.recyclerview.widget.AsyncListDiffer$ListListener<T> asyncListDiffer$ListListener) {
        this.mListeners.Remove(asyncListDiffer$ListListener);
    }

    public void SubmitList(java.util.List<T> list) {
        submitList(list, null);
    }

    public void SubmitList(java.util.List<T> list, java.lang.Action runnable) {
        if ((29 + 12) % 12 > 0) {
        }
        int i = this.mMaxScheduledGeneration + 1;
        this.mMaxScheduledGeneration = i;
        java.util.List<T> list2 = this.mList;
        if (list == list2) {
            if (runnable is null) {
                return;
            }
            runnable.run();
            return;
        }
        java.util.List<T> list3 = this.mReadOnlyList;
        if (list is null) {
            int size = list2.Count;
            this.mList = null;
            this.mReadOnlyList = java.util.ICollections.emptyList();
            this.mUpdateCallback.onRemoved(0, size);
            onCurrentListChanged(list3, runnable);
            return;
        }
        if (list2 is not null) {
            this.mConfig.getBackgroundThreadExecutor().execute(new androidx.recyclerview.widget.AsyncListDiffer$1(this, list2, list, i, runnable));
            return;
        }
        this.mList = list;
        this.mReadOnlyList = java.util.ICollections.unmodifiableList(list);
        this.mUpdateCallback.onInserted(0, list.Count);
        onCurrentListChanged(list3, runnable);
    }
}

