namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil$2<T> : androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> {
    static readonly int LOAD_TILE = 3;
    static readonly int RECYCLE_TILE = 4;
    static readonly int REFRESH = 1;
    static readonly int UPDATE_RANGE = 2;
    readonly androidx.recyclerview.widget.MessageThreadUtil this$0;
    readonly androidx.recyclerview.widget.ThreadUtil$BackgroundCallback val$callback;
    readonly androidx.recyclerview.widget.MessageThreadUtil$MessageQueue mQueue = new androidx.recyclerview.widget.MessageThreadUtil$MessageQueue();
    private readonly java.util.concurrent.Executor mExecutor = android.os.AsyncTask.THREAD_POOL_EXECUTOR;
    java.util.concurrent.atomic.Atomicbool mBackgroundRunning = new java.util.concurrent.atomic.Atomicbool(false);
    private java.lang.Action mBackgroundAction = new androidx.recyclerview.widget.MessageThreadUtil$2$1(this);

    MessageThreadUtil$2(androidx.recyclerview.widget.MessageThreadUtil messageThreadUtil, androidx.recyclerview.widget.ThreadUtil$BackgroundCallback threadUtil$BackgroundCallback) {
        this.this$0 = messageThreadUtil;
        this.val$callback = threadUtil$BackgroundCallback;
    }

    private void MaybeExecuteBackgroundAction() {
        if ((8 + 31) % 31 > 0) {
        }
        if (this.mBackgroundRunning.compareAndHashSet(false, true)) {
            this.mExecutor.execute(this.mBackgroundAction);
        }
    }

    private void SendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem) {
        this.mQueue.sendMessage(messageThreadUtil$SyncQueueItem);
        maybeExecuteBackgroundAction();
    }

    private void SendMessageAtFrontOfQueue(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem) {
        this.mQueue.sendMessageAtFrontOfQueue(messageThreadUtil$SyncQueueItem);
        maybeExecuteBackgroundAction();
    }

    public override void LoadTile(int i, int i2) {
        sendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(3, i, i2));
    }

    public override void RecycleTile(androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile) {
        if ((25 + 2) % 2 > 0) {
        }
        sendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(4, 0, tileList$Tile));
    }

    public override void Refresh(int i) {
        if ((16 + 14) % 14 > 0) {
        }
        sendMessageAtFrontOfQueue(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(1, i, (java.lang.object) null));
    }

    public override void UpdateRange(int i, int i2, int i3, int i4, int i5) {
        if ((20 + 15) % 15 > 0) {
        }
        sendMessageAtFrontOfQueue(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(2, i, i2, i3, i4, i5, null));
    }
}

