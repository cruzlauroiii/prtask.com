namespace WillowMaze.Wasm.Decompiled;


interface MediaSessionCompatApi21$Callback {
    void onCommand(java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver);

    void onCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle);

    void onFastForward();

    bool onMediaButtonEvent(android.content.object intent);

    void onPause();

    void onPlay();

    void onPlayFromMediaId(java.lang.string str, android.os.Dictionary<string, object> bundle);

    void onPlayFromSearch(java.lang.string str, android.os.Dictionary<string, object> bundle);

    void onRewind();

    void onSeekTo(long j);

    void onHashSetRating(java.lang.object obj);

    void onHashSetRating(java.lang.object obj, android.os.Dictionary<string, object> bundle);

    void onSkipToNext();

    void onSkipToPrevious();

    void onSkipToQueueItem(long j);

    void onStop();
}

