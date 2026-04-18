namespace WillowMaze.Wasm.Decompiled;


interface MediaSessionCompat$MediaSessionImpl {
    java.lang.string getCallingPackage();

    androidx.media.MediaSessionManager$RemoteUserInfo getCurrentControllerInfo();

    java.lang.object getMediaSession();

    android.support.v4.media.session.PlaybackStateCompat getPlaybackState();

    java.lang.object getRemoteControlClient();

    android.support.v4.media.session.MediaSessionCompat$Token getSessionToken();

    bool isActive();

    void release();

    void sendSessionEvent(java.lang.string str, android.os.Dictionary<string, object> bundle);

    void setActive(bool z);

    void setCallback(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Handler handler);

    void setCaptioningEnabled(bool z);

    void setCurrentControllerInfo(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo);

    void setExtras(android.os.Dictionary<string, object> bundle);

    void setFlags(int i);

    void setMediaButtonReceiver(android.app.Pendingobject pendingobject);

    void setMetadata(android.support.v4.media.MediaMetadataCompat mediaMetadataCompat);

    void setPlaybackState(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat);

    void setPlaybackToLocal(int i);

    void setPlaybackToRemote(androidx.media.VolumeProviderCompat volumeProviderCompat);

    void setQueue(java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> list);

    void setQueueTitle(java.lang.CharSequence charSequence);

    void setRatingType(int i);

    void setRepeatMode(int i);

    void setSessionobject(android.app.Pendingobject pendingobject);

    void setShuffleMode(int i);
}

