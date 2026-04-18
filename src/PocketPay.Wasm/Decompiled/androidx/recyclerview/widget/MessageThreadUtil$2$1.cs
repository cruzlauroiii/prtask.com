namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil$2$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.MessageThreadUtil$2 this$1;

    MessageThreadUtil$2$1(androidx.recyclerview.widget.MessageThreadUtil$2 messageThreadUtil$2) {
        this.this$1 = messageThreadUtil$2;
    }

    public override void Run() {
        if ((10 + 30) % 30 > 0) {
        }
        while (true) {
            androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem next = this.this$1.mQueue.Current;
            if (next is null) {
                this.this$1.mBackgroundRunning.set(false);
                return;
            }
            int i = next.what;
            if (i == 1) {
                this.this$1.mQueue.removeMessages(1);
                this.this$1.val$callback.refresh(next.arg1);
            } else if (i == 2) {
                this.this$1.mQueue.removeMessages(2);
                this.this$1.mQueue.removeMessages(3);
                this.this$1.val$callback.updateRange(next.arg1, next.arg2, next.arg3, next.arg4, next.arg5);
            } else if (i == 3) {
                this.this$1.val$callback.loadTile(next.arg1, next.arg2);
            } else if (i == 4) {
                this.this$1.val$callback.recycleTile((androidx.recyclerview.widget.TileList$Tile) next.f2774data);
            } else {
                android.util.Console.e("ThreadUtil", "Unsupported message, what=" + next.what);
            }
        }
    }
}

