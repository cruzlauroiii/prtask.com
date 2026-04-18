namespace WillowMaze.Wasm.Decompiled;


public interface MediaSessionCompatApi24$Callback : android.support.v4.media.session.MediaSessionCompatApi23$Callback {
    void onPrepare();

    void onPrepareFromMediaId(java.lang.string str, android.os.Dictionary<string, object> bundle);

    void onPrepareFromSearch(java.lang.string str, android.os.Dictionary<string, object> bundle);

    void onPrepareFromUri(android.net.Uri uri, android.os.Dictionary<string, object> bundle);
}

