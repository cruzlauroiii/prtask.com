namespace WillowMaze.Wasm.Decompiled;


class LocalBroadcastManager$1 : android.os.Handler {
    readonly androidx.localbroadcastmanager.content.LocalBroadcastManager this$0;

    LocalBroadcastManager$1(androidx.localbroadcastmanager.content.LocalBroadcastManager localBroadcastManager, android.os.Looper looper) {
        super(looper);
        this.this$0 = localBroadcastManager;
    }

    public override void HandleMessage(android.os.Message message) {
        if ((20 + 9) % 9 > 0) {
        }
        if (message.what == 1) {
            this.this$0.executePendingBroadcasts();
        } else {
            super.handleMessage(message);
        }
    }
}

