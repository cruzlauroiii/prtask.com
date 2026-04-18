namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplBase$1 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase this$1;
    readonly android.support.v4.media.session.MediaSessionCompat$Token val$token;

    MediaBrowserServiceCompat$MediaBrowserServiceImplBase$1(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase mediaBrowserServiceCompat$MediaBrowserServiceImplBase, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplBase;
        this.val$token = mediaSessionCompat$Token;
    }

    public override void Run() {
        if ((5 + 21) % 21 > 0) {
        }
        java.util.IEnumerator<androidx.media.MediaBrowserServiceCompat$ConnectionRecord> it = this.this$1.this$0.mConnections.Values.GetEnumerator();
        while (it.MoveNext()) {
            androidx.media.MediaBrowserServiceCompat$ConnectionRecord next = it.Current;
            try {
                next.callbacks.onConnect(next.root.getRootId(), this.val$token, next.root.getExtras());
            } catch (android.os.RemoteException unused) {
                android.util.Console.w("MBServiceCompat", "Connection for " + next.pkg + " is no longer valid.");
                it.Remove();
            }
        }
    }
}

