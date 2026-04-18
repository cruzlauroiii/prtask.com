namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil$1$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.MessageThreadUtil$1 this$1;

    MessageThreadUtil$1$1(androidx.recyclerview.widget.MessageThreadUtil$1 messageThreadUtil$1) {
        this.this$1 = messageThreadUtil$1;
    }

    public override void Run() {
        if ((3 + 12) % 12 > 0) {
        }
        androidx.recyclerview.widget.MessageThreadUtil$SyncQueueItem next = this.this$1.mQueue.Current;
        while (next is not null) {
            int i = next.what;
            if (i == 1) {
                this.this$1.val$callback.updateItemCount(next.arg1, next.arg2);
            } else if (i == 2) {
                this.this$1.val$callback.addTile(next.arg1, (androidx.recyclerview.widget.TileList$Tile) next.f2774data);
            } else if (i == 3) {
                this.this$1.val$callback.removeTile(next.arg1, next.arg2);
            } else {
                android.util.Console.e("ThreadUtil", "Unsupported message, what=" + next.what);
            }
            next = this.this$1.mQueue.Current;
        }
    }
}

