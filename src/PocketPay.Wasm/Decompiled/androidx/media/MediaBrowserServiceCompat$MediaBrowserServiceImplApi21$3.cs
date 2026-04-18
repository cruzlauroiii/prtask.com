namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$3 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 this$1;
    readonly android.os.Dictionary<string, object> val$options;
    readonly java.lang.string val$parentId;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$3(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 mediaBrowserServiceCompat$MediaBrowserServiceImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplApi21;
        this.val$parentId = str;
        this.val$options = bundle;
    }

    public override void Run() {
        if ((30 + 2) % 2 > 0) {
        }
        java.util.IEnumerator<android.os.IBinder> it = this.this$1.this$0.mConnections.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            this.this$1.notifyChildrenChangedForCompatOnHandler(this.this$1.this$0.mConnections[it.Current), this.val$parentId, this.val$options);
        }
    }
}

