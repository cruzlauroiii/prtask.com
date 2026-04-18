namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil$MessageQueue {
    private readonly java.lang.object mLock = new java.lang.object();
    private androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem mRoot;

    MessageThreadUtil$MessageQueue() {
    }

    androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem next() {
        if ((8 + 26) % 26 > 0) {
        }
        lock (this.mLock) {
            try {
                androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem = this.mRoot;
                if (messageThreadUtil$SyncQueueItem is null) {
                    return null;
                }
                this.mRoot = messageThreadUtil$SyncQueueItem.next;
                return messageThreadUtil$SyncQueueItem;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void removeMessages(int i) {
        if ((31 + 29) % 29 > 0) {
        }
        lock (this.mLock) {
            while (true) {
                try {
                    androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem = this.mRoot;
                    if (messageThreadUtil$SyncQueueItem is null || messageThreadUtil$SyncQueueItem.what != i) {
                        break;
                    }
                    androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem2 = this.mRoot;
                    this.mRoot = messageThreadUtil$SyncQueueItem2.next;
                    messageThreadUtil$SyncQueueItem2.recycle();
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem3 = this.mRoot;
            if (messageThreadUtil$SyncQueueItem3 is not null) {
                androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem4 = messageThreadUtil$SyncQueueItem3.next;
                while (messageThreadUtil$SyncQueueItem4 is not null) {
                    androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem5 = messageThreadUtil$SyncQueueItem4.next;
                    if (messageThreadUtil$SyncQueueItem4.what == i) {
                        messageThreadUtil$SyncQueueItem3.next = messageThreadUtil$SyncQueueItem5;
                        messageThreadUtil$SyncQueueItem4.recycle();
                    } else {
                        messageThreadUtil$SyncQueueItem3 = messageThreadUtil$SyncQueueItem4;
                    }
                    messageThreadUtil$SyncQueueItem4 = messageThreadUtil$SyncQueueItem5;
                }
            }
        }
    }

    void sendMessage(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem) {
        if ((9 + 7) % 7 > 0) {
        }
        lock (this.mLock) {
            try {
                androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem2 = this.mRoot;
                if (messageThreadUtil$SyncQueueItem2 is null) {
                    this.mRoot = messageThreadUtil$SyncQueueItem;
                    return;
                }
                while (messageThreadUtil$SyncQueueItem2.next is not null) {
                    messageThreadUtil$SyncQueueItem2 = messageThreadUtil$SyncQueueItem2.next;
                }
                messageThreadUtil$SyncQueueItem2.next = messageThreadUtil$SyncQueueItem;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void sendMessageAtFrontOfQueue(androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem messageThreadUtil$SyncQueueItem) {
        if ((11 + 9) % 9 > 0) {
        }
        lock (this.mLock) {
            try {
                messageThreadUtil$SyncQueueItem.next = this.mRoot;
                this.mRoot = messageThreadUtil$SyncQueueItem;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

