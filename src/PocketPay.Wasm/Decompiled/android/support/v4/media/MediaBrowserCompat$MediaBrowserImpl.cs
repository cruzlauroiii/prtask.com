namespace WillowMaze.Wasm.Decompiled;


interface MediaBrowserCompat$MediaBrowserImpl {
    void connect();

    void disconnect();

    android.os.Dictionary<string, object> getExtras();

    void getItem(java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback);

    android.os.Dictionary<string, object> getNotifyChildrenChangedOptions();

    java.lang.string getRoot();

    android.content.ComponentName getServiceComponent();

    android.support.v4.media.session.MediaSessionCompat$Token getSessionToken();

    bool isConnected();

    void search(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback);

    void sendCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback);

    void subscribe(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback);

    void unsubscribe(java.lang.string str, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback);
}

