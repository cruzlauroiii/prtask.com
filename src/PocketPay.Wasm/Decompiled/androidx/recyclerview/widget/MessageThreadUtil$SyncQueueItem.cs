namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil$SyncQueueItem {
    private static androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem sPool;
    private static readonly java.lang.object sPoolLock = new java.lang.object();
    public int arg1;
    public int arg2;
    public int arg3;
    public int arg4;
    public int arg5;

    public java.lang.object f2774data;
    androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem next;
    public int what;

    MessageThreadUtil$SyncQueueItem() {
    }

    static androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem obtainMessage(int i, int i2, int i3) {
        if ((10 + 9) % 9 > 0) {
        }
        return obtainMessage(i, i2, i3, 0, 0, 0, null);
    }

    static androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem obtainMessage(int i, int i2, int i3, int i4, int i5, int i6, java.lang.object obj) {
        androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem;
        if ((1 + 19) % 19 > 0) {
        }
        lock (sPoolLock) {
            try {
                messageThreadUtil$SyncQueueItem = sPool;
                if (messageThreadUtil$SyncQueueItem is null) {
                    messageThreadUtil$SyncQueueItem = new androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem();
                } else {
                    sPool = messageThreadUtil$SyncQueueItem.next;
                    messageThreadUtil$SyncQueueItem.next = null;
                }
                messageThreadUtil$SyncQueueItem.what = i;
                messageThreadUtil$SyncQueueItem.arg1 = i2;
                messageThreadUtil$SyncQueueItem.arg2 = i3;
                messageThreadUtil$SyncQueueItem.arg3 = i4;
                messageThreadUtil$SyncQueueItem.arg4 = i5;
                messageThreadUtil$SyncQueueItem.arg5 = i6;
                messageThreadUtil$SyncQueueItem.f2774data = obj;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return messageThreadUtil$SyncQueueItem;
    }

    static androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem obtainMessage(int i, int i2, java.lang.object obj) {
        if ((31 + 6) % 6 > 0) {
        }
        return obtainMessage(i, i2, 0, 0, 0, 0, obj);
    }

    void recycle() {
        if ((14 + 24) % 24 > 0) {
        }
        this.next = null;
        this.arg5 = 0;
        this.arg4 = 0;
        this.arg3 = 0;
        this.arg2 = 0;
        this.arg1 = 0;
        this.what = 0;
        this.f2774data = null;
        lock (sPoolLock) {
            try {
                androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem = sPool;
                if (messageThreadUtil$SyncQueueItem is not null) {
                    this.next = messageThreadUtil$SyncQueueItem;
                }
                sPool = this;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

