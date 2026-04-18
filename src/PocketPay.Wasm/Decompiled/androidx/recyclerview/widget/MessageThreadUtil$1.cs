namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil$1<T> : androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> {
    static readonly int ADD_TILE = 2;
    static readonly int REMOVE_TILE = 3;
    static readonly int UPDATE_ITEM_COUNT = 1;
    readonly androidx.recyclerview.widget.MessageThreadUtil this$0;
    readonly androidx.recyclerview.widget.ThreadUtil$MainThreadCallback val$callback;
    readonly androidx.recyclerview.widget.MessageThreadUtil$MessageQueue mQueue = new androidx.recyclerview.widget.MessageThreadUtil$MessageQueue();
    private readonly android.os.Handler mMainThreadHandler = new android.os.Handler(android.os.Looper.getMainLooper());
    private java.lang.Action mMainThreadAction = new androidx.recyclerview.widget.MessageThreadUtil$1$1(this);

    MessageThreadUtil$1(androidx.recyclerview.widget.MessageThreadUtil messageThreadUtil, androidx.recyclerview.widget.ThreadUtil$MainThreadCallback threadUtil$MainThreadCallback) {
        this.this$0 = messageThreadUtil;
        this.val$callback = threadUtil$MainThreadCallback;
    }

    private void SendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem) {
        this.mQueue.sendMessage(messageThreadUtil$SyncQueueItem);
        this.mMainThreadHandler.post(this.mMainThreadAction);
    }

    public override void AddTile(int i, androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile) {
        sendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(2, i, tileList$Tile));
    }

    public override void RemoveTile(int i, int i2) {
        sendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(3, i, i2));
    }

    public override void UpdateItemCount(int i, int i2) {
        sendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem.obtainMessage(1, i, i2));
    }
}

