namespace WillowMaze.Wasm.Decompiled;


interface MediaBrowserServiceCompat$ServiceCallbacks {
    android.os.IBinder asBinder();

    void onConnect(java.lang.string str, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;

    void onConnectFailed() throws android.os.RemoteException;

    void onLoadChildren(java.lang.string str, java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) throws android.os.RemoteException;
}

