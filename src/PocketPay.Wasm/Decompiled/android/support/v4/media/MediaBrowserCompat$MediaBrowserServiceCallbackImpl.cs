namespace WillowMaze.Wasm.Decompiled;


interface MediaBrowserCompat$MediaBrowserServiceCallbackImpl {
    void onConnectionFailed(android.os.Messenger messenger);

    void onLoadChildren(android.os.Messenger messenger, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2);

    void onServiceConnected(android.os.Messenger messenger, java.lang.string str, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, android.os.Dictionary<string, object> bundle);
}

