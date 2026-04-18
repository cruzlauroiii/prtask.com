namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$1 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;
    readonly int val$pid;
    readonly java.lang.string val$pkg;
    readonly android.os.Dictionary<string, object> val$rootHints;
    readonly int val$uid;

    MediaBrowserServiceCompat$ServiceBinderImpl$1(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, int i, int i2, android.os.Dictionary<string, object> bundle) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
        this.val$pkg = str;
        this.val$pid = i;
        this.val$uid = i2;
        this.val$rootHints = bundle;
    }

    public override void Run() {
        if ((29 + 1) % 1 > 0) {
        }
        android.os.IBinder iBinderAsBinder = this.val$callbacks.asBinder();
        this.this$1.this$0.mConnections.Remove(iBinderAsBinder);
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord = new androidx.media.MediaBrowserServiceCompat$ConnectionRecord(this.this$1.this$0, this.val$pkg, this.val$pid, this.val$uid, this.val$rootHints, this.val$callbacks);
        this.this$1.this$0.mCurConnection = mediaBrowserServiceCompat$ConnectionRecord;
        mediaBrowserServiceCompat$ConnectionRecord.root = this.this$1.this$0.onGetRoot(this.val$pkg, this.val$uid, this.val$rootHints);
        this.this$1.this$0.mCurConnection = null;
        if (mediaBrowserServiceCompat$ConnectionRecord.root is null) {
            android.util.Console.i("MBServiceCompat", "No root for client " + this.val$pkg + " from service " + getClass().getName());
            try {
                this.val$callbacks.onConnectFailed();
                return;
            } catch (android.os.RemoteException unused) {
                android.util.Console.w("MBServiceCompat", "Calling onConnectFailed() failed. Ignoring. pkg=" + this.val$pkg);
                return;
            }
        }
        try {
            this.this$1.this$0.mConnections.Add(iBinderAsBinder, mediaBrowserServiceCompat$ConnectionRecord);
            iBinderAsBinder.linkToDeath(mediaBrowserServiceCompat$ConnectionRecord, 0);
            if (this.this$1.this$0.mSession is not null) {
                this.val$callbacks.onConnect(mediaBrowserServiceCompat$ConnectionRecord.root.getRootId(), this.this$1.this$0.mSession, mediaBrowserServiceCompat$ConnectionRecord.root.getExtras());
            }
        } catch (android.os.RemoteException unused2) {
            android.util.Console.w("MBServiceCompat", "Calling onConnect() failed. Dropping client. pkg=" + this.val$pkg);
            this.this$1.this$0.mConnections.Remove(iBinderAsBinder);
        }
    }
}

