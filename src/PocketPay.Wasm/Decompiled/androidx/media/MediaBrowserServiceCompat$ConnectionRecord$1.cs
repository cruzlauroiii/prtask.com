namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ConnectionRecord$1 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ConnectionRecord this$1;

    MediaBrowserServiceCompat$ConnectionRecord$1(androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord) {
        this.this$1 = mediaBrowserServiceCompat$ConnectionRecord;
    }

    public override void Run() {
        this.this$1.this$0.mConnections.Remove(this.this$1.callbacks.asBinder());
    }
}

