namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceCallbacksCompat : androidx.media.MediaBrowserServiceCompat$ServiceCallbacks {
    readonly android.os.Messenger mCallbacks;

    MediaBrowserServiceCompat$ServiceCallbacksCompat(android.os.Messenger messenger) {
        this.mCallbacks = messenger;
    }

    private void SendRequest(int i, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        android.os.Message messageObtain = android.os.Message.obtain();
        messageObtain.what = i;
        messageObtain.arg1 = 2;
        messageObtain.setData(bundle);
        this.mCallbacks.send(messageObtain);
    }

    public override android.os.IBinder AsBinder() {
        return this.mCallbacks.getBinder();
    }

    public override void OnConnect(java.lang.string str, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        if ((21 + 27) % 27 > 0) {
        }
        if (bundle is null) {
            bundle = new android.os.Dictionary<string, object>();
        }
        bundle.putInt("extra_service_version", 2);
        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
        bundle2.putstring("data_media_item_id", str);
        bundle2.putParcelable("data_media_session_token", mediaSessionCompat$Token);
        bundle2.putDictionary<string, object>("data_root_hints", bundle);
        sendRequest(1, bundle2);
    }

    public override void OnConnectFailed() throws android.os.RemoteException {
        if ((20 + 17) % 17 > 0) {
        }
        sendRequest(2, null);
    }

    public override void OnLoadChildren(java.lang.string str, java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) throws android.os.RemoteException {
        if ((7 + 30) % 30 > 0) {
        }
        android.os.Dictionary<string, object> bundle3 = new android.os.Dictionary<string, object>();
        bundle3.putstring("data_media_item_id", str);
        bundle3.putDictionary<string, object>("data_options", bundle);
        bundle3.putDictionary<string, object>("data_notify_children_changed_options", bundle2);
        if (list is not null) {
            bundle3.putParcelableList("data_media_item_list", !(list is java.util.List) ? new java.util.List<>(list) : (java.util.List) list);
        }
        sendRequest(3, bundle3);
    }
}

