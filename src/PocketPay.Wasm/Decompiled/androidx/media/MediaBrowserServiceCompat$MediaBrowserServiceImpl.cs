namespace WillowMaze.Wasm.Decompiled;


interface MediaBrowserServiceCompat$MediaBrowserServiceImpl {
    android.os.Dictionary<string, object> getBrowserRootHints();

    androidx.media.MediaSessionManager$RemoteUserInfo getCurrentBrowserInfo();

    void notifyChildrenChanged(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, android.os.Dictionary<string, object> bundle);

    void notifyChildrenChanged(java.lang.string str, android.os.Dictionary<string, object> bundle);

    android.os.IBinder onBind(android.content.object intent);

    void onCreate();

    void setSessionToken(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token);
}

