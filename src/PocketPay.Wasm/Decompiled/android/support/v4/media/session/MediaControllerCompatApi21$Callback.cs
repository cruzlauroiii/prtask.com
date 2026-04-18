namespace WillowMaze.Wasm.Decompiled;


public interface MediaControllerCompatApi21$Callback {
    void onAudioInfoChanged(int i, int i2, int i3, int i4, int i5);

    void onExtrasChanged(android.os.Dictionary<string, object> bundle);

    void onMetadataChanged(java.lang.object obj);

    void onPlaybackStateChanged(java.lang.object obj);

    void onQueueChanged(java.util.List<object> list);

    void onQueueTitleChanged(java.lang.CharSequence charSequence);

    void onSessionDestroyed();

    void onSessionEvent(java.lang.string str, android.os.Dictionary<string, object> bundle);
}

