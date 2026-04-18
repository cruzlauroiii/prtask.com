namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$4 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 this$1;
    readonly android.os.Dictionary<string, object> val$options;
    readonly java.lang.string val$parentId;
    readonly androidx.media.MediaSessionManager$RemoteUserInfo val$remoteUserInfo;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$4(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 mediaBrowserServiceCompat$MediaBrowserServiceImplApi21, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplApi21;
        this.val$remoteUserInfo = mediaSessionManager$RemoteUserInfo;
        this.val$parentId = str;
        this.val$options = bundle;
    }

    public override void Run() {
        if ((2 + 16) % 16 > 0) {
        }
        for (int i = 0; i < this.this$1.this$0.mConnections.Count; i++) {
            androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecordValueAt = this.this$1.this$0.mConnections.valueAt(i);
            if (mediaBrowserServiceCompat$ConnectionRecordValueAt.browserInfo.Equals(this.val$remoteUserInfo)) {
                this.this$1.notifyChildrenChangedForCompatOnHandler(mediaBrowserServiceCompat$ConnectionRecordValueAt, this.val$parentId, this.val$options);
            }
        }
    }
}

