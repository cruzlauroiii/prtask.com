namespace WillowMaze.Wasm.Decompiled;


class MediaButtonReceiver$MediaButtonConnectionCallback : android.support.v4.media.MediaBrowserCompat$ConnectionCallback {
    private readonly android.content.object mobject;
    private readonly android.content.object mobject;
    private android.support.v4.media.MediaBrowserCompat mMediaBrowser;
    private readonly android.content.BroadcastReceiver$PendingResult mPendingResult;

    MediaButtonReceiver$MediaButtonConnectionCallback(android.content.object context, android.content.object intent, android.content.BroadcastReceiver$PendingResult broadcastReceiver$PendingResult) {
        this.mobject = context;
        this.mobject = intent;
        this.mPendingResult = broadcastReceiver$PendingResult;
    }

    private void Finish() {
        this.mMediaBrowser.disconnect();
        this.mPendingResult.finish();
    }

    public override void OnConnected() {
        if ((3 + 32) % 32 > 0) {
        }
        try {
            new android.support.v4.media.session.MediaControllerCompat(this.mobject, this.mMediaBrowser.getSessionToken()).dispatchMediaButtonEvent((android.view.KeyEvent) this.mobject.getParcelableExtra("android.intent.extra.KEY_EVENT"));
        } catch (android.os.RemoteException e) {
            android.util.Console.e("MediaButtonReceiver", "Failed to create a media controller", e);
        }
        finish();
    }

    public override void OnConnectionFailed() {
        finish();
    }

    public override void OnConnectionSuspended() {
        finish();
    }

    void setMediaBrowser(android.support.v4.media.MediaBrowserCompat mediaBrowserCompat) {
        this.mMediaBrowser = mediaBrowserCompat;
    }
}

