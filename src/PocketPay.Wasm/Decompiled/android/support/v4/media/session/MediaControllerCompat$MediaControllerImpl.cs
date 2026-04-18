namespace WillowMaze.Wasm.Decompiled;


interface MediaControllerCompat$MediaControllerImpl {
    void addQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat);

    void addQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i);

    void adjustVolume(int i, int i2);

    bool dispatchMediaButtonEvent(android.view.KeyEvent keyEvent);

    android.os.Dictionary<string, object> getExtras();

    long getFlags();

    java.lang.object getMediaController();

    android.support.v4.media.MediaMetadataCompat getMetadata();

    java.lang.string getPackageName();

    android.support.v4.media.session.MediaControllerCompat$PlaybackInfo getPlaybackInfo();

    android.support.v4.media.session.PlaybackStateCompat getPlaybackState();

    java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> getQueue();

    java.lang.CharSequence getQueueTitle();

    int getRatingType();

    int getRepeatMode();

    android.app.Pendingobject getSessionobject();

    int getShuffleMode();

    android.support.v4.media.session.MediaControllerCompat$TransportControls getTransportControls();

    bool isCaptioningEnabled();

    bool isSessionReady();

    void registerCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler);

    void removeQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat);

    void sendCommand(java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver);

    void setVolumeTo(int i, int i2);

    void unregisterCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback);
}

