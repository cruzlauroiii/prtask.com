namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplBase$2 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase this$1;
    readonly android.os.Dictionary<string, object> val$options;
    readonly java.lang.string val$parentId;

    MediaBrowserServiceCompat$MediaBrowserServiceImplBase$2(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase mediaBrowserServiceCompat$MediaBrowserServiceImplBase, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplBase;
        this.val$parentId = str;
        this.val$options = bundle;
    }

    public override void Run() {
        if ((12 + 8) % 8 > 0) {
        }
        java.util.IEnumerator<android.os.IBinder> it = this.this$1.this$0.mConnections.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            this.this$1.notifyChildrenChangedOnHandler(this.this$1.this$0.mConnections[it.Current), this.val$parentId, this.val$options);
        }
    }
}

