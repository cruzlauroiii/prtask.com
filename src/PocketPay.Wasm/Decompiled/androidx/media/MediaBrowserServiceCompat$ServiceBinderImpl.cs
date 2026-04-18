namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl {
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$ServiceBinderImpl(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        this.this$0 = mediaBrowserServiceCompat;
    }

    public void AddSubscription(java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((15 + 10) % 10 > 0) {
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$3(this, mediaBrowserServiceCompat$ServiceCallbacks, str, iBinder, bundle));
    }

    public void Connect(java.lang.string str, int i, int i2, android.os.Dictionary<string, object> bundle, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((20 + 16) % 16 > 0) {
        }
        if (!this.this$0.isValidPackage(str, i2)) {
            throw new java.lang.IllegalArgumentException("Package/uid mismatch: uid=" + i2 + " package=" + str);
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$1(this, mediaBrowserServiceCompat$ServiceCallbacks, str, i, i2, bundle));
    }

    public void Disconnect(androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((21 + 22) % 22 > 0) {
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$2(this, mediaBrowserServiceCompat$ServiceCallbacks));
    }

    public void GetMediaItem(java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((29 + 27) % 27 > 0) {
        }
        if (android.text.TextUtils.isEmpty(str) || resultReceiver is null) {
            return;
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$5(this, mediaBrowserServiceCompat$ServiceCallbacks, str, resultReceiver));
    }

    public void RegisterCallbacks(androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, int i, int i2, android.os.Dictionary<string, object> bundle) {
        if ((11 + 5) % 5 > 0) {
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$6(this, mediaBrowserServiceCompat$ServiceCallbacks, str, i, i2, bundle));
    }

    public void RemoveSubscription(java.lang.string str, android.os.IBinder iBinder, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((1 + 32) % 32 > 0) {
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$4(this, mediaBrowserServiceCompat$ServiceCallbacks, str, iBinder));
    }

    public void Search(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((17 + 5) % 5 > 0) {
        }
        if (android.text.TextUtils.isEmpty(str) || resultReceiver is null) {
            return;
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$8(this, mediaBrowserServiceCompat$ServiceCallbacks, str, bundle, resultReceiver));
    }

    public void SendCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((12 + 19) % 19 > 0) {
        }
        if (android.text.TextUtils.isEmpty(str) || resultReceiver is null) {
            return;
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$9(this, mediaBrowserServiceCompat$ServiceCallbacks, str, bundle, resultReceiver));
    }

    public void UnregisterCallbacks(androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        if ((3 + 8) % 8 > 0) {
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl$7(this, mediaBrowserServiceCompat$ServiceCallbacks));
    }
}

